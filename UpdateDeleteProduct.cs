using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFreshHouse
{
    public partial class UpdateDeleteProduct : Form
    {
        private readonly int _id;
        private readonly ManageProducts _manageProductForm;
        string ProductImagePath;

        public UpdateDeleteProduct(int productId, ManageProducts manageProduct)
        {
            InitializeComponent();
            _id = productId;
            _manageProductForm = manageProduct;

            ProductId.Text = _id.ToString();

            var selectedProduct = GetProductById(_id);

            ProductName.Text = selectedProduct.Name;
            ProductPrice.Text = selectedProduct.PricePerKg.ToString();
            if(selectedProduct.ProductImageUrl != null)
            {
                ProductPhoto.Image = Image.FromFile(selectedProduct.ProductImageUrl);
            }
            else
            {
                ProductPhoto.Image = Image.FromFile(selectedProduct.ProductImageUrl);
            }
            ProductImagePath = selectedProduct.ProductImageUrl;

        }

        private Product GetProductById(int productId)
        {
            using(var db = new SmartFreshHouseEntities())
            {
                //SELECT * from products where id = 1
                var product = db.Products.Find(productId);

                if(product != null)
                {
                    return product;
                }
                return null;
            }
        }

        private void UpdateProductBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Id = _id,
                Name = ProductName.Text,
                PricePerKg = Convert.ToDecimal( ProductPrice.Text),
                ProductImageUrl = ProductImagePath,
                UpdatedAt = DateTime.Now,
            };

            using(var db = new SmartFreshHouseEntities())
            {
                db.Products.AddOrUpdate(product);
                db.SaveChanges();
                MessageBox.Show("Product Updated Successfully", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            _manageProductForm.LoadProducts();
            this.Dispose();
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            using(var db = new SmartFreshHouseEntities())
            {
                var product = db.Products.Find(_id);

                if(product != null)
                {
                    try
                    {
                        db.Products.Remove(product);
                        db.SaveChanges();

                        MessageBox.Show("Product Deleted Successfully", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _manageProductForm.LoadProducts();
                        this.Close();
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show("You are not allowed to delete this product\n" + ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }
            }
        }

        private void BrowsePhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
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
    }
}
