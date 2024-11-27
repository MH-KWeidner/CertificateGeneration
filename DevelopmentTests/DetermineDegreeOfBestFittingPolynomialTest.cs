using CertificateGeneration.Models;
using CertificateGeneration.IoC.Modifiers;
using DevelopmentTests.NISTDataSets;
using CertificateGeneration.CertificateCalculations.Interpolation;
using CertificateGeneration.IoC.DataTransforms;
using CertificateGeneration.CertificateCalculations;

namespace DevelopmentTests;

[TestClass]
public class DetermineDegreeOfBestFittingPolynomialTest
{
    [Ignore]
    [TestMethod]
    public void DetermineDegreeOfBestFittingPolynomial_ValidInput_ReturnsExpectedInterpolatedValues()
    {
        // Arrange
        double[] appliedForce = MethodBNistTestData1.GetAppliedForce();
        Series series1 = Series.CreateSeries(1, appliedForce, MethodBNistTestData1.GetRawDataSeries1());
        Series series2 = Series.CreateSeries(2, appliedForce, MethodBNistTestData1.GetRawDataSeries2());
        Series series3 = Series.CreateSeries(3, appliedForce, MethodBNistTestData1.GetRawDataSeries3());

        IInterpolate interpolator = new NistInterpolator();
        series1.Interpolate(interpolator);
        series2.Interpolate(interpolator);
        series3.Interpolate(interpolator);

        // Because in LV, some data points are removed after intepolation
        // TODO: But check this
        List<int> exclusions = [11];
        series1.RemoveValuesByIndex(exclusions);
        series2.RemoveValuesByIndex(exclusions);
        series3.RemoveValuesByIndex(exclusions);

        IModifySeriesSize seriesSizeModifier = new RemoveZeroValueForceItems();
        series1.Modify(seriesSizeModifier);
        series2.Modify(seriesSizeModifier);
        series3.Modify(seriesSizeModifier);

        IOrderSeries orderSeries = new OrderByAppliedForceAscending();
        series1.Order(orderSeries);
        series2.Order(orderSeries);
        series3.Order(orderSeries);

        // Act
        ITransformToDoubleArray seriesValueTransform = new SeriesValueToArray();
        int bestFit = DetermineDegreeOfBestFittingPolynomial.Calculate(series1.Transform(new AppliedForceToArray()),
                series1.Transform(seriesValueTransform),
                series2.Transform(seriesValueTransform),
                series3.Transform(seriesValueTransform)
            );

        // Assert
        Assert.AreEqual(3, bestFit);
    }
}
