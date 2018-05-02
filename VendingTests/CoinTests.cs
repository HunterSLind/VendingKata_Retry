using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachineKata;

namespace VendingTests
{
    [TestClass]
    public class CoinTests
    {
        Coin testCoinBank;

        /// <summary>
        /// Test initialization: Creates a clean Coin Object
        /// </summary>
        [TestInitialize]
        public void testInit()
        {
            testCoinBank = new Coin();
        }

        /// <summary>
        /// Validates that the value of a penny should be 0 since it's an invalid coin.
        /// </summary>
        [TestMethod]
        public void ValidCoin_Penny()
        {
            Assert.AreEqual(0, Coin.CoinValue(Coin.PENNY.Item1, Coin.PENNY.Item2));
        }

        /// <summary>
        /// Validates that the value of a Nickels dimensions should be 5.
        /// </summary>
        [TestMethod]
        public void ValidCoin_Nickel()
        {
            Assert.AreEqual(5, Coin.CoinValue(Coin.NICKEL.Item1, Coin.NICKEL.Item2));
        }

        /// <summary>
        /// Validates that the value of a Dimes dimensions should be 10.
        /// </summary>
        [TestMethod]
        public void ValidCoin_Dime()
        {
            Assert.AreEqual(10, Coin.CoinValue(Coin.DIME.Item1, Coin.DIME.Item2));
        }

        /// <summary>
        /// Validates that the value of a Quarters dimensions should be 25.
        /// </summary>
        [TestMethod]
        public void ValidCoin_Quarter()
        {
            Assert.AreEqual(25, Coin.CoinValue(Coin.QUARTER.Item1, Coin.QUARTER.Item2));
        }

        [TestMethod]
        public void AddCoin()
        {
            int originalCount = testCoinBank.Coins[5];
            testCoinBank.AddCoin(5);
            Assert.AreEqual(originalCount + 1, testCoinBank.Coins[5]);
        }
        
        [TestMethod]
        public void MakeChange_NoChange()
        {

        }
    }
}
