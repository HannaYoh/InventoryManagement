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
    public partial class CustomerListControl : UserControl
    {
        public CustomerListControl()
        {
            InitializeComponent();
        }

        private string lName;

        public string Names
        {
            get { return lName; }
            set { lName = value; lblName.Text = value; }
        }

        private string lEmail;

        public string Email
        {
            get { return lEmail; }
            set { lEmail = value; lblEmail.Text = value; }
        }






    }
}
