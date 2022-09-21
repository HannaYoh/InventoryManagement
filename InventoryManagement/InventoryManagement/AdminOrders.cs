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
    public partial class AdminOrders : Form
    {
        public AdminOrders()
        {
            InitializeComponent();
        }

        private void txtProducts_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtOrderId.Text == "" || txtOrderId.Text == "Search Order ID")
                errorProvider1.SetError(pictureBox3, "Enter Order Id!");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtOrderId_Enter(object sender, EventArgs e)
        {
            txtOrderId.Text = "";
        }

        private void txtOrderId_Leave(object sender, EventArgs e)
        {
            txtOrderId.Text = "Search Order ID"; 
        }
    }
}
