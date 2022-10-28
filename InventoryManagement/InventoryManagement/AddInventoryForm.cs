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

        Models.Inventory inventory = new Models.Inventory();

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
            if (txtProductName.Text == "")
                txtProductName.Text = "Product Name";
        }

        private void txtRetailPrice_Leave(object sender, EventArgs e)
        {
            if (txtRetailPrice.Text == "")
                txtRetailPrice.Text = "Retail Price ";
        }

        private void txtRetailPrice_Enter(object sender, EventArgs e)
        {
            txtRetailPrice.Text = "";
        }

        private void txtWholeSalesPrice_Leave(object sender, EventArgs e)
        {
            if (txtWholeSalesPrice.Text == "")
                txtWholeSalesPrice.Text = "WholeSales Price";

        }

        private void txtWholeSalesPrice_Enter(object sender, EventArgs e)
        {
            txtWholeSalesPrice.Text = "";
        }

        private void txtAmountAvailable_Leave(object sender, EventArgs e)
        {
            if (txtAmountAvailable.Text == "")
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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {           
            if (cmbSupplier.SelectedIndex == 0)
            {
                inventory.SupplierId = 1;
            }
            else if (cmbSupplier.SelectedIndex == 1)
            {
                inventory.SupplierId = 2;
            }
            else
            {
                inventory.SupplierId = 3;
            }

            inventory.ProductName = txtProductName.Text;
            inventory.RetailPrice = Convert.ToDouble(txtRetailPrice.Text);
            inventory.WholesalePrice = Convert.ToDouble(txtWholeSalesPrice.Text);
            inventory.ManufactureDate = dtpManufacturingDate.Value.ToString();
            inventory.AmountAvailable = Convert.ToInt32(txtAmountAvailable.Text);
            inventory.isAvailable = true;


            inventory.addProductToDb();

            MessageBox.Show("product added");


        }
    }
}
