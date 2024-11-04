using Microsoft.VisualStudio.TestTools.UnitTesting;
using MHFMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHFMath.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MHFMath;
    using MathNet.Numerics;

    namespace MHFMath.Tests
    {
        [TestClass]
        public class StatisticsTests
        {
            [TestMethod]
            public void FitPolynomialToLeastSquares_ValidInput_ReturnsExpectedCoefficients()
            {
                // Arrange
                double[] x = { 1, 2, 3, 4, 5 };
                double[] y = { 1, 4, 9, 16, 25 }; // y = x^2
                int degree = 2;

                // Act
                double[] result = Statistics.FitPolynomialToLeastSquares(x, y, degree);

                // Assert
                Assert.AreEqual(3, result.Length);
                Assert.IsTrue(Math.Abs(result[0] - 0) < 1e-6); // constant term
                Assert.IsTrue(Math.Abs(result[1] - 0) < 1e-6); // linear term
                Assert.IsTrue(Math.Abs(result[2] - 1) < 1e-6); // quadratic term
            }

            [TestMethod]
            public void FitPolynomialToLeastSquares_InvalidInput_ThrowsException()
            {
                // Arrange
                double[] x = { 1, 2, 3 };
                double[] y = { 1, 4 }; // Mismatched length
                int degree = 2;

                // Act & Assert
                var exception = Assert.ThrowsException<Exception>(() => Statistics.FitPolynomialToLeastSquares(x, y, degree));
                Assert.AreEqual("Error in Statistics.FitPolynomialToLeastSquares", exception.Message);
            }
        }
    }

}