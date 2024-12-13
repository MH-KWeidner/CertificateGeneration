using CalibrationCalculations.MathLibrary;

namespace CalibrationCalculationsTests.MathLibTests
{
    namespace MathLib.Tests
    {
        /// <summary>
        /// Defines the <see cref="StatisticsTests" />
        /// </summary>
        [TestClass]
        public class StatisticsTests
        {
            /// <summary>
            /// The FitPolynomialToLeastSquares_ValidInput_ReturnsExpectedCoefficients
            /// </summary>
            [TestMethod]
            public void FitPolynomialToLeastSquares_ValidInput_ReturnsExpectedCoefficients()
            {
                // Arrange
                double[] x = { 1, 2, 3, 4, 5 };
                double[] y = { 1, 4, 9, 16, 25 };
                const int degree = 2;

                // Act
                double[] result = StatisticsMath.FitPolynomialToLeastSquares(x, y, degree);

                // Assert
                Assert.AreEqual(3, result.Length);
                Assert.IsTrue(Math.Abs(result[0] - 0) < 1e-6);
                Assert.IsTrue(Math.Abs(result[1] - 0) < 1e-6);
                Assert.IsTrue(Math.Abs(result[2] - 1) < 1e-6);
            }

            /// <summary>
            /// The FitPolynomialToLeastSquares_InvalidInput_ThrowsException
            /// </summary>
            // [Ignore]
            [TestMethod]
            public void FitPolynomialToLeastSquares_InvalidInput_ThrowsException()
            {
                // Arrange
                double[] x = { 1, 2, 3 };
                double[] y = { 1, 4 };
                const int degree = 2;

                // Act & Assert
                var exception = Assert.ThrowsException<Exception>(() => StatisticsMath.FitPolynomialToLeastSquares(x, y, degree));
                Assert.AreEqual("Error in Statistics.FitPolynomialToLeastSquares", exception.Message);
            }

            /// <summary>
            /// The GetMean_ValidInput_ReturnsExpectedValue
            /// </summary>
            [TestMethod]
            public void GetMean_ValidInput_ReturnsExpectedValue()
            {
                // Arrange
                double[] x = [ 10, 20, 30 ];

                // Act
                double result = StatisticsMath.CalculateMean(x);

                // Assert
                Assert.AreEqual(20, result);
            }

            /// <summary>
            /// The GetMean_ValidInput_ThrowsException
            /// </summary>
            [Ignore]
            [TestMethod]
            public void GetMean_ValidInput_ThrowsException()
            {
                //TODO build custom exception for NaN value;

                // TODO fix this test

                // Arrange
                double[] x = [ double.NaN, 20, 30 ];

                // Act
                double result = StatisticsMath.CalculateMean(x);

                // Assert
                var exception = Assert.ThrowsException<Exception>(() => StatisticsMath.CalculateMean(x));
                Assert.AreEqual("Calculated mean is NaN.", exception.Message);
            }
        }
    }
}
