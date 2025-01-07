using CalibrationCalculations.Factories.ModifyMeasurementSeriesSize;
using CalibrationCalculations.Factories.ReorderMeasurementSeries;
using CalibrationCalculations.Factories.TransformMeasurementPoints;
using CalibrationCalculations.Models;
using CalibrationCalculations.StandardCalculations.DegreeOfBestFit;
using CalibrationCalculations.StandardCalculations.Interpolation;
using CalibrationCalculationsCertificateTests.LabScheduleModels;
using CalibrationCalculationsCertificateTests.LabScheduleTestData.LS04_MethodB_Cert_10245NEGJ3024;


namespace CalibrationCalculationsCertificateTests
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
            ILabScheduleRawInput rawInput = new LS04_RawInput();
            double[] appliedForce = rawInput.NominalForcesApplied;
            MeasurementSeries series1 = MeasurementSeries.Create(1, appliedForce, rawInput.MeasurementData[0]);
            MeasurementSeries series2 = MeasurementSeries.Create(2, appliedForce, rawInput.MeasurementData[1]);
            MeasurementSeries series3 = MeasurementSeries.Create(3, appliedForce, rawInput.MeasurementData[2]);

            // Act
            IInterpolate interpolator = InterpolatorFactory.Create(CalibrationCalculations.Common.InterpolationTypes.MethodB);
            MeasurementSeries.Interpolate(interpolator, series1);
            MeasurementSeries.Interpolate(interpolator, series2);
            MeasurementSeries.Interpolate(interpolator, series3);

            IModifyMeasurementSeriesSize modifier = new RemoveZeroValuedNominalForces();
            series1.Modify(modifier);
            series2.Modify(modifier);
            series3.Modify(modifier);

            IReorderMeasurementSeries reorder = new ReorderByNominalForceAscending();
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
