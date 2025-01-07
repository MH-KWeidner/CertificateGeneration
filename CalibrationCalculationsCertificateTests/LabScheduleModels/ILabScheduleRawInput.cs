namespace CalibrationCalculationsCertificateTests.LabScheduleModels
{
    internal interface ILabScheduleRawInput
    {
        double[] NominalForcesApplied { get; }

        double[][] MeasurementData { get; }
    }
}
