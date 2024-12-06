using CertificateGeneration.Models;

namespace CertificateGenerationTests.ModelsTests;

[TestClass]
public class SeriesTests
{
    [TestMethod]
    public void SeriesAddValue_Validoutput_ReturnsCorrectValues()
    {
        // Arrange
        double[] force = [10, 20, 30];
        double[] values = [1.0, 2.0, 3.0];
        Series series = Series.CreateSeries(1, force, values);

        // Act
        series.IncreaseValuesByAdd(100.00);

        // Assert
        Assert.AreEqual(101.0, series.GetValue(0));
        Assert.AreEqual(102.0, series.GetValue(1));
        Assert.AreEqual(103.0, series.GetValue(2));
    }
}
