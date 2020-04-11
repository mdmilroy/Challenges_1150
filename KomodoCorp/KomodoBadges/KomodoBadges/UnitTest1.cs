using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomodoBadges
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateShouldAddItem()
        {
            // Assign
            BadgesRepo _badges = new BadgesRepo();
            List<string> _accessDoors = new List<string>();
            Dictionary<int, List<string>> _allBadges = new Dictionary<int, List<string>>();

            // Act
            _accessDoors.Add("A4");
            _accessDoors.Add("B1");
            _accessDoors.Add("C6");
            _accessDoors.Add("C7");
            Badges newBadge = new Badges(1234, _accessDoors);
            _allBadges.Add(newBadge.badgeID, newBadge.badgeAccess);

            // Assert
            int expectedBadges = 1;
            int actualBadges = _allBadges.Count;
            int expectedDoors = 4;
            int actualDoors = _accessDoors.Count;
            int actual = newBadge.badgeAccess.Count;

            Assert.AreEqual(expectedBadges, actualBadges);
            Assert.AreEqual(expectedDoors, actualDoors);
            Assert.AreEqual(expectedDoors, actual);
        }

    }
}
