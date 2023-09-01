using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockModels
{
    class Orderdetailmodel
    {
        

            public class Order : Baseclass<int>
            {
                public int userID { get; set; }
                public int stockID { get; set; }
                public string orderType { get; set; }
                public int quantity { get; set; }
                public decimal price { get; set; }
                public DateTime placedDate { get; set; }
                public string status { get; set; }
            }
           

    }
}
