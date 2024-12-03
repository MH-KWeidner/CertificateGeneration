using MathNet.Numerics;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.Statistics;

namespace CertificateGeneration.MathLibrary
{
    /// <summary>
    /// Defines the <see cref="Statistics" />
    /// </summary>
    public static class Statistics
    {
        /// <summary>
        /// The CalculatePolynomial
        /// </summary>
        /// <param name="coefficients">The coefficients<see cref="double[]"/></param>
        /// <param name="appliedForce">The appliedForce<see cref="double"/></param>
        /// <returns>The <see cref="double"/></returns>
        public static double CalculatePolynomial(double[] coefficients, double appliedForce)
        {
            //TODO add specific error handling

            return coefficients.Select((coeff, index) => coeff * Math.Pow(appliedForce, index)).Sum();
        }

        /// <summary>
        /// The CalculateMean
        /// </summary>
        /// <param name="values">The values<see cref="double[]"/></param>
        /// <returns>The <see cref="double"/></returns>
        public static double CalculateMean(double[] values)
        {
            //TODO better error handling

            try
            {
                double mean = values.Mean();

                if (double.IsNaN(mean))
                    throw new Exception("Error in Statistics.GetMean has NaN value.");

                return mean;
            }
            catch
            {
                //TODO add specific error handling
                throw new Exception("Error in Statistics.GetMean");
            }
        }

        /// <summary>
        /// The CalculateMean
        /// </summary>
        /// <param name="values">The values<see cref="IList{double}"/></param>
        /// <returns>The <see cref="double"/></returns>
        public static double CalculateMean(IList<double> values)
        {
            try
            {
                double mean = values.Mean();

                if (double.IsNaN(mean))
                    throw new Exception("Error in Statistics.GetMean has NaN value.");

                return mean;
            }
            catch
            {
                //TODO add specific error handling
                throw new Exception("Error in Statistics.GetMean");
            }
        }

        /// <summary>
        /// The CalculateCFactor
        /// </summary>
        /// <param name="n">The n<see cref="int"/></param>
        /// <param name="m">The m<see cref="int"/></param>
        /// <returns>The <see cref="double"/></returns>
        public static double CalculateCFactor(int n, int m)
        {
            // TODO: better naming that also explains what this is

            // TODO: better naming for parameters and constant

            const double DISTRIBUTION_EVALUATION = 0.975;

            // TODO: confirm this is the correct distribution or method to use
            var FDist = new FisherSnedecor(1, n - m - 1);
            var fDistValue = FDist.InverseCumulativeDistribution(DISTRIBUTION_EVALUATION);
            return (double)Math.Sqrt(1 + (fDistValue - 1) / (n - m));
        }

        /// <summary>
        /// The CalculateResidualStandardDeviation
        /// </summary>
        /// <param name="observedMean">The observedMean<see cref="double[]"/></param>
        /// <param name="predictedFit">The predictedFit<see cref="double[]"/></param>
        /// <param name="degreeOfPolynpmialFit">The degreeOfPolynpmialFit<see cref="int"/></param>
        /// <returns>The <see cref="double"/></returns>
        public static double CalculateResidualStandardDeviation(double[] observedMean, double[] predictedFit, int degreeOfPolynpmialFit)
        {
            // TODO: add error handling

            // TODO: verify arrays are the same size

            // TODO: consider if this is method is domain specific and should be moved to a different class/namespace

            // TODO : consider naming that relects name of parameters - degrees of freedom

            const int POWER_OF_TWO = 2;

            double residualStandardDeviation = 0.0;

            for (int i = 0; i < observedMean.Length; i++)
                residualStandardDeviation += Math.Pow(observedMean[i] - predictedFit[i], POWER_OF_TWO);

            residualStandardDeviation /= predictedFit.Length - degreeOfPolynpmialFit - 1;

            return Math.Sqrt(residualStandardDeviation);
        }

        /// <summary>
        /// The FitPolynomialToLeastSquares
        /// </summary>
        /// <param name="xsStacked">The xsStacked<see cref="double[]"/></param>
        /// <param name="ysStacked">The ysStacked<see cref="double[]"/></param>
        /// <param name="degree">The degree<see cref="int"/></param>
        /// <returns>The <see cref="double[]"/></returns>
        public static double[] FitPolynomialToLeastSquares(double[] xsStacked, double[] ysStacked, int degree)
        {
            try
            {
                return Fit.Polynomial(xsStacked, ysStacked, degree);
            }
            catch
            {
                //TODO add specific error handling
                throw new Exception("Error in Statistics.FitPolynomialToLeastSquares");
            }
        }
    }
}
