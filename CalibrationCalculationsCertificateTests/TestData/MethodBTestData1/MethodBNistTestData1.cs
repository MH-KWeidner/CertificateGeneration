﻿namespace CalibrationCalculationsCertificateTests.TestData.MethodBTestData1
{
    /// <summary>
    /// Defines the <see cref="MethodBNistTestData1" />
    /// </summary>
    internal class MethodBNistTestData1
    {
        // CALIBRATION & ISSUE DATE: 07/01/2024
        // REPORT NO.: U-7989G0124
        // Degree of Fit: Best Fit from LabSch is 4

        /// <summary>
        /// The GetAppliedForce
        /// </summary>
        /// <returns>The <see cref="double[]"/></returns>
        public static double[] GetAppliedForce()
        {
            return
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
        }

        /// <summary>
        /// The GetRawDataSeries1
        /// </summary>
        /// <returns>The <see cref="double[]"/></returns>
        public static double[] GetRawDataSeries1()
        {
            return
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
        }

        /// <summary>
        /// The GetRawDataSeries2
        /// </summary>
        /// <returns>The <see cref="double[]"/></returns>
        public static double[] GetRawDataSeries2()
        {
            return
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
        }

        /// <summary>
        /// The GetRawDataSeries3
        /// </summary>
        /// <returns>The <see cref="double[]"/></returns>
        public static double[] GetRawDataSeries3()
        {
            return
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
}
