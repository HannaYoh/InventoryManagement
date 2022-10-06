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
    public partial class StaffOrders : Form
    {
        public StaffOrders()
        {
            InitializeComponent();
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {

            AddOrders add = new AddOrders();
            add.Owner = this;
            add.ShowDialog();
        }

        private void txtOrderId_Leave(object sender, EventArgs e)
        {
            txtOrderId.Text = "Search Order Id";
        }

        private void txtOrderId_Enter(object sender, EventArgs e)
        {
            txtOrderId.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtOrderId.Text == "" || txtOrderId.Text == "Search Order ID")
                errorProvider1.SetError(pictureBox3, "Enter Order ID!");
        }
    }
}
