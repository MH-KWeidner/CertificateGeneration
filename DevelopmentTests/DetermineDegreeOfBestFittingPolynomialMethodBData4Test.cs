using CalibrationCalculations.IoC.ModifySeriesSize;
using CalibrationCalculations.IoC.ReorderSeries;
using CalibrationCalculations.Models;
using CalibrationCalculations.StandardCalculations.DegreeOfBestFit;
using CalibrationCalculations.StandardCalculations.Interpolation;
using DevelopmentTests.TestData.MethodBTestData4;
using CalibrationCalculations.IoC.TransformMeasurementPoints;

namespace DevelopmentTests
{
    /// <summary>
    /// Defines the <see cref="DetermineDegreeOfBestFittingPolynomialMethodBData4Test" />
    /// </summary>
    [TestClass]
    public class DetermineDegreeOfBestFittingPolynomialMethodBData4Test
    {
        /// <summary>
        /// The DetermineDegreeOfBestFittingPolynomial_ValidInput_ReturnsExpectedInterpolatedValues
        /// </summary>
        [TestMethod]
        public void DetermineDegreeOfBestFittingPolynomial_ValidInput_ReturnsExpectedInterpolatedValues()
        {
            // Arrange
            double[] appliedForce = MethodBNistTestData4.GetAppliedForce();
            MeasurementSeries series1 = MeasurementSeries.Create(1, appliedForce, MethodBNistTestData4.GetRawDataSeries1());
            MeasurementSeries series2 = MeasurementSeries.Create(2, appliedForce, MethodBNistTestData4.GetRawDataSeries2());
            MeasurementSeries series3 = MeasurementSeries.Create(3, appliedForce, MethodBNistTestData4.GetRawDataSeries3());

            // Act
            IInterpolate interpolator = InterpolatorFactory.Create(CalibrationCalculations.Common.InterpolationTypes.MethodB);
            MeasurementSeries.Interpolate(interpolator, series1);
            MeasurementSeries.Interpolate(interpolator, series2);
            MeasurementSeries.Interpolate(interpolator, series3);

            IModifySeriesSize modifier = new RemoveZeroValueForceItems();
            series1.Modify(modifier);
            series2.Modify(modifier);
            series3.Modify(modifier);

            IReorderSeries reorder = new ReorderByNominalForceAscending();
            series1.ReorderSeries(reorder);
            series2.ReorderSeries(reorder);
            series3.ReorderSeries(reorder);

            ITransformMeasurementPointsToArray seriesValueTransform = new MeasurementValuesToArray();
            int bestFit = DetermineDegreeOfBestFittingPolynomial.Calculate(series1.Transform(new NominalAppliedForcesToArray()),
                    series1.Transform(seriesValueTransform),
                    series2.Transform(seriesValueTransform),
                    series3.Transform(seriesValueTransform)
                );

            // Assert
            const int LABSCH_BEST_DEGREE_FIT = 2;
            Assert.AreEqual(LABSCH_BEST_DEGREE_FIT, bestFit);
        }
    }
}
