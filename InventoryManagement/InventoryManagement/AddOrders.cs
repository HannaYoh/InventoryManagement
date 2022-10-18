using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryManagement
{
    public partial class AddOrders : Form
    {
        public AddOrders()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = 10;
            errorProvider1.Clear();
            if (cmbProduct.SelectedIndex == -1)
            {
                errorProvider1.SetError(GrpProduct, "Choose Product!");
            } else
            {
                string[] row = { cmbProduct.SelectedItem.ToString(), nudQty.Value.ToString(), price.ToString() };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                lblPrice.Text = (Int32.Parse(lblPrice.Text) + (price * nudQty.Value)).ToString();


            }
            /*else
            {*/
               
            /*}*/
            

        }
    }
}
