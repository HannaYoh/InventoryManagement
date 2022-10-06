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
    public partial class StaffDiscount : Form
    {
        public StaffDiscount()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            errorProviderTxt.Clear();
            
            if (txtSearchByName.Text == "" || txtSearchByName.Text == "Search by Name")
                errorProviderTxt.SetError(pictureBox3, "Enter Discount Name!");
        }

        private void txtSearchByName_Leave(object sender, EventArgs e)
        {
            txtSearchByName.Text = "Search by Name";
        }

        private void txtSearchByName_Enter(object sender, EventArgs e)
        {
            txtSearchByName.Text = "";
        }
    }
}
