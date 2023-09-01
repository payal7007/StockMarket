using StockModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDataAccess
{
    class orderDetails
    {

        public void insertOrderDetails()
        {
            SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["StockConnection"].ToString());
            string query = "Insert into Stocks values (1, 1, 'Buy', 10, 150.25, getdate(),  'executed')";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            sqlcon.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlcon.Close();
        }
    }
}
