﻿using InventoryManagement.Models;
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
    public partial class AdminDiscount : Form
    {
        Models.DiscountDetail discountDetail = new Models.DiscountDetail();

        public AdminDiscount()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            errorProviderTxt.Clear();

            if (txtSearchByName.Text == "" || txtSearchByName.Text == "Search by Name")
                errorProviderTxt.SetError(pictureBox3, "Enter Discount Name!");
            else
            {
                discountDetail.DiscountId = int.Parse(txtSearchByName.Text);


                this.dataGridView1.Rows.Clear();

                List<Models.DiscountDetail> list = new List<Models.DiscountDetail>();
                list = discountDetail.searchByDiscountId();
                foreach (var discountdetail in list)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                   discountdetail.DiscountId,
                   discountdetail.DiscountName,
                   discountdetail.DiscountCode,
                   discountdetail.Status,
                   discountdetail.DiscountDetailId,
                   discountdetail.SupplierId,
                   discountdetail.AppliedDate,
                   discountdetail.RedeemedInTotal
                    });

                }
            }
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchByName_Enter(object sender, EventArgs e)
        {
            this.txtSearchByName.Text = "";
        }

        private void txtSearchByName_Leave(object sender, EventArgs e)
        {
            this.txtSearchByName.Text = "Search by Id";
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            GenerateDiscount gn = new GenerateDiscount();
            gn.Owner = this;
            gn.ShowDialog();
        }

        private void pnlAddInventory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSupplier.SelectedIndex == 0)
            {
                discountDetail.SupplierId = 1;

                this.dataGridView1.Rows.Clear();

                List<Models.DiscountDetail> list = new List<Models.DiscountDetail>();
                list = discountDetail.categoryBySupplierId();
                foreach (var discountdetail in list)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                   discountdetail.DiscountId,
                   discountdetail.DiscountName,
                   discountdetail.DiscountCode,
                   discountdetail.Status,
                   discountdetail.DiscountDetailId,
                   discountdetail.SupplierId,
                   discountdetail.AppliedDate,
                   discountdetail.RedeemedInTotal
                    });

                }

            }
            else if (cmbSupplier.SelectedIndex == 1)
            {
                discountDetail.SupplierId = 2;

                this.dataGridView1.Rows.Clear();

                List<Models.DiscountDetail> list = new List<Models.DiscountDetail>();
                list = discountDetail.categoryBySupplierId();
                foreach (var discountdetail in list)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                   discountdetail.DiscountId,
                   discountdetail.DiscountName,
                   discountdetail.DiscountCode,
                   discountdetail.Status,
                   discountdetail.DiscountDetailId,
                   discountdetail.SupplierId,
                   discountdetail.AppliedDate,
                   discountdetail.RedeemedInTotal
                    });

                }

            }
            else
            {
                cmbSupplier.SelectedIndex = -1;
                this.dataGridView1.Rows.Clear();

                List<Models.DiscountDetail> list = new List<Models.DiscountDetail>();
                list = discountDetail.categoryBySupplierId();
                foreach (var discountdetail in list)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                   discountdetail.DiscountId,
                   discountdetail.DiscountName,
                   discountdetail.DiscountCode,
                   discountdetail.Status,
                   discountdetail.DiscountDetailId,
                   discountdetail.SupplierId,
                   discountdetail.AppliedDate,
                   discountdetail.RedeemedInTotal
                    });

                }

            }
        }

        private void AdminDiscount_Load(object sender, EventArgs e)
        {
            List<Models.DiscountDetail> list = new List<Models.DiscountDetail>();
            list = discountDetail.viewAllDiscounts();
            foreach (var discountdetail in list)
            {
                dataGridView1.Rows.Add(new object[]
                {
                   discountdetail.DiscountId,
                   discountdetail.DiscountName,
                   discountdetail.DiscountCode,
                   discountdetail.Status,
                   discountdetail.DiscountDetailId,
                   discountdetail.SupplierId,
                   discountdetail.AppliedDate,
                   discountdetail.RedeemedInTotal
                });

            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedIndex == 0)
            {
                discountDetail.Status = true;

                this.dataGridView1.Rows.Clear();

                List<Models.DiscountDetail> list = new List<Models.DiscountDetail>();
                list = discountDetail.categoryByStatus();
                foreach (var discountdetail in list)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                   discountdetail.DiscountId,
                   discountdetail.DiscountName,
                   discountdetail.DiscountCode,
                   discountdetail.Status,
                   discountdetail.DiscountDetailId,
                   discountdetail.SupplierId,
                   discountdetail.AppliedDate,
                   discountdetail.RedeemedInTotal
                    });

                }

            }
            else if (cmbStatus.SelectedIndex == 1)
            {
                discountDetail.Status = false;

                this.dataGridView1.Rows.Clear();

                List<Models.DiscountDetail> list = new List<Models.DiscountDetail>();
                list = discountDetail.categoryByStatus();
                foreach (var discountdetail in list)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                   discountdetail.DiscountId,
                   discountdetail.DiscountName,
                   discountdetail.DiscountCode,
                   discountdetail.Status,
                   discountdetail.DiscountDetailId,
                   discountdetail.SupplierId,
                   discountdetail.AppliedDate,
                   discountdetail.RedeemedInTotal
                    });

                }

            }
            else
            {
                cmbStatus.SelectedIndex = -1;
                this.dataGridView1.Rows.Clear();

                List<Models.DiscountDetail> list = new List<Models.DiscountDetail>();
                list = discountDetail.categoryByStatus();
                foreach (var discountdetail in list)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                   discountdetail.DiscountId,
                   discountdetail.DiscountName,
                   discountdetail.DiscountCode,
                   discountdetail.Status,
                   discountdetail.DiscountDetailId,
                   discountdetail.SupplierId,
                   discountdetail.AppliedDate,
                   discountdetail.RedeemedInTotal
                    });

                }

            }

        }
    }
}
