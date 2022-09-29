﻿using System;
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
        public GenerateDiscount()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (cmbSupplier.SelectedIndex > -1)
            {
                if(listBox1.Items.Contains(this.cmbSupplier.SelectedItem)) {
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

            if (listBox1.SelectedIndex != -1 ){
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
            txtDiscountName.Text = "Discount Name";
        }

        private void txtDiscountName_Enter(object sender, EventArgs e)
        {
            txtDiscountName.Text = "";

        }

        private void txtDiscountCode_Leave(object sender, EventArgs e)
        {
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
            txtDiscountAmount.Text = "Discount Amount";

        }

        private void txtDiscountAmount_Enter(object sender, EventArgs e)
        {
            txtDiscountAmount.Text = "";

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
        }
    }
}