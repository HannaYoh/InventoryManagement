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
    public partial class AdminRecentActivities : UserControl
    {
        public AdminRecentActivities()
        {
            InitializeComponent();
        }

        private string lTitle;

        public string Title
        {
            get { return lTitle; }
            set { lTitle = value; lblTitle.Text = value; }
        }
        private string lDate;

        public string Date
        {
            get { return lDate; }
            set { lDate = value; lblDate.Text = value; }
        }
        private string lMessage;

        public string Message
        {
            get { return lMessage; }
            set { lMessage = value; lblMessage.Text = value; }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
