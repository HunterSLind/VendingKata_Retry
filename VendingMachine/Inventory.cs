using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineKata
{
    public class Inventory
    {

        Tuple<string, int> ColaInventory = new Tuple<string, int>("Cola", 5);


        public int SelectProduct(int productID)
        {
            return productID;
        }
    }
}
