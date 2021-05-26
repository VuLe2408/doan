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
    public partial class fColor : Form
    {
        public fColor()
        {
            InitializeComponent();
        }
        Connect ConnectSQL = new Connect();
        DataTable Colors = new DataTable();
        
        private void fColor_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvColor.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            cbSearch.Items.Add(dgvColor.Columns[0].HeaderText);
            cbSearch.Items.Add(dgvColor.Columns[1].HeaderText);
            cbSearch.SelectedIndex = 0;
            ShowColor();           
            ShowInTextBox(0);
        }
        //------------------------Hàm------------------------//
        //Kết Nối SQL
        void ConnectSql(string query, DataGridView dgv)
        {
            Colors = ConnectSQL.ExcuteQuery(query);
            dgv.DataSource = Colors;
        }
        void ShowColor()
        {
            string query = "Select * from Color";
            ConnectSql(query, dgvColor);
        }
        void ShowInTextBox(int vt)
        {
            txtIDColor.Text = Colors.Rows[vt][0].ToString();
            txtColorName.Text = Colors.Rows[vt][1].ToString();
        }       
        private void dgvColor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int SIZE = Colors.Rows.Count;
            int vt = e.RowIndex;
            if (vt >= 0 && vt != SIZE)
            {
                ShowInTextBox(vt);
            }
        }
        bool CheckID()
        {
            int SIZE = Colors.Rows.Count;
            for (int i = 0; i < SIZE; i++)
            {
                if (txtIDColor.Text == Colors.Rows[i][0].ToString()|| txtColorName.Text == Colors.Rows[i][1].ToString())
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        bool CheckIDDel()
        {
            int SIZE = Colors.Rows.Count;
            for (int i = 0; i < SIZE; i++)
            {
                if (txtIDColor.Text == Colors.Rows[i][0].ToString())
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        //Kiểm Tra Không Nhập Dữ Liệu
        int CheckNull()
        {
            if (string.IsNullOrEmpty(txtIDColor.Text))
            {
                errorColor.SetError(txtIDColor, "Nhập giá trị");
                return 0;
            }
            else if (string.IsNullOrEmpty(txtColorName.Text))
            {
                errorColor.SetError(txtColorName, "Nhập giá trị");
                return 1;
            }
            return -1;
        }
        void Search()
        {
            try
            {

                string query = "";
                for (int i = 0; i < Colors.Columns.Count; i++)
                {
                    if (cbSearch.SelectedIndex == i)
                    {
                        query = "select * from Color where " + Colors.Columns[i].ColumnName + " LIKE N'%" + txtSearch.Text + "%'";
                    }
                }
                ConnectSql(query, dgvColor);
            }
            catch
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại", "Thông Báo");
            }
        }
        void Add()
        {
            try
            {

                int SIZE = Colors.Rows.Count;
                string query = "insert into color([IDColor], [ColorName]) values('" + txtIDColor.Text + "', N'" + txtColorName.Text + "')";

                if (CheckNull() == -1 && !CheckID())
                {
                    DialogResult Question = MessageBox.Show("Bạn Có Thêm Muốn Màu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Question == DialogResult.Yes)
                    {
                        ConnectSQL.ExcuteQuery(query);
                        ShowColor();
                        ShowInTextBox(0);
                        int SIZE2 = Colors.Rows.Count;
                        if (SIZE != SIZE2)
                        {
                            MessageBox.Show("Thêm Màu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Thêm Màu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        errorColor.Clear();
                    }
                    
                }
                else if (CheckNull() == 0)
                    txtIDColor.Focus();
                else if (CheckNull() == 1)
                    txtColorName.Focus();
                else if (CheckID())
                {
                    MessageBox.Show("Màu đã tồn tại!", "Thông Báo");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!", "Thông Báo");
            }
        }
        void Delete()
        {
            try
            {

                if (!CheckIDDel())
                {
                    MessageBox.Show("Kiểm tra lại mã màu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDColor.Focus();
                    errorColor.SetError(txtIDColor, "Nhập lại giá trị");
                }
                else
                {

                    int SIZE = Colors.Rows.Count;
                    string query = "delete from color where IDColor = '" + txtIDColor.Text + "'";
                    DialogResult Question = MessageBox.Show("Bạn Có Muốn Xoá Màu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Question == DialogResult.Yes)
                    {
                        ConnectSQL.ExcuteQuery(query);
                        ShowColor();
                        ShowInTextBox(0);
                        int SIZE2 = Colors.Rows.Count;
                        if (SIZE != SIZE2)

                            MessageBox.Show("Xoá Màu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Xoá Màu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorColor.Clear();
                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("Còn sản phẩm màu này!", "Thông Báo");
            }

        }
    
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            fProduct fProduct = new fProduct();
            fProduct.ShowDialog();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorColor.Clear();
            Add();
        }

        private void txtIDColor_TextChanged(object sender, EventArgs e)
        {
            errorColor.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            errorColor.Clear();
            Delete();
        }

        private void txtIDColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            errorColor.Clear();
            Update();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            Search();
        }

        private void txtColorName_KeyUp(object sender, KeyEventArgs e)
        {
            ChangeFromColorNameToHex ColorChange = new ChangeFromColorNameToHex();
            txtIDColor.Text = ColorChange.Change(txtColorName.Text);
        }

    }
}
