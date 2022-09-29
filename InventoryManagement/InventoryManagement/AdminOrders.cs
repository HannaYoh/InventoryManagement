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
    public partial class AdminOrders : Form
    {
        Models.OrderDetail detail = new Models. OrderDetail();

        public AdminOrders()
        {
            InitializeComponent();
        }

        private void txtProducts_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtOrderId.Text == "" || txtOrderId.Text == "Search Order ID")
                errorProvider1.SetError(pictureBox3, "Enter Order Id!");
            else
            {
                detail.OrderId = int.Parse(txtOrderId.Text);

                detail.OrderDate = dateTimePicker1.Value.ToString();

                detail.OrderDate2 = dateTimePicker2.Value.ToString();

                this.dataGridView1.Rows.Clear();

                List<Models.OrderDetail> list = new List<Models.OrderDetail>();
                list = detail.searchByDate();
                foreach (var orders in list)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                   orders.FullName,
                   orders.OrderId,
                   orders.OrderDate,
                   orders.DeliveryDate,
                   orders.SupplierId,
                   orders.SupplierName,
                   orders.ProductId,
                   orders.ProductName,
                   orders.Quantity,
                   orders.TotalPrice,
                   orders.RetailPrice,
                   orders.WholesalePrice
                    });

                }
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtOrderId_Enter(object sender, EventArgs e)
        {
            txtOrderId.Text = "";
        }

        private void txtOrderId_Leave(object sender, EventArgs e)
        {
            txtOrderId.Text = "Search Order ID"; 
        }

        private void AdminOrders_Load(object sender, EventArgs e)
        {
            List<Models.OrderDetail> list = new List<Models.OrderDetail>();
            list = detail.viewAllOrders();
            foreach (var orders in list)
            {
                dataGridView1.Rows.Add(new object[]
                {
                   orders.FullName,
                   orders.OrderId,
                   orders.OrderDate,
                   orders.DeliveryDate,
                   orders.SupplierId,
                   orders.SupplierName,
                   orders.ProductId,
                   orders.ProductName,
                   orders.Quantity,
                   orders.TotalPrice,
                   orders.RetailPrice,
                   orders.WholesalePrice
                });

            }
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSupplier.SelectedIndex == 0)
            {
                detail.SupplierName = "SupA";

                this.dataGridView1.Rows.Clear();

                List<Models.OrderDetail> list = new List<Models.OrderDetail>();
                list = detail.categoryBySupplier();
                foreach (var orders in list)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                   orders.FullName,
                   orders.OrderId,
                   orders.OrderDate,
                   orders.DeliveryDate,
                   orders.SupplierId,
                   orders.SupplierName,
                   orders.ProductId,
                   orders.ProductName,
                   orders.Quantity,
                   orders.TotalPrice,
                   orders.RetailPrice,
                   orders.WholesalePrice
                    });

                }

            }
            else if (cmbSupplier.SelectedIndex == 1)
            {
                detail.SupplierName = "SupB";

                this.dataGridView1.Rows.Clear();

                List<Models.OrderDetail> list = new List<Models.OrderDetail>();
                list = detail.categoryBySupplier();
                foreach (var orders in list)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                   orders.FullName,
                   orders.OrderId,
                   orders.OrderDate,
                   orders.DeliveryDate,
                   orders.SupplierId,
                   orders.SupplierName,
                   orders.ProductId,
                   orders.ProductName,
                   orders.Quantity,
                   orders.TotalPrice,
                   orders.RetailPrice,
                   orders.WholesalePrice
                    });

                }

            }
            else
            {
                cmbSupplier.SelectedIndex = -1;
                this.dataGridView1.Rows.Clear();

                List<Models.OrderDetail> list = new List<Models.OrderDetail>();
                list = detail.categoryBySupplier();
                foreach (var orders in list)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                   orders.FullName,
                   orders.OrderId,
                   orders.OrderDate,
                   orders.DeliveryDate,
                   orders.SupplierId,
                   orders.SupplierName,
                   orders.ProductId,
                   orders.ProductName,
                   orders.Quantity,
                   orders.TotalPrice,
                   orders.RetailPrice,
                   orders.WholesalePrice
                    });

                }

            }
        }

    }
}
