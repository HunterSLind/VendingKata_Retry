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
            thisMachine.AcceptCoin(Coin.PENNY.Item1, Coin.PENNY.Item2);
            Assert.AreEqual(0, thisMachine.InsertedAmount);
        }

        [TestMethod]
        public void AcceptValidCoin()
        {
            thisMachine.AcceptCoin(Coin.NICKEL.Item1, Coin.NICKEL.Item2);
            Assert.AreEqual(5, thisMachine.InsertedAmount);
        }

        [TestMethod]
        public void DispenseProduct_Yes()
        {
            thisMachine.AcceptCoin(Coin.QUARTER.Item1, Coin.QUARTER.Item2);
            thisMachine.AcceptCoin(Coin.QUARTER.Item1, Coin.QUARTER.Item2);
            thisMachine.AcceptCoin(Coin.QUARTER.Item1, Coin.QUARTER.Item2);
            thisMachine.AcceptCoin(Coin.QUARTER.Item1, Coin.QUARTER.Item2);

            Assert.IsTrue(thisMachine.DispenseProduct(ProductInfo.COLAID));
        }

        [TestMethod]
        public void DispenseProduct_No()
        {
            thisMachine.AcceptCoin(Coin.QUARTER.Item1, Coin.QUARTER.Item2);
            thisMachine.AcceptCoin(Coin.QUARTER.Item1, Coin.QUARTER.Item2);
            thisMachine.AcceptCoin(Coin.QUARTER.Item1, Coin.QUARTER.Item2);

            Assert.IsFalse(thisMachine.DispenseProduct(ProductInfo.COLAID));
        }

        [TestMethod]
        public void DispenseProduct_No_NotEnoughMoney()
        {
            thisMachine.AcceptCoin(Coin.QUARTER.Item1, Coin.QUARTER.Item2);
            thisMachine.AcceptCoin(Coin.QUARTER.Item1, Coin.QUARTER.Item2);
            thisMachine.AcceptCoin(Coin.QUARTER.Item1, Coin.QUARTER.Item2);
            thisMachine.DispenseProduct(ProductInfo.COLAID);
            Assert.AreEqual(thisMachine.Display(), "PRICE: " + ProductInfo.COLAPRICE);
        }

        [TestMethod]
        public void DispenseProduct_No_OutOfStock()
        {
            for (int i = 0; i <= ProductInfo.COLASTOCK; i++)
            {
                thisMachine.DispenseProduct(ProductInfo.COLAID);
            }
            Assert.AreEqual(thisMachine.Display(), "SOLD OUT");
        }

        [TestMethod]
        public void DispenseProduct_No_ExactChangeOnly()
        {
            thisMachine.AcceptCoin(Coin.QUARTER.Item1, Coin.QUARTER.Item2);
            thisMachine.AcceptCoin(Coin.QUARTER.Item1, Coin.QUARTER.Item2);
            thisMachine.AcceptCoin(Coin.QUARTER.Item1, Coin.QUARTER.Item2);
            thisMachine.DispenseProduct(ProductInfo.CANDYID);
            Assert.AreEqual(thisMachine.Display(), "EXACT CHANGE ONLY");
        }

    }
}
