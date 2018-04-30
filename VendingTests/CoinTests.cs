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
        public void ValidCoin()
        {
            Assert.AreEqual(0, 1);
        }
    }
}
