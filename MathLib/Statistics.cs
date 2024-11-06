using MathNet.Numerics;
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
        
        public static double CalculateNISInterpolatedValue(double startZeroValue, double endZeroValue, int numberOfNonZeroForcePoints, double forceReading, int seriesPositionOfForceReading)
        {
            //TODO non-force specific naming
            try
            {
                return forceReading - (startZeroValue + ((endZeroValue - startZeroValue) * (seriesPositionOfForceReading - 1) / (numberOfNonZeroForcePoints - 1)));
            }
            catch
            {
                //TODO add specific error handling
                throw new Exception("Error in Statistics.CalculateNISInterpolatedValue");
            }
        }
    }
}