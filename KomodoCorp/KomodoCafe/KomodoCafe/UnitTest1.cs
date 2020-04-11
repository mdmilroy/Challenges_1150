using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomodoCafe
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            MenuRepo menu = new MenuRepo();
            List<Menu> currentItems = new List<Menu>();

            // Act
            Menu menu1 = new Menu(1, "cheeseburger", "burger with fries and drink", "bun, beef, pickles, cheese", 4.99);
            currentItems.Add(menu1);

            // Assert
            int actual = currentItems.Count();
            Assert.AreEqual(1, actual);
        }
    }
}
