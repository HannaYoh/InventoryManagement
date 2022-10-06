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
    public partial class StaffInventory : Form
    {
        public StaffInventory()
        {
            InitializeComponent();
        }

        private void txtSearchById_Leave(object sender, EventArgs e)
        {
            txtSearchById.Text = "Search by ID";
        }

        private void txtSearchById_Enter(object sender, EventArgs e)
        {
            txtSearchById.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            errorProviderTxt.Clear();

            if (txtSearchById.Text == "" || txtSearchById.Text == "Search by ID")
                errorProviderTxt.SetError(pictureBox3, "Enter Product ID!");
        }
    }
}
