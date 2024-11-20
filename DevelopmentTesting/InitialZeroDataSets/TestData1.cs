using CertificateGeneration.Models.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentTesting.InitialZeroDataSets
{
    internal class TestData1
    {
        //TODO remove this class when no longer needed

        // CALIBRATION & ISSUE DATE: 10/08/2024
        // REPORT NO.: 103443AJ0824

        public static double[] GetAppliedForce()
        {
            return
            [
                0,
                400,
                500,
                1000,
                200, //1500,
                2000,
                2500,
                3000,
                3500,
                4000,
                4500,
                5000,
                0
            ];
        }

        public static double[] GetRawDataSeries1()
        {
            return
            [
                0,
                405,
                506,
                1012,
                1518,
                2024,
                2531,
                3037,
                3543,
                4050,
                4556,
                5063,
                0
            ];
        }

        public static double[] GetRawDataSeries2()
        {
            return
            [
                0,
                405,
                506,
                1012,
                1518,
                2024,
                2531,
                3037,
                3543,
                4050,
                4556,
                5063,
                0
            ];
        }

        public static double[] GetRawDataSeries3()
        {
            return 
            [
                0,
                405,
                506,
                1013,
                1519,
                2025,
                2531,
                3037,
                3543,
                4050,
                4556,
                5063,
                0
            ];
        }
    }
}
