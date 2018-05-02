using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineKata
{
    public class Inventory
    {
        static Tuple<int, int> ColaInventory = new Tuple<int, int>(1, 5);
        static Tuple<int, int> ChipInventory = new Tuple<int, int>(2, 5);
        static Tuple<int, int> CandyInventory = new Tuple<int, int>(3, 5);

        public Dictionary<int, int> InventoryLevels;


        public Inventory()
        {
            InventoryLevels = new Dictionary<int, int>()
            {
                {ColaInventory.Item1, ColaInventory.Item2 },
                {ChipInventory.Item1, ChipInventory.Item2 },
                {CandyInventory.Item1, CandyInventory.Item2 }
            };
        }


        public Inventory(Dictionary<int, int> inventoryDictionary)
        {
            InventoryLevels = inventoryDictionary;
        }

        public bool IsProductInStock(int productID)
        {
            return (InventoryLevels[productID] > 0);
        }
    }
}
