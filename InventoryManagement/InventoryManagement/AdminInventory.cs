using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace InventoryManagement
{
    public partial class AdminInventory : Form
    {

        Models.Inventory inventory = new Models.Inventory();
        Models.Supplier sup = new Models.Supplier();

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
       
        public void filterProductById(string id)
        {
           // MessageBox.Show("Test");
            inventory.ProductId = int.Parse(id);

            pnlAddInventory.Visible = false;
            this.dataGridView1.Rows.Clear();

            List<Models.Inventory> list = new List<Models.Inventory>();
            list = inventory.searchByProductId();
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



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            errorProviderTxt.Clear();

            if (txtSearchById.Text == "" || txtSearchById.Text == "Search by ID")
                errorProviderTxt.SetError(pictureBox3, "Enter Product!");
            else
            {
                filterProductById(txtSearchById.Text);
            }
        }

        private void txtSearchById_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            AddInventoryForm add = new AddInventoryForm(this);
            add.Owner = this;
            add.ShowDialog();
        }

        public void reloadTable()
        {
            dataGridView1.Rows.Clear();
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

        private void AdminInventory_Load(object sender, EventArgs e)
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

            List<Models.Supplier> list2 = new List<Models.Supplier>();


            list2 = sup.searchSupplier();
            cmbSupplier.Items.Clear();
            foreach (var Supplier in list2)
            {

                cmbSupplier.Items.Add(Supplier.SupplierName);
            }
        }

        private void pnlAddInventory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

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
