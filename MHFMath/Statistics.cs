using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHFMath
{
    public static class Statistics
    {
        public static double[] FitPolynomialToLeastSquares(double[] x, double[] y, int order)
        {
            return Fit.Polynomial(x, y, order);
        }
    }
}