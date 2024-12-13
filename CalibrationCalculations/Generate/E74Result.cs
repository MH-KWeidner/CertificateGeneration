using System;
using System.Collections.Generic;
using System.Text;

namespace CalibrationCalculations.CertificateCreation
{
    public class E74Result
    {
        public int DegreeOfBestFit { get; set; }
        
        double[]? ACoefficients { get; set; }

        double[]? FittedCurve { get; set; }

        double[]? interpolatedForces { get; set; }

        double[][]? interpolatedMeasurements { get; set; }
    }
}
