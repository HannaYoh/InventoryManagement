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
            dtLowOnStock.DataSource = null;
            dtLowOnStock.DataSource = inventory.displayLowOnStock();

            /*int n = dtLowOnStock.Rows.Add();
            dtLowOnStock.Rows[n].Cells[0].Value = inventory.ProductName;
            dtLowOnStock.Rows[n].Cells[1].Value = inventory.AmountAvailable;*/

        }
    }
}
