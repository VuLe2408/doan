using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class fHomePage : Form
    {
        public fHomePage()
        {
            InitializeComponent();
            ShowProduct();
            ShowProductType();
            ShowProductDetail();
            ShowCustomer();
            ShowBill();
            ShowBillDetail();
            ShowStaff();
        }
        private void fHomePages_Load(object sender, EventArgs e)
        {
            Connect ConnectSQL = new Connect();
            DataTable Account = new DataTable();
            Account = ConnectSQL.ExcuteQuery("Select IDStaff, Status from Account");
            for (int i = 0; i < Account.Rows.Count; i++)
            {
                if (Account.Rows[i][1].ToString() == "1")
                {
                    ReturnIDAccount = Account.Rows[i][0].ToString();
                }
            }
        }
        //------------------------Khai Báo Biến------------------------//
        Connect ConnectSQL = new Connect();
        DataTable Account = new DataTable();
        public string ReturnIDAccount;
        //------------------------Hàm------------------------//
        //Kết nối SQL
        void InputQuery(string query, DataGridView drv)
        {
            Connect connect = new Connect();
            drv.DataSource = connect.ExcuteQuery(query);
        }
        //Danh sách loại sản phẩm
        void ShowProduct()
        {
            string query = "select * from PRODUCT";
            InputQuery(query, dgvProduct);
        }
        //Danh sách loại sản phẩm
        void ShowProductType()
        {
            string query = "select * from ProductType";
            InputQuery(query, dgvProductType);
        }
        //Danh sách chi tiết sản phẩm
        void ShowProductDetail()
        {
            string query = "select * from ProductDetail";
            InputQuery(query, dgvProductDetail);
        }
        //Danh sách nhà cung cấp
      
        //Danh sách khách hàng
        void ShowCustomer()
        {
            string query = "select * from Customer";
            InputQuery(query, dgvCustomer);
        }
        //Danh sách hoá đơn
        void ShowBill()
        {
            string query = "select * from Bill";
            InputQuery(query, dgvBill);
        }
        //Danh sách chi tiết hoá đơn
        void ShowBillDetail()
        {
            string query = "select * from BillDetail";
            InputQuery(query, dgvBillDetail);
        }
        //Danh sách nhân viên
        void ShowStaff()
        {
            string query = "select * from Staff";
            InputQuery(query, dgvStaff);
        }
        //------------------------Khai Báo Biến------------------------//
        //Nút quản lý sản phẩm
        void mstAddProduct_Click_1(object sender, EventArgs e)
        {
            Form fEditPro = new fProduct();
            fEditPro.ShowDialog();
        }
        //Nút quản lý loại sản phẩm
        private void mtsEditProductType_Click(object sender, EventArgs e)
        {
            Form fEditProType = new fProductType();
            fEditProType.ShowDialog();
        }
        //Nút quản lý nhân viên
        private void mtsEditStaff_Click(object sender, EventArgs e)
        {
            Form fS = new fStaff();
            fS.ShowDialog();
        }
        //Nút thông tin tài khoản
        private void mtsInfoAccount_Click(object sender, EventArgs e)
        {
            
            fInfoAccount fInfo = new fInfoAccount();
            fInfo.IDAccount = ReturnIDAccount;
            fInfo.ShowDialog();
        }
        //Nút quản lý khách hàng
        private void mtsAddCustomer_Click(object sender, EventArgs e)
        {
            fCustomer fCus = new fCustomer();
            fCus.ShowDialog();
        }
        //Nút đăng xuất
        private void mtsLogOut_Click(object sender, EventArgs e)
        {
            Account = ConnectSQL.ExcuteQuery("Update Account set Status = '0' where IDStaff = '" + ReturnIDAccount + "'");
            this.Hide();
            fLogin fLI = new fLogin();
            fLI.ShowDialog();
            this.Close();
        }
        //Nút quản lý nhà cung cấp
        
        //Nút thoát
        private void mstExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fbillsearch = new fBillSearch();
            fbillsearch.ShowDialog();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fbill = new fBill();
            fbill.ShowDialog();
        }
    }
}
