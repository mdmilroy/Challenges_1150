using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomodoOutings
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddOutingShouldAddNewOutingToList()
        {
            // Arrange
            OutingsRepo repo = new OutingsRepo();
            Outings outing = new Outings(TypeOfEvent.Golf, 100, DateTime.Now, 50, 5000);

            // Act
            repo.AddOuting(outing);
            int expected = 1;

            // Assert
            int actual = repo.ListAllOuting().Count;
            Assert.AreEqual(expected, actual);

        }
    }
}
