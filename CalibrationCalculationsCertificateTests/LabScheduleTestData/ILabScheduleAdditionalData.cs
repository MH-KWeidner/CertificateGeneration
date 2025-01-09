namespace CalibrationCalculationsCertificateTests.LabScheduleTestData;

/// <summary>
/// Defines the <see cref="ILabScheduleAdditionalData" />
/// </summary>
internal interface ILabScheduleAdditionalData
{
    /// <summary>
    /// The "raw" coefficients values from LabSchedule, copied during execution/break points in the MathNet.Numerics polynomial fit. 
    /// </summary>
    /// <param name="degree"></param>
    /// <returns></returns>
    internal double[] GetRawMathNetACoefficients(int degree);
}
