namespace CalibrationCalculationsCertificateTests.LabScheduleTestData.LS06_MethodA_Cert_C_10968LOK1424
{
    /// <summary>
    /// Defines the <see cref="MethodAInitialZeroTestData2" />
    /// </summary>
    internal class MethodAInitialZeroTestData2
    {
        // CALIBRATION & ISSUE DATE: 11/14/2024
        // REPORT NO.: C-10968(LO) K1424

        // NOTES:
        // This is compression data, but raw data includes tension data.
        // Raw data is in lbf, but actual cert is in N.
        //  ie will require conversion to N, in order to test value assertions.

        /// <summary>
        /// The GetAppliedForce
        /// </summary>
        /// <returns>The <see cref="double[]"/></returns>
        public static double[] GetAppliedForce()
        {
            return
            [
                0,
                2.5,
                5,
                10,
                12.5,
                15,
                20,
                22.5,
                25,
                30,
                32.5,
                35,
                20,
                0,
                0,
                1,
                0,
            ];
        }

        // Values missing from raw data
        //public static double[] GetRawDataSeries1()
        //{
        //    return
        //    [
        //    ];
        //}

        // Values missing from raw data
        //public static double[] GetRawDataSeries2()
        //{
        //    return
        //    [
        //    ];
        //}

        /// <summary>
        /// The GetRawDataSeries3
        /// </summary>
        /// <returns>The <see cref="double[]"/></returns>
        public static double[] GetRawDataSeries3()
        {
            return
            [
                3,
                -8311,
                -16628,
                -33263,
                -41582,
                -49897,
                -66529,
                -74844,
                -83162,
                -99793,
                -108107,
                -116425,
                -66530,
                8,
                3,
                -3324,
                3,
            ];
        }

        /// <summary>
        /// The GetRawDataSeries4
        /// </summary>
        /// <returns>The <see cref="double[]"/></returns>
        public static double[] GetRawDataSeries4()
        {
            return
            [
                1,
                -8316,
                -16633,
                -33289,
                -41600,
                -49928,
                -66549,
                -74839,
                -83124,
                -99800,
                -108127,
                -116396,
                -66662,
                6,
                1,
                -3326,
                1
            ];
        }

        /// <summary>
        /// The GetRawDataSeries5
        /// </summary>
        /// <returns>The <see cref="double[]"/></returns>
        public static double[] GetRawDataSeries5()
        {
            return
            [
                -9,
                -8322,
                -16638,
                -33272,
                -41589,
                -49908,
                -66540,
                -74856,
                -83174,
                -99805,
                -108121,
                -116439,
                -66538,
                3,
                -9,
                -3334,
                -9
            ];
        }

        /// <summary>
        /// The GetRawDataSeries6
        /// </summary>
        /// <returns>The <see cref="double[]"/></returns>
        public static double[] GetRawDataSeries6()
        {
            return
            [
                1,
                -8314,
                -16631,
                -33269,
                -41585,
                -49896,
                -66537,
                -74856,
                -83174,
                -99809,
                -108122,
                -116440,
                -66538,
                6,
                1,
                -3324,
                1
            ];
        }
    }
}
