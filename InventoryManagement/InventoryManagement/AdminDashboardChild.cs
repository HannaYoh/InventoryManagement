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
    public partial class AdminDashboardChild : Form
    {
        Models.Inventory inventory = new Models.Inventory();
        Models.Orders orders = new Models.Orders(); 
        Models.OrderDetail orderDetail = new Models.OrderDetail();
        Models.RecentActivity recent = new Models.RecentActivity();
        public AdminDashboardChild()
        {
            InitializeComponent();
        }

        private void AdminDashboardChild_Load(object sender, EventArgs e)
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

            //orders
            int orderResult = orders.totalOrder();
            label4.Text = orderResult.ToString();

            //profit
            decimal profitResult = orderDetail.calculateProfit();
            label2.Text = profitResult.ToString();

            //earnings
            decimal earningsResult = orderDetail.calculateEarnings();
            lblMessage.Text = earningsResult.ToString();

            //recent activity
            Models.RecentActivity modelSup = new Models.RecentActivity();
            modelSup = recent.returnSupplier();
            adminRecentActivities1.Date = modelSup.ActivityDate;
            adminRecentActivities1.Title = "Supplier";
            if (modelSup.ActivityType == 'I')
                adminRecentActivities1.Message = modelSup.FullName + " added " + modelSup.SupplierName;
            else if (modelSup.ActivityType == 'D')
                adminRecentActivities1.Message = modelSup.FullName + " removed " + modelSup.SupplierName;
            else
                adminRecentActivities1.Message = modelSup.FullName + " updated " + modelSup.SupplierName;

            Models.RecentActivity modelInv = new Models.RecentActivity();
            modelInv = recent.returnInventory();
            adminRecentActivities2.Date = modelInv.ActivityDate;
            adminRecentActivities2.Title = "Product";
            if (modelInv.ActivityType == 'I')
                adminRecentActivities2.Message = modelInv.FullName + " added " + modelInv.ProductName;
            else if (modelInv.ActivityType == 'D')
                adminRecentActivities2.Message = modelInv.FullName + " removed " + modelInv.ProductName;
            else
                adminRecentActivities2.Message = modelInv.FullName + " updated " + modelInv.ProductName;

            Models.RecentActivity modelEmp = new Models.RecentActivity();
            modelEmp = recent.returnEmployee();
            adminRecentActivities3.Date = modelEmp.ActivityDate;
            adminRecentActivities3.Title = "Staff";
            if (modelEmp.ActivityType == 'I')
                adminRecentActivities3.Message =   " added " + modelEmp.FullName;
            else if (modelEmp.ActivityType == 'D')
                adminRecentActivities3.Message =  " removed " + modelEmp.FullName;
            else
                adminRecentActivities3.Message =  " updated " + modelEmp.FullName;
        }

        private void dtLowOnStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
