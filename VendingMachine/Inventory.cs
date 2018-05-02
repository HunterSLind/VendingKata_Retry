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

        public Dictionary<int, ProductInfo> InventoryLevels;


        public Inventory()
        {
            InventoryLevels = new Dictionary<int, ProductInfo>()
            {
                {ColaInventory.Item1, new ProductInfo(ColaInventory.Item2, 100) },
                {ChipInventory.Item1, new ProductInfo(ChipInventory.Item2, 50) },
                {CandyInventory.Item1, new ProductInfo(CandyInventory.Item2, 65) }
            };
        }


        public Inventory(Dictionary<int, ProductInfo> inventoryDictionary)
        {
            InventoryLevels = inventoryDictionary;
        }

        public bool IsProductInStock(int productID)
        {
            return (InventoryLevels[productID].Stock > 0);
        }

        public bool IsEnoughMoneyForProduct(int productID, int moneyDeposited)
        {
            return (InventoryLevels[productID].Price < moneyDeposited);
        }
    }
}
