using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFreshHouse
{
    public partial class DashboardForm : Form
    {

        private BindingList<Cart> ShoppingCart = new BindingList<Cart>();

        private BindingList<Sale> SaleList = new BindingList<Sale>();


        public DashboardForm()
        {
            InitializeComponent();

            //ShoppingCart = new BindingList<Cart>();
            CartDataGridView.DataSource = ShoppingCart;
            CartDataGridView.RowTemplate.Height = 40;
            CartDataGridView.DefaultCellStyle.Padding = new Padding(5);
        }

        public void LoadProducts()
        {
            productFlowLayoutPanel.Controls.Clear();
            using (var db = new SmartFreshHouseEntities())
            {
                var products = db.Products.ToList();

                foreach (var product in products)
                {

                    //ProductCardControl productCard = new ProductCardControl(product.Name, product.PricePerKg, product.ProductImageUrl);
                    //ProductCardControl productCard = new ProductCardControl(product);

                    Panel productPanel = new Panel
                    {
                        Size = new Size(200, 300),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.White,
                    };

                    // Create a PictureBox
                    PictureBox pictureBox = new PictureBox
                    {
                        Size = new Size(180, 180),
                        Location = new Point(10, 0),
                        ImageLocation = product.ProductImageUrl,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        BackColor = Color.White,
                    };
                    productPanel.Controls.Add(pictureBox);

                    // Create a Label for the product name
                    Label lblProductName = new Label
                    {
                        Text = product.Name,
                        Location = new Point(10, 200),
                        AutoSize = true
                    };
                    productPanel.Controls.Add(lblProductName);

                    // Create a Label for the product price
                    Label lblProductPrice = new Label
                    {
                        Text = product.PricePerKg.ToString() + " /kg",
                        Location = new Point(10, 230),
                        AutoSize = true
                    };
                    productPanel.Controls.Add(lblProductPrice);

                    // Create a Button
                    Button btnAction = new Button
                    {
                        Text = "Add to Cart",
                        Location = new Point(10, 260),
                        Size = new Size(180, 30),
                        Cursor = Cursors.Hand,
                        BackColor= Color.DodgerBlue,
                        ForeColor= Color.White,
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font(this.Font, FontStyle.Bold),
                        Tag = product,
                    };
                    btnAction.Click += ProductBtn_Click;
                    productPanel.Controls.Add(btnAction);

                    productFlowLayoutPanel.Controls.Add(productPanel);

                    productFlowLayoutPanel.AutoScroll = true;

                }
            }

        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            GetTodaysTotalSales();
            GetCurrentMonthSales();
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            Product item = (Product) button.Tag;

            AddQuantityForm addQuantityForm = new AddQuantityForm();
            
            if(addQuantityForm.ShowDialog() == DialogResult.OK)
            {
                ShoppingCart.Add(new Cart()
                {
                    ProductId = item.Id,
                    ProductName = item.Name,
                    Quantity = Convert.ToDecimal(addQuantityForm.Quantity),
                    ProductPricePerKg=item.PricePerKg,
                    Subtotal = (item.PricePerKg / 1000) * (Convert.ToDecimal(addQuantityForm.Quantity) * 1000),

                });
                
                //addQuantityForm.Quantity = 0.0m;
            }
  
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal total = 0;

            foreach(var item in ShoppingCart)
            {
                total += item.Subtotal;
            }
            TotalAmountToPay.Text = total.ToString("00.00");
        }

        private void CheckOutBtn_Click(object sender, EventArgs e)
        {
            if (ShoppingCart.Count <= 0) {
                MessageBox.Show("No items in Shopping Cart", "Add to shopping cart first", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach(var item in ShoppingCart)
            {
                SaleList.Add( new Sale()
                {
                    ProductId = item.ProductId,
                    Date = DateTime.Now,
                    Quantity= item.Quantity,
                    PricePerKg = item.ProductPricePerKg,
                    TotalAmount = item.Subtotal,
                });
            }

            using(var db = new SmartFreshHouseEntities())
            {
                db.Sales.AddRange(SaleList);
                db.SaveChanges();
                MessageBox.Show("Checkout Successful","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            ShoppingCart.Clear();
            TotalAmountToPay.Text = "0";
            GetTodaysTotalSales();
            GetCurrentMonthSales();
        }

        private void clearShoppingCartbtn_Click(object sender, EventArgs e)
        {
            ShoppingCart.Clear();
            TotalAmountToPay.Text = "0";
        }

        private void CartDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CartDataGridView.Columns[e.ColumnIndex].Name == "DeleteAction")
            {
                var result = MessageBox.Show("Are you sure to delete this item?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    ShoppingCart.RemoveAt(e.RowIndex);
                    CalculateTotal();
                }
                    
            }
        }

        private void ManageProductBtn_Click(object sender, EventArgs e)
        {
            new ManageProducts(this).ShowDialog();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewSalesBtn_Click(object sender, EventArgs e)
        {
            new SalesView().Show();
        }

        private void GetTodaysTotalSales()
        {
            var today = DateTime.Today;

            using(var db = new SmartFreshHouseEntities())
            {
                var totalSalesToday = db.Sales.Where(s => s.Date == today)
                    .Select(s => s.TotalAmount)
                    .DefaultIfEmpty(0).Sum();

                totalSalesTodayLabel.Text = "Rs " + totalSalesToday.ToString();
            }
            
        }

        private void GetCurrentMonthSales()
        {
            var today = DateTime.Now;
            var CurrentMonth = today.Month;
            var CurrentYear = today.Year;

            using (var db = new SmartFreshHouseEntities())
            {
                var CurrentMonthSales = db.Sales.Where(s => s.Date.Month == CurrentMonth && s.Date.Year == CurrentYear)
                    .Select(s => s.TotalAmount)
                    .DefaultIfEmpty(0).Sum();
                CurrentMonthSalesLbl.Text = "Rs " + CurrentMonthSales.ToString();
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            
            LoadProducts();
        }
    }
}
