using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagement
{
    partial class AdminManageStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageStaff));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblAddressTitle = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblDobTitle = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblGenderTitle = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblAgeTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.pnlAdminTable = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTableChanger = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.pnlStaffTable = new System.Windows.Forms.Panel();
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.pnlGenerateAccessCode = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlAdminTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlTableChanger.SuspendLayout();
            this.pnlStaffTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.pnlGenerateAccessCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "About Me";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblAddress);
            this.panel2.Controls.Add(this.lblAddressTitle);
            this.panel2.Controls.Add(this.lblDob);
            this.panel2.Controls.Add(this.lblDobTitle);
            this.panel2.Controls.Add(this.lblGender);
            this.panel2.Controls.Add(this.lblGenderTitle);
            this.panel2.Controls.Add(this.lblAge);
            this.panel2.Controls.Add(this.lblAgeTitle);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblEmployeeId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(674, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 535);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 480);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(19, 447);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(48, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "+251912345678";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Info@ims.com";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(90, 342);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(104, 20);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Addis Ababa";
            // 
            // lblAddressTitle
            // 
            this.lblAddressTitle.AutoSize = true;
            this.lblAddressTitle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressTitle.Location = new System.Drawing.Point(101, 317);
            this.lblAddressTitle.Name = "lblAddressTitle";
            this.lblAddressTitle.Size = new System.Drawing.Size(66, 18);
            this.lblAddressTitle.TabIndex = 11;
            this.lblAddressTitle.Text = "Address";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(5, 342);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(87, 20);
            this.lblDob.TabIndex = 10;
            this.lblDob.Text = "01/01/1998";
            // 
            // lblDobTitle
            // 
            this.lblDobTitle.AutoSize = true;
            this.lblDobTitle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobTitle.Location = new System.Drawing.Point(25, 317);
            this.lblDobTitle.Name = "lblDobTitle";
            this.lblDobTitle.Size = new System.Drawing.Size(49, 18);
            this.lblDobTitle.TabIndex = 9;
            this.lblDobTitle.Text = "D.O.B";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(106, 275);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(62, 20);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Female";
            // 
            // lblGenderTitle
            // 
            this.lblGenderTitle.AutoSize = true;
            this.lblGenderTitle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderTitle.Location = new System.Drawing.Point(101, 250);
            this.lblGenderTitle.Name = "lblGenderTitle";
            this.lblGenderTitle.Size = new System.Drawing.Size(65, 18);
            this.lblGenderTitle.TabIndex = 7;
            this.lblGenderTitle.Text = "Gender";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(38, 275);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(25, 20);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "00";
            // 
            // lblAgeTitle
            // 
            this.lblAgeTitle.AutoSize = true;
            this.lblAgeTitle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeTitle.Location = new System.Drawing.Point(33, 250);
            this.lblAgeTitle.Name = "lblAgeTitle";
            this.lblAgeTitle.Size = new System.Drawing.Size(39, 18);
            this.lblAgeTitle.TabIndex = 5;
            this.lblAgeTitle.Text = "Age";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(46, 192);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 22);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "First Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(61, 75);
            this.lblEmployeeId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(64, 13);
            this.lblEmployeeId.TabIndex = 2;
            this.lblEmployeeId.Text = "EmployeeID";
            // 
            // pnlAdminTable
            // 
            this.pnlAdminTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlAdminTable.Controls.Add(this.dataGridView1);
            this.pnlAdminTable.Location = new System.Drawing.Point(33, 128);
            this.pnlAdminTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAdminTable.Name = "pnlAdminTable";
            this.pnlAdminTable.Size = new System.Drawing.Size(620, 374);
            this.pnlAdminTable.TabIndex = 17;
            this.pnlAdminTable.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(230, 40);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearchEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchEmployee.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchEmployee.ForeColor = System.Drawing.Color.Black;
            this.txtSearchEmployee.Location = new System.Drawing.Point(33, 40);
            this.txtSearchEmployee.Margin = new System.Windows.Forms.Padding(3, 45, 3, 3);
            this.txtSearchEmployee.Multiline = true;
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(200, 28);
            this.txtSearchEmployee.TabIndex = 12;
            this.txtSearchEmployee.Text = "Search for Employee";
            this.txtSearchEmployee.WordWrap = false;
            this.txtSearchEmployee.TextChanged += new System.EventHandler(this.txtSearchEmployee_TextChanged);
            this.txtSearchEmployee.Enter += new System.EventHandler(this.txtSearchEmployee_Enter);
            this.txtSearchEmployee.Leave += new System.EventHandler(this.txtSearchEmployee_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pnlTableChanger
            // 
            this.pnlTableChanger.Controls.Add(this.lblAdmin);
            this.pnlTableChanger.Controls.Add(this.lblStaff);
            this.pnlTableChanger.Location = new System.Drawing.Point(33, 82);
            this.pnlTableChanger.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTableChanger.Name = "pnlTableChanger";
            this.pnlTableChanger.Size = new System.Drawing.Size(620, 31);
            this.pnlTableChanger.TabIndex = 14;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(94, 2);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.lblAdmin.Size = new System.Drawing.Size(53, 27);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Admin";
            this.lblAdmin.Click += new System.EventHandler(this.lblAdmin_Click);
            // 
            // lblStaff
            // 
            this.lblStaff.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.lblStaff.Location = new System.Drawing.Point(2, 2);
            this.lblStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.lblStaff.Size = new System.Drawing.Size(42, 25);
            this.lblStaff.TabIndex = 0;
            this.lblStaff.Text = "Staff";
            this.lblStaff.Click += new System.EventHandler(this.lblStaff_Click);
            // 
            // pnlStaffTable
            // 
            this.pnlStaffTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlStaffTable.Controls.Add(this.dataGridViewStaff);
            this.pnlStaffTable.Location = new System.Drawing.Point(33, 128);
            this.pnlStaffTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlStaffTable.Name = "pnlStaffTable";
            this.pnlStaffTable.Size = new System.Drawing.Size(620, 371);
            this.pnlStaffTable.TabIndex = 18;
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridViewStaff.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.RowHeadersWidth = 51;
            this.dataGridViewStaff.Size = new System.Drawing.Size(620, 368);
            this.dataGridViewStaff.TabIndex = 0;
            this.dataGridViewStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStaff_CellContentClick);
            // 
            // pnlGenerateAccessCode
            // 
            this.pnlGenerateAccessCode.Controls.Add(this.label6);
            this.pnlGenerateAccessCode.Controls.Add(this.pictureBox12);
            this.pnlGenerateAccessCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlGenerateAccessCode.Location = new System.Drawing.Point(517, 40);
            this.pnlGenerateAccessCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlGenerateAccessCode.Name = "pnlGenerateAccessCode";
            this.pnlGenerateAccessCode.Size = new System.Drawing.Size(136, 28);
            this.pnlGenerateAccessCode.TabIndex = 19;
            this.pnlGenerateAccessCode.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(27, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Access Code";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(0, 3);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(21, 24);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 12;
            this.pictureBox12.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "EmployeeId";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 65;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Full Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Gender";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date of Birth";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "DepId";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 65;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Diactivate";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Text = "DiActivate";
            this.Column7.UseColumnTextForButtonValue = true;
            this.Column7.Width = 77;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 371);
            this.dataGridView1.TabIndex = 19;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Employee Id";
            this.Column8.Name = "Column8";
            this.Column8.Width = 88;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Full Name";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Gender";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Date Of Birth";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Email";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Department Id";
            this.Column13.Name = "Column13";
            this.Column13.Width = 87;
            // 
            // AdminManageStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 534);
            this.Controls.Add(this.pnlGenerateAccessCode);
            this.Controls.Add(this.pnlStaffTable);
            this.Controls.Add(this.pnlAdminTable);
            this.Controls.Add(this.pnlTableChanger);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtSearchEmployee);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminManageStaff";
            this.Text = "AdminManageStaff";
            this.Load += new System.EventHandler(this.AdminManageStaff_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlAdminTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlTableChanger.ResumeLayout(false);
            this.pnlTableChanger.PerformLayout();
            this.pnlStaffTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            this.pnlGenerateAccessCode.ResumeLayout(false);
            this.pnlGenerateAccessCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblGenderTitle;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblAgeTitle;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAddressTitle;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblDobTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtSearchEmployee;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Panel pnlTableChanger;
        private Label lblAdmin;
        private Label lblStaff;
        private Panel pnlAdminTable;
        private Panel pnlStaffTable;
        private Panel pnlGenerateAccessCode;
        private PictureBox pictureBox12;
        private Label label6;
        private DataGridView dataGridViewStaff;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewButtonColumn Column7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
    }
}