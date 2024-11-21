using MathNet.Numerics;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.Statistics;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateGeneration.MathLib
{
    public static class Statistics
    {
        public static double CalculatePolynomial(double[] coefficients, double appliedForce)
        {
            //TODO add specific error handling

            //

            return coefficients.Select((coeff, index) => coeff * Math.Pow(appliedForce, index)).Sum();
        }

        public static double CalculateMean(double[] values)
        {
            //TODO better error handling

            try
            {
                double mean = values.Mean();
                
                if(double.IsNaN(mean))
                    throw new Exception("Error in Statistics.GetMean has NaN value.");
                
                return mean;
            }
            catch
            {
                //TODO add specific error handling
                throw new Exception("Error in Statistics.GetMean");
            }
        }
    
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

        public static double CalculateCFactor(int n, int m)
        {
            // TODO: better naming that also explains what this is

            // TODO: better naming for parameters and constant

            const double DISTRIBUTION_EVALUATION = 0.975;

            var FDist = new FisherSnedecor(1, n - m - 1);
            var fDistValue = FDist.InverseCumulativeDistribution(DISTRIBUTION_EVALUATION);
            return (double)Math.Sqrt(1 + (fDistValue - 1) / (n - m));
        }

        // TODO verify if this is the correct implementation
        //public static double GetResidualStandardDeviation(double[] observed, double[] predicted)
        //{
        //    // TODO: add error handling

        //    // TODO: verify arrays are the same size

        //    double[] residuals = new double[observed.Length];

        //    for (int i = 0; i < observed.Length; i++)
        //        residuals[i] = observed[i] - predicted[i];

        //    return residuals.StandardDeviation();
        //}

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

            residualStandardDeviation /= (predictedFit.Length - degreeOfPolynpmialFit - 1);

            return Math.Sqrt(residualStandardDeviation);
        }

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

        //public static double[] GetCoefficients(double[] xs, double[] ys, int degree, bool fitThroughOrigin)
        //{
        //    // Use Numeric's more accurate line formula's for 1st degree calculations
        //    if (degree == 1)
        //    {
        //        if (fitThroughOrigin)
        //            return [0, Fit.LineThroughOrigin(xs, ys)];

        //        var (intercept, slope) = Fit.Line(xs, ys);
        //        return [intercept, slope];
        //    }

        //    if (!fitThroughOrigin)
        //        return Fit.Polynomial(xs, ys, degree);

        //    // Returns n rows of xs as [ xs^1, ... xs^degree ]n
        //    var multiDegree = CreateMultiDegreeValues(xs, degree);

        //    // If intercept is true, a column is prepended to the xs of the 0th power (all 1s)
        //    return [0, .. Fit.MultiDim(multiDegree, ys, intercept: !fitThroughOrigin)];
        //}



    }
}