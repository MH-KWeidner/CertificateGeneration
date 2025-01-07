using CalibrationCalculationsCertificateTests.LabScheduleModels;

namespace CalibrationCalculationsCertificateTests.LabScheduleTestData.LS03_MethodB_Cert_070221K0624
{
    /// <summary>
    /// Defines the <see cref="LS03_RawInput" />
    /// </summary>
    internal class LS03_RawInput : ILabScheduleRawInput
    {
        // CALIBRATION & ISSUE DATE: 11/06/2024
        // REPORT NO.: 070221K0624

        public double[] NominalForcesApplied => nominalForcesApplied;

        private static readonly double[] nominalForcesApplied =
        [
            0,
            45000,
            90000,
            135000,
            180000,
            225000,
            270000,
            315000,
            360000,
            405000,
            450000,
            0,
            0,
            9000,
            0
        ];

        public double[][] MeasurementData => [measurementData1, measurementData2, measurementData3, measurementData4];

        private static readonly double[] measurementData1 =
        [
            -0.00001,
            -0.20998,
            -0.41991,
            -0.62971,
            -0.83948,
            -1.04903,
            -1.25851,
            -1.46776,
            -1.67692,
            -1.8858,
            -2.09457,
            0.00061,
            -0.00001,
            -0.04203,
            0.0001
        ];

        private static readonly double[] measurementData2 =
        [
            -0.00005,
            -0.21024,
            -0.42026,
            -0.63014,
            -0.83996,
            -1.04954,
            -1.25905,
            -1.46834,
            -1.67753,
            -1.88645,
            -2.09526,
            0.00032,
            0,
            -0.04221,
            0.0001
        ];

        private static readonly double[] measurementData3 =
        [
            -0.00003,
            -0.21018,
            -0.4202,
            -0.63003,
            -0.83983,
            -1.04941,
            -1.2589,
            -1.46817,
            -1.67735,
            -1.88624,
            -2.09501,
            0.00049,
            0,
            -0.04215,
            0.00011
        ];

        private static readonly double[] measurementData4 =
        [
            0,
            -0.20998,
            -0.41993,
            -0.62972,
            -0.83949,
            -1.04904,
            -1.25852,
            -1.46778,
            -1.67693,
            -1.88581,
            -2.09457,
            0.00066,
            0,
            -0.04202,
            0.00009
        ];
    }
}
