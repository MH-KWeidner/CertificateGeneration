using Interpolation;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interpolation;

namespace DevelopmentTesting.NISTDataSets
{
    [TestClass]
    public class UsingInitialZeroValueTests
    {
        [TestMethod]
        public void InterpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues()
        {
            // Arrange
            Series series = Series.CreateSeries(1, [ 0, 10, 20 ], [ 0.00000, 0.00012, 0.00022 ]);


            // Act
            Interpolation.UsingInitialZeroValue.InterpolateSeriesInstance(series);

            // Assert
            Assert.AreEqual(0.00012, series.GetValue(1));
            Assert.AreEqual(0.00022, series.GetValue(2));
        }

        [TestMethod]
        public void interpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues2()
        {
            // Arrange
            Series series = Series.CreateSeries(1, [0, 10, 20], [0.00000, -0.00012, 0.00022]);


            // Act
            Interpolation.UsingInitialZeroValue.InterpolateSeriesInstance(series);

            // Assert
            Assert.AreEqual(-0.00012, series.GetValue(1));
            Assert.AreEqual(0.00022, series.GetValue(2));
        }

        [TestMethod]
        public void interpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues3()
        {
            // Arrange
            Series series = Series.CreateSeries(1, [0, 10, 20], [-0.00001, -0.00012, 0.00022]);


            // Act
            Interpolation.UsingInitialZeroValue.InterpolateSeriesInstance(series);

            // Assert
            Assert.AreEqual(-0.00011, series.GetValue(1));
            Assert.AreEqual(0.00023, series.GetValue(2));
        }

        [TestMethod]
        public void interpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues4()
        {
            // Arrange
            Series series = Series.CreateSeries(1, [0, 10, 0, 20], [-0.00001, -0.00012, 0.00002, -.00022]);

            // Act
            Interpolation.UsingInitialZeroValue.InterpolateSeriesInstance(series);

            // Assert
            Assert.AreEqual(-0.00011, series.GetValue(1));
            Assert.AreEqual(-0.00024, series.GetValue(3));
        }      
    }
}
