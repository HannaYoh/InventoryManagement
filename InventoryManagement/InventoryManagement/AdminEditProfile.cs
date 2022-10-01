using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace InventoryManagement
{
    public partial class AdminEditProfile : Form
    {
        Models.Employee employee = new Models.Employee();
        Login loginPage = new Login();

        [ DllImport(" Gdi32.dll ", EntryPoint= " CreateRoundRectRgn " ) ]
        private static extern IntPtr CreateRoundRectRgn
        (int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nwidthEllipse,
          int nHeightEllipse
        );
           
      
                              // x - coordinate of upper - left corner
                              // y - coordinate of upper - left corner
                              // x - coordinate of lower - right corner
                              // y - coordinate of lower - right corner
                              // height of ellipse
                              // width of ellipse
        public AdminEditProfile(string email)
        {
            InitializeComponent();
            /*this.pnlEditProfileContainer.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0, this.pnlEditProfileContainer.Width, this.pnlEditProfileContainer.Height, 20, 20));
            this.pnlSms.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0, this.pnlSms.Width, this.pnlSms.Height, 20, 20));
            this.pnlEmail.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0, this.pnlEmail.Width, this.pnlEmail.Height, 20, 20));
            this.pnlNotification.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0, this.pnlNotification.Width, this.pnlNotification.Height, 20, 20));
            this.pnlChangePassword.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0, this.pnlChangePassword.Width, this.pnlChangePassword.Height, 20, 20));*/
       
          employee.Email = email;
        }

        private void pnlEditProfileContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Models.Employee list = new Models.Employee();
            list = employee.returnEmployeeInfo();

            Regex regexName = new Regex(@"^[a-zA-Z]+$");
            Regex regexPhone = new Regex(@"^\d+$");
            Regex regexEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            errorProvider1.Clear();
            if (comboBox2.SelectedIndex == -1)
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
            else if (txtMobile.Text == "")
            {
                errorProvider1.SetError(txtMobile, "Required!");
            }
            else if (!regexPhone.IsMatch(txtMobile.Text))
            {
                errorProvider1.SetError(txtMobile, "Mobile number Must be Number");
            }
            else if (txtEmail.Text == "")
            {
                errorProvider1.SetError(txtEmail, "Required!");
            }
            else if (!regexEmail.IsMatch(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Email Must be in the format of example@domain.extension");
            }
            else if (txtAddress.Text == "")
            {
                errorProvider1.SetError(txtAddress, "Required!");
            }
            else if (txtConfirmPwd.Text == "")
            {
                errorProvider1.SetError(txtConfirmPwd, "Required!");
            }
            else if (txtConfirmPwd.Text != txtNewPwd.Text && txtCurrentPwd.Text != txtConfirmPwd.Text)
            {
                errorProvider1.SetError(txtConfirmPwd, "Passwords must match!");
            }
            else if (txtCurrentPwd.Text != list.Password)
            {
                errorProvider1.SetError(txtCurrentPwd, "Enter correct Password!");
            }
            else
            {
                MessageBox.Show("checked");
            }
        }

        private void AdminEditProfile_Load(object sender, EventArgs e)
        {
            Models.Employee list = new Models.Employee();
            list = employee.returnEmployeeInfo();

            txtName.Text = list.FullName;
            txtMobile.Text = list.Phone;
            txtEmail.Text = list.Email;
            txtAddress.Text = list.Address;
        }
    }
}
