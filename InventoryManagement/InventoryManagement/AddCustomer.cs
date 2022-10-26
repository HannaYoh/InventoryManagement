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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void txtCustomerName_Leave(object sender, EventArgs e)
        {
            if(txtCustomerName.Text == "")
                txtCustomerName.Text = "Customer Name";
        }

        private void txtCustomerName_Enter(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";

        }

        private void txtCustomerEmail_Leave(object sender, EventArgs e)
        {
            if (txtCustomerEmail.Text == "")
                txtCustomerEmail.Text = "Customer Email";

        }

        private void txtCustomerEmail_Enter(object sender, EventArgs e)
        {
            txtCustomerEmail.Text = "";

        }

        private void txtCustomerAddress_Leave(object sender, EventArgs e)
        {
            if(txtCustomerAddress.Text == "")
                txtCustomerAddress.Text = "Customer Address";

        }

        private void txtCustomerAddress_Enter(object sender, EventArgs e)
        {
            txtCustomerAddress.Text = "";

        }

        private void txtCustomerPhone_Leave(object sender, EventArgs e)
        {
            if (txtCustomerPhone.Text == "")
                txtCustomerPhone.Text = "Customer Phone";

        }

        private void txtCustomerPhone_Enter(object sender, EventArgs e)
        {
            txtCustomerPhone.Text = "";

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Models.Customer customer = new Models.Customer();

            customer.FullName = txtCustomerName.Text;
            customer.Email = txtCustomerEmail.Text;
            customer.Address = txtCustomerAddress.Text;
            customer.Phone = txtCustomerPhone.Text;
            customer.Gender = gbCustomerGender.ToString();
            customer.DateOfBirth = dtpDateofBirth.Value.ToString();

            customer.addCustomer();
            MessageBox.Show("Customer Added");
        }
    }
}
