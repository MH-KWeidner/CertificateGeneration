namespace CalibrationCalculationsCertificateTests.LabScheduleModels;

/// <summary>
/// Defines the <see cref="ILabScheduleAdditionalData" />
/// </summary>
internal interface ILabScheduleAdditionalData
{
    internal double[] GetMathNetACoefficients(int degree);
}
