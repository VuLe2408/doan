using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;    
namespace demo
{
    public class Connect
    {
        string connectionSTR = @"Data Source=LAPTOP-M78HRL4F;Initial Catalog=ShoesShop3;Integrated Security=True";
        public DataTable ExcuteQuery(string query)
        {
            SqlConnection connect = new SqlConnection(connectionSTR);          
            connect.Open();
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            adapter.Fill(data);
            connect.Close();           
            return data;            
        }
        public int ExcuteNonQuery(string query)
        {
            int data = 0;
            SqlConnection connect = new SqlConnection(connectionSTR);
            connect.Open();
            SqlCommand command = new SqlCommand(query, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            data = command.ExecuteNonQuery();
            connect.Close();
            return data;
        }

    }
}
