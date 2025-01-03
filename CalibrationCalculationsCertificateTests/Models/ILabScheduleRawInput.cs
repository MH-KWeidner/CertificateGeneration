namespace CalibrationCalculationsCertificateTests.Models
{
    internal interface ILabScheduleRawInput
    {
        double[] NominalForcesApplied { get; }

        double[][] MeasurementData { get; }
    }
}
