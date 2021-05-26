using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        //Form load
        private void fLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
            pbShowPassword.Visible = false;
        }
        //------------------------Khai Báo Biến------------------------//
        // Tạo lớp + datable
        Connect ConnectSQL = new Connect();
        DataTable Account = new DataTable();
        //------------------------Hàm------------------------//
        //Bắt lỗi Username
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                txtUserName.Focus();
                error.SetError(txtUserName, "Nhập giá trị");
            }
            else
                error.Clear();
        }
        //Kiểm tra thông tin tài khoản    
        bool CheckAccount()
        {
            bool Flag = false;
            string query = "select [UserName], [Password], [IDStaff] from Account";
            Account = ConnectSQL.ExcuteQuery(query);
            int Size = Account.Rows.Count;
            for(int i = 0; i<Size;i++)
            {
                if (txtUserName.Text == Account.Rows[i][2].ToString() && txtPassword.Text == Account.Rows[i][1].ToString())
                {
                    Flag = true;
                    break;
                }
                else
                    Flag = false;
            }    
            return Flag;
        }
        //------------------------Sự Kiện------------------------//
        //Ẩn hình eyes
        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            pbShowPassword.Visible = true;
        }
        //Viết hoa
        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }
        // Hiện mật khẩu
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            
            txtPassword.UseSystemPasswordChar = false;
        }
        //Ẩn mật khẩu
        private void pbShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
        //------------------------Nút------------------------//
        //Nút đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckAccount())
            {
                Account = ConnectSQL.ExcuteQuery("Update Account set Status = '1' where IDStaff = '" + txtUserName.Text + "'");
                txtUserName.Text = "";
                txtPassword.Text = "";
                this.Hide();
                fHomePage fHP = new fHomePage();
                fHP.ReturnIDAccount = txtUserName.Text;
                fHP.ShowDialog();
                this.Close();
                
            }
            else
            {

                MessageBox.Show("Tài khoản hoặc mật khẩu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
            }
        }    
        //Nút đăng ký
        private void btnRegister_Click(object sender, EventArgs e)
        {
            error.Clear();
            this.Hide();
            Form fRegis = new fRegister();          
            fRegis.ShowDialog();
            this.Close();
           
        }
    }
}
