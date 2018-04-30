using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineKata
{
    public class VendingMachine
    {
        private int moneyInMachine = 0;

        public int AcceptCoin(double diameter, double weight)
        {
            if(Coin.isValidCoin(diameter, weight))
            {
                // if coin is accepted, add to amount.
                return 1;
            }
            // if coin is not accepted, don't add to amount
            return 0;
        }

        public int SelectProduct()
        {
            return 0;
        }
    }
}
