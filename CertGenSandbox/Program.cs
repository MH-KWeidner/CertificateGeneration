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

            double[] appliedForce = [
                0,
                10,
                20,
                30,
                40,
                50,
                60,
                70,
                80,
                90,
                100,
                0,
                0,
                2,
                0
                ];

            double[] run1 = [
                0.00000,
                -0.21162,
                -0.42326,
                -0.63491,
                -0.84657,
                -1.05826,
                -1.26996,
                -1.48167,
                -1.69339,
                -1.90509,
                -2.11680,
                -0.00018,
                0.00000,
                -0.04234,
                0.00000
                    ];


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

