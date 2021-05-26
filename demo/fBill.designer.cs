
namespace demo
{
    partial class fBill
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
            this.dgvBillDetail = new System.Windows.Forms.DataGridView();
            this.IDProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbIDStaff = new System.Windows.Forms.ComboBox();
            this.cbIDCustomer = new System.Windows.Forms.ComboBox();
            this.cbTypeBill = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblIDBill = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pButton = new System.Windows.Forms.Panel();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefreshText = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbIDProduct = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblIDProduct = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).BeginInit();
            this.panel1.SuspendLayout();
            this.pButton.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBillDetail
            // 
            this.dgvBillDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProduct,
            this.ProductName,
            this.Number,
            this.Price,
            this.Discount,
            this.TotalPrice});
            this.dgvBillDetail.Location = new System.Drawing.Point(28, 119);
            this.dgvBillDetail.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBillDetail.Name = "dgvBillDetail";
            this.dgvBillDetail.RowHeadersWidth = 51;
            this.dgvBillDetail.Size = new System.Drawing.Size(1170, 245);
            this.dgvBillDetail.TabIndex = 13;
            // 
            // IDProduct
            // 
            this.IDProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDProduct.HeaderText = "IDProduct";
            this.IDProduct.MinimumWidth = 6;
            this.IDProduct.Name = "IDProduct";
            this.IDProduct.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Discount.HeaderText = "Discount";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.cbIDStaff);
            this.panel1.Controls.Add(this.cbIDCustomer);
            this.panel1.Controls.Add(this.cbTypeBill);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblCustomerName);
            this.panel1.Controls.Add(this.lblStaffName);
            this.panel1.Controls.Add(this.lblIDBill);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(9, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 215);
            this.panel1.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 22);
            this.dateTimePicker1.TabIndex = 34;
            this.dateTimePicker1.Value = new System.DateTime(2021, 5, 17, 9, 38, 48, 0);
            // 
            // cbIDStaff
            // 
            this.cbIDStaff.FormattingEnabled = true;
            this.cbIDStaff.Location = new System.Drawing.Point(165, 97);
            this.cbIDStaff.Name = "cbIDStaff";
            this.cbIDStaff.Size = new System.Drawing.Size(183, 24);
            this.cbIDStaff.TabIndex = 33;
            this.cbIDStaff.TextChanged += new System.EventHandler(this.cbIDStaff_TextChanged);
            // 
            // cbIDCustomer
            // 
            this.cbIDCustomer.FormattingEnabled = true;
            this.cbIDCustomer.Location = new System.Drawing.Point(563, 57);
            this.cbIDCustomer.Name = "cbIDCustomer";
            this.cbIDCustomer.Size = new System.Drawing.Size(183, 24);
            this.cbIDCustomer.TabIndex = 33;
            this.cbIDCustomer.TextChanged += new System.EventHandler(this.txtIDCustomer_TextChanged);
            this.cbIDCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // cbTypeBill
            // 
            this.cbTypeBill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeBill.FormattingEnabled = true;
            this.cbTypeBill.Items.AddRange(new object[] {
            "Hóa Đơn Bán",
            "Hóa Đơn Nhập"});
            this.cbTypeBill.Location = new System.Drawing.Point(563, 17);
            this.cbTypeBill.Name = "cbTypeBill";
            this.cbTypeBill.Size = new System.Drawing.Size(183, 24);
            this.cbTypeBill.TabIndex = 33;
            // 
            // lblAddress
            // 
            this.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddress.Location = new System.Drawing.Point(563, 142);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(183, 23);
            this.lblAddress.TabIndex = 32;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustomerName.Location = new System.Drawing.Point(563, 100);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(183, 23);
            this.lblCustomerName.TabIndex = 32;
            // 
            // lblStaffName
            // 
            this.lblStaffName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStaffName.Location = new System.Drawing.Point(165, 142);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(183, 23);
            this.lblStaffName.TabIndex = 32;
            // 
            // lblIDBill
            // 
            this.lblIDBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIDBill.Location = new System.Drawing.Point(165, 15);
            this.lblIDBill.Name = "lblIDBill";
            this.lblIDBill.Size = new System.Drawing.Size(183, 23);
            this.lblIDBill.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(423, 17);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 28);
            this.label16.TabIndex = 19;
            this.label16.Text = "TypeBill:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(423, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(423, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "CustomerName:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(423, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "IDCustomer:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(25, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "StaffName:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "IDStaff:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(25, 55);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 28);
            this.label9.TabIndex = 19;
            this.label9.Text = "Day:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(25, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 28);
            this.label10.TabIndex = 24;
            this.label10.Text = "IDBill:";
            // 
            // pButton
            // 
            this.pButton.Controls.Add(this.btnSaveProduct);
            this.pButton.Controls.Add(this.btnExit);
            this.pButton.Controls.Add(this.btnRefreshText);
            this.pButton.Controls.Add(this.btnAddProduct);
            this.pButton.Controls.Add(this.btnDeleteProduct);
            this.pButton.Location = new System.Drawing.Point(813, 30);
            this.pButton.Margin = new System.Windows.Forms.Padding(4);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(425, 215);
            this.pButton.TabIndex = 11;
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Location = new System.Drawing.Point(268, 14);
            this.btnSaveProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(100, 28);
            this.btnSaveProduct.TabIndex = 15;
            this.btnSaveProduct.Text = "Save";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(144, 50);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefreshText
            // 
            this.btnRefreshText.Location = new System.Drawing.Point(24, 48);
            this.btnRefreshText.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshText.Name = "btnRefreshText";
            this.btnRefreshText.Size = new System.Drawing.Size(100, 28);
            this.btnRefreshText.TabIndex = 16;
            this.btnRefreshText.Text = "Refresh";
            this.btnRefreshText.UseVisualStyleBackColor = true;
            this.btnRefreshText.Click += new System.EventHandler(this.btnRefreshText_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(24, 14);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 28);
            this.btnAddProduct.TabIndex = 16;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(144, 14);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteProduct.TabIndex = 17;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvBillDetail);
            this.groupBox1.Controls.Add(this.cbIDProduct);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblTotalCost);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblIDProduct);
            this.groupBox1.Controls.Add(this.lblProductName);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtDiscount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Location = new System.Drawing.Point(9, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1229, 428);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill Detail";
            // 
            // cbIDProduct
            // 
            this.cbIDProduct.FormattingEnabled = true;
            this.cbIDProduct.Location = new System.Drawing.Point(165, 21);
            this.cbIDProduct.Name = "cbIDProduct";
            this.cbIDProduct.Size = new System.Drawing.Size(183, 24);
            this.cbIDProduct.TabIndex = 33;
            this.cbIDProduct.TextChanged += new System.EventHandler(this.cbIDProduct_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(825, 27);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 28);
            this.label14.TabIndex = 24;
            this.label14.Text = "Price:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCost.Location = new System.Drawing.Point(965, 384);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(183, 23);
            this.lblTotalCost.TabIndex = 32;
            // 
            // lblPrice
            // 
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Location = new System.Drawing.Point(965, 65);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(183, 23);
            this.lblPrice.TabIndex = 32;
            // 
            // lblIDProduct
            // 
            this.lblIDProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIDProduct.Location = new System.Drawing.Point(965, 26);
            this.lblIDProduct.Name = "lblIDProduct";
            this.lblIDProduct.Size = new System.Drawing.Size(183, 23);
            this.lblIDProduct.TabIndex = 32;
            // 
            // lblProductName
            // 
            this.lblProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductName.Location = new System.Drawing.Point(563, 26);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(183, 23);
            this.lblProductName.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(423, 27);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 28);
            this.label12.TabIndex = 24;
            this.label12.Text = "ProductName:";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(825, 384);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 28);
            this.label15.TabIndex = 24;
            this.label15.Text = "TotalPrice:";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(825, 66);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 28);
            this.label13.TabIndex = 24;
            this.label13.Text = "Price:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(25, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 28);
            this.label7.TabIndex = 24;
            this.label7.Text = "IDProduct:";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(423, 66);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 28);
            this.label11.TabIndex = 24;
            this.label11.Text = "Discount %:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(563, 66);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(183, 22);
            this.txtDiscount.TabIndex = 32;
          
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(25, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 28);
            this.label6.TabIndex = 24;
            this.label6.Text = "Number:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(165, 66);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(183, 22);
            this.txtNumber.TabIndex = 32;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // fBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 704);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fBill";
            this.Text = "fBill";
            this.Load += new System.EventHandler(this.fBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pButton.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBillDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pButton;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefreshText;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblIDBill;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblIDProduct;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbTypeBill;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.ComboBox cbIDProduct;
        private System.Windows.Forms.ComboBox cbIDStaff;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.ComboBox cbIDCustomer;
    }
}