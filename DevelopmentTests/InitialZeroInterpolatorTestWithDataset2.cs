using CertificateGeneration.Models;
using DevelopmentTests.InitialZeroDataSets;
using CertificateGeneration.IoC.Modifiers;
using CertificateGeneration.CertificateCalculations.Interpolation;

namespace DevelopmentTests;

[TestClass]
public class InitialZeroInterpolatorTestWithDataset2
{
    [TestMethod]
    public void InterpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues()
    {
        // Arrange
        double[] appliedForce = MethodAInitialZeroTestData2.GetAppliedForce();
        MeasurementSeries series3 = MeasurementSeries.Create(1, appliedForce, MethodAInitialZeroTestData2.GetRawDataSeries3());
        MeasurementSeries series4 = MeasurementSeries.Create(2, appliedForce, MethodAInitialZeroTestData2.GetRawDataSeries4());
        MeasurementSeries series5 = MeasurementSeries.Create(3, appliedForce, MethodAInitialZeroTestData2.GetRawDataSeries5());
        MeasurementSeries series6 = MeasurementSeries.Create(3, appliedForce, MethodAInitialZeroTestData2.GetRawDataSeries6());

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

        RereorderByAppliedForceAscending rereorderByAppliedForceAscending = new();
        series3.ReorderSeries(rereorderByAppliedForceAscending);
        series4.ReorderSeries(rereorderByAppliedForceAscending);
        series5.ReorderSeries(rereorderByAppliedForceAscending);
        series6.ReorderSeries(rereorderByAppliedForceAscending);
    }
}
