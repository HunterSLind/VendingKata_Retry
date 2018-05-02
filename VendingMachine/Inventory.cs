﻿using System;
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
                {ProductInfo.COLAID, new ProductInfo(ProductInfo.COLASTOCK, ProductInfo.COLAPRICE) },
                {ProductInfo.CHIPID, new ProductInfo(ProductInfo.CHIPSTOCK, ProductInfo.CHIPPRICE) },
                {ProductInfo.CANDYID, new ProductInfo(ProductInfo.CANDYSTOCK, ProductInfo.CANDYPRICE) }
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
    }
}
