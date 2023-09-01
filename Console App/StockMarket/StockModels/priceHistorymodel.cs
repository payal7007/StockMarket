using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockModels
{
    class priceHistorymodel
    {
        public class PriceHistory : Baseclass<int>
        {
            public int stockID { get; set; }
            public decimal openPrice { get; set; }
            public decimal highPrice { get; set; }
            public decimal lowPrice { get; set; }
            public decimal closePrice { get; set; }
            public int volume { get; set; }
            public DateTime tradeDate { get; set; }
            public string OPtype { get; set; }
        }

    }
}
