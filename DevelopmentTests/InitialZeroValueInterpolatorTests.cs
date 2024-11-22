using CertificateGeneration.Interpolation;
using CertificateGeneration.Models;
using CertificateGeneration.Models.Modifiers;
using DevelopmentTests.InitialZeroDataSets;

namespace DevelopmentTests
{
    /// <summary>
    /// Defines the <see cref="InitialZeroValueInterpolatorTests" />
    /// </summary>
    [Ignore]
    [TestClass]
    public class InitialZeroValueInterpolatorTests
    {
        /// <summary>
        /// The interpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues
        /// </summary>
        [TestMethod]
        public void interpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues()
        {
            // Arrange
            double[] appliedForce = MethodAInitialZeroTestData1.GetAppliedForce();
            Series series = Series.CreateSeries(1, appliedForce, MethodAInitialZeroTestData1.GetRawDataSeries1());

            // Act
            InitialZeroValueInterpolator interoplater = new InitialZeroValueInterpolator();
            interoplater.Interpolate(series);

            IModifySeriesSize removeZeroValueForceItems = new RemoveZeroValueForceItems();
            series.Modify(removeZeroValueForceItems);

            IOrderSeries orderByAppliedForceAscending = new OrderByAppliedForceAscending();
            series.Order(orderByAppliedForceAscending);

            // Assert
            Assert.AreEqual(-0.08193, series.GetValue(1));
            Assert.AreEqual(-0.40851, series.GetValue(2));
        }
    }
}
