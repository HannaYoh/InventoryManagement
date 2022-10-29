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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GrpProduct = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbDiscount = new System.Windows.Forms.ComboBox();
            this.GrpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnSubmitOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitOrder.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmitOrder.Location = new System.Drawing.Point(110, 586);
            this.btnSubmitOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(210, 46);
            this.btnSubmitOrder.TabIndex = 46;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = false;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cmbProduct
            // 
            this.cmbProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProduct.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.ItemHeight = 25;
            this.cmbProduct.Items.AddRange(new object[] {
            "Product1",
            "Product2",
            "Product3"});
            this.cmbProduct.Location = new System.Drawing.Point(0, 25);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(17, 4, 4, 4);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(267, 33);
            this.cmbProduct.TabIndex = 43;
            this.cmbProduct.Text = "Product";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product,
            this.Qty,
            this.Amount});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(55, 418);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(347, 97);
            this.listView1.TabIndex = 48;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Product
            // 
            this.Product.Text = "Product";
            this.Product.Width = 100;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.Width = 100;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            // 
            // GrpProduct
            // 
            this.GrpProduct.Controls.Add(this.btnAdd);
            this.GrpProduct.Controls.Add(this.nudQty);
            this.GrpProduct.Controls.Add(this.cmbProduct);
            this.GrpProduct.Location = new System.Drawing.Point(93, 70);
            this.GrpProduct.Name = "GrpProduct";
            this.GrpProduct.Size = new System.Drawing.Size(270, 117);
            this.GrpProduct.TabIndex = 49;
            this.GrpProduct.TabStop = false;
            this.GrpProduct.Text = "Product";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(154, 66);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 29);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // nudQty
            // 
            this.nudQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nudQty.Location = new System.Drawing.Point(0, 66);
            this.nudQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(137, 22);
            this.nudQty.TabIndex = 44;
            this.nudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 25;
            this.comboBox1.Items.AddRange(new object[] {
            "CustA",
            "CustB"});
            this.comboBox1.Location = new System.Drawing.Point(93, 206);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(17, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(267, 33);
            this.comboBox1.TabIndex = 46;
            this.comboBox1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 329);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = "Delivery Date";
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dtpDeliveryDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dtpDeliveryDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeliveryDate.Location = new System.Drawing.Point(93, 357);
            this.dtpDeliveryDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(270, 27);
            this.dtpDeliveryDate.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 543);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 52;
            this.label1.Text = "Total: ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(196, 543);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(20, 21);
            this.lblPrice.TabIndex = 53;
            this.lblPrice.Text = "0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDiscount.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDiscount.FormattingEnabled = true;
            this.cmbDiscount.ItemHeight = 25;
            this.cmbDiscount.Items.AddRange(new object[] {
            "Product1",
            "Product2",
            "Product3"});
            this.cmbDiscount.Location = new System.Drawing.Point(93, 267);
            this.cmbDiscount.Margin = new System.Windows.Forms.Padding(17, 4, 4, 4);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(267, 33);
            this.cmbDiscount.TabIndex = 54;
            this.cmbDiscount.Text = "Discount";
            // 
            // AddOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 679);
            this.Controls.Add(this.cmbDiscount);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.GrpProduct);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSubmitOrder);
            this.Name = "AddOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddOrders";
            this.Load += new System.EventHandler(this.AddOrders_Load);
            this.GrpProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.GroupBox GrpProduct;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbDiscount;
    }
}