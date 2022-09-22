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
        public AdminDashboardChild()
        {
            InitializeComponent();
        }

        private void AdminDashboardChild_Load(object sender, EventArgs e)
        {
            
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

        }
    }
}
