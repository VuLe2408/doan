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
    public partial class fStaff : Form
    {
        public fStaff()
        {
            InitializeComponent();
        }
        Connect ConnectSQL = new Connect();
        DataTable Staff = new DataTable();

        //Kết nối query và dgv với sql
        void ConnectSql(string query, DataGridView dgv)
        {
            Staff = ConnectSQL.ExcuteQuery(query);
            dgv.DataSource = Staff;
        }
        // Danh sách nhân viên
        void ShowStaff()
        {
            String query = "select * from Staff";
            ConnectSql(query, dgvStaff);

        }
        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            int SIZE = Staff.Rows.Count;
            if (vt >= 0 && vt != SIZE)
                ShowInTextBox(vt, Staff);
        }
        //Load danh sách nhân viên + combobox
        private void fStaff_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvStaff.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            cbStatus.Items.Add("Gám đốc");
            cbStatus.Items.Add("Nhân viên bán hàng");
            cbStatus.Items.Add("Kế toán");
            cbStatus.Items.Add("Lễ tân");
            cbStatus.Items.Add("Bảo vệ");
            for(int i = 0; i < dgvStaff.Columns.Count;i++)
            {
                cbSearch.Items.Add(dgvStaff.Columns[i].HeaderText);
            }
            cbSearch.SelectedIndex = 0;
            ShowStaff();
            ShowInTextBox(0, Staff);

        }
        //Hiện dữ liệu khi nhấn vào dgv
        void ShowInTextBox(int vt, DataTable ds)
        {
            
            txtIDStaff.Text = ds.Rows[vt][0].ToString();
            txtStaffName.Text = ds.Rows[vt][1].ToString();
            txtSalary.Text = ds.Rows[vt][2].ToString();
            txtPhoneNum.Text = ds.Rows[vt][3].ToString();
            txtEmail.Text = ds.Rows[vt][4].ToString();
            txtAddress.Text = ds.Rows[vt][5].ToString();
            for (int i = 0; i < 5; i++)
            {
                if (ds.Rows[vt][6].ToString() == i.ToString())
                {
                    cbStatus.SelectedIndex = i;
                }
            }
        }

        //Kiểm tra trức khi cập nhật
        int CheckUpdate()
        {
            int Icheck = 0;
            int SIZE = Staff.Rows.Count;
            DataTable EmailPhone = new DataTable();
            EmailPhone = ConnectSQL.ExcuteQuery("Select Email, PhoneNum from Staff where IDStaff = '"+txtIDStaff.Text+"'");
            for (int i = 0; i < SIZE; i++)
            {

                if (txtEmail.Text == Staff.Rows[i][4].ToString())
                {
                    if (txtEmail.Text == EmailPhone.Rows[0][0].ToString())
                    {
                        continue;
                    }
                    Icheck = 1;
                }
                else if (txtPhoneNum.Text == Staff.Rows[i][3].ToString())
                {
                    if (txtPhoneNum.Text == EmailPhone.Rows[0][1].ToString())
                    {
                        continue;
                    }
                    Icheck = 2;
                }

            }

            return Icheck;
        }
        int CheckNull()
        {
            if (string.IsNullOrEmpty(txtStaffName.Text))
            {
                errorStaff.SetError(txtStaffName, "Nhập giá trị");
                return 0;
            }
            else if (string.IsNullOrEmpty(txtSalary.Text))
            {
                errorStaff.SetError(txtSalary, "Nhập giá trị");
                return 1;
            }
            else if (string.IsNullOrEmpty(txtPhoneNum.Text))
            {
                errorStaff.SetError(txtPhoneNum, "Nhập giá trị");
                return 2;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorStaff.SetError(txtEmail, "Nhập giá trị");
                return 3;
            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                errorStaff.SetError(txtAddress, "Nhập giá trị");
                return 4;
            }
            return -1;
        }
        //Kiểm tra ID nhập vào có trùng không
        bool CheckID()
        {
            Staff = ConnectSQL.ExcuteQuery("SELECT * FROM Staff");
            int SIZE = Staff.Rows.Count;
            for (int i = 0; i < SIZE; i++)
            {
                if (txtIDStaff.Text == Staff.Rows[i][0].ToString())
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        //Kiểm tra trước khi thêm
        int CheckAdd()
        {
            int Icheck = 0;          
            int SIZE = Staff.Rows.Count;
            
            for (int i = 0; i < SIZE; i++)
            {
                if (txtIDStaff.Text == Staff.Rows[i][0].ToString())
                {                   
                    Icheck = 1;
                    break;
                }
                else if (txtPhoneNum.Text == Staff.Rows[i][3].ToString())
                {
                    
                    Icheck = 3;
                    break;
                }
                else if (txtEmail.Text == Staff.Rows[i][4].ToString())
                {                       
                    Icheck = 2;
                    break;
                }
            }

            return Icheck;
        }
        //Tìm kiếm nhân viên
        void SearchStaff()
        {
            string query = "";
            for (int i = 0; i < Staff.Columns.Count; i++)
            {
                if (cbSearch.SelectedIndex == 0)
                {
                    query = "select * from Staff where IDStaff LIKE '%" + txtSearch.Text + "%'";
                }
                else if (cbSearch.SelectedIndex == 1)
                {
                    query = "select * from Staff where StaffName LIKE N'%" + txtSearch.Text + "%'";
                }
                else if (cbSearch.SelectedIndex == 2)
                {
                    query = "select * from Staff where Salary between '" + txtFrom.Text + "' and '" + txtTo.Text + "'";

                }
                else if (cbSearch.SelectedIndex == 3)
                {
                    query = "select * from Staff where PhoneNum LIKE N'%" + txtSearch.Text + "%'";
                }
                else if (cbSearch.SelectedIndex == 4)
                {
                    query = "select * from Staff where Email LIKE N'%" + txtSearch.Text + "%'";

                }
                else if (cbSearch.SelectedIndex == 5)
                {
                    query = "select * from Staff where Address LIKE N'%" + txtSearch.Text + "%'";
                }
                else if (cbSearch.SelectedIndex == 6)
                {
                    query = "select * from Staff where Status between '" + txtFrom.Text + "' and '" + txtTo.Text + "'";

                }
                ConnectSql(query, dgvStaff);
            }
        }
        //Nhập Lại
        private void RefreshTextBox()
        {
            txtIDStaff.Text = "";
            txtStaffName.Text = "";
            txtSalary.Text = "";
            txtPhoneNum.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            cbStatus.SelectedIndex = 0;
            txtIDStaff.Focus();
        }
        //Thêm nhân viên mới
        void AddStaff()
        {

            int SIZE = Staff.Rows.Count;
            string query = "INSERT INTO Staff (IDStaff, StaffName, Salary, PhoneNum, Email, Address, Status) VALUES ('" + txtIDStaff.Text + "', N'" + txtStaffName.Text + "', '" + txtSalary.Text + "', '" + txtPhoneNum.Text + "', '" + txtEmail.Text + "', N'" + txtAddress.Text + "', '" + cbStatus.SelectedIndex + "')";
            
                ConnectSQL.ExcuteQuery(query);
                ShowStaff();

                int SIZE2 = Staff.Rows.Count;
                if (SIZE != SIZE2)
                {
                    MessageBox.Show("Thêm Nhân Viên Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
        // Xoá nhân viên
        void DeleteStaff()
        {
            if (!CheckID())
            {
                MessageBox.Show("Kiểm tra lại ID", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDStaff.Focus();
                errorStaff.SetError(txtIDStaff, "Nhập lại giá trị");
            }
            else
            {

                int SIZE = Staff.Rows.Count;
                fHomePage fHP = new fHomePage();
                if (txtIDStaff.Text == fHP.ReturnIDAccount)
                {

                    MessageBox.Show("Tài Khoản Đang Hoạt Động", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult Question = MessageBox.Show("Bạn Có Muốn Xoá Nhân Viên", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Question == DialogResult.Yes)
                    {
                        ConnectSQL.ExcuteQuery("delete from Staff where IDStaff = '" + txtIDStaff.Text + "'");
                        ConnectSQL.ExcuteQuery("delete from Account where IDStaff = '" + txtIDStaff.Text + "'");
                        ShowStaff();
                    }

                    int SIZE2 = Staff.Rows.Count;
                    if (SIZE != SIZE2)
                    {
                        MessageBox.Show("Xoá Nhân Viên Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Xoá Nhân Viên Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }
        // Chỉnh sửa thông tin nhân viên
        void UpdateStaff()
        {
            if (!CheckID())
            {
                MessageBox.Show("Kiểm tra lại ID", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDStaff.Focus();
                errorStaff.SetError(txtIDStaff, "Nhập lại giá trị");
            }
            else
            {
                  
                if (CheckUpdate() == 1)
                    MessageBox.Show("Email Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (CheckUpdate() == 2)
                    MessageBox.Show("SĐT Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    string query = "update Staff set [StaffName] = N'" + txtStaffName.Text + "',[Salary] = '" + txtSalary.Text + "', [PhoneNum] = '" + txtPhoneNum.Text + "', [Email] = '" + txtEmail.Text + "', [Address] = N'" + txtAddress.Text + "', [Status] = '" + cbStatus.SelectedIndex + "' where[IDStaff] = '" + txtIDStaff.Text + "'";
                    DialogResult Question = MessageBox.Show("Bạn Có Muốn Cập Nhật Nhân Viên", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Question == DialogResult.Yes)
                    {
                        ConnectSQL.ExcuteQuery("Update Account set [UserName] = '" + txtStaffName.Text + "', [PhoneNum] = '" + txtPhoneNum.Text + "', [Email] = '" + txtEmail.Text + "' where [IDStaff] = '" + txtIDStaff.Text + "'");
                        if (cbStatus.SelectedIndex > 2)
                        {
                            ConnectSQL.ExcuteQuery("delete from Account where IDStaff = '" + txtIDStaff.Text + "'");
                        }
                        ConnectSQL.ExcuteQuery(query);
                    }
                    ShowStaff();
                    if (ConnectSQL.ExcuteNonQuery(query) > 0)
                    {
                        MessageBox.Show("Cập Nhật Thông Tin Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập Nhật Thông Tin Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }


        }


        private void btnRefreshText_Click(object sender, EventArgs e)
        {

            errorStaff.Clear();
            RefreshTextBox();

        }
        private void btnReload_Click(object sender, EventArgs e)
        {

            errorStaff.Clear();
            ShowStaff();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIDStaff_TextChanged(object sender, EventArgs e)
        {
            if (txtIDStaff.Text == "")
            {
                btnDeleteStaff.Enabled = false;
                btnAddStaff.Enabled = false;
                btnUpdateStaff.Enabled = false;
            }
            else
            {
                errorStaff.Clear();
                btnDeleteStaff.Enabled = true;
                btnAddStaff.Enabled = true;
                btnUpdateStaff.Enabled = true;
            }
        }
        
        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearch.SelectedIndex == 2 || cbSearch.SelectedIndex == 6)
            {
                txtSearch.Enabled = false;
                pValues.Visible = true;
                txtFrom.Focus();
            }
            else
            {
                txtSearch.Enabled = true;
                pValues.Visible = false;
            }
            txtSearch.Text = "";
            txtFrom.Text = "";
            txtTo.Text = "";
            txtSearch.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            errorStaff.Clear();
            SearchStaff();
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbSearch.SelectedIndex == 3)
            {
                if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                    e.Handled = true;
            }    
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            errorStaff.Clear();
            DeleteStaff();
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            errorStaff.Clear();
            if (CheckNull() == 0)
                txtStaffName.Focus();
            else if (CheckNull() == 1)
                txtSalary.Focus();
            else if (CheckNull() == 2)
                txtPhoneNum.Focus();
            else if (CheckNull() == 3)
                txtEmail.Focus();
            else if (CheckNull() == 4)
                txtAddress.Focus();
            else
            {                
                UpdateStaff();

            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            errorStaff.Clear();
            if (CheckNull() == 0)
                txtStaffName.Focus();
            else if (CheckNull() == 1)
                txtSalary.Focus();
            else if (CheckNull() == 2)
                txtPhoneNum.Focus();
            else if (CheckNull() == 3)
                txtEmail.Focus();
            else if (CheckNull() == 4)
                txtAddress.Focus();
            else
            {
                if (CheckAdd() == 1)
                {
                    MessageBox.Show("ID Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDStaff.Focus();
                    errorStaff.SetError(txtIDStaff, "Nhập lại giá trị");
                }
                else if (CheckAdd() == 3)
                {
                    MessageBox.Show("SĐT Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPhoneNum.Focus();
                    errorStaff.SetError(txtPhoneNum, "Nhập lại giá trị");
                }
                else if (CheckAdd() == 2)
                {
                    MessageBox.Show("Email Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmail.Focus();
                    errorStaff.SetError(txtEmail, "Nhập lại giá trị");
                }
                else
                {
                    DialogResult Question = MessageBox.Show("Bạn Có Muốn Thêm Nhân Viên", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Question == DialogResult.Yes)
                    {

                        AddStaff();
                    }
                }
            }
        }

        private void txtStaffName_TextChanged(object sender, EventArgs e)
        {
            if (txtStaffName.Text != "")
            {
                errorStaff.Clear();
            }
            if (txtSalary.Text != "")
            {
                errorStaff.Clear();
            }
            if (txtPhoneNum.Text != "")
            {
                errorStaff.Clear();
            }
            if (txtEmail.Text != "")
            {
                errorStaff.Clear();
            }
            if (txtAddress.Text != "")
            {
                errorStaff.Clear();
            }
        }

        private void txtIDStaff_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }
    }

}
