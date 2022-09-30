namespace InventoryManagement
{
    partial class AdminEditProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlEditProfileContainer = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnlChangePassword = new System.Windows.Forms.Panel();
            this.txtConfirmPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtCurrentPwd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlNotification = new System.Windows.Forms.Panel();
            this.pnlSms = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.chSmsNotification = new InventoryManagement.RJToggleButton();
            this.chEmailNotification = new InventoryManagement.RJToggleButton();
            this.pnlEditProfileContainer.SuspendLayout();
            this.pnlChangePassword.SuspendLayout();
            this.pnlNotification.SuspendLayout();
            this.pnlSms.SuspendLayout();
            this.pnlEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Edit Profile";
            // 
            // pnlEditProfileContainer
            // 
            this.pnlEditProfileContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditProfileContainer.Controls.Add(this.comboBox2);
            this.pnlEditProfileContainer.Controls.Add(this.label2);
            this.pnlEditProfileContainer.Controls.Add(this.dateTimePicker1);
            this.pnlEditProfileContainer.Controls.Add(this.label11);
            this.pnlEditProfileContainer.Controls.Add(this.label7);
            this.pnlEditProfileContainer.Controls.Add(this.txtMobile);
            this.pnlEditProfileContainer.Controls.Add(this.label4);
            this.pnlEditProfileContainer.Controls.Add(this.txtAddress);
            this.pnlEditProfileContainer.Controls.Add(this.label3);
            this.pnlEditProfileContainer.Controls.Add(this.txtEmail);
            this.pnlEditProfileContainer.Controls.Add(this.lblPwd);
            this.pnlEditProfileContainer.Controls.Add(this.txtName);
            this.pnlEditProfileContainer.Location = new System.Drawing.Point(48, 70);
            this.pnlEditProfileContainer.Name = "pnlEditProfileContainer";
            this.pnlEditProfileContainer.Size = new System.Drawing.Size(455, 515);
            this.pnlEditProfileContainer.TabIndex = 3;
            this.pnlEditProfileContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEditProfileContainer_Paint);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 21;
            this.comboBox2.Items.AddRange(new object[] {
            "DepA",
            "DepB",
            "DepC"});
            this.comboBox2.Location = new System.Drawing.Point(36, 444);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(17, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(374, 29);
            this.comboBox2.TabIndex = 42;
            this.comboBox2.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 353);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "Date of Birth";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 381);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(375, 27);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 131);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 19);
            this.label11.TabIndex = 39;
            this.label11.Text = "+251";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 21);
            this.label7.TabIndex = 38;
            this.label7.Text = "Mobile";
            // 
            // txtMobile
            // 
            this.txtMobile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMobile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(88, 130);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(4);
            this.txtMobile.Multiline = true;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(322, 32);
            this.txtMobile.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(35, 294);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(375, 32);
            this.txtAddress.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(35, 211);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(375, 32);
            this.txtEmail.TabIndex = 28;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPwd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd.Location = new System.Drawing.Point(31, 22);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(90, 21);
            this.lblPwd.TabIndex = 25;
            this.lblPwd.Text = "Full Name";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(35, 51);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(375, 32);
            this.txtName.TabIndex = 24;
            // 
            // pnlChangePassword
            // 
            this.pnlChangePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChangePassword.Controls.Add(this.txtConfirmPwd);
            this.pnlChangePassword.Controls.Add(this.txtNewPwd);
            this.pnlChangePassword.Controls.Add(this.txtCurrentPwd);
            this.pnlChangePassword.Controls.Add(this.label9);
            this.pnlChangePassword.Controls.Add(this.label10);
            this.pnlChangePassword.Controls.Add(this.label12);
            this.pnlChangePassword.Location = new System.Drawing.Point(625, 70);
            this.pnlChangePassword.Name = "pnlChangePassword";
            this.pnlChangePassword.Size = new System.Drawing.Size(446, 286);
            this.pnlChangePassword.TabIndex = 5;
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtConfirmPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPwd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPwd.Location = new System.Drawing.Point(35, 211);
            this.txtConfirmPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPwd.Multiline = true;
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.PasswordChar = '*';
            this.txtConfirmPwd.Size = new System.Drawing.Size(375, 32);
            this.txtConfirmPwd.TabIndex = 34;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtNewPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPwd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPwd.Location = new System.Drawing.Point(35, 130);
            this.txtNewPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPwd.Multiline = true;
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(375, 32);
            this.txtNewPwd.TabIndex = 33;
            // 
            // txtCurrentPwd
            // 
            this.txtCurrentPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtCurrentPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentPwd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPwd.Location = new System.Drawing.Point(35, 51);
            this.txtCurrentPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrentPwd.Multiline = true;
            this.txtCurrentPwd.Name = "txtCurrentPwd";
            this.txtCurrentPwd.PasswordChar = '*';
            this.txtCurrentPwd.Size = new System.Drawing.Size(375, 32);
            this.txtCurrentPwd.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 182);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 21);
            this.label9.TabIndex = 31;
            this.label9.Text = "Confirm Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "New Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 21);
            this.label12.TabIndex = 25;
            this.label12.Text = "Current Password";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(620, 39);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(196, 28);
            this.label13.TabIndex = 4;
            this.label13.Text = "Change Password";
            // 
            // pnlNotification
            // 
            this.pnlNotification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotification.Controls.Add(this.pnlSms);
            this.pnlNotification.Controls.Add(this.pnlEmail);
            this.pnlNotification.Location = new System.Drawing.Point(625, 401);
            this.pnlNotification.Name = "pnlNotification";
            this.pnlNotification.Size = new System.Drawing.Size(446, 167);
            this.pnlNotification.TabIndex = 36;
            // 
            // pnlSms
            // 
            this.pnlSms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSms.Controls.Add(this.label8);
            this.pnlSms.Controls.Add(this.chSmsNotification);
            this.pnlSms.Controls.Add(this.label15);
            this.pnlSms.Location = new System.Drawing.Point(18, 94);
            this.pnlSms.Name = "pnlSms";
            this.pnlSms.Size = new System.Drawing.Size(405, 53);
            this.pnlSms.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(5, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 18);
            this.label8.TabIndex = 39;
            this.label8.Text = "Turn on to get updates through sms";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 22);
            this.label15.TabIndex = 38;
            this.label15.Text = "SMS Notification";
            // 
            // pnlEmail
            // 
            this.pnlEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmail.Controls.Add(this.label6);
            this.pnlEmail.Controls.Add(this.chEmailNotification);
            this.pnlEmail.Controls.Add(this.label5);
            this.pnlEmail.Location = new System.Drawing.Point(18, 22);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(405, 53);
            this.pnlEmail.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(5, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Turn on to get updates through email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 22);
            this.label5.TabIndex = 38;
            this.label5.Text = "Email Notification";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(620, 370);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 28);
            this.label14.TabIndex = 35;
            this.label14.Text = "Notifications";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(925, 575);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(146, 42);
            this.btnLogin.TabIndex = 37;
            this.btnLogin.Text = "Save";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // chSmsNotification
            // 
            this.chSmsNotification.AutoSize = true;
            this.chSmsNotification.Location = new System.Drawing.Point(346, 14);
            this.chSmsNotification.MinimumSize = new System.Drawing.Size(45, 22);
            this.chSmsNotification.Name = "chSmsNotification";
            this.chSmsNotification.OffBackColor = System.Drawing.Color.Gray;
            this.chSmsNotification.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.chSmsNotification.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.chSmsNotification.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.chSmsNotification.Size = new System.Drawing.Size(45, 22);
            this.chSmsNotification.TabIndex = 1;
            this.chSmsNotification.UseVisualStyleBackColor = true;
            // 
            // chEmailNotification
            // 
            this.chEmailNotification.AutoSize = true;
            this.chEmailNotification.Checked = true;
            this.chEmailNotification.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chEmailNotification.Location = new System.Drawing.Point(346, 14);
            this.chEmailNotification.MinimumSize = new System.Drawing.Size(45, 22);
            this.chEmailNotification.Name = "chEmailNotification";
            this.chEmailNotification.OffBackColor = System.Drawing.Color.Gray;
            this.chEmailNotification.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.chEmailNotification.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.chEmailNotification.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.chEmailNotification.Size = new System.Drawing.Size(45, 22);
            this.chEmailNotification.TabIndex = 1;
            this.chEmailNotification.UseVisualStyleBackColor = true;
            // 
            // AdminEditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 651);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnlNotification);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pnlChangePassword);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pnlEditProfileContainer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminEditProfile";
            this.Text = "AdminChangePassword";
            this.pnlEditProfileContainer.ResumeLayout(false);
            this.pnlEditProfileContainer.PerformLayout();
            this.pnlChangePassword.ResumeLayout(false);
            this.pnlChangePassword.PerformLayout();
            this.pnlNotification.ResumeLayout(false);
            this.pnlSms.ResumeLayout(false);
            this.pnlSms.PerformLayout();
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlEditProfileContainer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel pnlChangePassword;
        private System.Windows.Forms.TextBox txtConfirmPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtCurrentPwd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlNotification;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlSms;
        private System.Windows.Forms.Label label8;
        private RJToggleButton chSmsNotification;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.Label label6;
        private RJToggleButton chEmailNotification;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}