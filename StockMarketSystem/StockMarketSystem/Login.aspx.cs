using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;
using System.Data.SqlClient;

namespace StockMarketSystem
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string email = TextBox1.Text;
            string password = TextBox2.Text;

            string validationmessage; 
            //string msg;
            UsersDA user = new UsersDA();
            bool exist = user.AuthenticateUser(email, password, out  validationmessage);

            if(exist)
            {
                Session["email"] = email;
                Response.Redirect("Default.aspx");
            }
            else
            {
                Label1.Text = validationmessage;
            }
        }
    }
}