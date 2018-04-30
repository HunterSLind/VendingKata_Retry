using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineKata
{
    public class VendingMachine
    {
        public int AcceptCoin(double diameter, double weight)
        {
            if(Coin.isValidCoin(diameter, weight))
            {
                return 1;
            }
            return 0;
        }

        public int SelectProduct()
        {
            return 0;
        }
    }
}
