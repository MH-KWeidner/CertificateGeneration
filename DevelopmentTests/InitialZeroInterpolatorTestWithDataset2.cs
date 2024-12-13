using DevelopmentTests.InitialZeroDataSets;
using MathNet.Numerics;
using CalibrationCalculations.IoC.Modifiers;
using CalibrationCalculations.Models;
using CalibrationCalculations.StandardCalculations.Interpolation;

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
        MeasurementSeries.Interpolate(interpolator, series3);
        MeasurementSeries.Interpolate(interpolator, series4);
        MeasurementSeries.Interpolate(interpolator, series5);
        MeasurementSeries.Interpolate(interpolator, series6);

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
