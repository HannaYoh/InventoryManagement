namespace InventoryManagement
{
    partial class AddOrders
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
            this.txtWholeSalesPrice = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpManufacturingDate = new System.Windows.Forms.DateTimePicker();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.txtAmountAvailable = new System.Windows.Forms.TextBox();
            this.txtRetailPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtWholeSalesPrice
            // 
            this.txtWholeSalesPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtWholeSalesPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWholeSalesPrice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWholeSalesPrice.ForeColor = System.Drawing.Color.Black;
            this.txtWholeSalesPrice.Location = new System.Drawing.Point(93, 198);
            this.txtWholeSalesPrice.Margin = new System.Windows.Forms.Padding(4, 55, 4, 4);
            this.txtWholeSalesPrice.Multiline = true;
            this.txtWholeSalesPrice.Name = "txtWholeSalesPrice";
            this.txtWholeSalesPrice.Size = new System.Drawing.Size(267, 34);
            this.txtWholeSalesPrice.TabIndex = 47;
            this.txtWholeSalesPrice.Text = "WholeSales Price";
            this.txtWholeSalesPrice.WordWrap = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProduct.Location = new System.Drawing.Point(109, 478);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(210, 46);
            this.btnAddProduct.TabIndex = 46;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 374);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 21);
            this.label3.TabIndex = 45;
            this.label3.Text = "Manufactured Date";
            // 
            // dtpManufacturingDate
            // 
            this.dtpManufacturingDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dtpManufacturingDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dtpManufacturingDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpManufacturingDate.Location = new System.Drawing.Point(93, 402);
            this.dtpManufacturingDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpManufacturingDate.Name = "dtpManufacturingDate";
            this.dtpManufacturingDate.Size = new System.Drawing.Size(267, 27);
            this.dtpManufacturingDate.TabIndex = 44;
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
            this.cmbSupplier.Location = new System.Drawing.Point(93, 315);
            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(17, 4, 4, 4);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(267, 33);
            this.cmbSupplier.TabIndex = 43;
            this.cmbSupplier.Text = "Supplier";
            // 
            // txtAmountAvailable
            // 
            this.txtAmountAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAmountAvailable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmountAvailable.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountAvailable.ForeColor = System.Drawing.Color.Black;
            this.txtAmountAvailable.Location = new System.Drawing.Point(93, 258);
            this.txtAmountAvailable.Margin = new System.Windows.Forms.Padding(4, 55, 4, 4);
            this.txtAmountAvailable.Multiline = true;
            this.txtAmountAvailable.Name = "txtAmountAvailable";
            this.txtAmountAvailable.Size = new System.Drawing.Size(267, 34);
            this.txtAmountAvailable.TabIndex = 42;
            this.txtAmountAvailable.Text = "Amount Available";
            this.txtAmountAvailable.WordWrap = false;
            // 
            // txtRetailPrice
            // 
            this.txtRetailPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRetailPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRetailPrice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetailPrice.ForeColor = System.Drawing.Color.Black;
            this.txtRetailPrice.Location = new System.Drawing.Point(93, 139);
            this.txtRetailPrice.Margin = new System.Windows.Forms.Padding(4, 55, 4, 4);
            this.txtRetailPrice.Multiline = true;
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.Size = new System.Drawing.Size(267, 34);
            this.txtRetailPrice.TabIndex = 41;
            this.txtRetailPrice.Text = "Retail Price";
            this.txtRetailPrice.WordWrap = false;
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.ForeColor = System.Drawing.Color.Black;
            this.txtProductName.Location = new System.Drawing.Point(93, 79);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4, 55, 4, 4);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(267, 34);
            this.txtProductName.TabIndex = 40;
            this.txtProductName.Text = "Product Name";
            this.txtProductName.WordWrap = false;
            // 
            // AddOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 603);
            this.Controls.Add(this.txtWholeSalesPrice);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpManufacturingDate);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.txtAmountAvailable);
            this.Controls.Add(this.txtRetailPrice);
            this.Controls.Add(this.txtProductName);
            this.Name = "AddOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddOrders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWholeSalesPrice;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpManufacturingDate;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.TextBox txtAmountAvailable;
        private System.Windows.Forms.TextBox txtRetailPrice;
        private System.Windows.Forms.TextBox txtProductName;
    }
}