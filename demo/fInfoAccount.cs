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
    public partial class fInfoAccount : Form
    {
        public fInfoAccount()
        {
            InitializeComponent();
        }
        private void fInfoAccount_Load(object sender, EventArgs e)
        {
            Account = SQLAccount.ExcuteQuery("Select * from Account where IDStaff = '" + IDAccount + "'");
            txtIDAccount.Text = Account.Rows[0][4].ToString();
            txtAccountName.Text = Account.Rows[0][0].ToString();
        }
        //------------------------Khai Báo Biến------------------------//
        Connect SQLAccount = new Connect();
        DataTable Account = new DataTable();
        public string  IDAccount;
        //------------------------Hàm------------------------//
        //Kiểm tra mật khẩu
        int CheckPassword()
        {
            Account = SQLAccount.ExcuteQuery("Select * from Account where IDStaff = '" + IDAccount + "'");
            if (txtPassword.Text != Account.Rows[0][1].ToString())
                return 1;
            else if (txtNewPassword.Text != txtReNewPassword.Text)
                return 2;
            return 0;
        }
        //Nút thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Nút cập nhật
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (CheckPassword() == 0)
                {
                    DialogResult Question = MessageBox.Show("Bạn Có Muốn Thêm Khách Hàng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Question == DialogResult.Yes)
                    {
                        SQLAccount.ExcuteQuery(" update Account set [Password] = '" + txtNewPassword.Text + "' where [IDStaff] = '" + txtIDAccount.Text + "'");
                        MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo");
                    }
                }
                else if (CheckPassword() == 1)
                {
                    MessageBox.Show("Mật Khẩu Cũ Không Đúng!", "Thông báo");
                    errorInfoAccount.SetError(txtPassword, "Kiểm tra lại");
                    txtPassword.Focus();
                }

                else if (CheckPassword() == 2)
                {
                    MessageBox.Show("Kiểm Tra Lại Mật Khẩu Mới", "Thông báo");
                    errorInfoAccount.SetError(txtReNewPassword, "Kiểm tra lại");
                    txtReNewPassword.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại", "Thông Báo");
            }
        }
        //------------------------Sự kiện------------------------//
        //Lỗi khi nhập xác nhận mật khẩu không giống
        private void txtReNewPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtReNewPassword.Text == txtNewPassword.Text)
            {
                errorInfoAccount.Clear();
            }
            else
                errorInfoAccount.SetError(txtReNewPassword, "Kiểm tra lại");

        }
        //Chặn Phím Space
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) == true)
                e.Handled = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            errorInfoAccount.Clear();
        }
    }
}
