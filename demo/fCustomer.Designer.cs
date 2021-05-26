
namespace demo
{
    partial class fCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCustomer));
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerdetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbcustomertype = new System.Windows.Forms.ComboBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pButton = new System.Windows.Forms.Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnRefreshText = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorCustomer = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.pButton.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhoneNum,
            this.customerdetail,
            this.CustomerName,
            this.IDCard,
            this.Email,
            this.Address,
            this.Status});
            this.dgvCustomer.Location = new System.Drawing.Point(13, 24);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersVisible = false;
            this.dgvCustomer.RowHeadersWidth = 40;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(856, 222);
            this.dgvCustomer.TabIndex = 13;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            // 
            // PhoneNum
            // 
            this.PhoneNum.DataPropertyName = "PhoneNum";
            this.PhoneNum.HeaderText = "Số Điện Thoại";
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.ReadOnly = true;
            // 
            // customerdetail
            // 
            this.customerdetail.DataPropertyName = "CustomerType";
            this.customerdetail.HeaderText = "Loại Khách Hàng";
            this.customerdetail.Name = "customerdetail";
            this.customerdetail.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Tên Khách Hàng";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // IDCard
            // 
            this.IDCard.DataPropertyName = "IDCard";
            this.IDCard.HeaderText = "Mã Thẻ";
            this.IDCard.Name = "IDCard";
            this.IDCard.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa Chỉ";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Trạng Thái";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbcustomertype);
            this.panel1.Controls.Add(this.txtPhoneNum);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIDCard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 205);
            this.panel1.TabIndex = 12;
            // 
            // cbcustomertype
            // 
            this.cbcustomertype.FormattingEnabled = true;
            this.cbcustomertype.Location = new System.Drawing.Point(132, 15);
            this.cbcustomertype.Name = "cbcustomertype";
            this.cbcustomertype.Size = new System.Drawing.Size(138, 21);
            this.cbcustomertype.TabIndex = 48;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(133, 70);
            this.txtPhoneNum.MaxLength = 10;
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(138, 20);
            this.txtPhoneNum.TabIndex = 0;
            this.txtPhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNum_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(362, 65);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(171, 20);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(363, 17);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(171, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(291, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 45;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(289, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 47;
            this.label5.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(27, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 46;
            this.label3.Text = "Loại Khách Hàng:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 46;
            this.label2.Text = "Số Điện Thoại:";
            // 
            // txtIDCard
            // 
            this.txtIDCard.Location = new System.Drawing.Point(132, 168);
            this.txtIDCard.MaxLength = 12;
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(138, 20);
            this.txtIDCard.TabIndex = 2;
            this.txtIDCard.TextChanged += new System.EventHandler(this.txtIDCard_TextChanged);
            this.txtIDCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDCard_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "Mã Thẻ";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(362, 115);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(171, 21);
            this.cbStatus.TabIndex = 5;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(132, 120);
            this.txtCustomerName.MaxLength = 20;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(138, 20);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(291, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Trạng Thái";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(27, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tên Khách Hàng";
            // 
            // pButton
            // 
            this.pButton.Controls.Add(this.txtSearch);
            this.pButton.Controls.Add(this.btnExit);
            this.pButton.Controls.Add(this.cbSearch);
            this.pButton.Controls.Add(this.btnUpdateCustomer);
            this.pButton.Controls.Add(this.btnRefreshText);
            this.pButton.Controls.Add(this.btnAddCustomer);
            this.pButton.Controls.Add(this.btnDeleteCustomer);
            this.pButton.Location = new System.Drawing.Point(610, 12);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(271, 205);
            this.pButton.TabIndex = 11;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconRight")));
            this.txtSearch.Location = new System.Drawing.Point(56, 139);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(161, 36);
            this.txtSearch.TabIndex = 38;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // btnExit
            // 
            this.btnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(54)))), ((int)(((byte)(128)))));
            this.btnExit.BorderRadius = 9;
            this.btnExit.BorderThickness = 3;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.HoverState.BorderColor = System.Drawing.SystemColors.Control;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(211, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(45, 37);
            this.btnExit.TabIndex = 11;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(56, 101);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(161, 21);
            this.cbSearch.TabIndex = 6;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(18, 53);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCustomer.TabIndex = 2;
            this.btnUpdateCustomer.Text = "Cập Nhập";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnRefreshText
            // 
            this.btnRefreshText.Location = new System.Drawing.Point(108, 53);
            this.btnRefreshText.Name = "btnRefreshText";
            this.btnRefreshText.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshText.TabIndex = 3;
            this.btnRefreshText.Text = "Nhập Lại";
            this.btnRefreshText.UseVisualStyleBackColor = true;
            this.btnRefreshText.Click += new System.EventHandler(this.btnRefreshText_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(18, 11);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Thêm";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(108, 11);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCustomer.TabIndex = 1;
            this.btnDeleteCustomer.Text = "Xoá";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCustomer);
            this.groupBox1.Location = new System.Drawing.Point(12, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 255);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Khách Hàng";
            // 
            // errorCustomer
            // 
            this.errorCustomer.ContainerControl = this;
            // 
            // fCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fCustomer";
            this.Load += new System.EventHandler(this.fCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pButton.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pButton;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnRefreshText;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorCustomer;
        private System.Windows.Forms.ComboBox cbcustomertype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerdetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}