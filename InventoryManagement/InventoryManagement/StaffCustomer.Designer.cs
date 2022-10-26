using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagement
{
    partial class StaffCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.btnSearchCustomers = new System.Windows.Forms.PictureBox();
            this.btnAddCustomers = new System.Windows.Forms.PictureBox();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSeparetor = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlContainerTransactionttl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlContainerOverviewttl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail1 = new System.Windows.Forms.Label();
            this.lblFullName1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlContainerTransactionttl.SuspendLayout();
            this.pnlContainerOverviewttl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(52, 130);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 428);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSearchCustomer);
            this.panel2.Controls.Add(this.btnSearchCustomers);
            this.panel2.Controls.Add(this.btnAddCustomers);
            this.panel2.Location = new System.Drawing.Point(52, 45);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 75);
            this.panel2.TabIndex = 0;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearchCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchCustomer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.ForeColor = System.Drawing.Color.Black;
            this.txtSearchCustomer.HideSelection = false;
            this.txtSearchCustomer.Location = new System.Drawing.Point(52, 31);
            this.txtSearchCustomer.Margin = new System.Windows.Forms.Padding(4, 55, 4, 4);
            this.txtSearchCustomer.Multiline = true;
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(261, 27);
            this.txtSearchCustomer.TabIndex = 39;
            this.txtSearchCustomer.Text = "Search Customers";
            this.txtSearchCustomer.Visible = false;
            this.txtSearchCustomer.WordWrap = false;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            this.txtSearchCustomer.Enter += new System.EventHandler(this.txtSearchByName_Enter);
            this.txtSearchCustomer.Leave += new System.EventHandler(this.txtSearchCustomer_Leave);
            // 
            // btnSearchCustomers
            // 
            this.btnSearchCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCustomers.Image")));
            this.btnSearchCustomers.Location = new System.Drawing.Point(321, 31);
            this.btnSearchCustomers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchCustomers.Name = "btnSearchCustomers";
            this.btnSearchCustomers.Size = new System.Drawing.Size(27, 23);
            this.btnSearchCustomers.TabIndex = 38;
            this.btnSearchCustomers.TabStop = false;
            this.btnSearchCustomers.Click += new System.EventHandler(this.btnSearchCustomers_Click);
            // 
            // btnAddCustomers
            // 
            this.btnAddCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCustomers.Image")));
            this.btnAddCustomers.Location = new System.Drawing.Point(368, 31);
            this.btnAddCustomers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddCustomers.Name = "btnAddCustomers";
            this.btnAddCustomers.Size = new System.Drawing.Size(21, 23);
            this.btnAddCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddCustomers.TabIndex = 36;
            this.btnAddCustomers.TabStop = false;
            this.btnAddCustomers.Click += new System.EventHandler(this.btnAddCustomers_Click);
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.Location = new System.Drawing.Point(276, 11);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(25, 27);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = ".";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.lblTitle1);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.pnlSeparetor);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.pnlContainerTransactionttl);
            this.panel4.Controls.Add(this.pnlContainerOverviewttl);
            this.panel4.Controls.Add(this.lblEmail1);
            this.panel4.Controls.Add(this.lblFullName1);
            this.panel4.Location = new System.Drawing.Point(481, 34);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(629, 524);
            this.panel4.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 446);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 18);
            this.label11.TabIndex = 51;
            this.label11.Text = "Full Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label12.Location = new System.Drawing.Point(37, 430);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 17);
            this.label12.TabIndex = 50;
            this.label12.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 18);
            this.label9.TabIndex = 49;
            this.label9.Text = "Gender";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label10.Location = new System.Drawing.Point(37, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 48;
            this.label10.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 18);
            this.label7.TabIndex = 47;
            this.label7.Text = "+251-912345678";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label8.Location = new System.Drawing.Point(37, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 18);
            this.label5.TabIndex = 45;
            this.label5.Text = "custemail@example.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label6.Location = new System.Drawing.Point(37, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 43;
            this.label4.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(36, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Name";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(39, 143);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Location = new System.Drawing.Point(281, 143);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(323, 364);
            this.panel5.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.OrderDate,
            this.ProductId,
            this.Quantity,
            this.TotalPrice});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(323, 364);
            this.dataGridView1.TabIndex = 0;
            // 
            // OrderId
            // 
            this.OrderId.HeaderText = "Order Id";
            this.OrderId.MinimumWidth = 6;
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            this.OrderId.Width = 125;
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.MinimumWidth = 6;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            this.OrderDate.Width = 125;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Product Id";
            this.ProductId.MinimumWidth = 6;
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 125;
            // 
            // pnlSeparetor
            // 
            this.pnlSeparetor.Location = new System.Drawing.Point(265, 126);
            this.pnlSeparetor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSeparetor.Name = "pnlSeparetor";
            this.pnlSeparetor.Size = new System.Drawing.Size(1, 382);
            this.pnlSeparetor.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(569, 28);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(511, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlContainerTransactionttl
            // 
            this.pnlContainerTransactionttl.Controls.Add(this.label2);
            this.pnlContainerTransactionttl.Location = new System.Drawing.Point(281, 96);
            this.pnlContainerTransactionttl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContainerTransactionttl.Name = "pnlContainerTransactionttl";
            this.pnlContainerTransactionttl.Size = new System.Drawing.Size(189, 27);
            this.pnlContainerTransactionttl.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Transactions";
            // 
            // pnlContainerOverviewttl
            // 
            this.pnlContainerOverviewttl.Controls.Add(this.label1);
            this.pnlContainerOverviewttl.Location = new System.Drawing.Point(33, 96);
            this.pnlContainerOverviewttl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContainerOverviewttl.Name = "pnlContainerOverviewttl";
            this.pnlContainerOverviewttl.Size = new System.Drawing.Size(189, 27);
            this.pnlContainerOverviewttl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "OverView";
            // 
            // lblEmail1
            // 
            this.lblEmail1.AutoSize = true;
            this.lblEmail1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lblEmail1.Location = new System.Drawing.Point(28, 58);
            this.lblEmail1.Name = "lblEmail1";
            this.lblEmail1.Size = new System.Drawing.Size(194, 18);
            this.lblEmail1.TabIndex = 2;
            this.lblEmail1.Text = "custemail@example.com";
            // 
            // lblFullName1
            // 
            this.lblFullName1.AutoSize = true;
            this.lblFullName1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName1.Location = new System.Drawing.Point(28, 31);
            this.lblFullName1.Name = "lblFullName1";
            this.lblFullName1.Size = new System.Drawing.Size(129, 27);
            this.lblFullName1.TabIndex = 1;
            this.lblFullName1.Text = "Full Name";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(407, 425);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // StaffCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1153, 657);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StaffCustomer";
            this.Text = "StaffCustomer";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlContainerTransactionttl.ResumeLayout(false);
            this.pnlContainerTransactionttl.PerformLayout();
            this.pnlContainerOverviewttl.ResumeLayout(false);
            this.pnlContainerOverviewttl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle1;
        private PictureBox btnAddCustomers;
        private ErrorProvider errorProvider1;
        private Panel panel4;
        private TextBox txtSearchCustomer;
        private PictureBox btnSearchCustomers;
        private Panel pnlContainerOverviewttl;
        private Label label1;
        private Label lblEmail1;
        private Label lblFullName1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel pnlContainerTransactionttl;
        private Label label2;
        private Panel panel5;
        private Panel pnlSeparetor;
        private Label label11;
        private Label label12;
        private Label label9;
        private Label label10;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn OrderId;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn TotalPrice;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}