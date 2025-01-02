using CalibrationCalculationsCertificateTests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationCalculationsCertificateTests.LabScheduleCertificateTestData.MethodBTestData1
{
    public class Cert1_MethodBInput : ILabScheduleInputData
    {
        public double[] NominalForcesApplied => nominalForcesApplied;

        private static readonly double[] nominalForcesApplied =
            [
                0,
                1000,
                5000,
                10000,
                15000,
                20000,
                25000,
                30000,
                35000,
                40000,
                45000,
                50000,
                20000,
                0
            ];

        public double[][] MeasurementData => [measurementData1, measurementData2, measurementData3];

        private static readonly double[] measurementData1 =
        [
            -0.00001,
            -0.08158,
            -0.4079,
            -0.81587,
            -1.22393,
            -1.63206,
            -2.04025,
            -2.4485,
            -2.85679,
            -3.26509,
            -3.67343,
            -4.08171,
            -1.63282,
            -0.00005,
        ];

        private static readonly double[] measurementData2 =
        [
                0,
                -0.08157,
                -0.40791,
                -0.81588,
                -1.22395,
                -1.63208,
                -2.04028,
                -2.44853,
                -2.85682,
                -3.26513,
                -3.67346,
                -4.08175,
                -1.63283,
                -0.00003
        ];

        private static readonly double[] measurementData3 =
        [
            -0.00001,
            -0.08158,
            -0.40791,
            -0.81589,
            -1.22396,
            -1.63209,
            -2.04028,
            -2.44853,
            -2.85681,
            -3.26513,
            -3.67345,
            -4.08171,
            -1.63282,
            -0.00003
        ];
    }
}
