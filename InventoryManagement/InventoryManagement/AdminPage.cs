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
    public partial class AdminPage : Form
    {
        Models.Employee employee = new Models.Employee();
        Login loginPage = new Login();
        public AdminPage(string username, Login login, string email)
        {
            InitializeComponent();
            openChildForm(new AdminDashboardChild());
            label5.Text = username;
            loginPage = login;
            employee.Email = email;
        }


        private void lblAdmin_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            txtProducts.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            txtProducts.Text = "Search for Products";

        }

        private void pnlActiveTab_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

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

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {

        }

        private void panelSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pnlActiveTab_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            showSubMenu();
            //lblActiveTab.Text = "Products";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            pnlDashboardActive.Visible = false;
            pnlManageStaffActive.Visible = true;
            pnlOrdersActive.Visible = false;
            pnlProductsActive.Visible = false;
            pnlEditProfile.Visible = false;
            pnlSupplierActive.Visible = false;
            lblActiveTab.Text = "Manage Staff";
            openChildForm(new AdminManageStaff(employee.Email));

        }

        private void button6_MouseHover(object sender, EventArgs e)
        {

        }

        private void panelSubMenu_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            pnlDashboardActive.Visible = false;
            pnlManageStaffActive.Visible = false;
            pnlOrdersActive.Visible = false;
            pnlProductsActive.Visible = true;
            pnlSupplierActive.Visible = false;
            pnlEditProfile.Visible = false;

            lblActiveTab.Text = "Products - Inventory";
            openChildForm(new AdminInventory());
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            pnlDashboardActive.Visible = false;
            pnlManageStaffActive.Visible = false;
            pnlOrdersActive.Visible = false;
            pnlProductsActive.Visible = true;
            pnlEditProfile.Visible = false;
            pnlSupplierActive.Visible = false;
            lblActiveTab.Text = "Products - Discount";
            openChildForm(new AdminDiscount());
        }

        private void btnDashboard_Click_3(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            pnlDashboardActive.Visible = true;
            pnlManageStaffActive.Visible = false;
            pnlOrdersActive.Visible = false;
            pnlProductsActive.Visible = false;
            pnlSupplierActive.Visible = false;
            pnlEditProfile.Visible = false;

            lblActiveTab.Text = "Dashboard";
            openChildForm(new AdminDashboardChild());

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            pnlDashboardActive.Visible = false;
            pnlManageStaffActive.Visible = false;
            pnlOrdersActive.Visible = true;
            pnlProductsActive.Visible = false;
            pnlSupplierActive.Visible = false;
            pnlEditProfile.Visible = false;

            lblActiveTab.Text = "Orders";
            openChildForm(new AdminOrders());

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            pnlDashboardActive.Visible = false;
            pnlManageStaffActive.Visible = false;
            pnlOrdersActive.Visible = false;
            pnlProductsActive.Visible = false;
            pnlSupplierActive.Visible = true;
            pnlEditProfile.Visible = false;

            lblActiveTab.Text = "Supplier";
            openChildForm(new AdminSupplier());

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panelSubMenu.Visible = false;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            panelSubMenu.Visible = false;
            if (txtProducts.Text == "" || txtProducts.Text == "Search for Products")
                errorProvider1.SetError(pictureBox3,"Enter Product!");
            else
            {
                panelSubMenu.Visible = false;
                pnlDashboardActive.Visible = false;
                pnlManageStaffActive.Visible = false;
                pnlOrdersActive.Visible = false;
                pnlProductsActive.Visible = true;
                pnlSupplierActive.Visible = false;
                pnlEditProfile.Visible = false;

                lblActiveTab.Text = "Products - Inventory";
                AdminInventory a = new AdminInventory();

                openChildForm(a);

                a.filterProductById(txtProducts.Text);
            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            txtProducts.Text = "";
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            txtProducts.Text = "Search for Products";
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
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

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            pnlDashboardActive.Visible = false;
            pnlManageStaffActive.Visible = false;
            pnlOrdersActive.Visible = false;
            pnlProductsActive.Visible = false;
            pnlSupplierActive.Visible = false;
            pnlEditProfile.Visible = true;
            lblActiveTab.Text = "Edit Profile";
            openChildForm(new AdminEditProfile(employee.Email));
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pnlEditProfile_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
