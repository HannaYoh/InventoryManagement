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
        public AdminPage()
        {
            InitializeComponent();
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
            textBox1.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Text = "Search for Products";

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
            lblActiveTab.Text = "Products";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            lblActiveTab.Text = "Manage Staff";


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
            lblActiveTab.Text = "Products - Inventory";

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            lblActiveTab.Text = "Products - Discount";

        }

        private void btnDashboard_Click_3(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            lblActiveTab.Text = "Dashboard";

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            lblActiveTab.Text = "Orders";


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            lblActiveTab.Text = "Supplier";

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panelSubMenu.Visible = false;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;

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
            textBox1.Text = "";
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            textBox1.Text = "Search for Products";
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
        }
    }
}
