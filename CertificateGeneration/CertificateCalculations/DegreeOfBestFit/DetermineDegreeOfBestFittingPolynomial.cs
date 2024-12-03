using CertificateGeneration.Helpers;
using CertificateGeneration.MathLibrary;
using MathNet.Numerics;

namespace CertificateGeneration.CertificateCalculations.DegreeOfBestFit
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
        public static int Calculate(double[] appliedForces, params double[][] data)
        {
            //TODO naming on data

            // TODO verify what to use for min and max degree of fit

            const int MIN_DEGREE_OF_FIT = 1;

            const int MAX_DEGREE_OF_FIT = 5;

            const int ONE_DEGREE_OF_FIT = 1;

            double[] stackedAppliedForces = ArrayHelper.StackArrayNTimes(appliedForces, data.Length);

            double[] stackedSeriesData = ArrayHelper.StackArrays(data);

            //TODO REMOVE THIS - FOR TESTING ONLY
            const int ROUNDING_DIGITS = 8;
            for(int i = 0; i < stackedSeriesData.Length; i++)
                stackedSeriesData[i]= Math.Round(stackedSeriesData[i], ROUNDING_DIGITS);

            double[] dataMeanValues = ArrayHelper.CalculateSeriesMeanXDirection(data);

            // var rangeOfDegrees = Enumerable.Range(MIN_DEGREE_OF_FIT, MAX_DEGREE_OF_FIT).Reverse();

            var rangeOfDegrees = Enumerable.Range(MIN_DEGREE_OF_FIT, MAX_DEGREE_OF_FIT);

            int returnBestFitDegree = 0;

            double currentResidualDeviation = 0;

            double previousResidualDeviation = 0;

            foreach (int degree in rangeOfDegrees)
            {
                returnBestFitDegree = degree;

                double[] polynomials;

                // TODO abstract this out
                if (degree == ONE_DEGREE_OF_FIT)
                    polynomials = CertificateGeneration.MathLibrary.Polynomial.GetCoefficientsOfLeastSquaresLine(stackedAppliedForces, stackedSeriesData);
                else
                    polynomials = CertificateGeneration.MathLibrary.Polynomial.GetCoefficientsOfLeastSquaresFit(stackedAppliedForces, stackedSeriesData, degree);

                double[] predictedFit = new double[appliedForces.Length];

                for (int i = 0; i < predictedFit.Length; i++)
                    predictedFit[i] = Statistics.CalculatePolynomial(polynomials, appliedForces[i]);


                // TODO REMOVE THIS - FOR TESTING ONLY
                for (int i = 0; i < predictedFit.Length; i++)
                    predictedFit[i] = Math.Round(predictedFit[i], ROUNDING_DIGITS);


                previousResidualDeviation = currentResidualDeviation;

                currentResidualDeviation = Statistics.CalculateResidualStandardDeviation(dataMeanValues, predictedFit, degree);


                /*if (appliedForces.Length - degree - 1 > 0) // else expression can not be passed as parameter to MathNet.Numerics.Distributions.FisherSnedecor (all params req to be >0)
                {
                    var FDist = new MathNet.Numerics.Distributions.FisherSnedecor(1, Fits[i].ValuesFromCurve.Count - Fits[i].DegreeFit - 1).InverseCumulativeDistribution(.975);
                    // var = new MathNet.Numerics.Distributions.FisherSnedecor(1, Fits[i].ValuesFromCurve.Count - Fits[i].DegreeFit - 1).CumulativeDistribution(.975);

                    var probabilityConstant = Math.Round(Math.Sqrt(((FDist - 1) / (Fits[i].ValuesFromCurve.Count - Fits[i].DegreeFit)) + 1), 3);

                    var stdratio = Fits[i - 1].StandardDeviationDeflectionAverage / Fits[i].StandardDeviationDeflectionAverage;

                    Fits[i].StandardDeviationLoad = Math.Round(Fits[i].StandardDeviationLoad, 5);

                    if (stdratio > probabilityConstant) // if the ratio of the standard deviation of the current fit vs the previous fit is greater than the statistical constant
                    {
                        // this is the best fit
                        //BestFit.FTestPass = true;
                        BestFit = Fits[i];
                        break;
                    }
                }*/






                //if (degree == MAX_DEGREE_OF_FIT)
                //    continue;

                //if (IsBestFitPolynomialFit(previousResidualDeviation, currentResidualDeviation, dataMeanValues.Length, degree))
                //    break;
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
