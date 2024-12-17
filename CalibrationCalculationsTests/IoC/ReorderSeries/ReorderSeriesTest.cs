using CalibrationCalculations.IoC.ReorderSeries;
using CalibrationCalculations.Models;
using CalibrationCalculations.Common;

namespace CalibrationCalculationsTests.IoC.ReorderSeries;

[TestClass]
public class ReorderSeriesTest
{
    [TestMethod]
    public void ReorderByNominalForceAscending_ValidInput_ReturnsValuesInExpectedInterpolatedValues()
    {
        // Arrange
        List<IMeasurementPoint> measurementPoints =
        [
            new NominalMeasurementPoint(20, 0.00000),
            new NominalMeasurementPoint(10, 0.00012),
            new NominalMeasurementPoint(0, 0.00022)
        ];

        // Act
        IReorderSeries reorderSeries = ReorderFactory.Create(ReorderTypes.NominalForceAscending);
        List<IMeasurementPoint>? reorderedPoints = reorderSeries.Reorder(measurementPoints);

        // Assert
        Assert.IsNotNull(reorderedPoints);
        Assert.AreEqual(0.00022, reorderedPoints[0].Value);
        Assert.AreEqual(0.00012, reorderedPoints[1].Value);
        Assert.AreEqual(0.00000, reorderedPoints[2].Value);
    }

    [TestMethod]
    public void ReorderByNominalForceDescending_ValidInput_ReturnsValuesInExpectedInterpolatedValues()
    {
        // Arrange
        List<IMeasurementPoint> measurementPoints =
        [
            new NominalMeasurementPoint(10, 0.00000),
            new NominalMeasurementPoint(20, 0.00012),
            new NominalMeasurementPoint(0, 0.00022)
        ];

        // Act
        IReorderSeries reorderSeries = ReorderFactory.Create(ReorderTypes.NominalForceDescending);
        List<IMeasurementPoint>? reorderedPoints = reorderSeries.Reorder(measurementPoints);

        // Assert
        Assert.IsNotNull(reorderedPoints);
        Assert.AreEqual(0.00012, reorderedPoints[0].Value);
        Assert.AreEqual(0.00000, reorderedPoints[1].Value);
        Assert.AreEqual(0.00022, reorderedPoints[2].Value);
    }
}
