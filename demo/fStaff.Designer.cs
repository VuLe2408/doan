
namespace demo
{
    partial class fStaff
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
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.IDStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pButton = new System.Windows.Forms.Panel();
            this.pValues = new System.Windows.Forms.Panel();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.From = new System.Windows.Forms.Label();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefreshText = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtIDStaff = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorStaff = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.pButton.SuspendLayout();
            this.pValues.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStaff
            // 
            this.dgvStaff.BackgroundColor = System.Drawing.Color.White;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDStaff,
            this.StaffName,
            this.Salary,
            this.PhoneNum,
            this.Email,
            this.Address,
            this.Status});
            this.dgvStaff.Location = new System.Drawing.Point(7, 17);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Size = new System.Drawing.Size(925, 240);
            this.dgvStaff.TabIndex = 13;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
            // 
            // IDStaff
            // 
            this.IDStaff.DataPropertyName = "IDStaff";
            this.IDStaff.HeaderText = "Mã Nhân Viên";
            this.IDStaff.Name = "IDStaff";
            this.IDStaff.ReadOnly = true;
            // 
            // StaffName
            // 
            this.StaffName.DataPropertyName = "StaffName";
            this.StaffName.HeaderText = "Tên Nhân Viên";
            this.StaffName.Name = "StaffName";
            this.StaffName.ReadOnly = true;
            this.StaffName.Width = 148;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Lương";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            this.Salary.Width = 145;
            // 
            // PhoneNum
            // 
            this.PhoneNum.DataPropertyName = "PhoneNum";
            this.PhoneNum.HeaderText = "Số Điện Thoại";
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.ReadOnly = true;
            this.PhoneNum.Width = 121;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 148;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa Chỉ";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 147;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Chức Vụ";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 72;
            // 
            // pButton
            // 
            this.pButton.Controls.Add(this.pValues);
            this.pButton.Controls.Add(this.cbSearch);
            this.pButton.Controls.Add(this.btnReload);
            this.pButton.Controls.Add(this.btnSearch);
            this.pButton.Controls.Add(this.btnUpdateStaff);
            this.pButton.Controls.Add(this.btnExit);
            this.pButton.Controls.Add(this.btnRefreshText);
            this.pButton.Controls.Add(this.btnAddStaff);
            this.pButton.Controls.Add(this.btnDeleteStaff);
            this.pButton.Controls.Add(this.txtSearch);
            this.pButton.Location = new System.Drawing.Point(625, 24);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(319, 175);
            this.pButton.TabIndex = 11;
            // 
            // pValues
            // 
            this.pValues.Controls.Add(this.txtTo);
            this.pValues.Controls.Add(this.label11);
            this.pValues.Controls.Add(this.txtFrom);
            this.pValues.Controls.Add(this.From);
            this.pValues.Location = new System.Drawing.Point(13, 106);
            this.pValues.Name = "pValues";
            this.pValues.Size = new System.Drawing.Size(291, 30);
            this.pValues.TabIndex = 36;
            this.pValues.Visible = false;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(184, 4);
            this.txtTo.MaxLength = 12;
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(86, 20);
            this.txtTo.TabIndex = 1;
            this.txtTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(142, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Đến:";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(45, 4);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(86, 20);
            this.txtFrom.TabIndex = 0;
            this.txtFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Location = new System.Drawing.Point(3, 7);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(23, 13);
            this.From.TabIndex = 0;
            this.From.Text = "Từ:";
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(28, 80);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(103, 21);
            this.cbSearch.TabIndex = 6;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(118, 43);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Tải Lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(28, 142);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(258, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.Location = new System.Drawing.Point(211, 14);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateStaff.TabIndex = 2;
            this.btnUpdateStaff.Text = "Cập Nhật";
            this.btnUpdateStaff.UseVisualStyleBackColor = true;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(211, 43);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefreshText
            // 
            this.btnRefreshText.Location = new System.Drawing.Point(28, 42);
            this.btnRefreshText.Name = "btnRefreshText";
            this.btnRefreshText.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshText.TabIndex = 3;
            this.btnRefreshText.Text = "Nhập Lại";
            this.btnRefreshText.UseVisualStyleBackColor = true;
            this.btnRefreshText.Click += new System.EventHandler(this.btnRefreshText_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(28, 14);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(75, 23);
            this.btnAddStaff.TabIndex = 0;
            this.btnAddStaff.Text = "Thêm";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Location = new System.Drawing.Point(118, 14);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStaff.TabIndex = 1;
            this.btnDeleteStaff.Text = "Xoá";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(150, 80);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(136, 20);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.txtStaffName);
            this.panel1.Controls.Add(this.txtPhoneNum);
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtIDStaff);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 175);
            this.panel1.TabIndex = 14;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(398, 90);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(136, 21);
            this.cbStatus.TabIndex = 6;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(124, 45);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(138, 20);
            this.txtStaffName.TabIndex = 1;
            this.txtStaffName.TextChanged += new System.EventHandler(this.txtStaffName_TextChanged);
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(126, 116);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(136, 20);
            this.txtPhoneNum.TabIndex = 3;
            this.txtPhoneNum.TextChanged += new System.EventHandler(this.txtStaffName_TextChanged);
            this.txtPhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(126, 78);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(136, 20);
            this.txtSalary.TabIndex = 2;
            this.txtSalary.TextChanged += new System.EventHandler(this.txtStaffName_TextChanged);
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(398, 52);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(136, 20);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtStaffName_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(398, 19);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtStaffName_TextChanged);
            // 
            // txtIDStaff
            // 
            this.txtIDStaff.Location = new System.Drawing.Point(126, 12);
            this.txtIDStaff.MaxLength = 20;
            this.txtIDStaff.Name = "txtIDStaff";
            this.txtIDStaff.Size = new System.Drawing.Size(136, 20);
            this.txtIDStaff.TabIndex = 0;
            this.txtIDStaff.TextChanged += new System.EventHandler(this.txtIDStaff_TextChanged);
            this.txtIDStaff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDStaff_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(291, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Email";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(292, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Trạng Thái";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(290, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Địa Chỉ";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(19, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tên Nhân Viên:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Số Điện Thoại:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Lương:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(19, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Mã Nhân Viên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvStaff);
            this.groupBox1.Location = new System.Drawing.Point(12, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 263);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Nhân Viên";
            // 
            // errorStaff
            // 
            this.errorStaff.ContainerControl = this;
            // 
            // fStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fStaff";
            this.Load += new System.EventHandler(this.fStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.pButton.ResumeLayout(false);
            this.pButton.PerformLayout();
            this.pValues.ResumeLayout(false);
            this.pValues.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Panel pButton;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefreshText;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtIDStaff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pValues;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ErrorProvider errorStaff;
    }
}