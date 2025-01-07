using CalibrationCalculations.Factories.ModifyMeasurementSeriesSize;
using CalibrationCalculations.Factories.ReorderMeasurementSeries;
using CalibrationCalculations.Models;
using CalibrationCalculations.StandardCalculations.Interpolation;
using CalibrationCalculationsCertificateTests.LabScheduleTestData.LS01_MethodB_Cert_U7989G0124;
using static CalibrationCalculationsCertificateTests.LabScheduleModels.LabAnalysisSingleRunResult;

namespace CalibrationCalculationsCertificateTests
{
    /// <summary>
    /// Defines the <see cref="NistInterpolatorTestWithDataset1" />
    /// </summary>
    [TestClass]
    public class NistInterpolatorTestWithDataset1
    {
        /// <summary>
        /// The InterpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues
        /// </summary>
        [TestMethod]
        public void InterpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues()
        {
            // Arrange
            ILabScheduleRawInput rawInput = new LS01_RawInput();
            double[] appliedForce = rawInput.NominalForcesApplied;
            MeasurementSeries series1 = MeasurementSeries.Create(1, appliedForce, rawInput.MeasurementData[0]);
            MeasurementSeries series2 = MeasurementSeries.Create(2, appliedForce, rawInput.MeasurementData[1]);
            MeasurementSeries series3 = MeasurementSeries.Create(3, appliedForce, rawInput.MeasurementData[2]);

            // Act
            IInterpolate interpolator = InterpolatorFactory.Create(CalibrationCalculations.Common.InterpolationTypes.MethodB);
            MeasurementSeries.Interpolate(interpolator, series1);
            MeasurementSeries.Interpolate(interpolator, series2);
            MeasurementSeries.Interpolate(interpolator, series3);

            List<int> TransientForceMeasurementsByIndex = [12];
            series1.RemoveValuesByIndex(TransientForceMeasurementsByIndex);
            series2.RemoveValuesByIndex(TransientForceMeasurementsByIndex);
            series3.RemoveValuesByIndex(TransientForceMeasurementsByIndex);

            IModifyMeasurementSeriesSize modifier = new RemoveZeroValuedNominalForces();
            series1.Modify(modifier);
            series2.Modify(modifier);
            series3.Modify(modifier);

            IReorderMeasurementSeries reorder = new ReorderByNominalForceAscending();
            series1.ReorderSeries(reorder);
            series2.ReorderSeries(reorder);
            series3.ReorderSeries(reorder);

            List<LabAnalysisSingleRunResult> labSchResult = new LS01_ResultsData().LabScheduleRunResults;
            List<SingleRunPoint> LabSchedulePointsSeries1 = labSchResult[0].Runs[0].NormalizedData;
            List<SingleRunPoint> LabSchedulePointsSeries2 = labSchResult[0].Runs[1].NormalizedData;
            List<SingleRunPoint> LabSchedulePointsSeries3 = labSchResult[0].Runs[2].NormalizedData;

            // Assert
            Assert.AreEqual(series1.Count(), LabSchedulePointsSeries1.Count);
            Assert.AreEqual(series2.Count(), LabSchedulePointsSeries2.Count);
            Assert.AreEqual(series3.Count(), LabSchedulePointsSeries3.Count);

            const int ROUNDING_DIGITS = 8;

            for (int i = 0; i < series1.Count(); i++)
                Assert.AreEqual(Math.Round(series1.GetValue(i), ROUNDING_DIGITS), (double)LabSchedulePointsSeries1[i].Value);

            for (int i = 0; i < series2.Count(); i++)
                Assert.AreEqual(Math.Round(series2.GetValue(i), ROUNDING_DIGITS), (double)LabSchedulePointsSeries2[i].Value);

            for (int i = 0; i < series3.Count(); i++)
                Assert.AreEqual(Math.Round(series3.GetValue(i), ROUNDING_DIGITS), (double)LabSchedulePointsSeries3[i].Value);
        }
    }
}
