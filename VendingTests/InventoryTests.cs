using System;
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
    }
}
