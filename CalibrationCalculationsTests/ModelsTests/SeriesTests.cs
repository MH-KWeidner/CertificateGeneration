using CalibrationCalculations.Models;

namespace CalibrationCalculationsTests.ModelsTests;

[TestClass]
public class SeriesTests
{
    [TestMethod]
    public void SeriesAddValue_Validoutput_ReturnsCorrectValues()
    {
        // Arrange
        double[] force = [10, 20, 30];
        double[] values = [1.0, 2.0, 3.0];
        MeasurementSeries series = MeasurementSeries.Create(1, force, values);

        // Act
        series.IncreaseValuesByAdd(100.00);

        // Assert
        Assert.AreEqual(101.0, series.GetValue(0));
        Assert.AreEqual(102.0, series.GetValue(1));
        Assert.AreEqual(103.0, series.GetValue(2));
    }

    [TestMethod]
    public void IncreaseValueByAdd_Validoutput_ReturnsCorrectValues()
    {
        // Arrange
        int seriesId = 1;
        double[] appliedForces = [ 10.0, 20.0, 30.0 ];
        double[] values = [ 1.0, 2.0, 3.0 ];
        double[] result = [6.0, 7.0, 8.0];
        double valueToAdd = 5.0;
        MeasurementSeries series = MeasurementSeries.Create(seriesId, appliedForces, values);

        // Act
        series.IncreaseValuesByAdd(valueToAdd);

        // Assert
        for (int i = 0; i < values.Length; i++)
        {

            Assert.AreEqual(result[i], series.GetValue(i), $"Value at index {i} was not increased correctly.");
        }
    }
}
