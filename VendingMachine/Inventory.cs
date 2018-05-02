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
        Tuple<int, int> ChipInventory = new Tuple<int, int>(2, 5);
        Tuple<int, int> CandyInventory = new Tuple<int, int>(3, 5);


        public bool IsProductInStock(int productID)
        {
            // cola productID is 1
            if(productID == ColaInventory.Item1)
            {
                // check cola inventory levels, if there are colas remaining, return true.
                return (ColaInventory.Item2 > 0);
            }
            if (productID == ChipInventory.Item1)
            {
                return (ChipInventory.Item2 > 0);
            }
            if (productID == CandyInventory.Item1)
            {
                return (CandyInventory.Item2 > 0);
            }
            return false;
        }
    }
}
