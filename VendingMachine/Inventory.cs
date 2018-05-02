using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineKata
{
    public class Inventory
    {

        public Dictionary<int, ProductInfo> InventoryInfo;

        

        public Inventory()
        {
            InventoryInfo = new Dictionary<int, ProductInfo>()
            {
                {ProductInfo.DEFAULTCOLAID, new ProductInfo(ProductInfo.DEFAULTCOLASTOCK, ProductInfo.DEFAULTCOLAPRICE) },
                {ProductInfo.DEFAULTCHIPID, new ProductInfo(ProductInfo.DEFAULTCHIPSTOCK, ProductInfo.DEFAULTCHIPPRICE) },
                {ProductInfo.DEFAULTCANDYID, new ProductInfo(ProductInfo.DEFAULTCANDYSTOCK, ProductInfo.DEFAULTCANDYPRICE) }
            };
        }


        public Inventory(Dictionary<int, ProductInfo> inventoryDictionary)
        {
            InventoryInfo = inventoryDictionary;
        }

        public bool IsProductInStock(int productID)
        {
            return (InventoryInfo[productID].Stock > 0);
        }

        public bool IsEnoughMoneyForProduct(int productID, int moneyDeposited)
        {
            return (InventoryInfo[productID].Price <= moneyDeposited);
        }

        public int CalculateChange(int productID, int moneyDeposited)
        {
            return moneyDeposited - InventoryInfo[productID].Price;
        }

        public void Withdraw(int productID)
        {
            InventoryInfo[productID].Stock -= 1;
        }
    }
}
