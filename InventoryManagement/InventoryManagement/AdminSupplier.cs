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
        Models.Supplier supplier = new Models.Supplier();

        public AdminSupplier()
        {
            InitializeComponent();
        }

        private void pnlAddSuppliers_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void txtSearchById_Enter(object sender, EventArgs e)
        {
            this.txtSearchById.Text = "";
        }

        private void txtSearchById_Leave(object sender, EventArgs e)
        {
            this.txtSearchById.Text = "Search by Name";

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            errorProviderTxt.Clear();

            if (txtSearchById.Text == "" || txtSearchById.Text == "Search by Supplier Id")
                errorProviderTxt.SetError(pictureBox3, "Enter Supplier Name!");

            else
            {
                supplier.SupplierId = int.Parse(txtSearchById.Text);


                this.dataGridViewSupplier.Rows.Clear();

                List<Models.Supplier> list = new List<Models.Supplier>();
                list = supplier.searchBySupplierId();
                foreach (var supplier in list)
                {
                    dataGridViewSupplier.Rows.Add(new object[]
                    {
                   supplier.SupplierId,
                   supplier.SupplierName,
                   supplier.Email,
                   supplier.Address,
                   supplier.Phone,
                  
                    });

                }
            }
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            AddSuppliers sup = new AddSuppliers();
            sup.Owner = this;
            sup.ShowDialog();
        }

        private void dataGridViewSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
