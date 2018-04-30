using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachineKata;

namespace VendingTests
{
    [TestClass]
    public class CoinTests
    {
        Coin testCoin;

        /// <summary>
        /// Test initialization: Creates a clean Coin Object
        /// </summary>
        [TestInitialize]
        public void testInit()
        {
            testCoin = new Coin();
        }

        [TestMethod]
        public void ValidCoin_Penny()
        {
            Assert.AreEqual(false, Coin.isValidCoin(Coin.PENNY.Item1, Coin.PENNY.Item2));
        }

        [TestMethod]
        public void ValidCoin_Nickel()
        {
            Assert.AreEqual(true, Coin.isValidCoin(Coin.NICKEL.Item1, Coin.NICKEL.Item2));
        }
    }
}
