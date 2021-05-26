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
    public partial class fSize : Form
    {
        public fSize()
        {
            InitializeComponent();
        }
        Connect ConnectSQL = new Connect();
        DataTable SizePro = new DataTable();
        void ShowSize()
        {
           SizePro = ConnectSQL.ExcuteQuery("select * from Size");
           dgvSize.DataSource = SizePro;

        }
        void ConnectSql(string query, DataGridView dgv)
        {
            SizePro = ConnectSQL.ExcuteQuery(query);
            dgv.DataSource = SizePro;
        }
        private void fSize_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvSize.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            cbSearch.Items.Add(dgvSize.Columns[0].HeaderText);
            cbSearch.Items.Add(dgvSize.Columns[1].HeaderText);
            cbSearch.Items.Add(dgvSize.Columns[2].HeaderText);
            cbSearch.SelectedIndex = 0;
            ShowSize();
            ShowInTextBox(0);
        }
        void ShowInTextBox(int vt)
        {
            txtSize.Text = SizePro.Rows[vt][0].ToString();
            txtWidth.Text = SizePro.Rows[vt][1].ToString();
            txtHeight.Text = SizePro.Rows[vt][2].ToString();

        }

        private void dgvSize_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            int SIZE = SizePro.Rows.Count;
            if (vt >= 0 && vt != SIZE)
            {
                ShowInTextBox(vt);
            }
        }
        bool CheckID()
        {
            int SIZE = SizePro.Rows.Count;
            for (int i = 0; i < SIZE; i++)
            {
                if (txtSize.Text == SizePro.Rows[i][0].ToString())
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        int CheckNull()
        {
            if (string.IsNullOrEmpty(txtSize.Text))
            {
                errorSize.SetError(txtSize, "Nhập giá trị");
                return 0;
            }
            else if (string.IsNullOrEmpty(txtWidth.Text))
            {
                errorSize.SetError(txtWidth, "Nhập giá trị");
                return 1;
            }
            else if (string.IsNullOrEmpty(txtHeight.Text))
            {
                errorSize.SetError(txtHeight, "Nhập giá trị");
                return 2;
            }
            return -1;
        }
        bool CheckIDUpdate()
        {
            DataTable ProductDetail = new DataTable();
            ProductDetail = ConnectSQL.ExcuteQuery("Select * from ProductDetail");
            int SIZE = ProductDetail.Rows.Count;
            for (int i = 0; i < SIZE; i++)
            {
                if (txtSize.Text == ProductDetail.Rows[i][3].ToString())
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        void Search()
        {
            try
            {

                string query = "";
                for (int i = 0; i < SizePro.Columns.Count; i++)
                {
                    if (cbSearch.SelectedIndex == i)
                    {
                        query = "select * from Size where " + SizePro.Columns[i].ColumnName + " LIKE N'%" + txtSearch.Text + "%'";
                    }
                }
                ConnectSql(query, dgvSize);
            }
            catch
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại", "Thông Báo");
            }
        }
        void Searchbtn()
        {
            try
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    string query = "";
                    for (int i = 0; i < SizePro.Columns.Count; i++)
                    {
                        if (cbSearch.SelectedIndex == i)
                        {
                            query = "select * from Size where " + SizePro.Columns[i].ColumnName + " between '" + txtFrom.Text + "' and '" + txtTo.Text + "'";
                        }
                    }
                    ConnectSql(query, dgvSize);
                }
                else
                    Search();
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

                int SIZE = SizePro.Rows.Count;
                string query = "insert into Size([IDSize], [Width], [Height]) values('" + txtSize.Text + "', '" + txtWidth.Text + "', '" + txtHeight.Text + "')";

                if (CheckNull() == -1 && !CheckID())
                {
                    DialogResult Question = MessageBox.Show("Bạn Có Muốn Thêm Kích Thước", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Question == DialogResult.Yes)
                    {
                        ConnectSQL.ExcuteQuery(query);
                        ShowSize();
                        ShowInTextBox(0);
                        int SIZE2 = SizePro.Rows.Count;
                        if (SIZE != SIZE2)
                        {
                            MessageBox.Show("Thêm Kích Thước Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Thêm Kích Thước Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        errorSize.Clear();
                    }
                    
                }
                else if (CheckNull() == 0)
                    txtSize.Focus();
                else if (CheckNull() == 1)
                    txtWidth.Focus();
                else if (CheckNull() == 2)
                    txtHeight.Focus();
                else if (CheckID())
                {
                    MessageBox.Show("Kich thước đã tồn tại!", "Thông Báo");
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

                if (!CheckID())
                {
                    MessageBox.Show("Kiểm tra lại kích thước", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSize.Focus();
                    errorSize.SetError(txtSize, "Nhập lại giá trị");
                }
                else
                {

                    int SIZE = SizePro.Rows.Count;
                    string query = "delete from SIZE where IDSize = '" + txtSize.Text + "'";
                    DialogResult Question = MessageBox.Show("Bạn Có Muốn Xoá Kích Thước", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Question == DialogResult.Yes)
                    {
                        ConnectSQL.ExcuteQuery(query);
                        ShowSize();
                        ShowInTextBox(0);
                        int SIZE2 = SizePro.Rows.Count;
                        if (SIZE != SIZE2)

                            MessageBox.Show("Xoá Kích Thước Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Xoá Kích Thước Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorSize.Clear();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Còn sản phẩm kích thước này!", "Thông Báo");
            }
        }
        void Update()
        {
            try
            {

                string query = "UPDATE Size SET Width = '" + txtWidth.Text + "', Height = '" + txtHeight.Text + "'  WHERE IDSize = '" + txtSize.Text + "'";
                if (CheckIDUpdate())
                {
                    MessageBox.Show("Còn sản phẩm kích thước này!", "Thông Báo");
                }
                else if (CheckID() && CheckNull() == -1 && !CheckIDUpdate())
                {
                    DialogResult Question = MessageBox.Show("Bạn Có Muốn Cập Nhật Kích Thước", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Question == DialogResult.Yes)
                    {
                        ConnectSQL.ExcuteQuery(query);
                        ShowSize();
                        ShowInTextBox(0);
                        if (ConnectSQL.ExcuteNonQuery(query) > 0)
                        {
                            MessageBox.Show("Cập Nhật Kích Thước Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cập Nhật Kích Thước Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        errorSize.Clear();
                    }
                }
                else if (CheckNull() == 0)
                    txtSize.Focus();
                else if (CheckNull() == 1)
                    txtWidth.Focus();
                else if (CheckNull() == 1)
                    txtHeight.Focus();
                else if (!CheckID())
                {
                    MessageBox.Show("Kiểm tra lại kích thước", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSize.Focus();
                    errorSize.SetError(txtSize, "Nhập lại giá trị");
                }
            }
            catch
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại", "Thông Báo");
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
            errorSize.Clear();
            Add();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            errorSize.Clear();
            Delete();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            errorSize.Clear();
            Update();
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {
            errorSize.Clear();
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            errorSize.Clear();
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            errorSize.Clear();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            Search();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Searchbtn();
        }

        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
    }
}
