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
            double[] appliedForce = TestData1.GetAppliedForce();
            var seriesList = new List<Series>
            {
                TestData1.GetSeries1()
            };

            // Act
            NISTInterpolatedZeroReduction.InterpolateSeriesList(appliedForce, seriesList);

            // Assert
            Assert.AreEqual(0.0, seriesList[0].GetInterpolatedValue(0));
            Assert.AreEqual(1.0, seriesList[0].GetInterpolatedValue(1));
            Assert.AreEqual(2.0, seriesList[0].GetInterpolatedValue(2));
            Assert.AreEqual(0.0, seriesList[0].GetInterpolatedValue(3));
            Assert.AreEqual(3.0, seriesList[0].GetInterpolatedValue(4));
            Assert.AreEqual(4.0, seriesList[0].GetInterpolatedValue(5));
            Assert.AreEqual(0.0, seriesList[0].GetInterpolatedValue(6));
        }
    }
}
