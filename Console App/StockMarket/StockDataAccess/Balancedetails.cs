using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDataAccess
{
    public class Balancedetails
    {
        public void insertBalancedetails()
        {
            SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["StockConnection"].ToString());
            string query = "Insert into Stocks values ('jiya','jiya@gmail.com')";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            sqlcon.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlcon.Close();
        }
    }
}
