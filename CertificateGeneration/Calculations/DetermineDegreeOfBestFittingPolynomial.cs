using CertificateGeneration.Helpers;
using CertificateGeneration.Wrappers.MathNet;

namespace CertificateGeneration.Calculations
{
    /// <summary>
    /// Defines the <see cref="DetermineDegreeOfBestFittingPolynomial" />
    /// </summary>
    public static class DetermineDegreeOfBestFittingPolynomial
    {
        /// <summary>
        /// The Calculate
        /// </summary>
        /// <param name="appliedForces">The appliedForces<see cref="double[]"/></param>
        /// <param name="data">The data<see cref="double[][]"/></param>
        /// <returns>The <see cref="int"/></returns>
        public static int Calculate(double[] appliedForces, double[][] data)
        {
            //TODO naming on data

            // TODO verify what to use for min and max degree of fit

            const int MIN_DEGREE_OF_FIT = 1;

            const int MAX_DEGREE_OF_FIT = 4;

            double[] stackedAppliedForces = ArrayHelper.StackArrayNTimes(appliedForces, data.Length);

            double[] stackedSeriesData = ArrayHelper.StackArrays(data);

            double[] dataMeanValues = ArrayHelper.CalculateSeriesMeanXDirection(data);

            var rangeOfDegrees = Enumerable.Range(MIN_DEGREE_OF_FIT, MAX_DEGREE_OF_FIT).Reverse();

            int returnBestFitDegree = 0;

            double currentResidualDeviation = 0;

            double previousResidualDeviation = 0;

            foreach (int degree in rangeOfDegrees)
            {
                returnBestFitDegree = degree;

                double[] polynomials = Statistics.FitPolynomialToLeastSquares(stackedAppliedForces, stackedSeriesData, degree);

                double[] predictedFit = new double[appliedForces.Length];

                for (int i = 0; i < predictedFit.Length; i++)
                    predictedFit[i] = Statistics.CalculatePolynomial(polynomials, appliedForces[i]);

                previousResidualDeviation = currentResidualDeviation;

                currentResidualDeviation = Statistics.CalculateResidualStandardDeviation(dataMeanValues, predictedFit, degree);

                if (degree == MAX_DEGREE_OF_FIT)
                    continue;

                if (IsBestFitPolynomialFit(previousResidualDeviation, currentResidualDeviation, dataMeanValues.Length, degree))
                    break;
            }

            return returnBestFitDegree;
        }

        /// <summary>
        /// The IsBestFitPolynomialFit
        /// </summary>
        /// <param name="previousResidualDeviation">The previousResidualDeviation<see cref="double"/></param>
        /// <param name="currentResidualStandardDeveian">The currentResidualStandardDeveian<see cref="double"/></param>
        /// <param name="numOfNonZeroForceIncrements">The numOfNonZeroForceIncrements<see cref="int"/></param>
        /// <param name="degreeOfPolynomialFit">The degreeOfPolynomialFit<see cref="int"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public static bool IsBestFitPolynomialFit(double previousResidualDeviation, double currentResidualStandardDeveian, int numOfNonZeroForceIncrements, int degreeOfPolynomialFit)
        {
            return previousResidualDeviation / currentResidualStandardDeveian > Statistics.CalculateCFactor(numOfNonZeroForceIncrements, degreeOfPolynomialFit);
        }
    }
}
