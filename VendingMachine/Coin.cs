using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineKata
{
    public class Coin
    {
        /// <summary>
        /// The following Tuple values are the diameter (cm) and weight (g) of known coins, stored respectively.
        /// </summary>
        public static readonly Tuple<double, double> PENNY = new Tuple<double, double>(19, 2.5);
        public static readonly Tuple<double, double> NICKEL = new Tuple<double, double>(21.2, 5);
        public static readonly Tuple<double, double> DIME = new Tuple<double, double>(17.9, 2.3);
        public static readonly Tuple<double, double> QUARTER = new Tuple<double, double>(24.3, 5.7);

       

        private static readonly Dictionary<Tuple<double, double>, int> VALIDCOINDICTIONARY = new Dictionary<Tuple<double, double>, int>()
        {
            {NICKEL, 5 },
            {DIME, 10},
            {QUARTER, 25 }
        };


        /// <summary>
        /// Contains a dictionary of currently deposited coins and their values. 
        /// </summary>
        public Dictionary<int, int> Coins = new Dictionary<int, int>()
        {
            {5, 0 },
            {10, 0 },
            {25, 0 }
        };

        public Coin(int numberOfNickels = 0, int numberOfDimes = 0, int numberOfQuarters = 0)
        {
            Coins[5] = numberOfNickels;
            Coins[10] = numberOfDimes;
            Coins[25] = numberOfQuarters;
        }


        public static int CoinValue(double diameter, double weight)
        {
            Tuple<double, double> coinTuple = new Tuple<double, double>(diameter, weight);
            if(VALIDCOINDICTIONARY.ContainsKey(coinTuple))
            {
                return VALIDCOINDICTIONARY[coinTuple];
            }
            return 0;
        }

        public void AddCoin(int coinValue)
        {
            Coins[coinValue]++;
        }

        
    }
}
