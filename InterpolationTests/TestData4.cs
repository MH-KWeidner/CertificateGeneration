using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolationTests
{
    internal class TestData4
    {
        //TODO remove this class when no longer needed

        // CALIBRATION & ISSUE DATE: 10/30/2024
        // REPORT NO.: 10245(NEG)J3024

        public static double[] GetAppliedForce()
        {
            return
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
        }

        public static double[] GetRawDataSeries1()
        {
            return
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
        }

        public static double[] GetRawDataSeries2()
        {
            return
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
        }

        public static double[] GetRawDataSeries3()
        {
            return
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
    }
}
