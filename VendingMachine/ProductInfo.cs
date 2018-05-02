using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineKata
{
    public class ProductInfo
    {
        public static int DEFAULTCOLAID = 1;
        public static int DEFAULTCHIPID = 2;
        public static int DEFAULTCANDYID = 3;

        public static int DEFAULTCOLASTOCK = 5;
        public static int DEFAULTCHIPSTOCK = 5;
        public static int DEFAULTCANDYSTOCK = 5;

        public static int DEFAULTCOLAPRICE = 100;
        public static int DEFAULTCHIPPRICE = 50;
        public static int DEFAULTCANDYPRICE = 65;

        public int Price { get; set; }
        public int Stock { get; set; }

        public ProductInfo(int stock, int price)
        {
            Price = price;
            Stock = stock;
        }
    }
}
