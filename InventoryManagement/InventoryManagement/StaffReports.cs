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
    public partial class StaffReports : Form
    {
        Models.Inventory inventory = new Models.Inventory();
        Models.Orders orders = new Models.Orders();
        Models.OrderDetail orderDetail = new Models.OrderDetail();
        Models.Customer customer = new Models.Customer();
        Models.Employee employee = new Models.Employee();
        Login loginPage = new Login();
        public StaffReports(string email)
        {
            InitializeComponent();
            employee.Email = email;
            orderDetail.Email = email;
        }

        private void StaffReports_Load(object sender, EventArgs e)
        {
            //dataGridView
            List<Models.Inventory> list = new List<Models.Inventory>();
            list = inventory.displayLowOnStock();
            foreach (var product in list)
            {
                dtLowOnStock.Rows.Add(new object[]
                {
                    product.ProductName,
                    product.AmountAvailable
                });

            }
            //chart
            chartGrossRevenue.DataSource = orderDetail.displayGrossRevenue();
            chartGrossRevenue.Series["Total Revenue"].XValueMember = "OrderDate";
            chartGrossRevenue.Series["Total Revenue"].YValueMembers = "Total";

            //pie chart
            chart1.DataSource = orderDetail.displayBestSellers();
            chart1.Series["Series1"].XValueMember = "ProductName";
            chart1.Series["Series1"].YValueMembers = "BestSold";

            //orders
            int orderResult = orders.totalOrder();
            label4.Text = orderResult.ToString();

            //customers
            int custResult = customer.totalCustomer();
            lblCustomers.Text = custResult.ToString();

            //personal sales
            
            decimal salesResult = orderDetail.displayPersonalSales();
            label2.Text = salesResult.ToString();



        }
    }
}
