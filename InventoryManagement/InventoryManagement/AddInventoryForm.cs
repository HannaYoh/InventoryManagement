using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class AddInventoryForm : Form
    {
        public AddInventoryForm()
        {
            InitializeComponent();
        }

        private void txtProductName_Enter(object sender, EventArgs e)
        {
            txtProductName.Text = "";
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            txtProductName.Text = "Product Name";
        }

        private void txtRetailPrice_Leave(object sender, EventArgs e)
        {
            txtRetailPrice.Text = "Retail Price ";
        }

        private void txtRetailPrice_Enter(object sender, EventArgs e)
        {
            txtRetailPrice.Text = "";
        }

        private void txtWholeSalesPrice_Leave(object sender, EventArgs e)
        {
            txtWholeSalesPrice.Text = "WholeSales Price";

        }

        private void txtWholeSalesPrice_Enter(object sender, EventArgs e)
        {
            txtWholeSalesPrice.Text = "";
        }

        private void txtAmountAvailable_Leave(object sender, EventArgs e)
        {
            txtAmountAvailable.Text = "Amount Available";
        }

        private void txtAmountAvailable_Enter(object sender, EventArgs e)
        {
            txtAmountAvailable.Text = "";
        }

        private void txtMobile_Leave(object sender, EventArgs e)
        {
        }

        private void txtMobile_Enter(object sender, EventArgs e)
        {

        }
    }
}
