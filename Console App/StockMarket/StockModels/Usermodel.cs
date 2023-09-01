using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockModels
{
    class Usermodel : Baseclass<int>
    {
        public string userName { get; set; }
        public string email { get; set; }

        public int brokerID { get; set; }
    }
}
