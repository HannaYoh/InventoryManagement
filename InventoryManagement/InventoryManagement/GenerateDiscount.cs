using InventoryManagement.Models;
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
    public partial class GenerateDiscount : Form
    {
        Models.Supplier sup = new Models.Supplier();
        AdminDiscount adminDiscount = new AdminDiscount();
        public GenerateDiscount(AdminDiscount ad)
        {
            InitializeComponent();
            adminDiscount = ad;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (cmbSupplier.SelectedIndex > -1)
            {
                if (listBox1.Items.Contains(this.cmbSupplier.SelectedItem))
                {
                    errorProvider1.SetError(btnAdd, "Supplier already selected");
                }
                else
                {
                    listBox1.Items.Add(this.cmbSupplier.SelectedItem);

                }

            }
            else
            {
                // MessageBox.Show("test");
                errorProvider1.SetError(btnAdd, "Select Supplier");
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                //MessageBox.Show("test");
                errorProvider1.SetError(btnClear, "Select Supplier from List");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            listBox1.Items.Clear();
        }

        private void txtDiscountName_Leave(object sender, EventArgs e)
        {
            if (txtDiscountName.Text == "")
                txtDiscountName.Text = "Discount Name";
        }

        private void txtDiscountName_Enter(object sender, EventArgs e)
        {
            txtDiscountName.Text = "";

        }

        private void txtDiscountCode_Leave(object sender, EventArgs e)
        {
            if (txtDiscountCode.Text == "")
                txtDiscountCode.Text = "Discount Code";
        }

        private void txtDiscountCode_Enter(object sender, EventArgs e)
        {
            txtDiscountCode.Text = "";

        }

        private void txtDiscountAmount_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDiscountAmount_Leave(object sender, EventArgs e)
        {
            if (txtDiscountAmount.Text == "")
                txtDiscountAmount.Text = "Discount Amount";

        }

        private void txtDiscountAmount_Enter(object sender, EventArgs e)
        {
            txtDiscountAmount.Text = "";

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Models.Discount discount = new Models.Discount();

            discount.DiscountName = txtDiscountName.Text;
            discount.DiscountCode = txtDiscountCode.Text;
            discount.Status = 1;
            discount.DiscountAmount = Convert.ToDouble(txtDiscountAmount.Text);

            discount.addDiscount();

            Models.DiscountDetail discountDetail = new Models.DiscountDetail();

            for (int i = 0; i < listBox1.Items.Count; i++)
            {

                discountDetail.SupplierName = listBox1.Items[i].ToString();
                discountDetail.DiscountId = discount.totalDiscount();
                discountDetail.RedeemedInTotal = 1;

                discountDetail.addDiscountDetails();
            }
            MessageBox.Show("discount added");
            adminDiscount.reloadTable();
        }

        private void GenerateDiscount_Load(object sender, EventArgs e)
        {
            List<Models.Supplier> list = new List<Models.Supplier>();

            list = sup.searchSupplier();
cmbSupplier.Items.Clear();
            foreach (var Supplier in list)
            {
                
                cmbSupplier.Items.Add(Supplier.SupplierName);
            }
        }
    }
}
