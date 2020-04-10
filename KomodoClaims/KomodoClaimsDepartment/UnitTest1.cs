using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomodoClaimsDepartment
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            // Arrange
            ClaimsRepo repo = new ClaimsRepo();

            // Act
            Claim claim1 = new Claim(1, "car", "highway crash, no fault", 5000, new DateTime(2020, 02, 01), new DateTime(2020, 02, 05), true);
            Claim claim2 = new Claim(2, "house", "basement flooded", 500, new DateTime(2020, 01, 01), new DateTime(2020, 01, 30), true);
            Claim claim3 = new Claim(3, "car", "hit parked car", 1000, new DateTime(2020, 03, 01), new DateTime(2020, 03, 15), false);
            Claim claim4 = new Claim(4, "theft", "stolen wallet", 10, new DateTime(2019, 08, 01), new DateTime(2019, 09, 05), true);
            List<Claim> currentItems = new List<Claim>();

            currentItems.Add(claim1);
            currentItems.Add(claim2);
            currentItems.Add(claim3);
            currentItems.Add(claim4);

            // Assert
            int expected = 4;
            int actual = currentItems.Count();

            Assert.AreEqual(expected, actual);
        }
    }
}