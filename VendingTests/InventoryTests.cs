using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachineKata;

namespace VendingTests
{
    [TestClass]
    public class InventoryTests
    {
        Inventory thisInventory;
        /// <summary>
        /// Test initialization: Creates a clean Product Object
        /// </summary>
        [TestInitialize]
        public void testInit()
        {
            thisInventory = new Inventory();
        }

        [TestMethod]
        public void IsProductInStock_Cola()
        {
            Assert.IsTrue(thisInventory.IsProductInStock(1));
        }

        [TestMethod]
        public void IsProductInStock_Chips()
        {
            Assert.IsTrue(thisInventory.IsProductInStock(2));
        }

        [TestMethod]
        public void IsProductInStock_Candy()
        {
            Assert.IsTrue(thisInventory.IsProductInStock(3));
        }

        [TestMethod]
        public void IsProductOutOfStock()
        {
            thisInventory = new Inventory(new Dictionary<int, int>()
            {
                {1, 0 }
            });
            Assert.IsFalse(thisInventory.IsProductInStock(1));
        }

        [TestMethod]
        public void IsEnoughMoneyForProduct()
        {
            Assert.IsTrue(thisInventory.IsEnoughMoneyForProduct(1, 200));
        }
    }
}
