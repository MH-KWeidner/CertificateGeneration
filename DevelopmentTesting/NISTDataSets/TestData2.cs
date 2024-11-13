using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentTesting.NISTDataSets
{
    internal class TestData2
    {
        //TODO remove this class when no longer needed

        // CALIBRATION & ISSUE DATE: 11/06/2024
        // REPORT NO.: 226367AK0624

        public static double[] GetAppliedForce()
        {
            return
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
        }

        public static double[] GetRawDataSeries1()
        {
            return
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
        }

        public static double[] GetRawDataSeries2()
        {
            return
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
        }

        public static double[] GetRawDataSeries3()
        {
            return
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
}
