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
            Regex regexNum = new Regex(@"^\d+$");
            Regex regexName = new Regex(@"^[a-zA-Z]+$");
            Regex regexEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (!rbAdmin.Checked && !rbStaff.Checked)
            {
                errorProvider1.SetError(groupBox1, "Required!");
            }
            else if (comboBox2.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBox2, "Required!");
            }
            else if (txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "Required!");
            }
            else if (!regexName.IsMatch(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Name must be letters");
            }
            else if (txtAccessCode.Text == "")
            {
                errorProvider1.SetError(txtAccessCode, "Required!");
            }
            else if (!regexNum.IsMatch(txtAccessCode.Text))
            {                            
                errorProvider1.SetError(txtAccessCode, "Access Code Must be a Number");              
            }
            else if (txtAccessCode.Text != Clipboard.GetText())
            {
                MessageBox.Show("invalid");
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
                errorProvider1.SetError(txtEmail, "Required!");
            }
            else if (!regexEmail.IsMatch(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Email Must be in the format of example@domain.extension");
            }
            else if (txtMobile.Text == "")
            {
                errorProvider1.SetError(txtMobile, "Required!");
            }
            else if (!regexNum.IsMatch(txtMobile.Text))
            {
                errorProvider1.SetError(txtMobile, "Mobile number Must be Number");
            }
            else if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "Required!");
            }
            else if (txtConfirmPwd.Text != txtPassword.Text)
            {
                errorProvider1.SetError(txtConfirmPwd, "Passwords must match!");
            }
            else if (txtConfirmBackupPwd.Text != txtBackupPwd.Text)
            {
                errorProvider1.SetError(txtConfirmBackupPwd, "Passwords must match!");
            }
            else
            {
                if (AccessCode.Code == "000000" || AccessCode.Code != txtAccessCode.Text)
                {
                    MessageBox.Show("Access code not compatable");
                }
                else
                {
                    Models.Employee employee = new Models.Employee();
                    employee.FullName = txtName.Text;
                    employee.Email = txtEmail.Text;
                    employee.BackupPassword = txtBackupPwd.Text;
                    employee.DateOfBirth = dateTimePicker1.Value.ToString();
                    employee.Password = txtPassword.Text;
                    employee.Phone = txtMobile.Text;
                    employee.Address = txtAddress.Text;


                    if (comboBox2.SelectedIndex == 0)
                    {
                        employee.DepId = 1;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        employee.DepId = 2;
                    }
                    else
                    {
                        employee.DepId = 3;
                    }

                    if (comboBox1.SelectedIndex == 0)
                    {
                        employee.Gender = "Male";
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        employee.Gender = "Female";
                    }
                    else
                    {
                        employee.Gender = " ";
                    }

                    if (rbAdmin.Checked)
                    {
                        employee.Roll = "Admin";
                    }
                    else
                    {
                        employee.Roll = "Staff";
                    }

                    employee.addEmployee();

                    MessageBox.Show("Account created");
                }
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

        private void rbAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
