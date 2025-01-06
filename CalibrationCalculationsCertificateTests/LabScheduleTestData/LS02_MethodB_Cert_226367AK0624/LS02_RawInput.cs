using CalibrationCalculationsCertificateTests.Models;

namespace CalibrationCalculationsCertificateTests.LabScheduleCertificateTestData.LS02_MethodB_Cert_226367AK0624
{
    /// <summary>
    /// Defines the <see cref="LS02_RawInput" />
    /// </summary>
    internal class LS02_RawInput : ILabScheduleRawInput
    {
        // CALIBRATION & ISSUE DATE: 11/06/2024
        // REPORT NO.: 226367AK0624
        // Degree of Fit: Best Fit from LabSch is 3


        public double[] NominalForcesApplied => nominalForcesApplied;

        private static readonly double[] nominalForcesApplied =
        [
            0,
            200,
            1000,
            2000,
            3000,
            4000,
            5000,
            6000,
            7000,
            8000,
            9000,
            10000,
            4000,
            0
        ];

        public double[][] MeasurementData => [measurementData1, measurementData2, measurementData3];

        private static readonly double[] measurementData1 =
        [
            -0.012945,
            -0.094522,
            -0.421162,
            -0.82959,
            -1.238096,
            -1.646677,
            -2.055324,
            -2.464048,
            -2.872841,
            -3.281682,
            -3.690589,
            -4.099538,
            -1.647374,
            -0.013032
        ];


        private static readonly double[] measurementData2 =
        [
            -0.012863,
            -0.094495,
            -0.421204,
            -0.829649,
            -1.238159,
            -1.646742,
            -2.055398,
            -2.464131,
            -2.872932,
            -3.281777,
            -3.690693,
            -4.099652,
            -1.647437,
            -0.012988
    ];


        private static readonly double[] measurementData3 =
        [
            -0.012889,
            -0.094517,
            -0.421216,
            -0.82966,
            -1.238174,
            -1.646763,
            -2.055435,
            -2.46416,
            -2.872961,
            -3.281814,
            -3.690713,
            -4.099662,
            -1.647477,
            -0.013017,
        ];
        
    }
}
