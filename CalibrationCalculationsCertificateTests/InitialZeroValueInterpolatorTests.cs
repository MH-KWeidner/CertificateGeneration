using CalibrationCalculations.Factories.ModifyMeasurementSeriesSize;
using CalibrationCalculations.Factories.ReorderMeasurementSeries;
using CalibrationCalculations.Models;
using CalibrationCalculations.StandardCalculations.Interpolation;
using CalibrationCalculationsCertificateTests.InitialZeroDataSets;

namespace CalibrationCalculationsCertificateTests
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
        public void InterpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues()
        {
            // Arrange
            double[] appliedForce = MethodAInitialZeroTestData1.GetAppliedForce();
            MeasurementSeries series = MeasurementSeries.Create(1, appliedForce, MethodAInitialZeroTestData1.GetRawDataSeries1());

            // Act
            InitialZeroValueInterpolator interoplater = new InitialZeroValueInterpolator();
            interoplater.Interpolate(series);

            IModifyMeasurementSeriesSize removeZeroValueForceItems = new RemoveZeroValuedNominalForces();
            series.Modify(removeZeroValueForceItems);

            IReorderMeasurementSeries reorderByAppliedForceAscending = new ReorderByNominalForceAscending();
            series.ReorderSeries(reorderByAppliedForceAscending);

            // Assert
            Assert.AreEqual(-0.08193, series.GetValue(1));
            Assert.AreEqual(-0.40851, series.GetValue(2));
        }
    }
}
