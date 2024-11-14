using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Models.Modifiers;
using Interpolation;

namespace DevelopmentTesting.NISTDataSets
{
    [TestClass]
    public class UsingNISTInterpollationTests
    {
        [TestMethod]
        public void calculateNISInterpolatedValue_ValidOutput_ReturnsExpectedInterpolatedValue()
        {
            // Arrange
            double startZeroValue = 0.00002;
            double endZeroValue = 0.00012;
            int numberOfNonZeroForcePoints = 11;
            double forceReading = -0.08191;
            int OneBasedSeriesPositionOfForceReading = 1;

            // Act
            var interpolatedValue = UsingNISTInterpolation.CalculateNISInterpolatedValue
                (
                     startZeroValue: startZeroValue,
                     endZeroValue: endZeroValue,
                     numberOfNonZeroForcePoints: numberOfNonZeroForcePoints,
                     forceReading: forceReading,
                     OneBasedSeriesPositionForNonZeroForce: OneBasedSeriesPositionOfForceReading
                );

            // Assert
            Assert.AreEqual(-0.08193, interpolatedValue);
        }
    }
}
