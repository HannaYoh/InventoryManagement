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

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            pbar.Value = 100;
            timer1.Start();
            pnlCopyCode.Visible = true;
            Random generator = new Random();
            String r = generator.Next(0, 1000000).ToString("D6");
            lblCode.Text = r;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblCode.Text);
            MessageBox.Show("Access code Copied");
        }
    }
}
