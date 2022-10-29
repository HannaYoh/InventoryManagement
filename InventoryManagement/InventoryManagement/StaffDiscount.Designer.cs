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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.errorProviderTxt = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTxt)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            "Active",
            "Deactive"});
            this.cmbStatus.Location = new System.Drawing.Point(474, 34);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(17, 4, 4, 4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(230, 33);
            this.cmbStatus.TabIndex = 37;
            this.cmbStatus.Text = "Status";
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(41, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 460);
            this.panel1.TabIndex = 40;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DiscountId,
            this.DiscountName,
            this.DiscountCode,
            this.Status,
            this.DiscountAmount,
            this.DiscountDetailId,
            this.SupplierId,
            this.AppliedDate,
            this.RedeemedInTotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 460);
            this.dataGridView1.TabIndex = 1;
            // 
            // DiscountId
            // 
            this.DiscountId.HeaderText = "Discount Id";
            this.DiscountId.MinimumWidth = 6;
            this.DiscountId.Name = "DiscountId";
            this.DiscountId.ReadOnly = true;
            this.DiscountId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DiscountName
            // 
            this.DiscountName.HeaderText = "Discount Name";
            this.DiscountName.MinimumWidth = 6;
            this.DiscountName.Name = "DiscountName";
            this.DiscountName.ReadOnly = true;
            // 
            // DiscountCode
            // 
            this.DiscountCode.HeaderText = "Discount Code";
            this.DiscountCode.MinimumWidth = 6;
            this.DiscountCode.Name = "DiscountCode";
            this.DiscountCode.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // DiscountAmount
            // 
            this.DiscountAmount.HeaderText = "Discount Amount";
            this.DiscountAmount.MinimumWidth = 6;
            this.DiscountAmount.Name = "DiscountAmount";
            this.DiscountAmount.ReadOnly = true;
            // 
            // DiscountDetailId
            // 
            this.DiscountDetailId.HeaderText = "Dicount Detail Id";
            this.DiscountDetailId.MinimumWidth = 6;
            this.DiscountDetailId.Name = "DiscountDetailId";
            this.DiscountDetailId.ReadOnly = true;
            // 
            // SupplierId
            // 
            this.SupplierId.HeaderText = "Supplier Id";
            this.SupplierId.MinimumWidth = 6;
            this.SupplierId.Name = "SupplierId";
            this.SupplierId.ReadOnly = true;
            // 
            // AppliedDate
            // 
            this.AppliedDate.HeaderText = "Applied Date";
            this.AppliedDate.MinimumWidth = 6;
            this.AppliedDate.Name = "AppliedDate";
            this.AppliedDate.ReadOnly = true;
            // 
            // RedeemedInTotal
            // 
            this.RedeemedInTotal.HeaderText = "Redeemed In Total";
            this.RedeemedInTotal.MinimumWidth = 6;
            this.RedeemedInTotal.Name = "RedeemedInTotal";
            this.RedeemedInTotal.ReadOnly = true;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSupplier.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.ItemHeight = 25;
            this.cmbSupplier.Items.AddRange(new object[] {
            "SupA",
            "SupB"});
            this.cmbSupplier.Location = new System.Drawing.Point(819, 34);
            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(17, 4, 4, 4);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(230, 33);
            this.cmbSupplier.TabIndex = 38;
            this.cmbSupplier.Text = "Supplier";
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
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
            this.Load += new System.EventHandler(this.StaffDiscount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTxt)).EndInit();
            this.panel1.ResumeLayout(false);
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
    }
}