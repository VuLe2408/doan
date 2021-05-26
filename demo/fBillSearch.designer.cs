
namespace demo
{
    partial class fBillSearch
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
            this.btnExit = new System.Windows.Forms.Button();
            this.pButton = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.IDBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBillDetail = new System.Windows.Forms.DataGridView();
            this.IDBill1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đổiTrạngTháiHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pButton.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(37, 45);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 28);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pButton
            // 
            this.pButton.Controls.Add(this.btnExit);
            this.pButton.Location = new System.Drawing.Point(1058, 20);
            this.pButton.Margin = new System.Windows.Forms.Padding(4);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(199, 120);
            this.pButton.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(809, 45);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(191, 28);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(25, 45);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 28);
            this.label10.TabIndex = 24;
            this.label10.Text = "IDBill:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(28, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 120);
            this.panel1.TabIndex = 15;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(124, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(645, 22);
            this.txtSearch.TabIndex = 25;
            // 
            // dgvBill
            // 
            this.dgvBill.BackgroundColor = System.Drawing.Color.White;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDBill,
            this.Date,
            this.IDCustomer,
            this.IDStaff,
            this.TypeBill});
            this.dgvBill.Location = new System.Drawing.Point(28, 34);
            this.dgvBill.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.Size = new System.Drawing.Size(579, 273);
            this.dgvBill.TabIndex = 13;
            this.dgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellContentClick);
           
            // 
            // IDBill
            // 
            this.IDBill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDBill.DataPropertyName = "IDBill";
            this.IDBill.HeaderText = "IDBill";
            this.IDBill.MinimumWidth = 6;
            this.IDBill.Name = "IDBill";
            this.IDBill.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // IDCustomer
            // 
            this.IDCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDCustomer.DataPropertyName = "IDCustomer";
            this.IDCustomer.HeaderText = "IDCustomer";
            this.IDCustomer.MinimumWidth = 6;
            this.IDCustomer.Name = "IDCustomer";
            this.IDCustomer.ReadOnly = true;
            // 
            // IDStaff
            // 
            this.IDStaff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDStaff.DataPropertyName = "IDStaff";
            this.IDStaff.HeaderText = "IDStaff";
            this.IDStaff.MinimumWidth = 6;
            this.IDStaff.Name = "IDStaff";
            this.IDStaff.ReadOnly = true;
            // 
            // TypeBill
            // 
            this.TypeBill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeBill.DataPropertyName = "TypeBill";
            this.TypeBill.HeaderText = "TypeBill";
            this.TypeBill.MinimumWidth = 6;
            this.TypeBill.Name = "TypeBill";
            this.TypeBill.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvBill);
            this.groupBox1.Location = new System.Drawing.Point(28, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 336);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Bill";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBillDetail);
            this.groupBox2.Location = new System.Drawing.Point(661, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 336);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bill Detail";
            // 
            // dgvBillDetail
            // 
            this.dgvBillDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDBill1,
            this.IDProduct,
            this.Number,
            this.Price,
            this.Discount,
            this.TotalPrice});
            this.dgvBillDetail.Location = new System.Drawing.Point(28, 34);
            this.dgvBillDetail.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBillDetail.Name = "dgvBillDetail";
            this.dgvBillDetail.RowHeadersWidth = 51;
            this.dgvBillDetail.Size = new System.Drawing.Size(543, 273);
            this.dgvBillDetail.TabIndex = 13;
            // 
            // IDBill1
            // 
            this.IDBill1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDBill1.DataPropertyName = "IDBill";
            this.IDBill1.HeaderText = "IDBill";
            this.IDBill1.MinimumWidth = 6;
            this.IDBill1.Name = "IDBill1";
            this.IDBill1.ReadOnly = true;
            // 
            // IDProduct
            // 
            this.IDProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDProduct.DataPropertyName = "IDProduct";
            this.IDProduct.HeaderText = "IDProduct";
            this.IDProduct.MinimumWidth = 6;
            this.IDProduct.Name = "IDProduct";
            this.IDProduct.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Discount";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiTrạngTháiHóaĐơnToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(235, 28);
            // 
            // đổiTrạngTháiHóaĐơnToolStripMenuItem
            // 
            this.đổiTrạngTháiHóaĐơnToolStripMenuItem.Name = "đổiTrạngTháiHóaĐơnToolStripMenuItem";
            this.đổiTrạngTháiHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.đổiTrạngTháiHóaĐơnToolStripMenuItem.Text = "Đổi trạng thái Hóa Đơn";
            // 
            // fBillSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1285, 521);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pButton);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fBillSearch";
            this.Text = "fBillDetail";
            this.Load += new System.EventHandler(this.fBillDetail_Load);
            this.pButton.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pButton;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeBill;
        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.DataGridView dgvBillDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBill1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đổiTrạngTháiHóaĐơnToolStripMenuItem;
    }
}