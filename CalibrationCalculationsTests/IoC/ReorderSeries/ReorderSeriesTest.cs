using CalibrationCalculations.IoC.ReorderSeries;
using CalibrationCalculations.Models;
using CalibrationCalculations.Common;

namespace CalibrationCalculationsTests.IoC.ReorderSeries;

[TestClass]
public class ReorderSeriesTest
{
    [TestMethod]
    public void ReorderByNominalForceAscending_ValidInput_ReturnsValuesInExpectedOrder()
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
    public void ReorderByNominalForceDescending_ValidInput_ReturnsValuesInExpectedOrder()
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

    [TestMethod]
    public void ReorderByOrderTagAscending_NullOrderTag_ThrowsException()
    {
        // Arrange
        List<IMeasurementPoint> measurementPoints =
        [
            new NominalMeasurementPoint(10, 0.00000, null),
            new NominalMeasurementPoint(20, 0.00012, 1)
        ];

        // Assert.
        IReorderSeries reorderSeries = ReorderFactory.Create(ReorderTypes.OrderTagAscending);
        
        // Act and Assert
        var exception = Assert.ThrowsException<ArgumentException>(() => reorderSeries.Reorder(measurementPoints));
    }

    [TestMethod]
    public void ReorderByOrderTagAscending_ValidInput_ReturnsValuesInExpectedOrder()
    {
        // Arrange
        List<IMeasurementPoint> measurementPoints =
        [
            new NominalMeasurementPoint(10, 0.3, 10),
            new NominalMeasurementPoint(20, 0.2, 5),
            new NominalMeasurementPoint(20, 0.1, 1)
        ];

        // Act
        IReorderSeries reorderSeries = ReorderFactory.Create(ReorderTypes.OrderTagAscending);
        List<IMeasurementPoint>? reorderedPoints = reorderSeries.Reorder(measurementPoints);

        // Assert
        Assert.IsNotNull(reorderedPoints);
        Assert.AreEqual(0.1, reorderedPoints[0].Value);
        Assert.AreEqual(0.2, reorderedPoints[1].Value);
        Assert.AreEqual(0.3, reorderedPoints[2].Value);
    }

    [TestMethod]
    public void ReorderByOrderTagDescending_NullOrderTag_ThrowsException()
    {
        // Arrange
        List<IMeasurementPoint> measurementPoints =
        [
            new NominalMeasurementPoint(10, 0.00000, null),
            new NominalMeasurementPoint(20, 0.00012, 1)
        ];

        // Assert.
        IReorderSeries reorderSeries = ReorderFactory.Create(ReorderTypes.OrderTagDescending);

        // Act and Assert
        var exception = Assert.ThrowsException<ArgumentException>(() => reorderSeries.Reorder(measurementPoints));
    }

    [TestMethod]
    public void ReorderByOrderTagDescending_ValidInput_ReturnsValuesInExpectedOrder()
    {
        // Arrange
        List<IMeasurementPoint> measurementPoints =
        [
            new NominalMeasurementPoint(10, 0.2, 4),
            new NominalMeasurementPoint(20, 0.1, 20),
            new NominalMeasurementPoint(20, 0.3, 1)
        ];

        // Act
        IReorderSeries reorderSeries = ReorderFactory.Create(ReorderTypes.OrderTagDescending);
        List<IMeasurementPoint>? reorderedPoints = reorderSeries.Reorder(measurementPoints);

        // Assert
        Assert.IsNotNull(reorderedPoints);
        Assert.AreEqual(0.1, reorderedPoints[0].Value);
        Assert.AreEqual(0.2, reorderedPoints[1].Value);
        Assert.AreEqual(0.3, reorderedPoints[2].Value);
    }
}
