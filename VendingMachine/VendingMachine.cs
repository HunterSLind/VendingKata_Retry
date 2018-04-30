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

        public void AcceptCoin(double diameter, double weight)
        {
            if(Coin.isValidCoin(diameter, weight))
            {
                // if coin is accepted, add to amount.
            }
            // if coin is not accepted, don't add to amount
        }

        public int SelectProduct()
        {
            return 0;
        }
    }
}
