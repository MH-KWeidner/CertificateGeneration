using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helpers;
using Helpers.Models;

namespace Helpers.Tests
{
    [TestClass]
    public class ArrayHelperTests
    {
        [TestMethod]
        public void GetZeroValueElements_ValidInput_ReturnsZeroValueElements()
        {
            // Arrange
            const double TARGET_VALUE = 0.0;
            double[] array = {1.0, 0.0};
            

            // Act
            DoubleValueArrayElement[] result = ArrayHelper.GetElementsByValue(TARGET_VALUE, array);

            // Assert
            Assert.AreEqual(1, result.Length);
            Assert.AreEqual(1, result[0].Index);
            Assert.AreEqual(0.0, result[0].Value);
        }

        [TestMethod]
        public void GetZeroValueElements_AllZeros_ReturnsAllElements()
        {
            // Arrange
            const double TARGET_VALUE = 0.0;
            double[] array = {0.0, 0.0};

            // Act
            DoubleValueArrayElement[] result = ArrayHelper.GetElementsByValue(TARGET_VALUE, array);

            // Assert
            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(0, result[0].Index);
            Assert.AreEqual(0.0, result[0].Value);
            Assert.AreEqual(1, result[1].Index);
            Assert.AreEqual(0.0, result[0].Value);
        }

        [TestMethod]
        public void GetZeroValueElements_NoZeros_ReturnsEmptyArray()
        {
            // Arrange
            const double TARGET_VALUE = 0.0;
            double[] array = {1.0, 2.0};

            // Act
            DoubleValueArrayElement[] result = ArrayHelper.GetElementsByValue(TARGET_VALUE, array);

            // Assert
            Assert.AreEqual(0, result.Length);
        }
    }
}
