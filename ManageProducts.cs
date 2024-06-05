using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFreshHouse
{
    public partial class ManageProducts : Form
    {
        public readonly DashboardForm _dashboardForm;
        string ProductImagePath;
        public ManageProducts()
        {
            
        }
        public ManageProducts(DashboardForm dashboardForm)
        {
            _dashboardForm = dashboardForm;
            InitializeComponent();
            CreateImagesFolder();

            //ProductPhoto.Image = Properties.Resources
            ProductPhoto.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void CreateImagesFolder()
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string imagesFolder = Path.Combine(currentDirectory, "images");

            if (!Directory.Exists(imagesFolder))
            {
                Directory.CreateDirectory(imagesFolder);
            }

        }

        private void SelectPhotoBtn_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

                openFileDialog.InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filepath = openFileDialog.FileName;

                    string uploadDir = Path.Combine(currentDirectory, "ProductImages");

                    if (!Directory.Exists(uploadDir))
                    {
                        Directory.CreateDirectory(uploadDir);
                    }

                    //save the selected image to the directory
                    string fileName = Path.GetFileName(filepath);
                    string fileUploadPath = Path.Combine(uploadDir, fileName);
                    File.Copy(filepath, fileUploadPath, true);

                    //set the value for  property ProductImagePath so it cal be used later
                    ProductImagePath = fileUploadPath;

                    //display image to the pictureBox
                    ProductPhoto.Image = Image.FromFile(fileUploadPath);
                    ProductPhoto.SizeMode = PictureBoxSizeMode.Zoom;

                }
            }
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            using(var db = new SmartFreshHouseEntities())
            {
                db.Products.Add(new Product
                {
                    Name = ProductNameText.Text,
                    PricePerKg = Convert.ToDecimal(ProductPriceText.Text),
                    ProductImageUrl = ProductImagePath,
                    UpdatedAt = DateTime.Now,   
                });

                db.SaveChanges();
                MessageBox.Show("Product added successfully","Product Added",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            ProductNameText.Text = string.Empty;
            ProductPriceText.Text = "";
            LoadProducts();
            _dashboardForm.LoadProducts();
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartFreshHouseDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.smartFreshHouseDataSet.Products);
            LoadProducts();
        }

        public void LoadProducts()
        {
            using (var db = new SmartFreshHouseEntities())
            {
                var products = db.Products.ToList();

                ProductGridView.DataSource = products;

            }
        }

        private void ManageProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dashboardForm.LoadProducts();
        }

        private void ProductGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            else
            {
                int productID = Convert.ToInt32(ProductGridView.CurrentRow.Cells[0].Value);

                UpdateDeleteProduct updateDeleteProductForm = new UpdateDeleteProduct(productID, this);
                updateDeleteProductForm.ShowDialog();
            }
        }
    }
}
