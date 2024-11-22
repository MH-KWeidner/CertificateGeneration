namespace CertificateGeneration.MathLib
{
    using CertificateGeneration.Models.DataTransform;
    using System;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="DetermineDegreeOfBestFittingPolynomial" />
    /// </summary>
    public static class DetermineDegreeOfBestFittingPolynomial
    {
        /// <summary>
        /// The Calculate
        /// </summary>
        /// <returns>The <see cref="int"/></returns>
        public static int Calculate()
        {
            const int MIN_DEGREE_OF_FIT = 1;

            const int MAX_DEGREE_OF_FIT = 4;

            double[] stackedAppliedForces = StackData(new AppliedForceToArray());

            double[] stackedSeriesData = StackData(new SeriesValueToArray());

            double[] observedMean = CalculateSeriesMean();

            double[] appliedForces = GetAppliedForces();

            var rangeOfDegrees = Enumerable.Range(MIN_DEGREE_OF_FIT, MAX_DEGREE_OF_FIT).Reverse();

            int returnBestFitDegree = 0;

            // TODO: consider double?
            double currentResidualDeviation = 0;
            double previousResidualDeviation = 0;

            foreach (int degree in rangeOfDegrees)
            {
                returnBestFitDegree = degree;

                double[] polynomials = MathLib.Statistics.FitPolynomialToLeastSquares(stackedAppliedForces, stackedSeriesData, degree);

                double[] predictedFit = new double[appliedForces.Length];

                for (int i = 0; i < predictedFit.Length; i++)
                    predictedFit[i] = MathLib.Statistics.CalculatePolynomial(polynomials, appliedForces[i]);

                previousResidualDeviation = currentResidualDeviation;

                currentResidualDeviation = MathLib.Statistics.CalculateResidualStandardDeviation(observedMean, predictedFit, degree);

                if (degree == MAX_DEGREE_OF_FIT)
                    continue;

                if (IsBestFitPolynomialFit(previousResidualDeviation, currentResidualDeviation, observedMean.Length, degree))
                    break;
            }

            return returnBestFitDegree;
        }
    }
}
