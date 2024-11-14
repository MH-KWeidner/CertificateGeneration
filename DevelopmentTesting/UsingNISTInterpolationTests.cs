using DevelopmentTesting.NISTDataSets;
using Models;
using Interpolation;

namespace DevelopmentTesting
{
    [Ignore]
    [TestClass]
    public class UsingNISTInterpolationTests
    {
        [TestMethod]
        public void interpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues()
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
            UsingNISTInterpolation.InterpolateSeries(appliedForce, seriesList);

            //seriesList[0].ZeroReduceAndSortByAppliedForceAscending();
            //seriesList[1].ZeroReduceAndSortByAppliedForceAscending();
            //seriesList[2].ZeroReduceAndSortByAppliedForceAscending();

            // Assert
            Assert.AreEqual(-0.08193, seriesList[0].GetValue(1));
            Assert.AreEqual(-0.40851, seriesList[0].GetValue(2));
        }
    }
}