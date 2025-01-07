using CalibrationCalculationsCertificateTests.LabScheduleModels;

namespace CalibrationCalculationsCertificateTests.MiscTestData;

/// <summary>
/// Defines the <see cref="Misc01_MHForceWebExample_RawInput" />
/// </summary>
internal class Misc01_MHForceWebExample_RawInput : ILabScheduleRawInput
{
    // Test data from https://mhforce.com/interpolated-zero-reduction-methods/

    public double[] NominalForcesApplied => nominalForcesApplied;

    private static readonly double[] nominalForcesApplied =
    [
        0,
        500,
        2500,
        5000,
        7500,
        10000,
        12500,
        15000,
        17500,
        20000,
        22500,
        25000,
        0
    ];

    public double[][] MeasurementData => [measurementData];

    private static readonly double[] measurementData =
    [
        0.00002,
        -0.08191,
        -0.40848,
        -0.81670,
        -1.22496,
        -1.63328,
        -2.04170,
        -2.45015,
        -2.85863,
        -3.26713,
        -3.67564,
        -4.08417,
        0.00012
    ];
}
