using CalibrationCalculations.Common;

namespace CalibrationCalculations.StandardCalculations.DegreeOfBestFit
{
    /// <summary>
    /// Defines the <see cref="SelectBestDegreeOfFit" />
    /// </summary>
    static public class SelectBestDegreeOfFit
    {
        /// <summary>
        /// The Select
        /// </summary>
        /// <param name="degreeOfFitType">The degreeOfFitType<see cref="DegreeOfFitTypes"/></param>
        /// <param name="appliedForces">The appliedForces<see cref="double[]"/></param>
        /// <param name="valuesForAllSeries">The valuesForAllSeries<see cref="double[][]"/></param>
        /// <returns>The <see cref="int"/></returns>
        static public int Select(DegreeOfFitTypes degreeOfFitType, double[] appliedForces, double[][] valuesForAllSeries)
        {
            return degreeOfFitType switch
            {
                DegreeOfFitTypes.One => 1,
                DegreeOfFitTypes.Two => 2,
                DegreeOfFitTypes.Three => 3,
                DegreeOfFitTypes.Four => 4,
                DegreeOfFitTypes.Five => 5,
                DegreeOfFitTypes.CalculatedDegreeOfBestFit => DetermineDegreeOfBestFittingPolynomial.Calculate(appliedForces, valuesForAllSeries),
                _ => throw new ArgumentOutOfRangeException(nameof(degreeOfFitType), degreeOfFitType, "SelectBestDegreeOfFit Invalid DegreeOfFitType")
            };
        }
    }
}
