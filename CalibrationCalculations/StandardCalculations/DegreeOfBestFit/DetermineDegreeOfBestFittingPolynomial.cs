using CalibrationCalculations.Helpers;
using CalibrationCalculations.MathLibrary;

namespace CalibrationCalculations.StandardCalculations.DegreeOfBestFit;

/// <summary>
/// Defines the <see cref="DetermineDegreeOfBestFittingPolynomial" />
/// </summary>
public static class DetermineDegreeOfBestFittingPolynomial
{
    /// <summary>
    /// The Build
    /// </summary>
    /// <param name="appliedForces">The appliedForces<see cref="double[]"/></param>
    /// <param name="data">The data<see cref="double[][]"/></param>
    /// <returns>The <see cref="int"/></returns>
    public static int Calculate(double[] appliedForces, params double[][] data)
    {
        const int MIN_DEGREE_OF_FIT = 1;

        const int NUM_OF_DEGREES_OF_FIT = 5;

        const int RAISED_TO_POWER = 2;

        double[] stackedAppliedForces = ArrayHelper.StackArrayNTimes(appliedForces, data.Length);

        double[] stackedMeasurementData = ArrayHelper.StackArrays(data);

        var degreesOfFitDecendingOrder = Enumerable.Range(MIN_DEGREE_OF_FIT, NUM_OF_DEGREES_OF_FIT).Reverse().ToArray();

        double currentResidualStandardDeviation = 0;

        double previousResidualStandardDeviation = 0;

        // A1.2 Build the mean of the data
        double[] meanData = ArrayHelper.CalculateMeanAcrossX(data);

        for (int i = 0; i < degreesOfFitDecendingOrder.Length; i++)
        {
            // A1.3 Fit separate polynomials of degree 1, 2, 3, 4, and 5 to the mean data
            double[] coefficients = PolynomialMath.GetCoefficientsOfLeastSquaresFit(stackedAppliedForces, stackedMeasurementData, degreesOfFitDecendingOrder[i]);

            double[] fittedCurve = appliedForces.Select(force => StatisticsMath.EvaluateCoefficients(coefficients, force)).ToArray();

            // A1.3 Sum differences between the fitted curve and the observed mean values
            double difference = meanData.Zip(fittedCurve, (mean, fit) => Math.Pow(mean - fit, RAISED_TO_POWER)).Sum();

            previousResidualStandardDeviation = currentResidualStandardDeviation;

            // A1.3 Build the residual standard deviation
            currentResidualStandardDeviation = Math.Sqrt(difference / (appliedForces.Length - degreesOfFitDecendingOrder[i] - 1));

            if (i == 0)
                continue;

            // A1.5 Compute s4 /s5 and compare it to C(n1, 5)
            if (currentResidualStandardDeviation / previousResidualStandardDeviation > StatisticsMath.CalculateCFactor(meanData.Length, degreesOfFitDecendingOrder[i - 1]))
                return degreesOfFitDecendingOrder[i - 1];
        }

        // TODO: how to handle case if best fit cannot be determined
        const string exceptionMessage = "Unable to determine the best fitting polynomial degree.";
        throw new Exception(exceptionMessage);
    }
}
