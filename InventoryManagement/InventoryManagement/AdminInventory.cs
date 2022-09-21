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
    public partial class AdminInventory : Form
    {
        public AdminInventory()
        {
            InitializeComponent();
        }

        private void AdminInventory_Enter(object sender, EventArgs e)
        {

        }

        private void txtSearchById_Enter(object sender, EventArgs e)
        {
            txtSearchById.Text = "";
        }

        private void txtSearchById_Leave(object sender, EventArgs e)
        {
            txtSearchById.Text = "Search by ID";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            errorProviderTxt.Clear();
            
            if (txtSearchById.Text == "" || txtSearchById.Text == "Search by ID")
                errorProviderTxt.SetError(pictureBox3, "Enter Product!");
        }

        private void txtSearchById_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            AddInventoryForm add = new AddInventoryForm();
                    add.Owner = this;
                    add.ShowDialog();               
        }

        private void AdminInventory_Load(object sender, EventArgs e)
        {

        }
    }
}
