using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            // Arrange
            var soruce = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            // Act
            var actual = soruce.InsertSpaces();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesWithExtraSpacesTestValid()
        {
            // Arrange
            var soruce = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            // Act
            var actual = soruce.InsertSpaces();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
