namespace CalibrationCalculationsCertificateTests.LabScheduleTestData.LS04_MethodB_Cert_10245NEGJ3024;

/// <summary>
/// Defines the <see cref="LS04_RawInput" />
/// </summary>
internal class LS04_RawInput : ILabScheduleRawInput
{
    // CALIBRATION & ISSUE DATE: 10/30/2024
    // REPORT NO.: 10245(NEG)J3024
    // Degree of Fit: Best Fit from LabSch is 2

    public double[] NominalForcesApplied => nominalForcesApplied;
    
    private static readonly double[] nominalForcesApplied =
    [
        0,
        0.04,
        0.07999,
        0.19999,
        0.39997,
        0.79998,
        1.19998,
        1.59998,
        1.99998,
        2.39997,
        3.2,
        3.99997,
        4.39995,
        0
    ];

    public double[][] MeasurementData => [measurementData1, measurementData2, measurementData3];

    private static readonly double[] measurementData1 =
    [
        0,
        -0.04,
        -0.08,
        -0.2,
        -0.39997,
        -0.79999,
        -1.19998,
        -1.59998,
        -1.99998,
        -2.39998,
        -3.20001,
        -4.00002,
        -4.40001,
        0
    ];

    private static readonly double[] measurementData2 =
    [
        0,
        -0.04,
        -0.08,
        -0.2,
        -0.39997,
        -0.79999,
        -1.19998,
        -1.59998,
        -1.99998,
        -2.39998,
        -3.20001,
        -4.00002,
        -4.40001,
        0
    ];

    private static readonly double[] measurementData3 =
    [
        0,
        -0.04,
        -0.07999,
        -0.2,
        -0.39998,
        -0.79998,
        -1.19998,
        -1.59999,
        -1.99999,
        -2.39998,
        -3.20002,
        -4.00003,
        -4.40001,
        -0.00001,
    ];
}
