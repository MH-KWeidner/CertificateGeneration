using System;
using System.Collections.Generic;
using System.Text;

namespace CertificateGeneration.CertificateCalculations.TemperatureCorrection
{
    public static class CalculateTemperatureCorrection
    {
        public static double Calculate(double ambientTemperature, double standardCalibrationTemperature, double temperatureCorrectionValuePer1Degree)
        {
            return temperatureCorrectionValuePer1Degree * (ambientTemperature - standardCalibrationTemperature);
        }
    }


}
