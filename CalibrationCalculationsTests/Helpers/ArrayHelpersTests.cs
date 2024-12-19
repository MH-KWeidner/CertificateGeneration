using CalibrationCalculations.Helpers;
using CalibrationCalculations.IoC.ReorderSeries;

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

    [TestMethod]
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
        Assert.AreEqual(3, result.Length);
    }

    [TestMethod]
    public void StackArrays_ArrayOfDoubleInputs_ReturnsExpectedStackedArray()
    {
        // Arrange
        double[] array1 = [1.0, 2.0, 3.0];
        double[] array2 = [4.0, 5.0, 6.0];
        double[] array3 = [7.0, 8.0, 9.0];
        // Act
        double[] result = ArrayHelper.StackArrays(array1, array2, array3);
        // Assert
        double[] expected = [1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0];
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void StackArrayNTimes_StackZeroTimes_ThrowsArgumentException()
    {
        // Arrange
        double[] array = [1.0, 2.0, 3.0];

        // Act and Assert
        var exception = Assert.ThrowsException<ArgumentException>(() => ArrayHelper.StackArrayNTimes(array, 0));
    }

}

