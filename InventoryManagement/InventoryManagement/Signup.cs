using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (!rbAdmin.Checked && !rbStaff.Checked)
            {
                errorProvider1.SetError(groupBox1, "Required!");
            }
            else if (txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "Required!");
            }
           
            else if (txtAccessCode.Text == "")
            {
                errorProvider1.SetError(txtAccessCode, "Required!");
            }
            else if (txtAccessCode.Text != "")
            {
                Regex regex = new Regex(@"^\d+$");
                if (!regex.IsMatch(txtAccessCode.Text))
                {
                    errorProvider1.SetError(txtAccessCode, "Access Code Must be a Number");
                }

            }
            else if (txtAddress.Text == "")
            {
                errorProvider1.SetError(txtAddress, "Required!");
            }
            else if (txtBackupPwd.Text == "")
            {
                errorProvider1.SetError(txtBackupPwd, "Required!");
            }
            else if (txtConfirmBackupPwd.Text == "")
            {
                errorProvider1.SetError(txtConfirmBackupPwd, "Required!");
            }
            else if (txtConfirmPwd.Text == "")
            {
                errorProvider1.SetError(txtConfirmPwd, "Required!");
            }
            else if (txtEmail.Text == "")
            {
                errorProvider1.SetError(txtEmail, ")Required!");
            }
            else if (txtEmail.Text != "")
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (!regex.IsMatch(txtAccessCode.Text))
                {
                    errorProvider1.SetError(txtEmail, "Email Must be in the format of example@doamin.extention");
                }

            }
            else if (txtMobile.Text == "")
            {
                errorProvider1.SetError(txtMobile, "Required!");
            }
            else if (txtMobile.Text != "")
            {
                Regex regex = new Regex(@"^\d+$");
                if (!regex.IsMatch(txtAccessCode.Text))
                {
                    errorProvider1.SetError(txtMobile, "Mobile number Must be Number");
                }

            }
            else if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "Required!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            Login login = new Login();
            login.Show();
            Hide();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtName_Leave(object sender, EventArgs e)
        {

        }
    }
}
