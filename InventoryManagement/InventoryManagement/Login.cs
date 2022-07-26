﻿using System;
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
       Models.Employee employee = new Models.Employee();
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
            else
            {
                if (rbAdmin.Checked)
                {
                    if (lblPwd.Text == "Password")
                    {
                        employee.Email = txtEmail.Text;
                        employee.Password = txtPassword.Text;
                        bool status = employee.adminAuthentication();
                        if (status)
                        {
                            Models.Employee model = new Models.Employee();
                            model = employee.returnEmployeeInfo();

                            AdminPage adminPage = new AdminPage(model.FullName, this, employee.Email);
                            adminPage.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid input");
                            ////txtEmail.Clear();
                            txtPassword.Clear();
                        }
                    }
                    else
                    {
                        employee.Email = txtEmail.Text;
                        employee.BackupPassword = txtPassword.Text;
                        bool status = employee.backupPwdLoginAdmin();
                        if (status)
                        {
                            Models.Employee model = new Models.Employee();
                            model = employee.returnEmployeeInfo();

                            AdminPage adminPage = new AdminPage(model.FullName, this, employee.Email);
                            adminPage.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid input");
                            //txtEmail.Clear();
                            txtPassword.Clear();
                        }
                    }

                }
                else
                {
                    if (lblPwd.Text == "Password")
                    {
                        employee.Email = txtEmail.Text;
                        employee.Password = txtPassword.Text;
                        bool status = employee.staffAuthentication();
                        if (status)
                        {
                            Models.Employee model = new Models.Employee();
                            model = employee.returnEmployeeInfo();

                            StaffPage staffPage = new StaffPage(model.FullName, this, employee.Email);
                            staffPage.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid input");
                            //txtEmail.Clear();
                            txtPassword.Clear();
                        }
                    }
                    else
                    {
                        employee.Email = txtEmail.Text;
                        employee.BackupPassword = txtPassword.Text;
                        bool status = employee.backupPwdLoginStaff();
                        if (status)
                        {
                            Models.Employee model = new Models.Employee();
                            model = employee.returnEmployeeInfo();

                            StaffPage staffPage = new StaffPage(model.FullName, this, employee.Email);
                            staffPage.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid input");
                            //txtEmail.Clear();
                            txtPassword.Clear();
                        }
                    }
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            lblPwd.Text = "Backup Password";
            txtPassword.Text = "";
            txtEmail.Text = "";
            label5.Visible = false;
            label3.Visible = true; 
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            lblPwd.Text = "Password";
            txtPassword.Text = "";
            txtEmail.Text = "";
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
