using MathNet.Numerics;

namespace CertificateGeneration;

class Program
{
    static void Main(string[] args)
    {

        double[] xData = { 10, 20, 30, 40, 50 };
        double[] yData = { 2.2, 3.3, 5.5, 7.7, 11.11 };
        int degree = 2;

        double[] coefficients = Fit.Polynomial(xData, yData, degree);
        Console.WriteLine("Coefficients: " + string.Join(", ", coefficients));

        /////////////

        double[] fittedValues = new double[xData.Length];

        for (int i = 0; i < xData.Length; i++)
        {
            double fittedValue = 0.0;
            for (int j = 0; j < coefficients.Length; j++)
            {
                Console.WriteLine();
                Console.WriteLine("-----------------");
                fittedValue += coefficients[j] * Math.Pow(xData[i], j);
                Console.WriteLine($"coefficients[j]: {coefficients[j]}    Power(xData[i]): {xData[i]}     poser: {j}");
                Console.WriteLine("-----------------");
                Console.WriteLine();
            }
            fittedValues[i] = fittedValue;
            Console.WriteLine($"Fitted value at x = {xData[i]}: {fittedValues[i]}");
        }

        Console.ReadKey();
    }
}
