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
        Models.Inventory inventory = new Models.Inventory();

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

        private void StaffInventory_Load(object sender, EventArgs e)
        {
            List<Models.Inventory> list = new List<Models.Inventory>();
            list = inventory.viewAllProducts();
            foreach (var products in list)
            {
                dataGridView1.Rows.Add(new object[]
                {
                   products.ProductId,
                   products.ProductName,
                   products.RetailPrice,
                   products.WholesalePrice,
                   products.ManufactureDate,
                   products.AmountAvailable,
                   products.isAvailable,
                   products.SupplierId
                });

            }


        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSupplier.SelectedIndex == 0)
            {
                inventory.SupplierId = 1;

                this.dataGridView1.Rows.Clear();

                List<Models.Inventory> list = new List<Models.Inventory>();
                list = inventory.categoryBySupplierId();
                foreach (var products in list)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                   products.ProductId,
                   products.ProductName,
                   products.RetailPrice,
                   products.WholesalePrice,
                   products.ManufactureDate,
                   products.AmountAvailable,
                   products.isAvailable,
                   products.SupplierId
                    });

                }

            }
            else if (cmbSupplier.SelectedIndex == 1)
            {
                inventory.SupplierId = 2;

                this.dataGridView1.Rows.Clear();

                List<Models.Inventory> list = new List<Models.Inventory>();
                list = inventory.categoryBySupplierId();
                foreach (var products in list)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                   products.ProductId,
                   products.ProductName,
                   products.RetailPrice,
                   products.WholesalePrice,
                   products.ManufactureDate,
                   products.AmountAvailable,
                   products.isAvailable,
                   products.SupplierId
                    });

                }

            }
            else
            {
                cmbSupplier.SelectedIndex = -1;
                this.dataGridView1.Rows.Clear();

                List<Models.Inventory> list = new List<Models.Inventory>();
                list = inventory.categoryBySupplierId();
                foreach (var products in list)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                   products.ProductId,
                   products.ProductName,
                   products.RetailPrice,
                   products.WholesalePrice,
                   products.ManufactureDate,
                   products.AmountAvailable,
                   products.isAvailable,
                   products.SupplierId
                    });

                }

            }


        }

        private void cmbCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCatagory.SelectedIndex == 0)
            {
                inventory.isAvailable = true;

                this.dataGridView1.Rows.Clear();

                List<Models.Inventory> list = new List<Models.Inventory>();
                list = inventory.categoryByAvailability();
                foreach (var products in list)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                   products.ProductId,
                   products.ProductName,
                   products.RetailPrice,
                   products.WholesalePrice,
                   products.ManufactureDate,
                   products.AmountAvailable,
                   products.isAvailable,
                   products.SupplierId
                    });

                }

            }
            else if (cmbCatagory.SelectedIndex == 1)
            {
                inventory.isAvailable = false;

                this.dataGridView1.Rows.Clear();

                List<Models.Inventory> list = new List<Models.Inventory>();
                list = inventory.categoryByAvailability();
                foreach (var products in list)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                   products.ProductId,
                   products.ProductName,
                   products.RetailPrice,
                   products.WholesalePrice,
                   products.ManufactureDate,
                   products.AmountAvailable,
                   products.isAvailable,
                   products.SupplierId
                    });

                }

            }
            else
            {
                cmbCatagory.SelectedIndex = -1;
                this.dataGridView1.Rows.Clear();

                List<Models.Inventory> list = new List<Models.Inventory>();
                list = inventory.categoryByAvailability();
                foreach (var products in list)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                   products.ProductId,
                   products.ProductName,
                   products.RetailPrice,
                   products.WholesalePrice,
                   products.ManufactureDate,
                   products.AmountAvailable,
                   products.isAvailable,
                   products.SupplierId
                    });

                }

            }


        }
    }
}
