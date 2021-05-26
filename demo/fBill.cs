using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace demo
{
    public partial class fBill : Form
    {
        int totalprice = 0;
        int countbill = 1;
        public fBill()
        {
            InitializeComponent();
        }
        // Load combobox
        private void fBill_Load(object sender, System.EventArgs e)
        {
            Product= ConnectSQL.ExcuteQuery("Select IDProduct from Product");
            for (int i = 0; i < Product.Rows.Count; i++)
            {
                cbIDProduct.Items.Add(Product.Rows[i][0]);
            }
            Staff= ConnectSQL.ExcuteQuery("Select IDStaff from Staff");
            for (int i = 0; i < Staff.Rows.Count; i++)
            {
                cbIDStaff.Items.Add(Staff.Rows[i][0]);
            }
            Bill= ConnectSQL.ExcuteQuery("Select IDBill from Bill");
            for (int i = 0; i < Bill.Rows.Count; i++)
            {
                countbill++;
            }
            lblIDBill.Text = "HD" + countbill;
            Customer = ConnectSQL.ExcuteQuery("Select PhoneNum from Customer");
            for (int i = 0; i < Customer.Rows.Count; i++)
            {
                cbIDCustomer.Items.Add(Customer.Rows[i][0]);
            }
            btnSaveProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
            txtDiscount.Text = "0";
        }
        //------------------------Khai Báo Biến------------------------//
        Connect ConnectSQL = new Connect();
        DataTable Product = new DataTable();
        DataTable ProductDetail = new DataTable();
        DataTable BillDetail = new DataTable();
        DataTable Customer = new DataTable();
        DataTable Staff = new DataTable();
        DataTable Bill = new DataTable();

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
               e.Handled = true;
        }
        //thêm chi tiết hóa đơn
        public void add()
        {
            var index = dgvBillDetail.Rows.Add();
            this.dgvBillDetail.Rows[index].Cells[0].Value = cbIDProduct.Text;
            this.dgvBillDetail.Rows[index].Cells[1].Value = lblProductName.Text;
            this.dgvBillDetail.Rows[index].Cells[2].Value = txtNumber.Text;
            this.dgvBillDetail.Rows[index].Cells[3].Value = lblIDProduct.Text;
            this.dgvBillDetail.Rows[index].Cells[4].Value = txtDiscount.Text;
            this.dgvBillDetail.Rows[index].Cells[5].Value = lblPrice.Text;
            totalprice += Convert.ToInt32(lblPrice.Text);
            lblTotalCost.Text = totalprice.ToString();
        }
        //  kiểm tra số lượng
        public bool check(string a,int b)
        {
            string str = "Select Number from ProductDetail where IDProduct = N'" + a + "'";
            ProductDetail = ConnectSQL.ExcuteQuery(str);
            if(ProductDetail.Rows.Count>0)
            if (b <= (int)ProductDetail.Rows[0][0])
                return true;
            return false;
        }
        // trừ số lượng sản phẩm
        public int subtractSL(string a, int b)
        {
            int sl= 0;
            string str = "Select Number from ProductDetail where IDProduct = N'" + a + "'";
            ProductDetail = ConnectSQL.ExcuteQuery(str);
            sl =(int) ProductDetail.Rows[0][0];
            sl -= b;
            return sl;
        }
        // tính tổng tiền 
        public double totalPrice()
        {
            double tt, sl, dg, gg;
            if (txtNumber.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtNumber.Text);
            if (txtDiscount.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtDiscount.Text);
            if (lblIDProduct.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(lblPrice.Text);
            tt = sl * dg - sl * dg * gg / 100;
            return tt;

        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            bool flag = true;
            bool flag1 = true;
            if (cbIDProduct.Text=="")
            { MessageBox.Show("Chưa Nhập Mã sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); cbIDProduct.Focus(); flag = false; }
            if (txtNumber.Text == "")
            { MessageBox.Show("Chưa Nhập Số lượng sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); txtNumber.Focus(); flag = false; }
            if(flag)
            {
                    for (int i = 0; i < dgvBillDetail.Rows.Count - 1; i++)
                    {
                        flag1 = true;
                        if (this.dgvBillDetail.Rows[i].Cells[0].Value.ToString() == cbIDProduct.Text)
                        {                       
                            int slban = Convert.ToInt32(dgvBillDetail.Rows[i].Cells[2].Value);
                            slban += Convert.ToInt32(txtNumber.Text);
                            if (!check(cbIDProduct.Text,slban))
                            {
                                MessageBox.Show("Số lượng sản phẩm không đủ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                         
                            }else this.dgvBillDetail.Rows[i].Cells[2].Value = slban;
                            flag1 = false;
                            break;
                        }

                    }
                    if (flag1)
                    {                       
                         if (!check(cbIDProduct.Text,Convert.ToInt32(txtNumber.Text)))
                        {
                            MessageBox.Show("Số lượng sản phẩm không đủ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                           
                        }else
                            add();
                }
            }

        }

        private void cbIDStaff_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbIDStaff.Text == "")
                lblStaffName.Text = "";
            else
            {
                try
                {
                    // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
                    str = "Select StaffName from Staff where IDStaff = N'" + cbIDStaff.Text + "'";
                    Staff = ConnectSQL.ExcuteQuery(str);
                    lblStaffName.Text = Staff.Rows[0][0].ToString();
                }
                catch { }
            }
        }

        private void txtIDCustomer_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbIDCustomer.Text == "")
            {
                lblCustomerName.Text = "";
                lblAddress.Text = "";
            }
            else
            {
                try
                {
                    // Khi chọn Mã khách hàng thì tên khach hang tự động hiện ra
                    str = "Select CustomerName,Address from Customer where PhoneNum = N'" + cbIDCustomer.Text + "'";
                    Customer = ConnectSQL.ExcuteQuery(str);
                    lblCustomerName.Text = Customer.Rows[0][0].ToString();
                    lblAddress.Text = Customer.Rows[0][1].ToString();
                }
                catch { }
            }
        }

        private void cbIDProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool flag = true;
            if (cbTypeBill.Text == "")
            { MessageBox.Show("Chưa Nhập loại hóa đơn sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); cbIDProduct.Focus(); flag = false;  }
            if (flag)
            {
                string str;
                string str1 = "";
                if (cbIDProduct.Text == "")
                {
                    lblProductName.Text = "";
                    lblIDProduct.Text = "";
                }
                else
                {
                    try
                    {
                        // Khi chọn Mã sản phẩm thì tên nhân viên tự động hiện ra
                        str = "Select ProductName from Product where  IDProduct = N'" + cbIDProduct.Text + "'";

                        if (cbTypeBill.Text == "Hóa Đơn Bán")
                        { str1 = "Select PriceOut from ProductDetail where ProductDetail.IDProduct =N'" + cbIDProduct.Text + "'"; }
                        else if (cbTypeBill.Text == "Hóa Đơn Nhập")
                        { str1 = "Select PriceIn from ProductDetail where ProductDetail.IDProduct =N'" + cbIDProduct.Text + "'"; }
                        Product = ConnectSQL.ExcuteQuery(str);
                        ProductDetail = ConnectSQL.ExcuteQuery(str1);
                        lblProductName.Text = Product.Rows[0][0].ToString();
                        if (ProductDetail.Rows.Count == 0)
                            lblPrice.Text ="0";
                        else
                            lblPrice.Text = ProductDetail.Rows[0][0].ToString();
                    }
                    catch { }
                }
            }
        }


        private void btnRefreshText_Click(object sender, EventArgs e)
        {
            cbIDStaff.Text = "";
            cbIDCustomer.Text = "";
            txtNumber.Text = "";
            cbIDProduct.Text = "";
            txtDiscount.Text = "";
            lblTotalCost.Text = "";
            totalprice = 0;
            dgvBillDetail.Rows.Clear();
            btnSaveProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
            cbIDCustomer.Focus();

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgvBillDetail.SelectedCells)
            {
                if (oneCell.Selected)
                    dgvBillDetail.Rows.RemoveAt(oneCell.RowIndex);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (cbTypeBill.Text == "")
            { MessageBox.Show("Chưa Nhập loại hóa đơn sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); cbIDProduct.Focus(); flag = false; }
            if (cbIDCustomer.Text == "")
            { MessageBox.Show("Chưa Nhập ID khách hàng sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); txtNumber.Focus(); flag = false; }
            if (cbIDStaff.Text == "")
            { MessageBox.Show("Chưa Nhập ID nhân viên sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); txtNumber.Focus(); flag = false; }
            if (flag)
            {
                int SIZE = Bill.Rows.Count;
                string query = "";
                string query1 = "";
                    if (cbTypeBill.Text == "Hóa Đơn Bán")
                {
                    query = "INSERT INTO Bill (IDBill, Date, IDCustomer,IDStaff, TypeBill,Status) VALUES('" + lblIDBill.Text + "', '" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "', '" + cbIDCustomer.Text + "','', '" + cbIDStaff.Text + "', '" + cbTypeBill.Text + "', '" + "1" + "')";
                }
                else if (cbTypeBill.Text == "Hóa Đơn Nhập")
                { query = "INSERT INTO Bill (IDBill, Date, IDProvider, IDStaff, TypeBill,Status) VALUES('" + lblIDBill.Text + "', '" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "', '" + cbIDCustomer.Text + "', '" + cbIDStaff.Text + "', '" + cbTypeBill.Text + "', '" + "1" + "')"; }
                DialogResult Question = MessageBox.Show("Bạn Có Muốn Thêm Hóa đơn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Question == DialogResult.Yes)
                {
                    ConnectSQL.ExcuteQuery(query);
                    for (int i = 0; i < dgvBillDetail.Rows.Count-1; i++)
                    {                    
                        string IDProduct, Number, Price, Discount, TotalPrice;
                        IDProduct=dgvBillDetail.Rows[i].Cells[0].Value.ToString();
                        Number=dgvBillDetail.Rows[i].Cells[2].Value.ToString();
                        Price=dgvBillDetail.Rows[i].Cells[3].Value.ToString();
                        Discount=dgvBillDetail.Rows[i].Cells[4].Value.ToString();
                        TotalPrice =dgvBillDetail.Rows[i].Cells[5].Value.ToString();
                        query1 = "INSERT INTO BillDetail (IDBill, IDProduct, Number, Price, Discount,TotalPrice) VALUES('" +lblIDBill.Text + "', '" + IDProduct + "', '" + Number + "', '" + Price + "', '" + Discount + "', '" + TotalPrice + "')";
                        ConnectSQL.ExcuteQuery(query1);
                    }

                }
                int SIZE2 = Bill.Rows.Count;
                if (SIZE != SIZE2)
                {
                    MessageBox.Show("Thêm Hoá đơn Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }


    }
 }

