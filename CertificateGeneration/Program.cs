namespace ConsoleTesting;

class Program
{
    static void Main(string[] args)
    {
        
        var xs = new double[] { 1, 2, 3, 4, 5 };
        var ys = new double[] { 1, 4, 9, 16, 25 };

        var z = CertificateGeneration.MathLib.Polynomial.CreateMultiDegreeValues(xs, 3);

        Console.ReadKey();
    }
}
