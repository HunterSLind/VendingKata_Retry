using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineKata
{
    public class Inventory
    {

        Tuple<int, int> ColaInventory = new Tuple<int, int>(1, 5);


        public bool ProductInStock(int productID)
        {
            // cola productID is 1
            if(productID == ColaInventory.Item1)
            {
                // check cola inventory levels, if there are colas remaining, return true.
                return (ColaInventory.Item2 > 0);
            }
            return false;
        }
    }
}
