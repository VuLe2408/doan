using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace demo
{
    public partial class fProduct : Form
    {
        public fProduct()
        {
            InitializeComponent();
        }
        // Load danh sách sản phẩm + combobox
        //------------------------Khai Báo Biến------------------------//
        Connect ConnectSQL = new Connect();
        DataTable Product = new DataTable();
        DataTable ProductType = new DataTable();
        DataTable Customer = new DataTable();
        DataTable ProductDetail = new DataTable();
        DataTable Color = new DataTable();
        DataTable Size = new DataTable();
        int LocationClickProduct = 0;
        //Kết nối query và dgv với sql

        // Danh sách sản phẩm
        void ShowProduct()
        {
            Product = ConnectSQL.ExcuteQuery("select * from Product");
            dgvProduct.DataSource = Product;
        }
        public void ConnectColorSize()
        {
            Color = ConnectSQL.ExcuteQuery("Select * from Color");
            Size = ConnectSQL.ExcuteQuery("Select * from Size");
        }
        void ShowProductDetail(int vt)
        {
            ProductDetail = ConnectSQL.ExcuteQuery("Select * from ProductDetail where IDProduct = '" + Product.Rows[vt][0] + "'");
            dgvProductDetail.DataSource = ProductDetail;
        }
        private void fEditProduct_Load(object sender, EventArgs e)
        {

            foreach (DataGridViewColumn column in dgvProduct.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn column in dgvProductDetail.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            ConnectColorSize();
            DataTable TypeName = new DataTable();
            TypeName = ConnectSQL.ExcuteQuery("Select ProductTypeName from ProductType");
            Customer = ConnectSQL.ExcuteQuery("Select * from Customer where CustomerType = N'Nhà Cung Cấp'");
            int SizeNum = Size.Rows.Count;
            int ColorNum = Color.Rows.Count;
            flp1.Controls.Clear();
            flp2.Controls.Clear();
            for (int i = 0; i < SizeNum; i++)
            {
                CheckBox cSize = new CheckBox();
                cSize.Text = Size.Rows[i][0].ToString();
                cSize.Name = "ckb" + cSize.Text;
                cSize.Width = 38;
                cSize.Height = 17;
                flp1.Controls.Add(cSize);
            }
            for (int i = 0; i < ColorNum; i++)
            {
                CheckBox cColor = new CheckBox();
                cColor.Text = Color.Rows[i][1].ToString();
                cColor.Name = "ckb" + cColor.Text;
                cColor.Width = 80;
                cColor.Height = 17;
                flp2.Controls.Add(cColor);
            }
            ShowProduct();
            for (int i = 0; i < TypeName.Rows.Count; i++)
            {
                cbProductType.Items.Add(TypeName.Rows[i][0]);
            }
            for (int i = 0; i < Customer.Rows.Count; i++)
            {
                cbProvider.Items.Add(Customer.Rows[i][1]);
            }
            for (int i = 0; i < Product.Columns.Count; i++)
            {
                cbSearch.Items.Add(dgvProduct.Columns[i].HeaderText);
            }
            cbSearch.SelectedIndex = 0;
            cbStatus.Items.Add("Còn hàng");
            cbStatus.Items.Add("Hết hàng");
            if (Product.Rows.Count > 0)
            {
                ShowInTextBox(0);
                ShowProductDetail(0);
                ShowDetailInTextBox(0);
            }
        }
        void ShowInTextBox(int vt)
        {
            DataTable TypeName = new DataTable();
            DataTable ProviderName = new DataTable();
            txtIDProduct.Text = Product.Rows[vt][0].ToString();
            txtProductName.Text = Product.Rows[vt][1].ToString();
            TypeName = ConnectSQL.ExcuteQuery("Select ProductTypeName from ProductType where IDProductType LIKE N'" + Product.Rows[vt][2].ToString() + "'");
            cbProductType.SelectedItem = TypeName.Rows[0][0].ToString();
            ProviderName = ConnectSQL.ExcuteQuery("Select CustomerName from Customer where PhoneNum = '" + Product.Rows[vt][3].ToString() + "'");
            cbProvider.SelectedItem = ProviderName.Rows[0][0].ToString();
            if (Convert.ToInt32(Product.Rows[vt][4]) == 1)
                cbStatus.SelectedIndex = 1;
            else
                cbStatus.SelectedIndex = 0;
        }
        void ShowDetailInTextBox(int vt)
        {
            Color = ConnectSQL.ExcuteQuery("Select * from Color");
            Size = ConnectSQL.ExcuteQuery("Select * from Size");
            int SizeNum = Size.Rows.Count;
            int ColorNum = Color.Rows.Count;
            if (ProductDetail.Rows.Count > 0)
            {
                DataTable ColorName = new DataTable();

                txtIDProductDetail.Text = ProductDetail.Rows[vt][0].ToString();
                ColorName = ConnectSQL.ExcuteQuery("Select ColorName from Color where IDColor = '" + ProductDetail.Rows[vt][2].ToString() + "'");
                for (int i = 0; i < SizeNum; i++)
                {
                    CheckBox n = (CheckBox)flp1.Controls[i];

                    if (n.Text != ProductDetail.Rows[vt][1].ToString())
                    {
                        n.Checked = false;
                    }
                    else
                        n.Checked = true;

                }

                for (int i = 0; i < ColorNum; i++)
                {
                    CheckBox n = (CheckBox)flp2.Controls[i];

                    if (n.Text != ColorName.Rows[0][0].ToString())
                    {
                        n.Checked = false;
                    }
                    else
                        n.Checked = true;

                }
                txtImageName.Text = ProductDetail.Rows[vt][3].ToString();
                string filename = @".\image" + @"\";
                filename += txtImageName.Text;
                Bitmap img = new Bitmap(filename);
                pProduct.Image = img;
                txtPriceIn.Text = ProductDetail.Rows[vt][4].ToString();
                txtPriceOut.Text = ProductDetail.Rows[vt][5].ToString();
                nudNumber.Value = Convert.ToInt32(ProductDetail.Rows[vt][6]);
                string Images = txtImageDetail.Text = ProductDetail.Rows[vt][8].ToString();
                string[] filenames = Images.Split(';');
                flpImageDetail.Controls.Clear();
                if (!string.IsNullOrEmpty(Images))
                {

                    for (int i = 0; i < filenames.Count(); i++)
                    {
                        string a = @".\image" + @"\";
                        a += filenames[i];
                        Bitmap b = new Bitmap(a);
                        PictureBox pic = new PictureBox();
                        pic.Image = b;
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Width = 92;
                        pic.Height = 111;
                        pic.BorderStyle = BorderStyle.FixedSingle;
                        flpImageDetail.Controls.Add(pic);
                    }
                }
            }
            else
            {
                txtIDProductDetail.Text = "";
                txtPriceIn.Text = "";
                txtPriceOut.Text = "";
                nudNumber.Value = 1;
                txtImageName.Text = "";
                pProduct.Image = null;
                flpImageDetail.Controls.Clear();
                txtImageDetail.Text = "";
                for (int i = 0; i < SizeNum; i++)
                {
                    CheckBox n = (CheckBox)flp1.Controls[i];
                    n.Checked = false;
                }
                for (int i = 0; i < ColorNum; i++)
                {
                    CheckBox n = (CheckBox)flp2.Controls[i];
                    n.Checked = false;
                }
            }
        }
        bool CheckID()
        {
            int SIZE = Product.Rows.Count;
            for (int i = 0; i < SIZE; i++)
            {
                if (txtIDProduct.Text == Product.Rows[i][0].ToString())
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        bool CheckIDProductDetail(string ID)
        {
            int SIZE = ProductDetail.Rows.Count;
            for (int i = 0; i < SIZE; i++)
            {
                if (ID == ProductDetail.Rows[i][0].ToString())
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        int CheckNullProduct()
        {
            if (string.IsNullOrEmpty(txtIDProduct.Text))
            {
                errorProduct.SetError(txtIDProduct, "Nhập giá trị");
                return 0;
            }
            else if (string.IsNullOrEmpty(txtProductName.Text))
            {
                errorProduct.SetError(txtProductName, "Nhập giá trị");
                return 1;
            }
            return -1;
        }
        int CheckNullProductDetail()
        {

            if (string.IsNullOrEmpty(txtPriceIn.Text))
            {
                errorProductDetail.SetError(txtPriceIn, "Nhập giá trị");
                return 1;
            }
            else if (string.IsNullOrEmpty(txtPriceOut.Text))
            {
                errorProductDetail.SetError(txtPriceOut, "Nhập giá trị");
                return 2;
            }
            else if (string.IsNullOrEmpty(txtImageName.Text))
            {
                errorProductDetail.SetError(txtImageName, "Chọn ảnh");
                return 3;
            }
            else if (string.IsNullOrEmpty(nudNumber.Text))
            {
                errorProductDetail.SetError(nudNumber, "Nhập giá trị");
                return 4;
            }
            else if (string.IsNullOrEmpty(txtIDProduct.Text))
            {
                errorProductDetail.SetError(txtIDProduct, "Nhập giá trị");
                return 5;
            }           
            return -1;
        }
        void Add()
        {
            try
            {
                DataTable IDType = new DataTable();
                DataTable IDProvider = new DataTable();
                IDType = ConnectSQL.ExcuteQuery("Select IDProductType from ProductType Where ProductTypeName = N'" + cbProductType.SelectedItem + "'");
                string ProductType = IDType.Rows[0][0].ToString();
                IDProvider = ConnectSQL.ExcuteQuery("Select PhoneNum from Customer Where CustomerName = N'" + cbProvider.SelectedItem + "'");
                string ProductProvider = IDProvider.Rows[0][0].ToString();
                int SIZE = Product.Rows.Count;
                string query = "insert into Product([IDProduct],[ProductName],[IDProductType],[IDCustomer],[Status]) values('" + txtIDProduct.Text + "', N'" + txtProductName.Text + "', '" + ProductType + "', '" + ProductProvider + "', '0')";
                if (CheckNullProduct() == -1 && !CheckID())
                {
                    DialogResult Question = MessageBox.Show("Bạn Có Muốn Thêm Sản Phẩm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Question == DialogResult.Yes)
                    {
                        ConnectSQL.ExcuteQuery(query);
                    }
                    ShowProduct();
                    ShowInTextBox(0);
                    int SIZE2 = Product.Rows.Count;
                    if (SIZE != SIZE2)
                    {
                        MessageBox.Show("Thêm Sản Phẩm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm Sản Phẩm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (CheckNullProduct() == 0)
                    txtIDProduct.Focus();
                else if (CheckNullProduct() == 1)
                    txtProductName.Focus();
                else if (CheckID())
                {
                    MessageBox.Show("Sản phẩm đã tồn tại!", "Thông Báo");
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
                    MessageBox.Show("Kiểm tra lại mã sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDProduct.Focus();
                    errorProduct.SetError(txtIDProduct, "Nhập lại giá trị");
                }
                else
                {
                    int SIZE = Product.Rows.Count;
                    string query = "delete from ProductDetail where IDProduct = '" + txtIDProduct.Text + "'";
                    string query1 = "delete from Product where IDProduct = '" + txtIDProduct.Text + "'";
                    DialogResult Question = MessageBox.Show("Bạn Có Muốn Xoá Sản Phẩm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Question == DialogResult.Yes)
                    {
                        ConnectSQL.ExcuteQuery(query);
                        ConnectSQL.ExcuteQuery(query1);
                        ShowProduct();
                        ShowInTextBox(0);
                        int SIZE2 = Product.Rows.Count;
                        if (SIZE2 > 0)
                        {
                            ShowProductDetail(0);
                        }
                        if (SIZE != SIZE2)

                            MessageBox.Show("Xoá Sản Phẩm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Xoá Sản Phẩm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!", "Thông Báo");
            }
        }
        void Update()
        {
            try
            {
                DataTable IDType = new DataTable();
                DataTable IDProvider = new DataTable();
                IDType = ConnectSQL.ExcuteQuery("Select IDProductType from ProductType Where ProductTypeName = N'" + cbProductType.SelectedItem + "'");
                string ProductType = IDType.Rows[0][0].ToString();
                IDProvider = ConnectSQL.ExcuteQuery("Select PhoneNum from Customer Where CustomerName = N'" + cbProvider.SelectedItem + "'");
                string ProductProvider = IDProvider.Rows[0][0].ToString();
                string query = "UPDATE Product SET ProductName = N'" + txtProductName.Text + "', IDProductType = '" + ProductType + "',  IDCustomer = '" + ProductProvider + "',Status = '" + cbStatus.SelectedIndex + "'  WHERE IDProduct = '" + txtIDProduct.Text + "'";
                if (cbStatus.SelectedIndex == 1)
                {
                    string query1 = "Delete from ProductDetail WHERE IDProduct = '" + txtIDProduct.Text + "' ";
                }
                if (CheckID() && CheckNullProduct() == -1)
                {
                    DialogResult Question = MessageBox.Show("Bạn Có Muốn Cập Nhật Sản Phẩm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Question == DialogResult.Yes)
                    {
                        ConnectSQL.ExcuteQuery(query);
                        if (cbStatus.SelectedIndex == 1)
                        {
                            string query1 = "Delete from ProductDetail WHERE IDProduct = '" + txtIDProduct.Text + "' ";
                            ConnectSQL.ExcuteQuery(query1);
                        }

                        ShowProduct();
                        ShowDetailInTextBox(0);
                        ShowInTextBox(0);
                        ShowDetailInTextBox(0);
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
                else if (CheckNullProduct() == 0)
                    txtIDProduct.Focus();
                else if (CheckNullProduct() == 1)
                    txtProductName.Focus();
                else if (!CheckID())
                {
                    MessageBox.Show("Kiểm tra lại mã sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDProduct.Focus();
                    errorProduct.SetError(txtIDProduct, "Nhập lại giá trị");
                }
            }
            catch
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại", "Thông Báo");
            }
        }
        void AddDetail()
        {
            try
            {
                int SIZE = ProductDetail.Rows.Count;
                string query = "";
                string IDColor = "";
                string IDSize = "";
                int SizeNum = Size.Rows.Count;
                int ColorNum = Color.Rows.Count;
                if (CheckID() && CheckNullProductDetail() == -1)
                {
                    for (int i = 0; i < SizeNum; i++)
                    {
                        CheckBox s = (CheckBox)flp1.Controls[i];
                        if (s.Checked == true)
                        {
                            IDSize = s.Text;
                            for (int j = 0; j < ColorNum; j++)
                            {
                                CheckBox c = (CheckBox)flp2.Controls[j];
                                if (c.Checked == true)
                                {
                                    DataTable IDColorChange = new DataTable();
                                    IDColorChange = ConnectSQL.ExcuteQuery("Select IDColor from Color Where ColorName = N'" + c.Text + "'");
                                    IDColor = IDColorChange.Rows[0][0].ToString();
                                    string IDProDetail = "CT_" + IDSize + "_" + IDColor + "_" + txtIDProduct.Text + "";
                                    query = "insert into ProductDetail([IDProductDetail], [Size], [Color],[image], [PriceIn] , [PriceOut], [Number], [IDProduct], [ImageDetail]) values('" + IDProDetail + "', '" + IDSize + "', '" + IDColor + "', '" + txtImageName.Text + "', '" + txtPriceIn.Text + "', '" + txtPriceOut.Text + "', '" + nudNumber.Value + "', '" + txtIDProduct.Text + "' , '" + txtImageDetail.Text + "' )";
                                    if (CheckNullProductDetail() == -1 && !CheckIDProductDetail(IDProDetail))
                                    {
                                        ConnectSQL.ExcuteQuery(query);
                                        MessageBox.Show("Thêm Chi Tiết Sản Phẩm: " + IDProDetail + "\nMàu: " + c.Text + "\nKích Thước: " + s.Text + "\nSố Lượng: " + nudNumber.Value + "\nGiá Nhập: " + txtPriceIn.Text + "\nGiá Xuất: " + txtPriceOut.Text + " Thành Công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        if (CheckIDProductDetail(IDProDetail))
                                        {
                                            MessageBox.Show("Chi tiết sản phẩm:" + IDProDetail + "\nMàu: " + c.Text + "\nKích Thước: " + s.Text + "\nSố Lượng: " + nudNumber.Value + "\nGiá Nhập: " + txtPriceIn.Text + "\nGiá Xuất: " + txtPriceOut.Text + " đã tồn tại!", "Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (IDSize != "" && IDColor != "")
                    {
                        string query1 = "UPDATE Product SET Status = '0'  WHERE IDProduct = '" + txtIDProduct.Text + "'";
                        ConnectSQL.ExcuteQuery(query1);
                        //ShowProduct();
                        //ShowInTextBox(0);
                        ShowProductDetail(LocationClickProduct);
                        ShowDetailInTextBox(0);
                    }
                    else if (IDSize == "")
                    {
                        MessageBox.Show("Vui lòng chọn kích thước!", "Thông Báo");
                    }
                    else if (IDColor == "")
                    {
                        MessageBox.Show("Vui lòng chọn nàu!", "Thông Báo");
                    }
                }
                else if(!CheckID())
                    MessageBox.Show("Kiểm tra lại mã sản phẩm!", "Thông Báo");
                else if (CheckNullProductDetail() == 1)
                    txtPriceIn.Focus();
                else if (CheckNullProductDetail() == 2)
                    txtPriceOut.Focus();
                else if (CheckNullProductDetail() == 4)
                    nudNumber.Focus();
                else if (CheckNullProductDetail() == 3)
                    txtIDProduct.Focus();

            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!", "Thông Báo");
            }
        }
        void DeleteDetail()
        {
            try
            {
                if (!CheckIDProductDetail(txtIDProductDetail.Text))
                {
                    MessageBox.Show("Chọn lại Chi Tiết Sản Phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int SIZE = ProductDetail.Rows.Count;
                    string query = "delete from ProductDetail where IDProductDetail = '" + txtIDProductDetail.Text + "'";
                    DialogResult Question = MessageBox.Show("Bạn Có Muốn Xoá Chi Tiết Sản Phẩm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    string IDProduct = "Select IDProduct where IDProductDetail = '" + txtIDProductDetail.Text + "' ";
                    if (Question == DialogResult.Yes)
                    {
                        ConnectSQL.ExcuteQuery(query);
                        ShowProductDetail(LocationClickProduct);
                        ShowDetailInTextBox(0);

                        int SIZE2 = ProductDetail.Rows.Count;
                        if (SIZE != SIZE2)

                            MessageBox.Show("Xoá Chi Tiết Sản Phẩm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Xoá Chi Tiết Sản Phẩm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!", "Thông Báo");
            }
        }
        void UpdateDetail()
        {
            try
            {
                int SIZE = ProductDetail.Rows.Count;
                string query = "";
                string IDColor = "";
                string IDSize = "";
                int SizeNum = Size.Rows.Count;
                int ColorNum = Color.Rows.Count;
                int CountColor = 0;
                int CountSize = 0;
                if (CheckIDProductDetail(txtIDProductDetail.Text) && CheckNullProductDetail() == -1)
                {
                    for (int i = 0; i < SizeNum; i++)
                    {
                        CheckBox s = (CheckBox)flp1.Controls[i];
                        if (CountSize < 2)
                        {
                            if (s.Checked == true)
                            {
                                CountSize++;
                                IDSize = s.Text;
                                for (int j = 0; j < ColorNum; j++)
                                {
                                    CheckBox c = (CheckBox)flp2.Controls[j];
                                    if (CountColor < 2)
                                    {
                                        if (c.Checked == true)
                                        {
                                            CountColor++;
                                            DataTable IDColorChange = new DataTable();
                                            IDColorChange = ConnectSQL.ExcuteQuery("Select IDColor from Color Where ColorName = N'" + c.Text + "'");
                                            IDColor = IDColorChange.Rows[0][0].ToString();
                                        }
                                    }
                                    else
                                        break;
                                }
                            }
                        }
                        else
                            break;

                    }
                    if (CountColor == 1 && CountSize == 1)
                    {
                        query = "UPDATE ProductDetail SET [Size] = '" + IDSize + "', [Color] = '" + IDColor + "', [image] = '" + txtImageName.Text + "',[PriceIn] = '" + txtPriceIn.Text + "', [PriceOut] = '" + txtPriceOut.Text + "',[Number]  = '" + nudNumber.Value + "'  , [ImageDetail] = '" + txtImageDetail.Text + "' WHERE [IDProductDetail] = '" + txtIDProductDetail.Text + "'";
                        DialogResult Question = MessageBox.Show("Bạn Có Muốn Cập Nhật Chi Tiết Sản Phẩm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Question == DialogResult.Yes)
                        {
                            ConnectSQL.ExcuteQuery(query);
                            ShowProductDetail(LocationClickProduct);
                            ShowDetailInTextBox(0);
                            ShowInTextBox(LocationClickProduct);
                            if (ConnectSQL.ExcuteNonQuery(query) > 0)
                            {
                                MessageBox.Show("Cập Nhật Chi Tiết Sản Phẩm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Cập Nhật Sản Phẩm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else if (CountSize > 1 || CountSize == 0)
                        MessageBox.Show("Vui chọn một kích thước!", "Thông báo");
                    else if (CountColor > 1 || CountColor == 0)
                        MessageBox.Show("Vui chọn một màu!", "Thông báo");
                }
                
                else if (CheckNullProductDetail() == 1)
                    txtPriceIn.Focus();
                else if (CheckNullProductDetail() == 2)
                    txtPriceOut.Focus();
                else if (CheckNullProductDetail() == 4)
                    nudNumber.Focus();
                else if (CheckNullProductDetail() == 3)
                    txtIDProduct.Focus();
                else if (!CheckID())
                {
                    MessageBox.Show("Kiểm tra lại mã sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDProduct.Focus();
                    errorProduct.SetError(txtIDProduct, "Nhập lại giá trị");
                }
            }
            catch
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại", "Thông Báo");
            }
        }
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            int SIZE = Product.Rows.Count;
            if (vt >= 0 && vt != SIZE)
            {
                LocationClickProduct = vt;
                ShowInTextBox(vt); 
                ShowProductDetail(vt);
                ShowDetailInTextBox(0);
            }
        }
        private void dgvProductDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt1 = e.RowIndex;
            int SIZE = ProductDetail.Rows.Count;
            if (vt1 >= 0 && vt1 != SIZE)
            {
                ShowDetailInTextBox(vt1);
            }
        }
        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearch.SelectedIndex > 1 && cbSearch.SelectedIndex < 5)
            {
                txtSearch.Text = "";
                txtSearch.Enabled = false;

            }
            else
            {
                txtSearch.Text = "";
                txtSearch.Enabled = true;

            }

            txtSearch.Focus();
        }
        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            errorProduct.Clear();
        }
        private void txtIDProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }

        private void txtPriceIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFrom.Text = "";
            txtTo.Text = "";
            txtSearch.Text = "";
            if (cbSearch.SelectedIndex == 6 || cbSearch.SelectedIndex == 9 || cbSearch.SelectedIndex == 10 || cbSearch.SelectedIndex == 11)
            {
                pValues.Visible = true;
                txtFrom.Focus();
            }
            else
            {
                pValues.Visible = false;
                txtSearch.Focus();
            }
        }

        private void txtIDProduct_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }
        private void txtID_KeyUp(object sender, KeyEventArgs e)
        {
            //string query = "";
            //string x = "";
            //for (int i = 0; i < Product.Columns.Count; i++)
            //{
            //    if (i == cbSearch.SelectedIndex)
            //    {               
            //            if (i < 5)
            //                x = "Product.";
            //            else x = "ProductDetail.";
            //            query = qPro + " And " + x + Product.Columns[i].ToString() + " LIKE '%" + txtID.Text + "%'";
            //            break;                 
            //    }
            //}
            //ConnectSql(query, dgvProduct);
        }
        private void btnSize_Click(object sender, EventArgs e)
        {
            this.Hide();
            fSize fSize = new fSize();
            fSize.ShowDialog();
            this.Close();
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            this.Hide();
            fColor fColor = new fColor();
            fColor.ShowDialog();
            this.Close();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            errorProduct.Clear();
            Update();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Image = new OpenFileDialog();
                Image.InitialDirectory = Path.GetDirectoryName(@"C:\Users\Bill\Desktop\Shoesshop1\ShoesShop\demo\bin\Debug\image\");
                if (Image.ShowDialog() == DialogResult.Yes)
                {
                    Image.ShowDialog();
                }
                if (Image.FileName != "")
                {
                    Bitmap i = new Bitmap(Image.FileName);
                    pProduct.Image = i;
                    pProduct.SizeMode = PictureBoxSizeMode.StretchImage;
                    string[] Name;
                    Name = Image.FileName.Split('\\');
                    txtImageName.Text = Name[Name.Count() - 1];
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn lại ảnh!", "Thông Báo");
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            errorProduct.Clear();
            Add();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            errorProduct.Clear();
            Delete();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProductDetail_Click(object sender, EventArgs e)
        {
            errorProductDetail.Clear();
            AddDetail();
        }

        private void btnDeleteProductDetail_Click(object sender, EventArgs e)
        {
            errorProductDetail.Clear();
            DeleteDetail();
        }

        private void txtIDProductDetail_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDProductDetail.Text))
                txtIDProductDetail.Text = "Tự động phát sinh ...";
        }

        private void btnUpdateProductDetail_Click(object sender, EventArgs e)
        {
            errorProductDetail.Clear();
            UpdateDetail();
        }

        private void btnImages_Click(object sender, EventArgs e)
        {           
            OpenFileDialog o = new OpenFileDialog();
            o.InitialDirectory = Path.GetFullPath("image") + @"\";
            o.Multiselect = true;         
            //if (o.ShowDialog() == DialogResult.Cancel)
            //{
            //    o.ShowDialog();
            //}
            if (o.ShowDialog() == DialogResult.OK)
            {
                flpImageDetail.Controls.Clear();
                txtImageDetail.Text = null;
                int count = o.FileNames.Length;
                foreach (string f in o.FileNames)
                {
                    Bitmap a = new Bitmap(f);
                    PictureBox pic = new PictureBox();
                    pic.Image = a;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Width = 92;
                    pic.Height = 111;
                    pic.BorderStyle = BorderStyle.FixedSingle;
                    flpImageDetail.Controls.Add(pic);
                    string[] tens = f.Split('\\');
                    count--;
                    if (count >= 1)
                    {
                        txtImageDetail.Text += tens[tens.Count() - 1] + ";";
                    }
                    else
                    {
                        txtImageDetail.Text += tens[tens.Count() - 1];
                    }
                }
            }
            
        }
    }
}

