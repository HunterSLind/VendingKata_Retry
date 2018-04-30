using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachineKata;

namespace VendingTests
{
    [TestClass]
    public class VendingTests
    {
        VendingMachine thisMachine;

        /// <summary>
        /// Test initialization: Creates a clean VendingMachine Object
        /// </summary>
        [TestInitialize]
        public void testInit()
        {
            thisMachine = new VendingMachine();
        }
        [TestMethod]
        public void DeclineCoin_Penny()
        {
            Assert.AreEqual(0, thisMachine.AcceptCoin(Coin.PENNY.Item1, Coin.PENNY.Item2));
        }

        [TestMethod]
        public void AcceptCoin_Nickel()
        {
            Assert.AreEqual(1, thisMachine.AcceptCoin(Coin.NICKEL.Item1, Coin.NICKEL.Item2));
        }

        //[TestMethod]
        //public void AcceptCoin_Dime()
        //{
        //    Assert.AreEqual(1, thisMachine.AcceptCoin());
        //}

        //[TestMethod]
        //public void AcceptCoin_Quarter()
        //{
        //    Assert.AreEqual(1, thisMachine.AcceptCoin());
        //}

        //[TestMethod]
        //public void DeclineCoin_BadCoin()
        //{
        //    Assert.AreEqual(1, thisMachine.AcceptCoin());
        //}


        //[TestMethod]
        //public void SelectProduct_Chips()
        //{
        //    Assert.AreEqual(1, thisMachine.SelectProduct());
        //}

        //[TestMethod]
        //public void SelectProduct_Cola()
        //{
        //    Assert.AreEqual(1, thisMachine.SelectProduct());
        //}

        //[TestMethod]
        //public void SelectProduct_Candy()
        //{
        //    Assert.AreEqual(1, thisMachine.SelectProduct());
        //}

        [TestMethod]
        public void MakeChange()
        {
            
        }
        

        
    }
}
