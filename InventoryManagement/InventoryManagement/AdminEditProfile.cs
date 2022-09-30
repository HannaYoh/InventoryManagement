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
        public AdminEditProfile()
        {
            InitializeComponent();
            /*this.pnlEditProfileContainer.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0, this.pnlEditProfileContainer.Width, this.pnlEditProfileContainer.Height, 20, 20));
            this.pnlSms.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0, this.pnlSms.Width, this.pnlSms.Height, 20, 20));
            this.pnlEmail.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0, this.pnlEmail.Width, this.pnlEmail.Height, 20, 20));
            this.pnlNotification.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0, this.pnlNotification.Width, this.pnlNotification.Height, 20, 20));
            this.pnlChangePassword.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0, this.pnlChangePassword.Width, this.pnlChangePassword.Height, 20, 20));*/
        }

        private void pnlEditProfileContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (comboBox2.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBox2, "Required!");
            }
            else if (txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "Required!");
            }
            else if (txtMobile.Text == "")
            {
                errorProvider1.SetError(txtMobile, "Required!");
            }
            else if (txtEmail.Text != "")
            {
                errorProvider1.SetError(txtEmail, "Required!");
            }
            else if (txtAddress.Text != "")
            {
                errorProvider1.SetError(txtAddress, "Required!");
            }
            else if (txtCurrentPwd.Text != "")
            {
                errorProvider1.SetError(txtCurrentPwd, "Required!");
            }
            else if (txtNewPwd.Text != "")
            {
                errorProvider1.SetError(txtNewPwd, "Required!");
            }
            else if (txtConfirmPwd.Text != "")
            {
                errorProvider1.SetError(txtConfirmPwd, "Required!");
            }
            else
            {
                MessageBox.Show("checked");
            }
        }
    }
}
