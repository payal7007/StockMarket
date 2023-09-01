using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockModels
{
    public class Baseclass<T>
    {
        public T stockId { get; set; }
        public T userId { get; set; }
        public T priceHistoryID { get; set; }

        public T orderID { get; set; }
        public T balanceID { get; set; }

    }

}
