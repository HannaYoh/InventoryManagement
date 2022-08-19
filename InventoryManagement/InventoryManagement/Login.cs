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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtEmail.Text == "")
            {
                errorProvider1.SetError(txtEmail, "Requiered");
            }
            else if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "Requiered");
            }
            else if (!rbAdmin.Checked && !rbStaff.Checked)
            {
                errorProvider1.SetError(groupBox1, "Admin or Staff must be selcted");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            lblPwd.Text = "Backup Password";

            label5.Visible = false;
            label3.Visible = true; 
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            lblPwd.Text = "Password";

            label5.Visible = true;
            label3.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            Hide();
        }
    }
}
