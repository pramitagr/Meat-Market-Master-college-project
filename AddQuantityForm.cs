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
    public partial class AddQuantityForm : Form
    {
        public decimal Quantity { get; set; }
        public AddQuantityForm()
        {
            InitializeComponent();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {

            if (decimal.TryParse(QtyTextBox.Text, out decimal Qty))
            {

                this.Quantity = Qty;
                //this.Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Enter valid number only");
                DialogResult = DialogResult.Cancel;
            }

        }
    }
}
