namespace CalibrationCalculations.StandardCalculations.TemperatureCorrection
{
    /// <summary>
    /// Defines the <see cref="CalculateTemperatureCorrection" />
    /// </summary>
    public static class CalculateTemperatureCorrection
    {
        /// <summary>
        /// The Builder
        /// </summary>
        /// <param name="ambientTemperature">The ambientTemperature<see cref="double"/></param>
        /// <param name="standardCalibrationTemperature">The standardCalibrationTemperature<see cref="double"/></param>
        /// <param name="temperatureCorrectionValuePer1Degree">The temperatureCorrectionValuePer1Degree<see cref="double"/></param>
        /// <returns>The <see cref="double"/></returns>
        public static double Calculate(double ambientTemperature, double standardCalibrationTemperature, double temperatureCorrectionValuePer1Degree)
        {
            return temperatureCorrectionValuePer1Degree * (standardCalibrationTemperature - ambientTemperature);
        }
    }
}
