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

        /// <summary>
        /// Adds a coins value to the inserted amount.
        /// </summary>
        /// <param name="diameter"></param>
        /// <param name="weight"></param>
        public void AcceptCoin(double diameter, double weight)
        {
            if(Coin.CoinValue(diameter, weight) != 0)
            {
                // if coin is accepted, add to amount.
                InsertedAmount += Coin.CoinValue(diameter, weight);
            }
            // if coin is not accepted, don't add to amount
        }
        
    }
}
