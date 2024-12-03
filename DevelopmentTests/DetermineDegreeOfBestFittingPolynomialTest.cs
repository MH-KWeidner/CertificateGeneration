using CertificateGeneration.Models;
using CertificateGeneration.IoC.Modifiers;
using DevelopmentTests.NISTDataSets;
using CertificateGeneration.CertificateCalculations.Interpolation;
using CertificateGeneration.IoC.DataTransforms;
using CertificateGeneration.CertificateCalculations.DegreeOfBestFit;

namespace DevelopmentTests;

[TestClass]
public class DetermineDegreeOfBestFittingPolynomialTest
{
    [TestMethod]
    public void DetermineDegreeOfBestFittingPolynomial_ValidInput_ReturnsExpectedInterpolatedValues()
    {
        // Arrange
        // Arrange
        double[] appliedForce = MethodBNistTestData1.GetAppliedForce();
        Series series1 = Series.CreateSeries(1, appliedForce, MethodBNistTestData1.GetRawDataSeries1());
        Series series2 = Series.CreateSeries(2, appliedForce, MethodBNistTestData1.GetRawDataSeries2());
        Series series3 = Series.CreateSeries(3, appliedForce, MethodBNistTestData1.GetRawDataSeries3());

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

        IOrderSeries reorder = new OrderByAppliedForceAscending();
        series1.Order(reorder);
        series2.Order(reorder);
        series3.Order(reorder);

        // Act
        ITransformToDoubleArray seriesValueTransform = new SeriesValueToArray();
        int bestFit = DetermineDegreeOfBestFittingPolynomial.Calculate(series1.Transform(new AppliedForceToArray()),
                series1.Transform(seriesValueTransform),
                series2.Transform(seriesValueTransform),
                series3.Transform(seriesValueTransform)
            );

        // Assert
        Assert.AreEqual(4, bestFit);
    }
}
