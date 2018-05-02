using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineKata
{
    public class Inventory
    {

        public Dictionary<int, ProductInfo> InventoryLevels;


        public Inventory()
        {
            InventoryLevels = new Dictionary<int, ProductInfo>()
            {
                {ProductInfo.COLAID, new ProductInfo(ProductInfo.COLASTOCK, ProductInfo.COLAPRICE) },
                {ProductInfo.CHIPID, new ProductInfo(ProductInfo.CHIPSTOCK, ProductInfo.CHIPPRICE) },
                {ProductInfo.CANDYID, new ProductInfo(ProductInfo.CANDYSTOCK, ProductInfo.CANDYPRICE) }
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
            return (InventoryLevels[productID].Price <= moneyDeposited);
        }
    }
}
