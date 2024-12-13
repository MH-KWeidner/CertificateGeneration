using System;
using System.Collections.Generic;
using System.Text;

namespace CertificateGeneration.CertificateCreation
{
    public class E74CertificateResult
    {
        public int DegreeOfBestFit { get; set; }
        
        double[]? ACoefficients { get; set; }

        double[]? FittedCurve { get; set; }

        double[]? interpolatedForces { get; set; }

        double[][]? interpolatedMeasurements { get; set; }
    }
}
