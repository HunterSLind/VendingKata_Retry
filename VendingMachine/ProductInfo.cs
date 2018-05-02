using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineKata
{
    public class ProductInfo
    {
        public static int COLAID = 1;
        public static int CHIPID = 2;
        public static int CANDYID = 3;

        public static int COLASTOCK = 5;
        public static int CHIPSTOCK = 5;
        public static int CANDYSTOCK = 5;

        public static int COLAPRICE = 100;
        public static int CHIPPRICE = 50;
        public static int CANDYPRICE = 65;

        public int Price { get; set; }
        public int Stock { get; set; }

        public ProductInfo(int price, int stock)
        {
            Price = price;
            Stock = stock;
        }
    }
}
