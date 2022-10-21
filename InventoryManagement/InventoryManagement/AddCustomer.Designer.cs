namespace InventoryManagement
{
    partial class AddCustomer
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
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateofBirth = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.gbCustomerGender = new System.Windows.Forms.GroupBox();
            this.rbStaff = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.gbCustomerGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCustomerAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerAddress.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerAddress.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerAddress.Location = new System.Drawing.Point(70, 161);
            this.txtCustomerAddress.Margin = new System.Windows.Forms.Padding(3, 45, 3, 3);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(200, 28);
            this.txtCustomerAddress.TabIndex = 47;
            this.txtCustomerAddress.Text = "Customer Address";
            this.txtCustomerAddress.WordWrap = false;
            this.txtCustomerAddress.Enter += new System.EventHandler(this.txtCustomerAddress_Enter);
            this.txtCustomerAddress.Leave += new System.EventHandler(this.txtCustomerAddress_Leave);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCustomer.Location = new System.Drawing.Point(82, 388);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(158, 37);
            this.btnAddCustomer.TabIndex = 46;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Date of Birth";
            // 
            // dtpDateofBirth
            // 
            this.dtpDateofBirth.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dtpDateofBirth.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dtpDateofBirth.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateofBirth.Location = new System.Drawing.Point(70, 327);
            this.dtpDateofBirth.Name = "dtpDateofBirth";
            this.dtpDateofBirth.Size = new System.Drawing.Size(201, 23);
            this.dtpDateofBirth.TabIndex = 44;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCustomerPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerPhone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhone.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerPhone.Location = new System.Drawing.Point(70, 210);
            this.txtCustomerPhone.Margin = new System.Windows.Forms.Padding(3, 45, 3, 3);
            this.txtCustomerPhone.Multiline = true;
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(200, 28);
            this.txtCustomerPhone.TabIndex = 42;
            this.txtCustomerPhone.Text = "Customer Phone";
            this.txtCustomerPhone.WordWrap = false;
            this.txtCustomerPhone.Enter += new System.EventHandler(this.txtCustomerPhone_Enter);
            this.txtCustomerPhone.Leave += new System.EventHandler(this.txtCustomerPhone_Leave);
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCustomerEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerEmail.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerEmail.Location = new System.Drawing.Point(70, 113);
            this.txtCustomerEmail.Margin = new System.Windows.Forms.Padding(3, 45, 3, 3);
            this.txtCustomerEmail.Multiline = true;
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(200, 28);
            this.txtCustomerEmail.TabIndex = 41;
            this.txtCustomerEmail.Text = "Customer Email";
            this.txtCustomerEmail.WordWrap = false;
            this.txtCustomerEmail.Enter += new System.EventHandler(this.txtCustomerEmail_Enter);
            this.txtCustomerEmail.Leave += new System.EventHandler(this.txtCustomerEmail_Leave);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerName.Location = new System.Drawing.Point(70, 64);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 45, 3, 3);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(200, 28);
            this.txtCustomerName.TabIndex = 40;
            this.txtCustomerName.Text = "Customer Name";
            this.txtCustomerName.WordWrap = false;
            this.txtCustomerName.Enter += new System.EventHandler(this.txtCustomerName_Enter);
            this.txtCustomerName.Leave += new System.EventHandler(this.txtCustomerName_Leave);
            // 
            // gbCustomerGender
            // 
            this.gbCustomerGender.Controls.Add(this.rbStaff);
            this.gbCustomerGender.Controls.Add(this.rbAdmin);
            this.gbCustomerGender.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbCustomerGender.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomerGender.Location = new System.Drawing.Point(70, 252);
            this.gbCustomerGender.Name = "gbCustomerGender";
            this.gbCustomerGender.Size = new System.Drawing.Size(200, 40);
            this.gbCustomerGender.TabIndex = 48;
            this.gbCustomerGender.TabStop = false;
            // 
            // rbStaff
            // 
            this.rbStaff.AutoSize = true;
            this.rbStaff.Location = new System.Drawing.Point(132, 15);
            this.rbStaff.Name = "rbStaff";
            this.rbStaff.Size = new System.Drawing.Size(72, 20);
            this.rbStaff.TabIndex = 1;
            this.rbStaff.TabStop = true;
            this.rbStaff.Text = "Female";
            this.rbStaff.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(0, 15);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(58, 20);
            this.rbAdmin.TabIndex = 0;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Male";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 490);
            this.Controls.Add(this.gbCustomerGender);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDateofBirth);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.txtCustomerEmail);
            this.Controls.Add(this.txtCustomerName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddCustomer";
            this.gbCustomerGender.ResumeLayout(false);
            this.gbCustomerGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateofBirth;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.GroupBox gbCustomerGender;
        private System.Windows.Forms.RadioButton rbStaff;
        private System.Windows.Forms.RadioButton rbAdmin;
    }
}