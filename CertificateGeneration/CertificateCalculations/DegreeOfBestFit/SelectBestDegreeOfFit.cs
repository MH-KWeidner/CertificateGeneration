using System;
using System.Collections.Generic;
using System.Text;

namespace CertificateGeneration.CertificateCalculations.DegreeOfBestFit
{
    static public class SelectBestDegreeOfFit
    {
        static public int Select(DegreeOfFitTypes degreeOfFitType, double[] appliedForces, double[][] valuesForAllSeries)
        {
            return degreeOfFitType switch
            {
                DegreeOfFitTypes.One => 1,
                DegreeOfFitTypes.Two => 2,
                DegreeOfFitTypes.Three => 3,
                DegreeOfFitTypes.Four => 4,
                DegreeOfFitTypes.Five => 5,
                DegreeOfFitTypes.DegreeOfBestFit => DetermineDegreeOfBestFittingPolynomial.Calculate(appliedForces, valuesForAllSeries),
                _ => throw new ArgumentOutOfRangeException(nameof(degreeOfFitType), degreeOfFitType, "SelectBestDegreeOfFit Invalid DegreeOfFitType")
            };
        }
    }
}
