﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineKata
{
    public class VendingMachine
    {
        public int InsertedAmount = 0;
        public CoinBank MachineBank;
        public Inventory MachineInventory;

        public string displayMessage = "";

        public VendingMachine()
        {
            MachineBank = new CoinBank(0, 0, 0);
            MachineInventory = new Inventory();
        }

        /// <summary>
        /// Adds a coins value to the inserted amount.
        /// </summary>
        /// <param name="diameter"></param>
        /// <param name="weight"></param>
        public void AcceptCoin(double diameter, double weight)
        {
            if (CoinBank.CoinValue(diameter, weight) != 0)
            {
                int valueOfCoin = CoinBank.CoinValue(diameter, weight);
                updateBankAndBalance(valueOfCoin);
            }
            // if coin is not accepted, don't add to amount
        }

        private void updateBankAndBalance(int valueOfCoin)
        {
            MachineBank.AddCoin(valueOfCoin);
            // if coin is accepted, add to amount.
            InsertedAmount += valueOfCoin;
        }

        public bool DispenseProduct(int productID)
        {
            // first, check that the product is in stock
            if (MachineInventory.IsProductInStock(productID))
            {
                // then check that there is enough money in the machine for the product
                if (MachineInventory.IsEnoughMoneyForProduct(productID, InsertedAmount))
                {
                    // lastly, make sure we can make change for the purchase
                    if (MachineBank.AbleToMakeChange(MachineInventory.CalculateChange(productID, InsertedAmount)))
                    {
                        // withdraw item from inventory
                        MachineInventory.Withdraw(productID);
                        // empty inserted amount
                        InsertedAmount = 0;
                        return true;
                    }
                    // EXACT CHANGE ONLY
                    displayMessage = "EXACT CHANGE ONLY";
                    return false;
                }
                displayMessage = "PRICE: " + MachineInventory.InventoryInfo[productID].Price;
                return false;
            }
            displayMessage = "SOLD OUT";
            // SOLD OUT
            return false;
        }

        public string Display()
        {
            return displayMessage;
        }
    }
}
