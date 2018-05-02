using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineKata
{
    public class VendingMachine
    {
        public int InsertedAmount = 0;
        public Coin machineBank;
        public Inventory machineInventory;

        public VendingMachine()
        {
            machineBank = new Coin(10, 10, 10);
            machineInventory = new Inventory();
        }

        /// <summary>
        /// Adds a coins value to the inserted amount.
        /// </summary>
        /// <param name="diameter"></param>
        /// <param name="weight"></param>
        public void AcceptCoin(double diameter, double weight)
        {
            if (Coin.CoinValue(diameter, weight) != 0)
            {
                // if coin is accepted, add to amount.
                InsertedAmount += Coin.CoinValue(diameter, weight);
            }
            // if coin is not accepted, don't add to amount
        }

        public bool DispenseProduct(int productID)
        {
            // first, check that the product is in stock
            if (machineInventory.IsProductInStock(productID))
            {
                // then check that there is enough money in the machine for the product
                if (machineInventory.IsEnoughMoneyForProduct(productID, InsertedAmount))
                {
                    // lastly, make sure we can make change for the purchase
                    if (machineBank.AbleToMakeChange(machineInventory.CalculateChange(productID, InsertedAmount)))
                    {
                        return true;
                    }
                    // EXACT CHANGE ONLY
                }
                // PRICE: [Item Price]
            }
            // SOLD OUT
            return false;
        }
    }
}
