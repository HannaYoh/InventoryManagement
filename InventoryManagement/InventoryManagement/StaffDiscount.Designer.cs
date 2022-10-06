namespace InventoryManagement
{
    partial class StaffDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDiscount));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.errorProviderTxt = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(303, 33);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearchByName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchByName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByName.ForeColor = System.Drawing.Color.Black;
            this.txtSearchByName.Location = new System.Drawing.Point(41, 33);
            this.txtSearchByName.Margin = new System.Windows.Forms.Padding(4, 55, 4, 4);
            this.txtSearchByName.Multiline = true;
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(267, 34);
            this.txtSearchByName.TabIndex = 35;
            this.txtSearchByName.Text = "Search by Name";
            this.txtSearchByName.WordWrap = false;
            this.txtSearchByName.Enter += new System.EventHandler(this.txtSearchByName_Enter);
            this.txtSearchByName.Leave += new System.EventHandler(this.txtSearchByName_Leave);
            // 
            // errorProviderTxt
            // 
            this.errorProviderTxt.ContainerControl = this;
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.ItemHeight = 25;
            this.cmbStatus.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbStatus.Location = new System.Drawing.Point(474, 34);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(17, 4, 4, 4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(230, 33);
            this.cmbStatus.TabIndex = 37;
            this.cmbStatus.Text = "Status";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(41, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 460);
            this.panel1.TabIndex = 40;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSupplier.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.ItemHeight = 25;
            this.cmbSupplier.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbSupplier.Location = new System.Drawing.Point(819, 34);
            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(17, 4, 4, 4);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(230, 33);
            this.cmbSupplier.TabIndex = 38;
            this.cmbSupplier.Text = "Supplier";
            // 
            // StaffDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 657);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffDiscount";
            this.Text = "StaffDiscount";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.ErrorProvider errorProviderTxt;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbSupplier;
    }
}