using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineKata
{
    public class ProductInfo
    {
        public int Price { get; set; }
        public int Stock { get; set; }

        public ProductInfo(int price, int stock)
        {
            Price = price;
            Stock = stock;
        }
    }
}
