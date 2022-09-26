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
            this.pnlEditProfileContainer.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0, this.pnlEditProfileContainer.Width, this.pnlEditProfileContainer.Height, 20, 20));
            this.pnlSms.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0, this.pnlSms.Width, this.pnlSms.Height, 20, 20));
            this.pnlEmail.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0, this.pnlEmail.Width, this.pnlEmail.Height, 20, 20));
            this.pnlNotification.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0, this.pnlNotification.Width, this.pnlNotification.Height, 20, 20));
            this.pnlChangePassword.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0, this.pnlChangePassword.Width, this.pnlChangePassword.Height, 20, 20));
        }

        private void pnlEditProfileContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
