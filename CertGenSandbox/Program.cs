using MathLib;
using System.Runtime.CompilerServices;
using Interpolation;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Start");

            


            //double[] interpolatedValues = NISTInterpolatedZeroReduction.Calculate(appliedForce, run1);



            // Fit a 4th order polynomial
            //var coefficients = MathLib.Statistics.FitPolynomialToLeastSquares(run1, interpolatedValues, 4);

            //// Display the coefficients
            //Console.WriteLine("Coefficients of the 4th order polynomial:");
            //for (int i = 0; i < coefficients.Length; i++)
            //{
            //    Console.WriteLine($"A{i} = {coefficients[i]}");
            //}

            Console.WriteLine("Finish");
            Console.ReadKey();

        }
        
    }
}

