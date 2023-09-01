using StockModels;
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
     public class priceHistoryDetails
    {
        public void insertPriceHistoryrecord()
        {

            SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["StockConnection"].ToString());


            string query = "insertpricedata1";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@stockId", SqlDbType.Int).Value = 1;
            cmd.Parameters.Add("@openPrice", SqlDbType.Decimal).Value = 150.00;
            cmd.Parameters.Add("@highPrice", SqlDbType.Decimal).Value = 155.00;
            cmd.Parameters.Add("@lowPrice", SqlDbType.Decimal).Value = 155.00;
            cmd.Parameters.Add("@closePrice", SqlDbType.Decimal).Value = 155.00;
            cmd.Parameters.Add("@volume", SqlDbType.Int).Value = 10;
            cmd.Parameters.Add("@tradeDate", SqlDbType.DateTime).Value = DateTime.Now;

            cmd.Parameters.Add("@OPtype", SqlDbType.Int).Value = 'A';

            sqlcon.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlcon.Close();

        }
        
    }
}
