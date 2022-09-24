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
    public partial class AdminManageStaff : Form
    {
        public AdminManageStaff()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtSearchEmployee.Text == "" || txtSearchEmployee.Text == "Search for Employee")
                errorProvider1.SetError(pictureBox4, "Enter Employee!");
        }

        private void txtSearchEmployee_Enter(object sender, EventArgs e)
        {
            txtSearchEmployee.Text = "";
        }

        private void txtSearchEmployee_Leave(object sender, EventArgs e)
        {
            txtSearchEmployee.Text = "Search for Employee";

        }
    }
}
