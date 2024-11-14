using MathNet.Numerics;
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
        public static double[] FitPolynomialToLeastSquares(double[] x, double[] y, int degree)
        {
            //TODO better wording on x and y

            try
            {
                return Fit.Polynomial(x, y, degree);
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
    }
}