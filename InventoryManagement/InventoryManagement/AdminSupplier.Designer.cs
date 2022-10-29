namespace InventoryManagement
{
    partial class AdminSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSupplier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtSearchById = new System.Windows.Forms.TextBox();
            this.errorProviderTxt = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewSupplier = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlAddSuppliers = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).BeginInit();
            this.pnlAddSuppliers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(305, 33);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // txtSearchById
            // 
            this.txtSearchById.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearchById.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchById.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchById.ForeColor = System.Drawing.Color.Black;
            this.txtSearchById.Location = new System.Drawing.Point(43, 33);
            this.txtSearchById.Margin = new System.Windows.Forms.Padding(4, 55, 4, 4);
            this.txtSearchById.Multiline = true;
            this.txtSearchById.Name = "txtSearchById";
            this.txtSearchById.Size = new System.Drawing.Size(267, 34);
            this.txtSearchById.TabIndex = 35;
            this.txtSearchById.Text = "Search by Supplier Id";
            this.txtSearchById.WordWrap = false;
            this.txtSearchById.Enter += new System.EventHandler(this.txtSearchById_Enter);
            this.txtSearchById.Leave += new System.EventHandler(this.txtSearchById_Leave);
            // 
            // errorProviderTxt
            // 
            this.errorProviderTxt.ContainerControl = this;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(0, 0);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(37, 36);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 24;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAdd.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdd.Location = new System.Drawing.Point(43, 5);
            this.lblAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(59, 25);
            this.lblAdd.TabIndex = 25;
            this.lblAdd.Text = "Add";
            this.lblAdd.Click += new System.EventHandler(this.lblAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridViewSupplier);
            this.panel1.Location = new System.Drawing.Point(43, 110);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 460);
            this.panel1.TabIndex = 40;
            // 
            // dataGridViewSupplier
            // 
            this.dataGridViewSupplier.AllowUserToOrderColumns = true;
            this.dataGridViewSupplier.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSupplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSupplier.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSupplier.ColumnHeadersHeight = 30;
            this.dataGridViewSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridViewSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSupplier.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSupplier.Location = new System.Drawing.Point(0, -1);
            this.dataGridViewSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewSupplier.Name = "dataGridViewSupplier";
            this.dataGridViewSupplier.ReadOnly = true;
            this.dataGridViewSupplier.RowHeadersVisible = false;
            this.dataGridViewSupplier.RowHeadersWidth = 51;
            this.dataGridViewSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSupplier.Size = new System.Drawing.Size(1007, 460);
            this.dataGridViewSupplier.TabIndex = 0;
            this.dataGridViewSupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupplier_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Supplier Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "SupplierName";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Address";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Phone";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Edit";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Text = "Edit";
            this.Column6.UseColumnTextForButtonValue = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Delete";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Text = "Delete";
            this.Column7.UseColumnTextForButtonValue = true;
            // 
            // pnlAddSuppliers
            // 
            this.pnlAddSuppliers.Controls.Add(this.pictureBox11);
            this.pnlAddSuppliers.Controls.Add(this.lblAdd);
            this.pnlAddSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlAddSuppliers.Location = new System.Drawing.Point(949, 34);
            this.pnlAddSuppliers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAddSuppliers.Name = "pnlAddSuppliers";
            this.pnlAddSuppliers.Size = new System.Drawing.Size(104, 36);
            this.pnlAddSuppliers.TabIndex = 39;
            this.pnlAddSuppliers.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddSuppliers_Paint);
            // 
            // AdminSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 657);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtSearchById);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAddSuppliers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminSupplier";
            this.Text = "AdminSupplier";
            this.Load += new System.EventHandler(this.AdminSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).EndInit();
            this.pnlAddSuppliers.ResumeLayout(false);
            this.pnlAddSuppliers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtSearchById;
        private System.Windows.Forms.ErrorProvider errorProviderTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlAddSuppliers;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.DataGridView dataGridViewSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
    }
}