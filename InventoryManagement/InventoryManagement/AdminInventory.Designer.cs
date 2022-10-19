using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagement
{
    partial class AdminInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInventory));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtSearchById = new System.Windows.Forms.TextBox();
            this.errorProviderTxt = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbCatagory = new System.Windows.Forms.ComboBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.pnlAddInventory = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WholesalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufactureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.pnlAddInventory.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // txtSearchById
            // 
            this.txtSearchById.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearchById.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchById.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchById.ForeColor = System.Drawing.Color.Black;
            this.txtSearchById.Location = new System.Drawing.Point(32, 27);
            this.txtSearchById.Margin = new System.Windows.Forms.Padding(3, 45, 3, 3);
            this.txtSearchById.Multiline = true;
            this.txtSearchById.Name = "txtSearchById";
            this.txtSearchById.Size = new System.Drawing.Size(200, 28);
            this.txtSearchById.TabIndex = 10;
            this.txtSearchById.Text = "Search by ID";
            this.txtSearchById.WordWrap = false;
            this.txtSearchById.TextChanged += new System.EventHandler(this.txtSearchById_TextChanged);
            this.txtSearchById.Enter += new System.EventHandler(this.txtSearchById_Enter);
            this.txtSearchById.Leave += new System.EventHandler(this.txtSearchById_Leave);
            // 
            // errorProviderTxt
            // 
            this.errorProviderTxt.ContainerControl = this;
            // 
            // cmbCatagory
            // 
            this.cmbCatagory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbCatagory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCatagory.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCatagory.FormattingEnabled = true;
            this.cmbCatagory.ItemHeight = 21;
            this.cmbCatagory.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.cmbCatagory.Location = new System.Drawing.Point(295, 28);
            this.cmbCatagory.Margin = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.cmbCatagory.Name = "cmbCatagory";
            this.cmbCatagory.Size = new System.Drawing.Size(174, 29);
            this.cmbCatagory.TabIndex = 22;
            this.cmbCatagory.Text = "Catagory";
            this.cmbCatagory.SelectedIndexChanged += new System.EventHandler(this.cmbCatagory_SelectedIndexChanged);
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
            this.cmbSupplier.TabIndex = 26;
            this.cmbSupplier.Text = "Supplier";
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            // 
            // pnlAddInventory
            // 
            this.pnlAddInventory.Controls.Add(this.pictureBox11);
            this.pnlAddInventory.Controls.Add(this.lblAdd);
            this.pnlAddInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlAddInventory.Location = new System.Drawing.Point(712, 28);
            this.pnlAddInventory.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAddInventory.Name = "pnlAddInventory";
            this.pnlAddInventory.Size = new System.Drawing.Size(78, 29);
            this.pnlAddInventory.TabIndex = 27;
            this.pnlAddInventory.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddInventory_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(32, 94);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 375);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.RetailPrice,
            this.WholesalePrice,
            this.ManufactureDate,
            this.AmountAvailable,
            this.isAvailable,
            this.SupplierId,
            this.DeleteProduct});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 369);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Product Id";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // RetailPrice
            // 
            this.RetailPrice.HeaderText = "Retail Price";
            this.RetailPrice.Name = "RetailPrice";
            this.RetailPrice.ReadOnly = true;
            // 
            // WholesalePrice
            // 
            this.WholesalePrice.HeaderText = "Wholesale Price";
            this.WholesalePrice.Name = "WholesalePrice";
            this.WholesalePrice.ReadOnly = true;
            // 
            // ManufactureDate
            // 
            this.ManufactureDate.HeaderText = "Manufacture Date";
            this.ManufactureDate.Name = "ManufactureDate";
            this.ManufactureDate.ReadOnly = true;
            // 
            // AmountAvailable
            // 
            this.AmountAvailable.HeaderText = "Amount Available";
            this.AmountAvailable.Name = "AmountAvailable";
            this.AmountAvailable.ReadOnly = true;
            // 
            // isAvailable
            // 
            this.isAvailable.HeaderText = "is Available";
            this.isAvailable.Name = "isAvailable";
            this.isAvailable.ReadOnly = true;
            // 
            // SupplierId
            // 
            this.SupplierId.HeaderText = "Supplier Id";
            this.SupplierId.Name = "SupplierId";
            this.SupplierId.ReadOnly = true;
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.HeaderText = "";
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Text = "Delete";
            this.DeleteProduct.UseColumnTextForButtonValue = true;
            // 
            // AdminInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAddInventory);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.cmbCatagory);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtSearchById);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminInventory";
            this.Text = "AdminInventory";
            this.Load += new System.EventHandler(this.AdminInventory_Load);
            this.Enter += new System.EventHandler(this.AdminInventory_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.pnlAddInventory.ResumeLayout(false);
            this.pnlAddInventory.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtSearchById;
        private System.Windows.Forms.ErrorProvider errorProviderTxt;
        private System.Windows.Forms.ComboBox cmbCatagory;
        private Label lblAdd;
        private PictureBox pictureBox11;
        private ComboBox cmbSupplier;
        private Panel pnlAddInventory;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn RetailPrice;
        private DataGridViewTextBoxColumn WholesalePrice;
        private DataGridViewTextBoxColumn ManufactureDate;
        private DataGridViewTextBoxColumn AmountAvailable;
        private DataGridViewTextBoxColumn isAvailable;
        private DataGridViewTextBoxColumn SupplierId;
        private DataGridViewButtonColumn DeleteProduct;
    }
}