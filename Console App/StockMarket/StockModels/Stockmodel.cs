using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockModels
{

    public class Stockmodel : Baseclass<int>
    {
        public int brokerID { get; set; }
        public string stockSymbol { get; set; }
        public string stockName { get; set; }

        public string sector { get; set; }
        public string Industry { get; set; }
        public string OPtype { get; set; }
    }



}
