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
    public partial class GenerateAccessCode : Form
    {
        public GenerateAccessCode()
        {
            InitializeComponent();

            if(AccessCode.Code != "000000")
            {
                lblCode.Text = AccessCode.Code;
                timer1.Enabled = true;
                pbar.Value = AccessCode.Time;
                pnlCopyCode.Visible = true;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.pbar.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pbar.Text = ((pbar.Value)).ToString()+" sec";
            pbar.Value -= 1;
            if(pbar.Value == 0)
            {
                timer1.Enabled = false;
                lblCode.Text = "000000";
                MessageBox.Show("Access code reseted");
                this.pbar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                pbar.Text = "Remaining Time";
                pnlCopyCode.Visible = false;
                pbar.Value = 100;
                AccessCode.Code = "000000";
                AccessCode.Time = 0;
                timer1.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        String r;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            pbar.Value = 100;
            timer1.Start();
            pnlCopyCode.Visible = true;
            Random generator = new Random();
             r = generator.Next(0, 1000000).ToString("D6");
            lblCode.Text = r;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblCode.Text);
            MessageBox.Show("Access code Copied");
        }

        private void GenerateAccessCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer1.Enabled)
            {
                 AccessCode.Code = lblCode.Text;
                 AccessCode.Time = pbar.Value;
            }
        }
    }
}
