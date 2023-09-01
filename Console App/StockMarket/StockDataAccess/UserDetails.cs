using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDataAccess
{
   public class UserDetails
    {
        public void insertUserDetails()
        {
            SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["StockConnection"].ToString());
            string query = "Insert into Stocks values (@userName,@email)";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.Parameters.Add("@userName", SqlDbType.VarChar).Value = "jiya";
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = "jiya@gmail.com";
            cmd.Parameters.Add("@email", SqlDbType.Int).Value = 1;

            sqlcon.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

    }
}
