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
        Models.Supplier addSupplier = new Models.Supplier();
        Models.Supplier sentSupplier = new Models.Supplier();
        string identifier;

        public AddSuppliers()
        {
            InitializeComponent();
        }

        public AddSuppliers(int supplierId, string name, string email, string address, string phone)
        {
            InitializeComponent();
            identifier = "editing";
            sentSupplier.SupplierId = supplierId;
            txtSupplierName.Text = name;
            txtEmail.Text = email;
            txtAddress.Text = address;
            txtMobile.Text = phone;
        }

        private void txtSupplierName_Enter(object sender, EventArgs e)
        {
            txtSupplierName.Text = "";

        }
        private void txtSupplierName_Leave(object sender, EventArgs e)
        {
            if (txtSupplierName.Text == "")
            txtSupplierName.Text = "Supplier Name";
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")

                txtEmail.Text = "Email";
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.Text = "";

        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")

                txtAddress.Text = "Address"; 
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            txtAddress.Text = "";

        }

        private void txtMobile_Leave(object sender, EventArgs e)
        {
            if (txtMobile.Text == "")

                txtMobile.Text = "Phone";
        }

        private void txtMobile_Enter(object sender, EventArgs e)
        {
            txtMobile.Text = "";

        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            if (identifier == "editing")
            {
                sentSupplier.SupplierName = txtSupplierName.Text;
                sentSupplier.Email = txtEmail.Text;
                sentSupplier.Address = txtAddress.Text;
                sentSupplier.Phone = txtMobile.Text;
                sentSupplier.updateSupplierInfo();

                MessageBox.Show("Supplier Edited");
            }
            else
            {
                Models.Supplier supplier = new Models.Supplier();

                supplier.SupplierName = txtSupplierName.Text;
                supplier.Email = txtEmail.Text;
                supplier.Address = txtAddress.Text;
                supplier.Phone = txtMobile.Text;


                supplier.addSupplier();
                MessageBox.Show("Supplier Added");
            }
            
        }
    }
    
}
