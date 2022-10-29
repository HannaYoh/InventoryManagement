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
    public partial class StaffCustomer : Form
    {
        Models.Customer customer = new Models.Customer();
       
        public StaffCustomer()
        {
            InitializeComponent();
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panel2.AutoSize = false; //Allows you to change height to have bottom padding
            this.panel2.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
            this.pnlContainerOverviewttl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlContainerOverviewttl.AutoSize = false; //Allows you to change height to have bottom padding
            this.pnlContainerOverviewttl.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
            this.pnlContainerTransactionttl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlContainerTransactionttl.AutoSize = false; //Allows you to change height to have bottom padding
            this.pnlContainerTransactionttl.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black }); 
            this.pnlSeparetor.BackColor = Color.Black;
            this.pnlSeparetor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlSeparetor.AutoSize = false; //Allows you to change height to have bottom padding
            this.pnlSeparetor.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Left, BackColor = Color.Black });

        }

        private void txtSearchByName_Enter(object sender, EventArgs e)
        {
            txtSearchCustomer.Text = "";
        }

        private void txtSearchCustomer_Leave(object sender, EventArgs e)
        {
            txtSearchCustomer.Text = "Search Customer";
        }

        private void btnSearchCustomers_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtSearchCustomer.Visible = true;
            lblTitle1.Visible = false;
            if (txtSearchCustomer.Text == "" || txtSearchCustomer.Text == "Search Customer")
            {
                errorProvider1.SetError(btnSearchCustomers, "Enter Customer Name!");
            }
           /* else
            {
                customer.FullName = txtSearchCustomer.Text;
                label4.Text = customer.FullName;
                label5.Text = customer.Email;
                label7.Text = customer.Phone;
                label9.Text = customer.Gender;
                label11.Text = customer.Address;

                List<Models.Customer> list = new List<Models.Customer>();
                list = customer.searchCustomerByName();
                

                foreach (var transaction in list)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                   transaction.OrderId,
                   transaction.OrdaerDate,
                   transaction.ProductId,
                   transaction.Quantity,
                   transaction.TotalPrice
                    });

                }
            }*/
        }

        private void btnSearchCustomers_MouseHover(object sender, EventArgs e)
        {
      
        }

        private void btnSearchCustomers_MouseLeave(object sender, EventArgs e)
        {
  
        }

        private void txtSearchCustomer_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void txtSearchCustomer_MouseLeave(object sender, EventArgs e)
        {
           

        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
    
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnAddCustomers_Click(object sender, EventArgs e)
        {
            //txtSearchCustomer.Visible = false;
            //lblTitle1.Visible = true;

            AddCustomer add = new AddCustomer
            {
                Owner = this
            };
            add.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtSearchCustomer.Visible = false;
            lblTitle1.Visible = true;

            string email = lblEmail1.Text;
            string fullname = label4.Text;
            string phone = label7.Text;
            string address = label11.Text;
            AddCustomer add = new AddCustomer(fullname ,email, address, phone);

            add.Owner = this;
            
            add.ShowDialog();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtSearchCustomer.Visible = false;
            lblTitle1.Visible = true;
            customer.Email = lblEmail1.Text;
            customer.deleteCustomer();
            MessageBox.Show("cutomer deleted");
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtSearchCustomer.Visible = true;
            lblTitle1.Visible = false;
            if (txtSearchCustomer.Text == "" || txtSearchCustomer.Text == "Search Customer")
            {
                errorProvider1.SetError(btnSearchCustomers, "Enter Customer Name!");

            }
            else
            {
                customer.FullName = txtSearchCustomer.Text;

                flowLayoutPanel1.Controls.Clear();

                foreach (var cust in customer.searchCustomer())
                {
                    CustomerListControl card = new CustomerListControl();
                    card.Names = cust.FullName;
                    card.Email = cust.Email;                                  
                   
                    flowLayoutPanel1.Controls.Add(card);
                    card.Click += new System.EventHandler(this.CustomerListControl_Click);
                }

            }
        }

        private void CustomerListControl_Click(object sender, EventArgs e)
        {        
            CustomerListControl obj = (CustomerListControl)sender;
            lblFullName1.Text = obj.Names;
            lblEmail1.Text = obj.Email;

            customer.Email = lblEmail1.Text;
            Models.Customer tempCust = new Models.Customer();
            tempCust = customer.returnCustomerInfo();

            label4.Text = tempCust.FullName;
            label5.Text = tempCust.Email;
            label7.Text = tempCust.Phone;
            label9.Text = tempCust.Gender;
            label11.Text = tempCust.Address;

            int custId = customer.returnCustomerId();
            customer.CustId = custId;

            this.dataGridView1.Rows.Clear();

            List<Models.Customer> list = new List<Models.Customer>();
            list = customer.searchOrderByCustId();


            foreach (var transaction in list)
            {
                dataGridView1.Rows.Add(new object[]
                {                
                   transaction.ProductId,
                   transaction.Quantity,
                   transaction.TotalPrice
                });

            }



        }

        private void StaffCustomer_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var cust in customer.searchAllCustomer())
            {
                CustomerListControl card = new CustomerListControl();
                card.Names = cust.FullName;
                card.Email = cust.Email;

                flowLayoutPanel1.Controls.Add(card);
                card.Click += new System.EventHandler(this.CustomerListControl_Click);
            }
        }
    }
}
