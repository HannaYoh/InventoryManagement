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
    public partial class StaffPage : Form
    {
        /*Models.Employee employee = new Models.Employee();
        Login loginPage = new Login();*/
        public StaffPage()
        {
            InitializeComponent();
            openChildForm(new StaffReports());

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void showSubMenu()
        {
            if (panelSubMenu.Visible == false)
                panelSubMenu.Visible = true;
            else
                panelSubMenu.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            showSubMenu();
        }


        private void pnlDashboardActive_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            showSubMenu();
            
        }

        private void btnDashboard_Click_4(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            pnlReportsActive.Visible = true;
            pnlCustomerActive.Visible = false;
            pnlOrdersActive.Visible = false;
            pnlProductsActive.Visible = false;
            pnlSupplierActive.Visible = false;
            pnlEditProfile.Visible = false;


            lblActiveTab.Text = "Reports";
            openChildForm(new StaffReports());
        }

        private void label4_Click_2(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            pnlReportsActive.Visible = false;
            pnlCustomerActive.Visible = false;
            pnlOrdersActive.Visible = true;
            pnlProductsActive.Visible = false;
            pnlSupplierActive.Visible = false;
            pnlEditProfile.Visible = false;



            lblActiveTab.Text = "Orders";
            openChildForm(new StaffOrders());

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            pnlReportsActive.Visible = false;
            pnlCustomerActive.Visible = false;
            pnlOrdersActive.Visible = false;
            pnlProductsActive.Visible = true;
            pnlSupplierActive.Visible = false;
            pnlEditProfile.Visible = false;


            lblActiveTab.Text = "Products - Inventory";
            openChildForm(new StaffInventory());
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            pnlReportsActive.Visible = false;
            pnlCustomerActive.Visible = false;
            pnlOrdersActive.Visible = false;
            pnlProductsActive.Visible = true;
            pnlSupplierActive.Visible = false;
            pnlEditProfile.Visible = false;

            lblActiveTab.Text = "Products - Discount";
            /*openChildForm(new AdminDiscount());*/
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            pnlReportsActive.Visible = false;
            pnlCustomerActive.Visible = false;
            pnlOrdersActive.Visible = false;
            pnlProductsActive.Visible = false;
            pnlSupplierActive.Visible = true;
            pnlEditProfile.Visible = false;


            lblActiveTab.Text = "Supplier";
            //openChildForm(new AdminSupplier());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            pnlReportsActive.Visible = false;
            pnlCustomerActive.Visible = true;
            pnlOrdersActive.Visible = false;
            pnlProductsActive.Visible = false;
            pnlSupplierActive.Visible = false;
            pnlEditProfile.Visible = false;

            lblActiveTab.Text = "Customer";
            //openChildForm(new AdminManageStaff(employee.Email));

        }

        private void txtProducts_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProducts_Enter(object sender, EventArgs e)
        {
            txtProducts.Text = "";
        }

        private void txtProducts_Leave(object sender, EventArgs e)
        {
            txtProducts.Text = "Search for Products";

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            panelSubMenu.Visible = false;
            if (txtProducts.Text == "" || txtProducts.Text == "Search for Products")
                errorProvider1.SetError(pictureBox3, "Enter Product!");

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            pnlReportsActive.Visible = false;
            pnlCustomerActive.Visible = false;
            pnlOrdersActive.Visible = false;
            pnlProductsActive.Visible = false;
            pnlSupplierActive.Visible = false;
            pnlEditProfile.Visible = true;
            lblActiveTab.Text = "Edit Profile";
            //openChildForm(new AdminEditProfile(employee.Email));
        }
    }
}
