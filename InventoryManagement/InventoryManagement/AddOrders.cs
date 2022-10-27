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
        Models.OrderDetail orderDetail = new Models.OrderDetail();
        Models.Employee employee = new Models.Employee();
        Models.Discount discount = new Models.Discount();
        Login loginPage = new Login();
        public AddOrders(string email)
        {
            InitializeComponent();
            employee.Email = email;
            orderDetail.Email = email;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Models.Orders orders = new Models.Orders();
            if (comboBox1.SelectedIndex == 0)
            {
                orders.CustId = 1;
            }
            else
            {
                orders.CustId = 2;
            }
            orders.DeliveryDate = dtpDeliveryDate.Value.ToString();
            orders.addOrders();

            int result = orderDetail.getEmployeeId();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                Models.OrderDetail detail = new Models.OrderDetail();
                detail.ProductName = listView1.Items[i].SubItems[0].Text;

                if (detail.ProductName == "Product1")
                {
                    detail.ProductId = 1;
                }
                else if (detail.ProductName == "Product1")
                {
                    detail.ProductId = 2;
                }
                else
                {
                    detail.ProductId = 3;
                }
                detail.Quantity = (int)nudQty.Value;
                if(discount.searchDiscountCode(cmbDiscount.SelectedText) == null)
                    detail.TotalPrice = Convert.ToDouble(lblPrice.Text);
                else
                {
                    int disPercent = discount.getDiscountPercentageByCode(cmbDiscount.SelectedText);
                    detail.TotalPrice = Convert.ToDouble(lblPrice.Text) - Convert.ToDouble(lblPrice.Text) - disPercent/100;
                }
                //detail.Quantity = Convert.ToInt32(listView1.Items[i].SubItems[1].Text);
                //detail.TotalPrice = Convert.ToDouble(listView1.Items[i].SubItems[2].Text);
                
                detail.SoldById = result;
                detail.addOrderDetails();
            }


            MessageBox.Show("order added");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = 10;
            errorProvider1.Clear();
            if (cmbProduct.SelectedIndex == -1)
            {
                errorProvider1.SetError(GrpProduct, "Choose Product!");
            }
            else
            {
                //ListViewItem item = listView1.FindItemWithText("item_key");


                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == cmbProduct.SelectedItem.ToString())
                    {
                        listView1.Items[i].SubItems[1].Text = (Int32.Parse(listView1.Items[i].SubItems[1].Text) + nudQty.Value).ToString();
                        listView1.Items[i].SubItems[2].Text = (Int32.Parse(listView1.Items[i].SubItems[2].Text) + price).ToString();
                        if(listView1.Items.Count > 2)
                        {
                            listView1.Items[listView1.Items.Count-1].Remove();

                        }

                    }
                    else
                    {

                        string[] row = { cmbProduct.SelectedItem.ToString(), (nudQty.Value-1).ToString(), (price-10).ToString() };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                        lblPrice.Text = (Int32.Parse(lblPrice.Text) + (price * nudQty.Value)).ToString();



                    }

                }



            }
            /*else
            {*/

            /*}*/


        }
    }
}
