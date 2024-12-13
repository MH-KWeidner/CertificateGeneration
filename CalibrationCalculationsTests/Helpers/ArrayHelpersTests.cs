using CalibrationCalculations.Helpers;

namespace CalibrationCalculationsTests.Helpers;

[TestClass]
public class ArrayHelpersTests
{
    [TestMethod]
    public void CalculateSeriesMeanXDirection_ValidInput_ReturnsExpectedMeanValues()
    {
        // Arrange
        double[][] doubles =
        [
            [1, 2, 3],
            [4, 5, 6],
            [7, 8, 9]
        ];

        // Act
        double[] result = ArrayHelper.CalculateMeanAcrossX(doubles);

        // Assert
        Assert.AreEqual(4, result[0]);
        Assert.AreEqual(5, result[1]);
        Assert.AreEqual(6, result[2]);
    }

    public void CalculateSeriesMeanXDirection_ValidInput_ReturnsExpectedArraySize()
    {
        // Arrange
        double[][] doubles =
        [
            [1, 2, 3],
            [4, 5, 6],
            [7, 8, 9],
            [10, 11, 12]
        ];

        // Act
        double[] result = ArrayHelper.CalculateMeanAcrossX(doubles);

        // Assert
        Assert.AreEqual(4, result.Length);
    }
}
