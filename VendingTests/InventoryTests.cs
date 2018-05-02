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
            Assert.IsTrue(thisInventory.IsProductInStock(ProductInfo.DEFAULTCOLAID));
        }

        [TestMethod]
        public void IsProductInStock_Chips()
        {
            Assert.IsTrue(thisInventory.IsProductInStock(ProductInfo.DEFAULTCHIPID));
        }

        [TestMethod]
        public void IsProductInStock_Candy()
        {
            Assert.IsTrue(thisInventory.IsProductInStock(ProductInfo.DEFAULTCANDYID));
        }

        [TestMethod]
        public void IsProductOutOfStock()
        {
            thisInventory = new Inventory(new Dictionary<int, ProductInfo>()
            {
                {1, new ProductInfo(0, 0) }
            });
            Assert.IsFalse(thisInventory.IsProductInStock(1));
        }

        [TestMethod]
        public void IsEnoughMoneyForProduct()
        {
            Assert.IsTrue(thisInventory.IsEnoughMoneyForProduct(ProductInfo.DEFAULTCOLAID, ProductInfo.DEFAULTCOLAPRICE));
        }

        [TestMethod]
        public void CalculateChange_NoChange()
        {
            Assert.AreEqual(0, thisInventory.CalculateChange(ProductInfo.DEFAULTCOLAID, ProductInfo.DEFAULTCOLAPRICE));
        }

        [TestMethod]
        public void CalculateChange_SomeChange()
        {
            Assert.AreEqual(10, thisInventory.CalculateChange(ProductInfo.DEFAULTCOLAID, (ProductInfo.DEFAULTCOLAPRICE + 10)));
        }

        [TestMethod]
        public void UpdateProductStock()
        {
            int baseStock = thisInventory.InventoryInfo[ProductInfo.DEFAULTCOLAID].Stock;
            thisInventory.Withdraw(ProductInfo.DEFAULTCOLAID);
            Assert.AreEqual(baseStock - 1, thisInventory.InventoryInfo[ProductInfo.DEFAULTCOLAID].Stock);
        }
    }
}
