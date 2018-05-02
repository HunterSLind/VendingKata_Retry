using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachineKata;

namespace VendingTests
{
    [TestClass]
    public class CoinTests
    {
        CoinBank testCoinBank;

        /// <summary>
        /// Test initialization: Creates a clean Coin Object
        /// </summary>
        [TestInitialize]
        public void testInit()
        {
            testCoinBank = new CoinBank();
        }

        /// <summary>
        /// Validates that the value of a penny should be 0 since it's an invalid coin.
        /// </summary>
        [TestMethod]
        public void ValidCoin_Penny()
        {
            Assert.AreEqual(0, CoinBank.CoinValue(CoinBank.PENNY.Item1, CoinBank.PENNY.Item2));
        }

        /// <summary>
        /// Validates that the value of a Nickels dimensions should be 5.
        /// </summary>
        [TestMethod]
        public void ValidCoin_Nickel()
        {
            Assert.AreEqual(5, CoinBank.CoinValue(CoinBank.NICKEL.Item1, CoinBank.NICKEL.Item2));
        }

        /// <summary>
        /// Validates that the value of a Dimes dimensions should be 10.
        /// </summary>
        [TestMethod]
        public void ValidCoin_Dime()
        {
            Assert.AreEqual(10, CoinBank.CoinValue(CoinBank.DIME.Item1, CoinBank.DIME.Item2));
        }

        /// <summary>
        /// Validates that the value of a Quarters dimensions should be 25.
        /// </summary>
        [TestMethod]
        public void ValidCoin_Quarter()
        {
            Assert.AreEqual(25, CoinBank.CoinValue(CoinBank.QUARTER.Item1, CoinBank.QUARTER.Item2));
        }

        [TestMethod]
        public void AddCoin()
        {
            int originalCount = testCoinBank.Coins[5];
            testCoinBank.AddCoin(5);
            Assert.AreEqual(originalCount + 1, testCoinBank.Coins[5]);
        }

        [TestMethod]
        public void AbleToMakeChange_NoChange()
        {
            Assert.IsTrue(testCoinBank.AbleToMakeChange(0));
        }

        [TestMethod]
        public void AbleToMakeChange_25NoQuarters()
        {
            testCoinBank = new CoinBank(20, 10);
            Assert.IsTrue(testCoinBank.AbleToMakeChange(25));
        }
        
        [TestMethod]
        public void AbleToMakeChange_Unable()
        {
            testCoinBank = new CoinBank(4);
            Assert.IsFalse(testCoinBank.AbleToMakeChange(25));
        }

        [TestMethod]
        public void MakeChange_NoChange()
        {
            Dictionary<int, int> expectedResultDictionary = new Dictionary<int, int>()
            {
                {5, 0 },
                {10, 0 },
                {25, 0 }
            };
            Dictionary<int, int> actualResultDictionary = testCoinBank.MakeChange(0);

            Assert.AreEqual(expectedResultDictionary[5], actualResultDictionary[5]);
            Assert.AreEqual(expectedResultDictionary[10], actualResultDictionary[10]);
            Assert.AreEqual(expectedResultDictionary[25], actualResultDictionary[25]);
        }

        [TestMethod]
        public void MakeChange_25()
        {
            testCoinBank = new CoinBank(0, 0, 1);
            Dictionary<int, int> expectedResultDictionary = new Dictionary<int, int>()
            {
                {5, 0 },
                {10, 0 },
                {25, 1 }
            };
            Dictionary<int, int> actualResultDictionary = testCoinBank.MakeChange(25);

            Assert.AreEqual(expectedResultDictionary[5], actualResultDictionary[5]);
            Assert.AreEqual(expectedResultDictionary[10], actualResultDictionary[10]);
            Assert.AreEqual(expectedResultDictionary[25], actualResultDictionary[25]);
        }

        public void WithdrawChange()
        {
            // Make sure that when we call Withdraw Change, change is removed from the bank.
        }
    }
}
