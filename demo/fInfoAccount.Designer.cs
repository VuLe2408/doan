
namespace demo
{
    partial class fInfoAccount
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReNewPassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIDAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.errorInfoAccount = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorInfoAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(29, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật Khẩu";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(135, 58);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(156, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(29, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật Khẩu Mới";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(135, 99);
            this.txtNewPassword.MaxLength = 20;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(156, 20);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(66, 357);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(189, 357);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtReNewPassword);
            this.panel1.Controls.Add(this.txtNewPassword);
            this.panel1.Location = new System.Drawing.Point(12, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 184);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(103, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thay Đổi Mật Khẩu";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(29, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Xác Nhận Mật Khẩu";
            // 
            // txtReNewPassword
            // 
            this.txtReNewPassword.Location = new System.Drawing.Point(135, 142);
            this.txtReNewPassword.MaxLength = 20;
            this.txtReNewPassword.Name = "txtReNewPassword";
            this.txtReNewPassword.Size = new System.Drawing.Size(156, 20);
            this.txtReNewPassword.TabIndex = 2;
            this.txtReNewPassword.UseSystemPasswordChar = true;
            this.txtReNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtReNewPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtReNewPassword_KeyUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtIDAccount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtAccountName);
            this.panel2.Location = new System.Drawing.Point(12, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 143);
            this.panel2.TabIndex = 4;
            // 
            // txtIDAccount
            // 
            this.txtIDAccount.Enabled = false;
            this.txtIDAccount.Location = new System.Drawing.Point(135, 58);
            this.txtIDAccount.Name = "txtIDAccount";
            this.txtIDAccount.Size = new System.Drawing.Size(156, 20);
            this.txtIDAccount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(103, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Tài Khoản";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(29, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(29, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên Tài Khoản";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Enabled = false;
            this.txtAccountName.Location = new System.Drawing.Point(135, 97);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(156, 20);
            this.txtAccountName.TabIndex = 1;
            // 
            // errorInfoAccount
            // 
            this.errorInfoAccount.ContainerControl = this;
            // 
            // fInfoAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Name = "fInfoAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fInfoAccount";
            this.Load += new System.EventHandler(this.fInfoAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorInfoAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtIDAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReNewPassword;
        private System.Windows.Forms.ErrorProvider errorInfoAccount;
    }
}