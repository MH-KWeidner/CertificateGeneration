using MathNet.Numerics;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public static class Statistics
    {
        public static double[] FitPolynomialToLeastSquares(double[] appliedForces, double[] seriesValues, int degree)
        {
            try
            {
                return Fit.Polynomial(appliedForces, seriesValues, degree);
            }
            catch
            {
                //TODO add specific error handling
                throw new Exception("Error in Statistics.FitPolynomialToLeastSquares");
            }
        }

        public static double GetMean(double[] values)
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
    
        public static double GetMean(IList<double> values)
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

        public static double CFactor(int n, int m)
        {
            // TODO: better naming

            const double DISTRIBUTION_EVALUATION = 0.975;

            var FDist = new FisherSnedecor(1, n - m - 1);
            var fDistValue = FDist.InverseCumulativeDistribution(DISTRIBUTION_EVALUATION);
            return (double)Math.Sqrt(1 + (fDistValue - 1) / (n - m));
        }
    }
}