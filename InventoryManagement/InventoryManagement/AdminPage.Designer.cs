namespace InventoryManagement
{
    partial class AdminPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnManageStaff = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.lblIMS = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(274, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel2.Controls.Add(this.btnManageStaff);
            this.panel2.Controls.Add(this.btnSupplier);
            this.panel2.Controls.Add(this.lblIMS);
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 503);
            this.panel2.TabIndex = 1;
            // 
            // btnManageStaff
            // 
            this.btnManageStaff.Location = new System.Drawing.Point(3, 219);
            this.btnManageStaff.Name = "btnManageStaff";
            this.btnManageStaff.Size = new System.Drawing.Size(259, 56);
            this.btnManageStaff.TabIndex = 2;
            this.btnManageStaff.Text = "Manage Staff";
            this.btnManageStaff.UseVisualStyleBackColor = true;
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(3, 154);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(259, 59);
            this.btnSupplier.TabIndex = 1;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.UseVisualStyleBackColor = true;
            // 
            // lblIMS
            // 
            this.lblIMS.AutoSize = true;
            this.lblIMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMS.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblIMS.Location = new System.Drawing.Point(89, 38);
            this.lblIMS.Name = "lblIMS";
            this.lblIMS.Size = new System.Drawing.Size(77, 38);
            this.lblIMS.TabIndex = 0;
            this.lblIMS.Text = "IMS";
            this.lblIMS.Click += new System.EventHandler(this.lblAdmin_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.panel3.Controls.Add(this.lblLogout);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Controls.Add(this.lblDashboard);
            this.panel3.Location = new System.Drawing.Point(274, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(647, 52);
            this.panel3.TabIndex = 2;
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblLogout.Location = new System.Drawing.Point(562, 17);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(48, 16);
            this.lblLogout.TabIndex = 2;
            this.lblLogout.Text = "Logout";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblName.Location = new System.Drawing.Point(480, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDashboard.Location = new System.Drawing.Point(46, 10);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(108, 25);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Dashboard";
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 513);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnManageStaff;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Label lblIMS;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDashboard;
    }
}