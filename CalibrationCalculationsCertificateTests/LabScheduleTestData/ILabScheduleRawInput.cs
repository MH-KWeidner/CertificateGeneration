namespace CalibrationCalculationsCertificateTests.LabScheduleTestData;

internal interface ILabScheduleRawInput
{
    double[] NominalForcesApplied { get; }

    double[][] MeasurementData { get; }
}
