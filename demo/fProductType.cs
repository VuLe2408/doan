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
    public partial class fProductType : Form
    {
        public fProductType()
        {
            InitializeComponent();
        }
        // Form load
        private void fEditProductType_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvProductType.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            ShowProductType();
            int SIZE = dgvProductType.Columns.Count;
            for(int i = 0; i < SIZE; i++)
            {
                cbSearch.Items.Add(dgvProductType.Columns[i].HeaderText);
            }
            if (ProductType.Rows.Count >= 1)
            {
                ShowInTextBox(0, ProductType);
                
            }
            cbSearch.SelectedIndex = 0;
        }
        //------------------------Khai Báo Biến------------------------//
        Connect ConnectSQL = new Connect();
        DataTable ProductType = new DataTable();
        DataTable Product = new DataTable();
        //------------------------Hàm------------------------//
        //Kết nối sql + hiện datagridview
        void ConnectSql(string query, DataGridView dgv)
        {
            ProductType = ConnectSQL.ExcuteQuery(query);
            dgv.DataSource = ProductType;
        }
        // Danh sách loại sản phẩm
        void ShowProductType()
        {
            String query = "select * from producttype";
            ConnectSql(query, dgvProductType);

        }
        // Hiện ở text box khi chọn
        void ShowInTextBox(int vt, DataTable ds)
        {         
            txtIDProductType.Text = ds.Rows[vt][0].ToString();
            txtProductTypeName.Text = ds.Rows[vt][1].ToString();         
        }
        // Tìm kiếm loại sản phẩm
        void SearchProducType()
        {
          
            if(cbSearch.SelectedIndex == 0)
            {
                string query = "select * from ProductType where IDProductType LIKE '%" + txtSearch.Text + "%'";
                ConnectSql(query, dgvProductType);
            }
            else
            {
                string query = "select * from ProductType where ProductTypeName LIKE N'%" + txtSearch.Text + "%'";
                ConnectSql(query, dgvProductType);
            }    
            
        }
        //kiểm tra ID loại sản phẩm
        bool CheckIDPro(string Text)
        {
            Product = ConnectSQL.ExcuteQuery("select [IDProductType] from Product");
            int SizePro = Product.Rows.Count;
            for (int i = 0; i < SizePro; i++)
            {
                if (Text == Product.Rows[i][0].ToString())
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        //Xoá loại sản phẩm
        void DeleteProductType()
        {
            int SIZE = ProductType.Rows.Count;
            string query = "delete from ProductType where [IDProductType] = '"+txtIDProductType.Text+"'";

            if (CheckIDPro(txtIDProductType.Text))
            {
                MessageBox.Show("Còn Sản Phẩm Loại Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorProductType.SetError(txtIDProductType, "Nhập giá trị");
                txtIDProductType.Focus();
            }
            else
            {
                DialogResult Question = MessageBox.Show("Bạn Có Muốn Xoá Loại Sản Phẩm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Question == DialogResult.Yes)
                {
                    ConnectSQL.ExcuteQuery(query);
                    ShowProductType();
                    ShowInTextBox(0, ProductType);
                }
                int SIZE2 = ProductType.Rows.Count;
                if (SIZE != SIZE2)
                {
                    MessageBox.Show("Xoá Loại Sản Phẩm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xoá Loại Sản Phẩm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        // cập nhật loại sản phẩm
        void UpdateProductType()
        {
            if (!CheckID())
            {
                MessageBox.Show("Kiểm Tra Lại ID", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorProductType.SetError(txtIDProductType, "Nhập giá trị");
                txtIDProductType.Focus();
            }
            else
            {
                string query = "update ProductType set  [ProductTypeName] = N'" + txtProductTypeName.Text + "' where [IDProductType] = '" + txtIDProductType.Text + "'";
                DialogResult Question = MessageBox.Show("Bạn Có Muốn Cập Nhật Sản Phẩm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Question == DialogResult.Yes)
                {
                    ConnectSQL.ExcuteQuery(query);
                    ShowProductType();
                    ShowInTextBox(0, ProductType);

                }
                if (ConnectSQL.ExcuteNonQuery(query) > 0)
                {
                    MessageBox.Show("Cập Nhật Sản Phẩm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập Nhật Sản Phẩm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        // Kiểm tra id trùng
        bool CheckID()
        {
            bool Flag = false;
            int SIZE = ProductType.Rows.Count;
            for (int i = 0; i < SIZE; i++)
            {
                if (txtIDProductType.Text == ProductType.Rows[i][0].ToString())
                {
                    Flag = true;
                    break;
                }
            }
            return Flag;

        }
        //Thêm loại sản phẩm
        void AddProductType()
        {
            int SIZE = ProductType.Rows.Count;
            string query = "INSERT INTO ProductType ([IDProductType], [ProductTypeName] ) VALUES('"+txtIDProductType.Text+"', N'"+txtProductTypeName.Text+"')";
            if (CheckID())
            {
                MessageBox.Show("ID Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorProductType.SetError(txtIDProductType, "Nhập giá trị");
                txtIDProductType.Focus();
            }
            else
            {
                DialogResult Question = MessageBox.Show("Bạn Có Muốn Thêm Loại Sản Phẩm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Question == DialogResult.Yes)
                {
                    ConnectSQL.ExcuteQuery(query);
                }
                ShowProductType();
                ShowInTextBox(0, ProductType);

                int SIZE2 = ProductType.Rows.Count;
                if (SIZE != SIZE2)
                {
                    MessageBox.Show("Thêm Loại Sản Phẩm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm Loại Sản Phẩm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //------------------------Nút------------------------//



        //------------------------Sự kiện------------------------//
        //Lây vị trí khi click vào dgv
        private void dgvProductType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            int SIZE = ProductType.Rows.Count;
            if (vt >= 0 && vt != SIZE)
                ShowInTextBox(vt, ProductType);
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            errorProductType.Clear();
            SearchProducType();
        }

        private void txtProductTypeName_TextChanged(object sender, EventArgs e)
        {
            errorProductType.Clear();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                errorProductType.Clear();
                if (string.IsNullOrEmpty(txtIDProductType.Text))
                {
                    errorProductType.SetError(txtIDProductType, "Nhập giá trị");
                    txtIDProductType.Focus();
                }
                else if (string.IsNullOrEmpty(txtProductTypeName.Text))
                {
                    errorProductType.SetError(txtProductTypeName, "Nhập giá trị");
                    txtProductTypeName.Focus();
                }
                else
                {
                    AddProductType();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!", "Thông Báo");
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                errorProductType.Clear();
                if (!CheckID())
                {
                    MessageBox.Show("Kiểm Tra Lại ID", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    errorProductType.SetError(txtIDProductType, "Nhập giá trị");
                    txtIDProductType.Focus();
                }
                else
                {
                    DeleteProductType();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!", "Thông Báo");
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                errorProductType.Clear();
                if (string.IsNullOrEmpty(txtProductTypeName.Text))
                {
                    errorProductType.SetError(txtProductTypeName, "Nhập giá trị");
                    txtProductTypeName.Focus();
                }
                else
                {
                    UpdateProductType();
                }

            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!", "Thông Báo");
            }
        }

        private void txtIDProductType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }
    }
}
