using CertificateGeneration.Models;
using CertificateGeneration.CertificateCalculations.Interpolation;

namespace CertificateGenerationTests.InterpolationTests
{
    /// <summary>
    /// Defines the <see cref="InitialZeroValueInterpolatorTests" />
    /// </summary>
    [TestClass]
    public class InitialZeroValueInterpolatorTests
    {
        /// <summary>
        /// The InterpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues
        /// </summary>
        [TestMethod]
        public void InterpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues()
        {
            // Arrange
            Series series = Series.CreateSeries(1, [0, 10, 20], [0.00000, 0.00012, 0.00022]);

            // Act
            InitialZeroValueInterpolator usingInitialZeroValue = new InitialZeroValueInterpolator();
            usingInitialZeroValue.Interpolate(series);

            // Assert
            Assert.AreEqual(0.00012, series.GetValue(1));
            Assert.AreEqual(0.00022, series.GetValue(2));
        }

        /// <summary>
        /// The interpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues2
        /// </summary>
        [TestMethod]
        public void interpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues2()
        {
            // Arrange
            Series series = Series.CreateSeries(1, [0, 10, 20], [0.00000, -0.00012, 0.00022]);

            // Act
            InitialZeroValueInterpolator usingInitialZeroValue = new InitialZeroValueInterpolator();
            usingInitialZeroValue.Interpolate(series);

            // Assert
            Assert.AreEqual(-0.00012, series.GetValue(1));
            Assert.AreEqual(0.00022, series.GetValue(2));
        }

        /// <summary>
        /// The interpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues3
        /// </summary>
        [TestMethod]
        public void interpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues3()
        {
            // Arrange
            Series series = Series.CreateSeries(1, [0, 10, 20], [-0.00001, -0.00012, 0.00022]);

            // Act
            InitialZeroValueInterpolator usingInitialZeroValue = new InitialZeroValueInterpolator();
            usingInitialZeroValue.Interpolate(series);

            // Assert
            Assert.AreEqual(-0.00011, series.GetValue(1));
            Assert.AreEqual(0.00023, series.GetValue(2));
        }

        /// <summary>
        /// The interpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues4
        /// </summary>
        [TestMethod]
        public void interpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues4()
        {
            // Arrange
            Series series = Series.CreateSeries(1, [0, 10, 0, 20], [-0.00001, -0.00012, 0.00002, -.00022]);

            // Act
            InitialZeroValueInterpolator usingInitialZeroValue = new InitialZeroValueInterpolator();
            usingInitialZeroValue.Interpolate(series);

            // Assert
            Assert.AreEqual(-0.00011, series.GetValue(1));
            Assert.AreEqual(-0.00024, series.GetValue(3));
        }
    }
}
