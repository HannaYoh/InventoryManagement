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
            AddSuppliers sup = new AddSuppliers(this);
            sup.Owner = this;
            sup.ShowDialog();

        }

        private void dataGridViewSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int id = (int)dataGridViewSupplier.CurrentRow.Cells[0].Value;
                string name = dataGridViewSupplier.CurrentRow.Cells[1].Value.ToString();
                string email = dataGridViewSupplier.CurrentRow.Cells[2].Value.ToString();
                string address = dataGridViewSupplier.CurrentRow.Cells[3].Value.ToString();
                string phone = dataGridViewSupplier.CurrentRow.Cells[4].Value.ToString();

                AddSuppliers sup = new AddSuppliers(id, name, email, address, phone);
                sup.Show();
            }
            else if (e.ColumnIndex == 6)
            {
                supplier.SupplierId = (int)dataGridViewSupplier.CurrentRow.Cells[0].Value;
                supplier.deleteSupplier();
                MessageBox.Show("Supplier deleted");
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            
        }

        private void AdminSupplier_Load(object sender, EventArgs e)
        {
            List<Models.Supplier> list = new List<Models.Supplier>();
            list = supplier.loadAllSuppliers();
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

        public void reloadTable()
        {
            dataGridViewSupplier.Rows.Clear();
            List<Models.Supplier> list = new List<Models.Supplier>();
            list = supplier.loadAllSuppliers();
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
}
