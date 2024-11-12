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
            double[] appliedForce = TestData4.GetAppliedForce();
            var seriesList = new List<Series>
            {
                Series.CreateSeries(1, appliedForce, TestData4.GetRawDataSeries1()),
                Series.CreateSeries(2, appliedForce, TestData4.GetRawDataSeries2()),
                Series.CreateSeries(3, appliedForce, TestData4.GetRawDataSeries3()),
            };

            // Act
            NISTInterpolatedZeroReduction.InterpolateSeries(appliedForce, seriesList);

            seriesList[0].ZeroReduceAndSortByAppliedForceAscending();
            seriesList[1].ZeroReduceAndSortByAppliedForceAscending();
            seriesList[2].ZeroReduceAndSortByAppliedForceAscending();

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
