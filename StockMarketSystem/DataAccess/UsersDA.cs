using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
   public  class UsersDA
    {
        public bool AuthenticateUser(string email,string password, out string validationmessage)
        {
            using (SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["StockConnection"].ToString()))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE email=email";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@email", email);

                sqlcon.Open();
                int row = (int)cmd.ExecuteScalar();
                sqlcon.Close();

                if (row == 0)
                {
                    validationmessage = "User email does not exist";
                    return false;
                }

                query = "SELECT COUNT(*) FROM Users WHERE email=@email AND password=@password";
                cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                sqlcon.Open();
                row = (int)cmd.ExecuteScalar();
                sqlcon.Close();

                validationmessage = row == 0 ? "Credentials do not match" : string.Empty;
                return row > 0;
            }
        }
    }
}