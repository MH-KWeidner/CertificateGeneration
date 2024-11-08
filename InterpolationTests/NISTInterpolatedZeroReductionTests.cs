using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Models;
using Interpolation;

namespace InterpolationTests
{
    [TestClass]
    public class NISTInterpolatedZeroReductionTests
    {
        [TestMethod]
        public void interpolateSeriesList_ValidInput_ReturnsExpectedInterpolatedValues()
        {
            // Arrange
            double[] appliedForce = TestData2.GetAppliedForce();
            var seriesList = new List<Series>
            {
                TestData2.GetSeries1(),
                TestData2.GetSeries2(),
                TestData2.GetSeries3()
            };

            // Act
            NISTInterpolatedZeroReduction.InterpolateSeriesList(appliedForce, seriesList);

            // Assert
            Assert.AreEqual(-0.08193, seriesList[0].GetInterpolatedValue(1));
            Assert.AreEqual(-0.40851, seriesList[0].GetInterpolatedValue(2));
        }

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
            var interpolatedValue = NISTInterpolatedZeroReduction.CalculateNISInterpolatedValue
                (
                     startZeroValue: startZeroValue,
                     endZeroValue: endZeroValue,
                     numberOfNonZeroForcePoints: numberOfNonZeroForcePoints,
                     forceReading: forceReading,
                     OneBasedSeriesPositionForNonZeroForce: OneBasedSeriesPositionOfForceReading
                );

// Assert
            Assert.AreEqual(0.0, interpolatedValue);
        }
    }
}
