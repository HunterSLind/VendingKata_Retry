using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine;

namespace VendingTests
{
    [TestClass]
    public class VendingTests
    {
        VendingMachine.VendingMachine thisMachine;

        [TestInitialize]
        public void testInit()
        {
            thisMachine = new VendingMachine.VendingMachine();
        }
        [TestMethod]
        public void DeclineCoin_Penny()
        {
            Assert.AreEqual(1, thisMachine.AcceptCoin());
        }

        [TestMethod]
        public void AcceptCoin_Nickel()
        {
            Assert.AreEqual(1, thisMachine.AcceptCoin());
        }

        [TestMethod]
        public void AcceptCoin_Dime()
        {
            Assert.AreEqual(1, thisMachine.AcceptCoin());
        }

        [TestMethod]
        public void AcceptCoin_Quarter()
        {
            Assert.AreEqual(1, thisMachine.AcceptCoin());
        }

        [TestMethod]
        public void DeclineCoin_BadCoin()
        {
            Assert.AreEqual(1, thisMachine.AcceptCoin());
        }
    }
}
