using MathNet.Numerics;

namespace CertificateGeneration.MathLibrary
{
    /// <summary>
    /// Defines the <see cref="Polynomial" />
    /// </summary>
    public class Polynomial
    {
        /// <summary>
        /// Returns <paramref name="degree"/> + 1 number of coefficients using Least Squares. Each row of <paramref name="ys"/> shall
        /// correspond to the same row of <paramref name="xs"/>. If <paramref name="fitThroughOrigin"/> is <see langword="true"/>,
        /// the first coefficient will be 0. Coefficients are returned in ascending degree order (i.e., x0, x1, x2, etc.)
        /// </summary>
        /// <param name="xs">The collection of x values that correspond with the <paramref name="ys"/></param>
        /// <param name="ys">The collection of y values that correspond with the <paramref name="xs"/></param>
        /// <param name="degree">The highest coefficient degree desired</param>
        /// <param name="fitThroughOrigin">If <see langword="true"/>, the first coefficient (x0) will be 0. Otherwise, coefficients are calculated normally</param>
        /// <returns>The <paramref name="degree"/> + 1 calculated coefficients in ascending degree order</returns>
        public static double[] GetCoefficients(double[] xs, double[] ys, int degree, bool fitThroughOrigin)
        {
            //TODO need to use this method having fitThroughOrigin

            // Use Numeric's more accurate line formula's for 1st degree calculations
            if (degree == 1)
            {
                if (fitThroughOrigin)
                    return [0, Fit.LineThroughOrigin(xs, ys)];

                var (intercept, slope) = Fit.Line(xs, ys);
                return [intercept, slope];
            }

            if (!fitThroughOrigin)
                return Fit.Polynomial(xs, ys, degree);

            // Returns n rows of xs as [ xs^1, ... xs^degree ]n
            var multiDegree = CreateMultiDegreeValues(xs, degree);

            // If intercept is true, a column is prepended to the xs of the 0th power (all 1s)

            return [0, .. Fit.MultiDim(multiDegree, ys, intercept: !fitThroughOrigin)];
        }

        /// <summary>
        /// Creates a two dimensional array of <paramref name="values"/> with <paramref name="degree"/> columns. The column index, <see langword="i"/>,
        /// represents the values raised to <see langword="i + 1"/>
        /// </summary>
        /// <param name="values">The values<see cref="double[]"/></param>
        /// <param name="degree">The degree<see cref="int"/></param>
        /// <returns></returns>
        public static double[][] CreateMultiDegreeValues(double[] values, int degree)
        {
            var rowCount = values.Length;
            var result = new double[rowCount][];

            for (var row = 0; row < rowCount; row++)
            {
                result[row] = new double[degree];
                var value = values[row];

                for (var col = 0; col < degree; col++)
                    result[row][col] = Math.Pow(value, col + 1);
            }

            return result;
        }

        public static double[] GetCoefficientsOfLeastSquaresFit(double[] xs, double[] ys, int degree)
        {
            // TODO add error handling

            return Fit.Polynomial(xs, ys, degree);
        }

        public static double[] GetCoefficientsOfLeastSquaresLine(double[] xs, double[] ys)
        {
            // TODO add error handling

            //TODO better naming            

            var (intercept, slope) = Fit.Line(xs, ys);
            return [intercept, slope];
        }
    }
}
