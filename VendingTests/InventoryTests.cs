﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachineKata;

namespace VendingTests
{
    [TestClass]
    public class ProductTests
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
        public void SelectProduct_Cola()
        {
            Assert.AreEqual(0, thisInventory);
        }
    }
}