using CertificateGeneration.Models;
using CertificateGeneration.IoC.Modifiers;
using CertificateGeneration.CertificateCalculations.Interpolation;
using CertificateGeneration.IoC.DataTransforms;
using CertificateGeneration.CertificateCalculations.DegreeOfBestFit;
using DevelopmentTests.TestData.MethodBTestData4;

namespace DevelopmentTests
{
    [TestClass]
    public class DetermineDegreeOfBestFittingPolynomialMethodBData4Test
    {
        [TestMethod]
        public void DetermineDegreeOfBestFittingPolynomial_ValidInput_ReturnsExpectedInterpolatedValues()
        {
            // Arrange
            double[] appliedForce = MethodBNistTestData4.GetAppliedForce();
            MeasurementSeries series1 = MeasurementSeries.CreateSeries(1, appliedForce, MethodBNistTestData4.GetRawDataSeries1());
            MeasurementSeries series2 = MeasurementSeries.CreateSeries(2, appliedForce, MethodBNistTestData4.GetRawDataSeries2());
            MeasurementSeries series3 = MeasurementSeries.CreateSeries(3, appliedForce, MethodBNistTestData4.GetRawDataSeries3());

            // Act
            IInterpolate interpolator = InterpolatorFactory.CreateInterpolator(CertificateGeneration.Common.InterpolationTypes.MethodB);
            series1.Interpolate(interpolator);
            series2.Interpolate(interpolator);
            series3.Interpolate(interpolator);

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
            const int LABSCH_BEST_DEGREE_FIT = 2;
            Assert.AreEqual(LABSCH_BEST_DEGREE_FIT, bestFit);
        }
    }
}