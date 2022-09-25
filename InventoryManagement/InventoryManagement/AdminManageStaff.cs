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
        public AdminManageStaff()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtSearchEmployee.Text == "" || txtSearchEmployee.Text == "Search for Employee")
                errorProvider1.SetError(pictureBox4, "Enter Employee!");
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
            this.lblStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.lblStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblStaff.AutoSize = false; //Allows you to change height to have bottom padding
            this.lblStaff.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))))
        });


            this.lblAdmin.ForeColor = System.Drawing.Color.Black;
            this.lblAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblAdmin.AutoSize = false; //Allows you to change height to have bottom padding
            this.lblAdmin.Controls.Add(new Label()
            {
                Height = 0,
                Dock = DockStyle.Bottom,
                BackColor = Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))))
            });

            pnlAdminTable.Visible = false;
            pnlStaffTable.Visible = true;

        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            this.lblAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.lblAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblAdmin.AutoSize = false; //Allows you to change height to have bottom padding
            this.lblAdmin.Controls.Add(new Label()
            {
                Height = 1,
                Dock = DockStyle.Bottom,
                BackColor = Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))))
            });


            this.lblStaff.ForeColor = System.Drawing.Color.Black;
            this.lblStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblStaff.AutoSize = false; //Allows you to change height to have bottom padding
            this.lblStaff.Controls.Add(new Label()
            {
                Height = 0,
                Dock = DockStyle.Bottom,
                BackColor = Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))))
            });
            pnlAdminTable.Visible = true;
            pnlStaffTable.Visible = false;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
