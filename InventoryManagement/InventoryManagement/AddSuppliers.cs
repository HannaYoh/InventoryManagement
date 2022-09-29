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
    public partial class AddSuppliers : Form
    {
        public AddSuppliers()
        {
            InitializeComponent();
        }

        private void txtSupplierName_Leave(object sender, EventArgs e)
        {
            txtSupplierName.Text = "Supplier Name";
        }

        private void txtSupplierName_Enter(object sender, EventArgs e)
        {
            txtSupplierName.Text = "";

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            txtEmail.Text = "Email";
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.Text = "";

        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            txtAddress.Text = "Address"; 
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            txtAddress.Text = "";

        }

        private void txtMobile_Leave(object sender, EventArgs e)
        {
            txtMobile.Text = "Phone";
        }

        private void txtMobile_Enter(object sender, EventArgs e)
        {
            txtMobile.Text = "";

        }
    }
}
