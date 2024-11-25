using CertificateGeneration.Interpolation;
using CertificateGeneration.Models;
using CertificateGeneration.Models.Modifiers;
using DevelopmentTests.InitialZeroDataSets;

namespace DevelopmentTests;

[TestClass]
public class InitialZeroInterpolatorTestWithDataset2
{
    [TestMethod]
    public void InterpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues()
    {
        // Arrange
        double[] appliedForce = MethodAInitialZeroTestData2.GetAppliedForce();
        Series series3 = Series.CreateSeries(1, appliedForce, MethodAInitialZeroTestData2.GetRawDataSeries3());
        Series series4 = Series.CreateSeries(2, appliedForce, MethodAInitialZeroTestData2.GetRawDataSeries4());
        Series series5 = Series.CreateSeries(3, appliedForce, MethodAInitialZeroTestData2.GetRawDataSeries5());
        Series series6 = Series.CreateSeries(3, appliedForce, MethodAInitialZeroTestData2.GetRawDataSeries6());

        NistInterpolator interpolator = new();
        series3.Interpolate(interpolator);
        series4.Interpolate(interpolator);
        series5.Interpolate(interpolator);
        series6.Interpolate(interpolator);

        RemoveZeroValueForceItems removeZeroValueForceItems = new();
        series3.Modify(removeZeroValueForceItems);
        series4.Modify(removeZeroValueForceItems);
        series5.Modify(removeZeroValueForceItems);
        series6.Modify(removeZeroValueForceItems);

        OrderByAppliedForceAscending orderByAppliedForceAscending = new();
        series3.Order(orderByAppliedForceAscending);
        series4.Order(orderByAppliedForceAscending);
        series5.Order(orderByAppliedForceAscending);
        series6.Order(orderByAppliedForceAscending);
    }
}
