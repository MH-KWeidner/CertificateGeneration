namespace CalibrationCalculationsCertificateTests.MiscTestDataSets
{
    /// <summary>
    /// Defines the <see cref="MHForceWebExampleTestData" />
    /// </summary>
    public static class MHForceWebExampleTestData
    {
        // Test data from https://mhforce.com/interpolated-zero-reduction-methods/

        /// <summary>
        /// The GetAppliedForce
        /// </summary>
        /// <returns>The <see cref="double[]"/></returns>
        public static double[] GetAppliedForce()
        {
            return
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
        }

        /// <summary>
        /// The GetRawDataSeries1
        /// </summary>
        /// <returns>The <see cref="double[]"/></returns>
        public static double[] GetRawDataSeries1()
        {
            return
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
    }
}
