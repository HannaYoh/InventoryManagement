namespace InventoryManagement
{
    partial class AdminDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDiscount));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.errorProviderTxt = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAddDiscount = new System.Windows.Forms.Panel();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DiscountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppliedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RedeemedInTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteDiscount = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlAddDiscount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(229, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearchByName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchByName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByName.ForeColor = System.Drawing.Color.Black;
            this.txtSearchByName.Location = new System.Drawing.Point(32, 27);
            this.txtSearchByName.Margin = new System.Windows.Forms.Padding(3, 45, 3, 3);
            this.txtSearchByName.Multiline = true;
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(200, 28);
            this.txtSearchByName.TabIndex = 29;
            this.txtSearchByName.Text = "Search by Id";
            this.txtSearchByName.WordWrap = false;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
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
            this.cmbStatus.ItemHeight = 21;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.cmbStatus.Location = new System.Drawing.Point(295, 28);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(174, 29);
            this.cmbStatus.TabIndex = 31;
            this.cmbStatus.Text = "Status";
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(0, 0);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(28, 29);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 24;
            this.pictureBox11.TabStop = false;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAdd.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdd.Location = new System.Drawing.Point(32, 4);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(49, 21);
            this.lblAdd.TabIndex = 25;
            this.lblAdd.Text = "Add";
            this.lblAdd.Click += new System.EventHandler(this.lblAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(32, 97);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 366);
            this.panel1.TabIndex = 34;
            // 
            // pnlAddDiscount
            // 
            this.pnlAddDiscount.Controls.Add(this.pictureBox11);
            this.pnlAddDiscount.Controls.Add(this.lblAdd);
            this.pnlAddDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlAddDiscount.Location = new System.Drawing.Point(712, 28);
            this.pnlAddDiscount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAddDiscount.Name = "pnlAddDiscount";
            this.pnlAddDiscount.Size = new System.Drawing.Size(78, 29);
            this.pnlAddDiscount.TabIndex = 33;
            this.pnlAddDiscount.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddInventory_Paint);
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSupplier.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.ItemHeight = 21;
            this.cmbSupplier.Items.AddRange(new object[] {
            "Sup A",
            "Sup B"});
            this.cmbSupplier.Location = new System.Drawing.Point(503, 28);
            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(174, 29);
            this.cmbSupplier.TabIndex = 32;
            this.cmbSupplier.Text = "Supplier";
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DiscountId,
            this.DiscountName,
            this.DiscountCode,
            this.Status,
            this.DiscountAmount,
            this.DiscountDetailId,
            this.SupplierId,
            this.AppliedDate,
            this.RedeemedInTotal,
            this.DeleteDiscount});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(750, 360);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DiscountId
            // 
            this.DiscountId.HeaderText = "Discount Id";
            this.DiscountId.Name = "DiscountId";
            this.DiscountId.ReadOnly = true;
            this.DiscountId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DiscountName
            // 
            this.DiscountName.HeaderText = "Discount Name";
            this.DiscountName.Name = "DiscountName";
            this.DiscountName.ReadOnly = true;
            // 
            // DiscountCode
            // 
            this.DiscountCode.HeaderText = "Discount Code";
            this.DiscountCode.Name = "DiscountCode";
            this.DiscountCode.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // DiscountAmount
            // 
            this.DiscountAmount.HeaderText = "Discount Amount";
            this.DiscountAmount.Name = "DiscountAmount";
            this.DiscountAmount.ReadOnly = true;
            // 
            // DiscountDetailId
            // 
            this.DiscountDetailId.HeaderText = "Dicount Detail Id";
            this.DiscountDetailId.Name = "DiscountDetailId";
            this.DiscountDetailId.ReadOnly = true;
            // 
            // SupplierId
            // 
            this.SupplierId.HeaderText = "Supplier Id";
            this.SupplierId.Name = "SupplierId";
            this.SupplierId.ReadOnly = true;
            // 
            // AppliedDate
            // 
            this.AppliedDate.HeaderText = "Applied Date";
            this.AppliedDate.Name = "AppliedDate";
            this.AppliedDate.ReadOnly = true;
            // 
            // RedeemedInTotal
            // 
            this.RedeemedInTotal.HeaderText = "Redeemed In Total";
            this.RedeemedInTotal.Name = "RedeemedInTotal";
            this.RedeemedInTotal.ReadOnly = true;
            // 
            // DeleteDiscount
            // 
            this.DeleteDiscount.HeaderText = "Delete Discount";
            this.DeleteDiscount.Name = "DeleteDiscount";
            this.DeleteDiscount.ReadOnly = true;
            this.DeleteDiscount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AdminDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 534);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAddDiscount);
            this.Controls.Add(this.cmbSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDiscount";
            this.Text = "AdminDiscount";
            this.Load += new System.EventHandler(this.AdminDiscount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlAddDiscount.ResumeLayout(false);
            this.pnlAddDiscount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.ErrorProvider errorProviderTxt;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlAddDiscount;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppliedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedeemedInTotal;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteDiscount;
    }
}