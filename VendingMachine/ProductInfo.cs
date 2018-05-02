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

        public int Price { get; set; }
        public int Stock { get; set; }

        public ProductInfo(int price, int stock)
        {
            Price = price;
            Stock = stock;
        }
    }
}
