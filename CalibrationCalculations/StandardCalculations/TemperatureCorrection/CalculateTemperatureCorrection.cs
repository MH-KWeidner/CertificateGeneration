using System;
using System.Collections.Generic;
using System.Text;

namespace CalibrationCalculations.StandardCalculations.TemperatureCorrection
{
    public static class CalculateTemperatureCorrection
    {
        public static double Calculate(double ambientTemperature, double standardCalibrationTemperature, double temperatureCorrectionValuePer1Degree)
        {
            return temperatureCorrectionValuePer1Degree * (standardCalibrationTemperature - ambientTemperature);
        }
    }
}
