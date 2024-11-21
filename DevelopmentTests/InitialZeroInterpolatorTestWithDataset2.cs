using CertificateGeneration.Models;
using DevelopmentTests.InitialZeroDataSets;
using CertificateGeneration.Interpolation;
using CertificateGeneration.Models.Modifiers;
using CertificateGeneration.Shared;

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

        series3.Interpolate(new NistInterpolator());
        series4.Interpolate(new NistInterpolator());
        series5.Interpolate(new NistInterpolator());
        series6.Interpolate(new NistInterpolator());

        series3.Modify(new RemoveZeroValueForceItems());
        series4.Modify(new RemoveZeroValueForceItems());
        series5.Modify(new RemoveZeroValueForceItems());
        series6.Modify(new RemoveZeroValueForceItems());

        series3.Order(new OrderByAppliedForceAscending());
        series4.Order(new OrderByAppliedForceAscending());
        series5.Order(new OrderByAppliedForceAscending());
        series6.Order(new OrderByAppliedForceAscending());
    }
}
