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
    public partial class StaffSupplier : Form
    {
        Models.Supplier supplier = new Models.Supplier();

        public StaffSupplier()
        {

            InitializeComponent();
        }

        private void txtSearchEmployee_Leave(object sender, EventArgs e)
        {
            txtSearchEmployee.Text = "Search by Id";
        }

        private void txtSearchEmployee_Enter(object sender, EventArgs e)
        {
            txtSearchEmployee.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            errorProviderTxt.Clear();

            if (txtSearchEmployee.Text == "" || txtSearchEmployee.Text == "Search by ID")
                errorProviderTxt.SetError(pictureBox3, "Enter Employee!");

            else
            {
                supplier.SupplierId = int.Parse(txtSearchEmployee.Text);


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
    }
}
