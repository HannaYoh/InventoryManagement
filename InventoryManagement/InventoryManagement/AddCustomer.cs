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
            txtCustomerName.Text = "Customer Name";
        }

        private void txtCustomerName_Enter(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";

        }

        private void txtCustomerEmail_Leave(object sender, EventArgs e)
        {
            txtCustomerEmail.Text = "Customer Email";

        }

        private void txtCustomerEmail_Enter(object sender, EventArgs e)
        {
            txtCustomerEmail.Text = "";

        }

        private void txtCustomerAddress_Leave(object sender, EventArgs e)
        {
            txtCustomerAddress.Text = "Customer Address";

        }

        private void txtCustomerAddress_Enter(object sender, EventArgs e)
        {
            txtCustomerAddress.Text = "";

        }

        private void txtCustomerPhone_Leave(object sender, EventArgs e)
        {
            txtCustomerPhone.Text = "Customer Phone";

        }

        private void txtCustomerPhone_Enter(object sender, EventArgs e)
        {
            txtCustomerPhone.Text = "";

        }
    }
}
