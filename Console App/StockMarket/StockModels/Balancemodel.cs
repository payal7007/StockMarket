using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockModels
{
    class Balancemodel
    {
        public class Balance : Baseclass<int>
        {
            public int userID { get; set; }
            public decimal amount { get; set; }
            public DateTime lastUpdated { get; set; }
        }

    }
}
