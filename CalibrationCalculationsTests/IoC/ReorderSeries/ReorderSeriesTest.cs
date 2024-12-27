using CalibrationCalculations.Models;
using CalibrationCalculations.Common;
using CalibrationCalculations.Common.Exceptions;
using CalibrationCalculations.Factories.ReorderSeries;

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
        IReorderSeries reorderSeries = ReorderFactory.Create(MeasurementSeriesReorderTypes.NominalForceAscending);
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
        IReorderSeries reorderSeries = ReorderFactory.Create(MeasurementSeriesReorderTypes.NominalForceDescending);
        List<IMeasurementPoint>? reorderedPoints = reorderSeries.Reorder(measurementPoints);

        // Assert
        Assert.IsNotNull(reorderedPoints);
        Assert.AreEqual(0.00012, reorderedPoints[0].Value);
        Assert.AreEqual(0.00000, reorderedPoints[1].Value);
        Assert.AreEqual(0.00022, reorderedPoints[2].Value);
    }

    [TestMethod]
    public void ReorderByNominalForceDescending_NullInput_ThrowsArgumentException()
    {
        // Arrange
        IReorderSeries reorderSeries = ReorderFactory.Create(MeasurementSeriesReorderTypes.NominalForceDescending);

        // Act and Assert
        var exception = Assert.ThrowsException<ArgumentException>(() => reorderSeries.Reorder(null));
    }

    [TestMethod]
    public void ReorderByNominalForceAscending_NullInput_ThrowsArgumentException()
    {
        // Arrange
        IReorderSeries reorderSeries = ReorderFactory.Create(MeasurementSeriesReorderTypes.NominalForceAscending);

        // Act and Assert
        var exception = Assert.ThrowsException<ArgumentException>(() => reorderSeries.Reorder(null));

    }

    [TestMethod]
    public void ReorderByOrderTagAscending_InputNull_ThrowsArgumentException()
    {
        // Arrange
        IReorderSeries reorderSeries = ReorderFactory.Create(MeasurementSeriesReorderTypes.OrderTagAscending);

        // Act and Assert
        var exception = Assert.ThrowsException<ArgumentException>(() => reorderSeries.Reorder(null));
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
        IReorderSeries reorderSeries = ReorderFactory.Create(MeasurementSeriesReorderTypes.OrderTagAscending);
        
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
        IReorderSeries reorderSeries = ReorderFactory.Create(MeasurementSeriesReorderTypes.OrderTagAscending);
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
        IReorderSeries reorderSeries = ReorderFactory.Create(MeasurementSeriesReorderTypes.OrderTagDescending);

        // Act and Assert
        var exception = Assert.ThrowsException<ArgumentException>(() => reorderSeries.Reorder(measurementPoints));
    }

    [TestMethod]
    public void ReorderByOrderTagDescending_InputNull_ThrowsArgumentException()
    {
        // Arrange
        IReorderSeries reorderSeries = ReorderFactory.Create(MeasurementSeriesReorderTypes.OrderTagDescending);

        // Act and Assert
        var exception = Assert.ThrowsException<ArgumentException>(() => reorderSeries.Reorder(null));
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
        IReorderSeries reorderSeries = ReorderFactory.Create(MeasurementSeriesReorderTypes.OrderTagDescending);
        List<IMeasurementPoint>? reorderedPoints = reorderSeries.Reorder(measurementPoints);

        // Assert
        Assert.IsNotNull(reorderedPoints);
        Assert.AreEqual(0.1, reorderedPoints[0].Value);
        Assert.AreEqual(0.2, reorderedPoints[1].Value);
        Assert.AreEqual(0.3, reorderedPoints[2].Value);
    }

    [TestMethod]
    public void ReorderByDetectedNominalForceOrdering_NullInput_ThrowsException()
    {
        // Arrange.
        IReorderSeries reorderSeries = ReorderFactory.Create(MeasurementSeriesReorderTypes.DetectedNominalForceOrdering);

        // Act and Assert
        var exception = Assert.ThrowsException<ArgumentException>(() => reorderSeries.Reorder(null));
    }

    [TestMethod]
    public void ReorderByDetectedNominalForceOrdering_InputEmpyList_ReturnsEmptyList()
    {
        // Arrange
        List<IMeasurementPoint> measurementPoints = []; 

        // Act
        IReorderSeries reorderSeries = ReorderFactory.Create(MeasurementSeriesReorderTypes.DetectedNominalForceOrdering);
        List<IMeasurementPoint>? reorderedPoints = reorderSeries.Reorder(measurementPoints);

        // Assert
        Assert.IsNotNull(reorderedPoints);
        Assert.AreEqual(0, reorderedPoints.Count);
    }

    [TestMethod]
    public void ReorderByDetectedNominalForceOrdering_InputOneValue_ReturnsListWithOneValue()
    {
        // Arrange
        List<IMeasurementPoint> measurementPoints =
        [
            new NominalMeasurementPoint(0, 0.2, 4)
        ];

        // Act
        IReorderSeries reorderSeries = ReorderFactory.Create(MeasurementSeriesReorderTypes.DetectedNominalForceOrdering);
        List<IMeasurementPoint>? reorderedPoints = reorderSeries.Reorder(measurementPoints);

        // Assert
        Assert.IsNotNull(reorderedPoints);
        Assert.AreEqual(1, reorderedPoints.Count);
    }

    [TestMethod]
    public void ReorderByDetectedNominalForceOrdering_FirstNominalForceValueNotZero_ThrowsException()
    {
        // Arrange
        List<IMeasurementPoint> measurementPoints =
        [
            new NominalMeasurementPoint(10, 0.1),
            new NominalMeasurementPoint(50, 0.4),
            new NominalMeasurementPoint(0, 0.2)
        ];

        // Assert
        IReorderSeries reorderSeries = ReorderFactory.Create(MeasurementSeriesReorderTypes.DetectedNominalForceOrdering);

        // Act
        var exception = Assert.ThrowsException<InvalidMeasurementPointException>(() => reorderSeries.Reorder(measurementPoints));
    }

    [TestMethod]
    public void ReorderByDetectedNominalForceOrdering_ValidInput_ReturnsValuesInAscendingOrder()
    {
        // Arrange
        List<IMeasurementPoint> measurementPoints =
        [
            new NominalMeasurementPoint(0.0, 0.1),
            new NominalMeasurementPoint(10.0, 0.4),
            new NominalMeasurementPoint(50.0, 0.2)
        ];

        // Act
        IReorderSeries reorderSeries = ReorderFactory.Create(MeasurementSeriesReorderTypes.DetectedNominalForceOrdering);
        List<IMeasurementPoint>? reorderedPoints = reorderSeries.Reorder(measurementPoints);

        // Assert
        Assert.IsNotNull(reorderedPoints);
        Assert.AreEqual(3, reorderedPoints.Count);
        Assert.AreEqual(0.0, reorderedPoints[0].AppliedForce);
        Assert.AreEqual(10.0, reorderedPoints[1].AppliedForce);
        Assert.AreEqual(50.0, reorderedPoints[2].AppliedForce);
    }

    [TestMethod]
    public void ReorderByDetectedNominalForceOrdering_ValidInput_ReturnsValuesInDecendingOrder()
    {
        // Arrange
        List<IMeasurementPoint> measurementPoints =
        [
            new NominalMeasurementPoint(0.0, 0.1),
            new NominalMeasurementPoint(50.0, 0.4),
            new NominalMeasurementPoint(30.0, 0.2),
            new NominalMeasurementPoint(10.0, 0.7)
        ];

        // Act
        IReorderSeries reorderSeries = ReorderFactory.Create(MeasurementSeriesReorderTypes.DetectedNominalForceOrdering);
        List<IMeasurementPoint>? reorderedPoints = reorderSeries.Reorder(measurementPoints);

        // Assert
        Assert.IsNotNull(reorderedPoints);
        Assert.AreEqual(4, reorderedPoints.Count);
        Assert.AreEqual(0.0, reorderedPoints[0].AppliedForce);
        Assert.AreEqual(50.0, reorderedPoints[1].AppliedForce);
        Assert.AreEqual(30.0, reorderedPoints[2].AppliedForce);
        Assert.AreEqual(10.0, reorderedPoints[3].AppliedForce);
    }

    [TestMethod]
    public void ReorderByDetectedNominalForceOrdering_ValidInput_ReturnsValuesInAscendingDecendingOrder()
    {
        // Arrange
        List<IMeasurementPoint> measurementPoints =
        [
            new NominalMeasurementPoint(0.0, 0.1),
            new NominalMeasurementPoint(50.0, 0.4),
            new NominalMeasurementPoint(30.0, 0.2),
            new NominalMeasurementPoint(10.0, 0.7),
            new NominalMeasurementPoint(20.0, 0.1),
            new NominalMeasurementPoint(25.0, 0.4),
            new NominalMeasurementPoint(30.0, 0.2),
            new NominalMeasurementPoint(42.0, 0.7)
        ];

        // Act
        IReorderSeries reorderSeries = ReorderFactory.Create(MeasurementSeriesReorderTypes.DetectedNominalForceOrdering);
        List<IMeasurementPoint>? reorderedPoints = reorderSeries.Reorder(measurementPoints);

        // Assert
        Assert.IsNotNull(reorderedPoints);
        Assert.AreEqual(8, reorderedPoints.Count);
        Assert.AreEqual(0.0, reorderedPoints[0].AppliedForce);
        Assert.AreEqual(20.0, reorderedPoints[1].AppliedForce);
        Assert.AreEqual(25.0, reorderedPoints[2].AppliedForce);
        Assert.AreEqual(30.0, reorderedPoints[3].AppliedForce);
        Assert.AreEqual(42.0, reorderedPoints[4].AppliedForce);
        Assert.AreEqual(50.0, reorderedPoints[5].AppliedForce);
        Assert.AreEqual(30.0, reorderedPoints[6].AppliedForce);
        Assert.AreEqual(10.0, reorderedPoints[7].AppliedForce);
    }

    [TestMethod]
    public void ReorderByDetectedNominalForceOrdering_ValidInput_ReturnsValuesInAscendingDecendingOrder2()
    {
        // Arrange
        List<IMeasurementPoint> measurementPoints =
        [
            new NominalMeasurementPoint(0.0, 0.1),  // A
            new NominalMeasurementPoint(50.0, 0.4), // A
            new NominalMeasurementPoint(30.0, 0.2), // D
            new NominalMeasurementPoint(10.0, 0.7), // D
            new NominalMeasurementPoint(0.0, 0.1),  // D
            new NominalMeasurementPoint(25.0, 0.4), // A
            new NominalMeasurementPoint(0.0, 0.2),  // D
            new NominalMeasurementPoint(42.0, 0.7)  // A
        ];

        // Act
        IReorderSeries reorderSeries = ReorderFactory.Create(MeasurementSeriesReorderTypes.DetectedNominalForceOrdering);
        List<IMeasurementPoint>? reorderedPoints = reorderSeries.Reorder(measurementPoints);

        // Assert
        Assert.IsNotNull(reorderedPoints);
        Assert.AreEqual(8, reorderedPoints.Count);

        // Ascending part of the list
        Assert.AreEqual(0.0, reorderedPoints[0].AppliedForce);
        Assert.AreEqual(25.0, reorderedPoints[1].AppliedForce);
        Assert.AreEqual(42.0, reorderedPoints[2].AppliedForce);
        Assert.AreEqual(50.0, reorderedPoints[3].AppliedForce);

        // Descending part of the list
        Assert.AreEqual(30.0, reorderedPoints[4].AppliedForce);
        Assert.AreEqual(10.0, reorderedPoints[5].AppliedForce);
        Assert.AreEqual(0.0, reorderedPoints[6].AppliedForce);
        Assert.AreEqual(0.0, reorderedPoints[7].AppliedForce);
    }

    [TestMethod]
    public void ReorderByDetectedNominalForceOrdering_ValidDuplicateInput_ReturnsSameValues()
    {
        // Arrange
        List<IMeasurementPoint> measurementPoints =
        [
            new NominalMeasurementPoint(0.0, 0.1),
            new NominalMeasurementPoint(50.0, 0.4),
            new NominalMeasurementPoint(50.0, 0.2),
            new NominalMeasurementPoint(50.0, 0.7),
        ];

        // Act
        IReorderSeries reorderSeries = ReorderFactory.Create(MeasurementSeriesReorderTypes.DetectedNominalForceOrdering);
        List<IMeasurementPoint>? reorderedPoints = reorderSeries.Reorder(measurementPoints);

        // Assert
        Assert.IsNotNull(reorderedPoints);
        Assert.AreEqual(4, reorderedPoints.Count);
        Assert.AreEqual(0.0, reorderedPoints[0].AppliedForce);
        Assert.AreEqual(50.0, reorderedPoints[1].AppliedForce);
        Assert.AreEqual(50.0, reorderedPoints[2].AppliedForce);
        Assert.AreEqual(50.0, reorderedPoints[3].AppliedForce);
    }

    [TestMethod]
    public void ReorderFactoryCreate_InputNotImplementedReorderType_ThrowsNotImplementedException()
    {
        // Act and Assert
        var exception = Assert.ThrowsException<NotImplementedException>(() => ReorderFactory.Create((MeasurementSeriesReorderTypes)999));
    }
}
