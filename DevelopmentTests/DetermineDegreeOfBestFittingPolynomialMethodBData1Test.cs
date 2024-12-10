using CertificateGeneration.Models;
using CertificateGeneration.IoC.Modifiers;
using CertificateGeneration.CertificateCalculations.Interpolation;
using CertificateGeneration.IoC.DataTransforms;
using CertificateGeneration.CertificateCalculations.DegreeOfBestFit;
using DevelopmentTests.TestData.MethodBTestData1;

namespace DevelopmentTests
{

    [TestClass]
    public class DetermineDegreeOfBestFittingPolynomialMethodBData1Test
    {
        [TestMethod]
        public void DetermineDegreeOfBestFittingPolynomial_ValidInput_ReturnsExpectedInterpolatedValues()
        {
            // Arrange
            double[] appliedForce = MethodBNistTestData1.GetAppliedForce();
            double[] actualForce1 = MethodBNistTestData1.GetAppliedForce();
            double[] actualForce2 = MethodBNistTestData1.GetAppliedForce();
            double[] actualForce3 = MethodBNistTestData1.GetAppliedForce();

            // TODO need to have actual force values for each series
            MeasurementSeries series1 = MeasurementSeries.CreateSeries(1, appliedForce, actualForce1, MethodBNistTestData1.GetRawDataSeries1());
            MeasurementSeries series2 = MeasurementSeries.CreateSeries(2, appliedForce, actualForce2, MethodBNistTestData1.GetRawDataSeries2());
            MeasurementSeries series3 = MeasurementSeries.CreateSeries(3, appliedForce, actualForce3, MethodBNistTestData1.GetRawDataSeries3());

            // Act
            IInterpolate interpolator = InterpolatorFactory.CreateInterpolator(CertificateGeneration.Common.InterpolationTypes.MethodB);
            series1.Interpolate(interpolator);
            series2.Interpolate(interpolator);
            series3.Interpolate(interpolator);

            List<int> TransientForceMeasurementsByIndex = [12];
            series1.RemoveValuesByIndex(TransientForceMeasurementsByIndex);
            series2.RemoveValuesByIndex(TransientForceMeasurementsByIndex);
            series3.RemoveValuesByIndex(TransientForceMeasurementsByIndex);

            IModifySeriesSize modifier = new RemoveZeroValueForceItems();
            series1.Modify(modifier);
            series2.Modify(modifier);
            series3.Modify(modifier);

            IReorderSeries reorder = new RereorderByAppliedForceAscending();
            series1.ReorderSeries(reorder);
            series2.ReorderSeries(reorder);
            series3.ReorderSeries(reorder);

            ITransformToDoubleArray seriesValueTransform = new SeriesValueToArray();
            int bestFit = DetermineDegreeOfBestFittingPolynomial.Calculate(series1.Transform(new AppliedForceToArray()),
                    series1.Transform(seriesValueTransform),
                    series2.Transform(seriesValueTransform),
                    series3.Transform(seriesValueTransform)
                );

            // Assert
            const int LABSCH_BEST_DEGREE_FIT = 4;
            Assert.AreEqual(LABSCH_BEST_DEGREE_FIT, bestFit);
        }
    }
}
