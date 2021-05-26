
namespace demo
{
    partial class fRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDStaff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblfLogIn = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.errorRegister = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(19, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIDStaff
            // 
            this.txtIDStaff.Location = new System.Drawing.Point(148, 71);
            this.txtIDStaff.MaxLength = 20;
            this.txtIDStaff.Name = "txtIDStaff";
            this.txtIDStaff.Size = new System.Drawing.Size(219, 20);
            this.txtIDStaff.TabIndex = 1;
            this.txtIDStaff.TextChanged += new System.EventHandler(this.txtIDStaff_TextChanged);
            this.txtIDStaff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDStaff_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Nhân Viên:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(148, 114);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(219, 20);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtIDStaff_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(148, 234);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(219, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtIDStaff_TextChanged);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(19, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập lại mật khẩu:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(148, 274);
            this.txtRePassword.MaxLength = 20;
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(219, 20);
            this.txtRePassword.TabIndex = 6;
            this.txtRePassword.UseSystemPasswordChar = true;
            this.txtRePassword.TextChanged += new System.EventHandler(this.txtIDStaff_TextChanged);
            this.txtRePassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRePassword_KeyPress);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(148, 155);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtIDStaff_TextChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Location = new System.Drawing.Point(200, 343);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblfLogIn
            // 
            this.lblfLogIn.Location = new System.Drawing.Point(69, 383);
            this.lblfLogIn.Name = "lblfLogIn";
            this.lblfLogIn.Size = new System.Drawing.Size(298, 23);
            this.lblfLogIn.TabIndex = 8;
            this.lblfLogIn.Text = "Bạn đã có tài khoản? Đăng nhập tại đây.";
            this.lblfLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblfLogIn.Click += new System.EventHandler(this.lblfLogIn_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(19, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số điện thoại:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(148, 194);
            this.txtPhoneNum.MaxLength = 10;
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(219, 20);
            this.txtPhoneNum.TabIndex = 4;
            this.txtPhoneNum.TextChanged += new System.EventHandler(this.txtIDStaff_TextChanged);
            this.txtPhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNum_KeyPress);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(19, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Chức vụ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(148, 27);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(219, 21);
            this.cbStatus.TabIndex = 0;
            // 
            // errorRegister
            // 
            this.errorRegister.ContainerControl = this;
            // 
            // fRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(425, 435);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblfLogIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDStaff);
            this.Controls.Add(this.label1);
            this.Name = "fRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            this.Load += new System.EventHandler(this.fRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblfLogIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ErrorProvider errorRegister;
    }
}