using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace demo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Connect ConnectSQL = new Connect();
            //DataTable Account = new DataTable();
            //Account = ConnectSQL.ExcuteQuery("Select IDStaff, Status from Account");
            //bool CheckAccountOnline()
            //{
            //    bool Flag = false;
            //    if (Account.Rows.Count >= 1)
            //    {
            //        for (int i = 0; i < Account.Rows.Count; i++)
            //        {
            //            if (Convert.ToInt32(Account.Rows[i][1]) == 1)
            //            {
            //                Flag = true;
            //                break;
            //            }
            //        }

            //    }
            //    return Flag;
            //}
            //Application.Run(new fLoading());

            //if (CheckAccountOnline())
            //{
            //    string IDStaff = "";
            //    for (int i = 0; i < Account.Rows.Count; i++)
            //    {
            //        if (Account.Rows[i][1].ToString() == "1")
            //        {
            //            IDStaff = Account.Rows[i][0].ToString();
            //        }
            //    }
            Application.Run(new fHomePage());
            //}
            //else
            //    Application.Run(new fLogin());

            //Application.Run(new fBill());
            //Application.Run(new fProduct());
            //Application.Run(new fCustomer());
            //Application.Run(new fSize());
            //Application.Run(new fColor());
            //Application.Run(new fStaff());
            //Application.Run(new fProductType());
            //Application.Run(new fProductDetail());
        }

    }
}
