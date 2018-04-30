﻿using System;
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

        private static readonly Dictionary<Tuple<double, double>, int> VALIDCOINDICTIONARY = new Dictionary<Tuple<double, double>, int>()
        {
        };

        public static bool isValidCoin(double diameter, double weight)
        {
            return true;
        }
    }
}
