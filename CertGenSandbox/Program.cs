

using MathLib;

Console.WriteLine("Start");

// note that provided test data values are post zero reduction

double[] appliedForce = [2, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100];

double[] run1 = [
    -0.04234,
    -0.21161,
    -0.42324,
    -0.63487,
    -0.84651,
    -1.05819,
    -1.26987,
    -1.48156,
    -1.69327,
    -1.90495,
    -2.11664
];

double[] run2 = [
    -0.0423,
    -0.2116,
    -0.42322,
    -0.63485,
    -0.84649,
    -1.05817,
    -1.26983,
    -1.48151,
    -1.69323,
    -1.90493,
    -2.11661
];

double[] run3 = [
    -0.04229,
    -0.2116,
    -0.42322,
    -0.63486,
    -0.84651,
    -1.05816,
    -1.26987,
    -1.48157,
    -1.69328,
    -1.90499,
    -2.1167
];


// Combine data sets
double[] xData = appliedForce.Concat(appliedForce).Concat(appliedForce).ToArray();
double[] yData = run1.Concat(run2).Concat(run3).ToArray();

// Fit a 4th order polynomial
var coefficients = MathLib.Statistics.FitPolynomialToLeastSquares(xData, yData, 4);

// Display the coefficients
Console.WriteLine("Coefficients of the 4th order polynomial:");
for (int i = 0; i < coefficients.Length; i++)
{
    Console.WriteLine($"A{i} = {coefficients[i]}");
}

Console.WriteLine("Finish");
Console.ReadKey();
