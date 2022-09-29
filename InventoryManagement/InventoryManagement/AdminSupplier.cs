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
    public partial class AdminSupplier : Form
    {
        public AdminSupplier()
        {
            InitializeComponent();
        }

        private void pnlAddSuppliers_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void txtSearchByName_Enter(object sender, EventArgs e)
        {
            this.txtSearchByName.Text = "";
        }

        private void txtSearchByName_Leave(object sender, EventArgs e)
        {
            this.txtSearchByName.Text = "Search by Name";

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            errorProviderTxt.Clear();

            if (txtSearchByName.Text == "" || txtSearchByName.Text == "Search by Name")
                errorProviderTxt.SetError(pictureBox3, "Enter Supplier Name!");
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            AddSuppliers sup = new AddSuppliers();
            sup.Owner = this;
            sup.ShowDialog();
        }
    }
}
