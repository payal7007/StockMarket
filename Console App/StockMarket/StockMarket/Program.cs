using StockModels;
using StockDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StockMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //insertStockDetails s = new insertStockDetails();
            //s.insertrecordThroughSP();
            //s.updaterecordThrough();
            //s.deleterecordThrough();
            //Stockmodel stock = new Stockmodel();
            //stock.stockName = " APPL";
            //priceHistoryDetails price = new priceHistoryDetails();
            //price.insertPriceHistoryrecord();
            UserDetails user = new UserDetails();
            user.insertUserDetails();
            //orderDetails order = new orderDetails();
            //order.insertOrderDetails();
            //insertBalancedetails balance = new insertBalancedetails();
            //balance.insertBalancedetails();
        }
    }
}
