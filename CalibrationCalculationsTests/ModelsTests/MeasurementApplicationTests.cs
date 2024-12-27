using CalibrationCalculations.IoC.TransformMeasurementPoints;
using CalibrationCalculations.Models;

namespace CalibrationCalculationsTests.ModelsTests;

[TestClass]
public class MeasurementApplicationTests
{
    [TestMethod]
    public void StackMeasurementPoints_ValidInput_ReturnsCorrectlyStackedValues()
    {
        // Arrange
        double[][] forces =
        {
            [10.0, 20.0, 30.0],
            [100.0, 200.0],
            [1000.0, 2000.0, 3000.0, 4000.0, 5000.0]
        };

        double[][] values =
        {
            [15, 25, 35],
            [105, 205],
            [1005, 2005, 3005, 4005, 5005]
        };

        // Act
        MeasurementApplication application = new(forces, values);
        double[] stacked = application.StackMeasurementPoints(new NominalAppliedForcesToArray());

        // Assert
        Assert.AreEqual(10.0, stacked.Length);
        Assert.AreEqual(10.0, stacked[0]);
        Assert.AreEqual(20.0, stacked[1]);
        Assert.AreEqual(30.0, stacked[2]);
        Assert.AreEqual(100.0, stacked[3]);
        Assert.AreEqual(200.0, stacked[4]);
        Assert.AreEqual(1000.0, stacked[5]);
        Assert.AreEqual(2000.0, stacked[6]);
        Assert.AreEqual(3000.0, stacked[7]);
        Assert.AreEqual(4000.0, stacked[8]);
        Assert.AreEqual(5000.0, stacked[9]);
    }

    [TestMethod]
    public void StackMeasurementPoints_ValidInput_ReturnsCorrectlyStackedForceValues()
    {
        // Arrange
        double[][] forces =
        {
            [10.0, 20.0, 30.0],
            [100.0, 200.0],
            [1000.0, 2000.0, 3000.0, 4000.0, 5000.0]
        };

        double[][] values =
        {
            [15.0, 25.0, 35.0],
            [105.0, 205.0],
            [1005.0, 2005.0, 3005.0, 4005.0, 5005.0]
        };

        // Act
        MeasurementApplication application = new(forces, values);
        double[] stacked = application.StackMeasurementPoints(new MeasurementValuesToArray());

        // Assert
        Assert.AreEqual(10.0, stacked.Length);
        Assert.AreEqual(15.0, stacked[0]);
        Assert.AreEqual(25.0, stacked[1]);
        Assert.AreEqual(35.0, stacked[2]);
        Assert.AreEqual(105.0, stacked[3]);
        Assert.AreEqual(205.0, stacked[4]);
        Assert.AreEqual(1005.0, stacked[5]);
        Assert.AreEqual(2005.0, stacked[6]);
        Assert.AreEqual(3005.0, stacked[7]);
        Assert.AreEqual(4005.0, stacked[8]);
        Assert.AreEqual(5005.0, stacked[9]);
    }
}
