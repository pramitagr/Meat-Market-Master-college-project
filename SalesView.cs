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
    public partial class SalesView : Form
    {
        
        public SalesView()
        {
            InitializeComponent();
            dataGridViewSales.RowTemplate.Height = 40;
            dataGridViewSales.DefaultCellStyle.Padding = new Padding(5);
        }

        private void SalesView_Load(object sender, EventArgs e)
        {
            loadSales();
            //dataGridViewSales.Columns["Id"].HeaderText = "ID";
            dataGridViewSales.Columns["Id"].Visible = false;
            dataGridViewSales.Columns["PricePerKg"].HeaderText = "Price Per Kg";
            dataGridViewSales.Columns["TotalAmount"].HeaderText = "Total Amount";
        }

        private void loadSales()
        {
            using(var db = new SmartFreshHouseEntities())
            {
                var AllTransaction = db.Sales.Include("Product")
                    .OrderByDescending(s => s.Id)
                    .Select(s => new
                        {
                            s.Id,
                            s.Date,
                            s.Product.Name,
                            s.PricePerKg,
                            s.Quantity,
                            s.TotalAmount
                        }).ToList();

                dataGridViewSales.DataSource =  AllTransaction;
            }
        }
    }
}
