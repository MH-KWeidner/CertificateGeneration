using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolationTests
{
    // CALIBRATION & ISSUE DATE: 07/01/2024
    // REPORT NO.: Useries.AddNewSeriesValue(-7989G0124

    internal class TestData2
    {
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

        public static Series GetSeries1()
        {
            var series = new Series(1);

            series.AddNewSeriesValue(-0.00001);
            series.AddNewSeriesValue(-0.08158);
            series.AddNewSeriesValue(-0.4079);
            series.AddNewSeriesValue(-0.81587);
            series.AddNewSeriesValue(-1.22393);
            series.AddNewSeriesValue(-1.63206);
            series.AddNewSeriesValue(-2.04025);
            series.AddNewSeriesValue(-2.4485);
            series.AddNewSeriesValue(-2.85679);
            series.AddNewSeriesValue(-3.26509);
            series.AddNewSeriesValue(-3.67343);
            series.AddNewSeriesValue(-4.08171);
            series.AddNewSeriesValue(-1.63282);
            series.AddNewSeriesValue(-0.00005);

            return series;
        }

        public static Series GetSeries2()
        {
            var series = new Series(2);

            series.AddNewSeriesValue(0);
            series.AddNewSeriesValue(-0.08157);
            series.AddNewSeriesValue(-0.40791);
            series.AddNewSeriesValue(-0.81588);
            series.AddNewSeriesValue(-1.22395);
            series.AddNewSeriesValue(-1.63208);
            series.AddNewSeriesValue(-2.04028);
            series.AddNewSeriesValue(-2.44853);
            series.AddNewSeriesValue(-2.85682);
            series.AddNewSeriesValue(-3.26513);
            series.AddNewSeriesValue(-3.67346);
            series.AddNewSeriesValue(-4.08175);
            series.AddNewSeriesValue(-1.63283);
            series.AddNewSeriesValue(-0.00003);



            return series;
        }

        public static Series GetSeries3()
        {
            var series = new Series(3);

            series.AddNewSeriesValue(-0.00001);
            series.AddNewSeriesValue(-0.08158);
            series.AddNewSeriesValue(-0.40791);
            series.AddNewSeriesValue(-0.81589);
            series.AddNewSeriesValue(-1.22396);
            series.AddNewSeriesValue(-1.63209);
            series.AddNewSeriesValue(-2.04028);
            series.AddNewSeriesValue(-2.44853);
            series.AddNewSeriesValue(-2.85681);
            series.AddNewSeriesValue(-3.26513);
            series.AddNewSeriesValue(-3.67345);
            series.AddNewSeriesValue(-4.08171);
            series.AddNewSeriesValue(-1.63282);
            series.AddNewSeriesValue(-0.00003);

            return series;
        }
    }
}
