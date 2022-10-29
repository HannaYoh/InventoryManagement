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
    public partial class AdminManageStaff : Form
    {
        Models.Employee employee = new Models.Employee();
        public AdminManageStaff(string email)
        {
            InitializeComponent();
            employee.Email = email;
        }



        private void pictureBox4_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtSearchEmployee.Text == "" || txtSearchEmployee.Text == "Search by ID")
                errorProvider1.SetError(pictureBox4, "Enter Employee!");

            else
            {
                employee.EmployeeId = int.Parse(txtSearchEmployee.Text);


                this.dataGridViewStaff.Rows.Clear();

                List<Models.Employee> list = new List<Models.Employee>();
                list = employee.searchByEmployeeId();
                foreach (var employee in list)
                {
                    dataGridViewStaff.Rows.Add(new object[]
                    {
                    employee.EmployeeId,
                    employee.FullName,
                    employee.Gender,
                    employee.DateOfBirth,
                    employee.Email,
                    employee.Roll,
                    employee.DepId,
                    employee.Address,
                    employee.Phone,
                    employee.Password,
                    employee.BackupPassword,
                });

                }
            }
        }


        private void txtSearchEmployee_Enter(object sender, EventArgs e)
        {
            txtSearchEmployee.Text = "";
        }

        private void txtSearchEmployee_Leave(object sender, EventArgs e)
        {
            txtSearchEmployee.Text = "Search for Employee";

        }

        private void lblStaff_Click(object sender, EventArgs e)
        {
            //this.lblStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));



            //this.lblAdmin.ForeColor = System.Drawing.Color.Black;


            //pnlAdminTable.Visible = false;
            //pnlStaffTable.Visible = true;

        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            //this.lblAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));



            //this.lblStaff.ForeColor = System.Drawing.Color.Black;

           // pnlAdminTable.Visible = true;
           // pnlStaffTable.Visible = false;

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            GenerateAccessCode gn = new GenerateAccessCode();
            gn.Owner = this;
            gn.ShowDialog();
        }

        private void AdminManageStaff_Load(object sender, EventArgs e)
        {
            Models.Employee model = new Models.Employee();
            model = employee.returnEmployeeInfo();
            
            lblEmployeeId.Text = model.EmployeeId.ToString();
            lblName.Text = model.FullName;
            lblGender.Text = model.Gender;
            lblDob.Text = model.DateOfBirth;
            lblAddress.Text = model.Address;
            int age = model.employeeAge();
            lblAge.Text = age.ToString();


            this.dataGridViewStaff.Rows.Clear();

                List<Models.Employee> list = new List<Models.Employee>();
                list = employee.loadAllEmployees();
            foreach (var employee in list)
            {
                dataGridViewStaff.Rows.Add(new object[]
                {
                    employee.EmployeeId,
                    employee.FullName,
                    employee.Gender,
                    employee.DateOfBirth,
                    employee.Email,
                    employee.Roll,
                    employee.DepId,
                    
            });
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                Models.Employee employee = new Models.Employee();

            MessageBox.Show("Contact developer to deactivate");

        }
    }
}
