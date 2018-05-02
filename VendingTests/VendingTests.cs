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
            thisMachine.AcceptCoin(CoinBank.PENNY.Item1, CoinBank.PENNY.Item2);
            Assert.AreEqual(0, thisMachine.InsertedAmount);
        }

        [TestMethod]
        public void AcceptValidCoin()
        {
            thisMachine.AcceptCoin(CoinBank.NICKEL.Item1, CoinBank.NICKEL.Item2);
            Assert.AreEqual(5, thisMachine.InsertedAmount);
        }

        [TestMethod]
        public void DispenseProduct_Yes()
        {
            thisMachine.AcceptCoin(CoinBank.QUARTER.Item1, CoinBank.QUARTER.Item2);
            thisMachine.AcceptCoin(CoinBank.QUARTER.Item1, CoinBank.QUARTER.Item2);
            thisMachine.AcceptCoin(CoinBank.QUARTER.Item1, CoinBank.QUARTER.Item2);
            thisMachine.AcceptCoin(CoinBank.QUARTER.Item1, CoinBank.QUARTER.Item2);

            Assert.IsTrue(thisMachine.DispenseProduct(ProductInfo.COLAID));
        }

        [TestMethod]
        public void DispenseProduct_No()
        {
            thisMachine.AcceptCoin(CoinBank.QUARTER.Item1, CoinBank.QUARTER.Item2);
            thisMachine.AcceptCoin(CoinBank.QUARTER.Item1, CoinBank.QUARTER.Item2);
            thisMachine.AcceptCoin(CoinBank.QUARTER.Item1, CoinBank.QUARTER.Item2);

            Assert.IsFalse(thisMachine.DispenseProduct(ProductInfo.COLAID));
        }

        [TestMethod]
        public void DispenseProduct_No_NotEnoughMoney()
        {
            thisMachine.AcceptCoin(CoinBank.QUARTER.Item1, CoinBank.QUARTER.Item2);
            thisMachine.AcceptCoin(CoinBank.QUARTER.Item1, CoinBank.QUARTER.Item2);
            thisMachine.AcceptCoin(CoinBank.QUARTER.Item1, CoinBank.QUARTER.Item2);
            thisMachine.DispenseProduct(ProductInfo.COLAID);
            Assert.AreEqual("PRICE: " + ProductInfo.COLAPRICE, thisMachine.Display());
        }

        [TestMethod]
        public void DispenseProduct_No_OutOfStock()
        {
            for (int i = 0; i <= ProductInfo.COLASTOCK; i++)
            {
                thisMachine.AcceptCoin(CoinBank.QUARTER.Item1, CoinBank.QUARTER.Item2);
                thisMachine.AcceptCoin(CoinBank.QUARTER.Item1, CoinBank.QUARTER.Item2);
                thisMachine.AcceptCoin(CoinBank.QUARTER.Item1, CoinBank.QUARTER.Item2);
                thisMachine.AcceptCoin(CoinBank.QUARTER.Item1, CoinBank.QUARTER.Item2);
                thisMachine.DispenseProduct(ProductInfo.COLAID);
            }
            Assert.AreEqual("SOLD OUT", thisMachine.Display());
        }

        [TestMethod]
        public void DispenseProduct_No_ExactChangeOnly()
        {
            thisMachine.AcceptCoin(CoinBank.QUARTER.Item1, CoinBank.QUARTER.Item2);
            thisMachine.AcceptCoin(CoinBank.QUARTER.Item1, CoinBank.QUARTER.Item2);
            thisMachine.AcceptCoin(CoinBank.QUARTER.Item1, CoinBank.QUARTER.Item2);
            thisMachine.DispenseProduct(ProductInfo.CANDYID);
            Assert.AreEqual("EXACT CHANGE ONLY", thisMachine.Display());
        }

    }
}
