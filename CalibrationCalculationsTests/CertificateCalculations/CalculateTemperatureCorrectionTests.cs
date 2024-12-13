using CertificateGeneration.CertificateCalculations.TemperatureCorrection;

namespace CertificateGenerationTests.CertificateCalculations;

[TestClass]
public class CalculateTemperatureCorrectionTests
{
    // Arrange
    [DataTestMethod]
    [DataRow(25.0, 20.0, 1.5, -7.5)]
    [DataRow(30.0, 20.0, 2.0, -20.0)]
    [DataRow(15.0, 20.0, 1.0, 5.0)]
    [DataRow(20.0, 20.0, 1.0, 0.0)]
    public void CalculateTemperatureCorrection_ValidInput_ReturnsExpectedResult(double ambientTemperature, double standardCalibrationTemperature, double temperatureCorrectionValuePer1Degree, double expected)
    {
        // Act
        double result = CalculateTemperatureCorrection.Calculate(ambientTemperature, standardCalibrationTemperature, temperatureCorrectionValuePer1Degree);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
