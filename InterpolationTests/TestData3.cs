using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolationTests
{
    internal class TestData3
    {
        //CALIBRATION & ISSUE DATE: 11/06/2024
        //REPORT NO.: 226367AK0624

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

        public static Series GetSeries1()
        {
            var series = new Series(1);

            series.AddNewSeriesValue(-0.012945);
            series.AddNewSeriesValue(-0.094522);
            series.AddNewSeriesValue(-0.421162);
            series.AddNewSeriesValue(-0.82959);
            series.AddNewSeriesValue(-1.238096);
            series.AddNewSeriesValue(-1.646677);
            series.AddNewSeriesValue(-2.055324);
            series.AddNewSeriesValue(-2.464048);
            series.AddNewSeriesValue(-2.872841);
            series.AddNewSeriesValue(-3.281682);
            series.AddNewSeriesValue(-3.690589);
            series.AddNewSeriesValue(-4.099538);
            series.AddNewSeriesValue(-1.647374);
            series.AddNewSeriesValue(-0.013032);

            return series;
        }

        public static Series GetSeries2()
        {
            var series = new Series(2);

            series.AddNewSeriesValue(-0.012863);
            series.AddNewSeriesValue(-0.094495);
            series.AddNewSeriesValue(-0.421204);
            series.AddNewSeriesValue(-0.829649);
            series.AddNewSeriesValue(-1.238159);
            series.AddNewSeriesValue(-1.646742);
            series.AddNewSeriesValue(-2.055398);
            series.AddNewSeriesValue(-2.464131);
            series.AddNewSeriesValue(-2.872932);
            series.AddNewSeriesValue(-3.281777);
            series.AddNewSeriesValue(-3.690693);
            series.AddNewSeriesValue(-4.099652);
            series.AddNewSeriesValue(-1.647437);
            series.AddNewSeriesValue(-0.012988);

            return series;
        }

        public static Series GetSeries3()
        {
            var series = new Series(3);

            series.AddNewSeriesValue(-0.012889);
            series.AddNewSeriesValue(-0.094517);
            series.AddNewSeriesValue(-0.421216);
            series.AddNewSeriesValue(-0.82966);
            series.AddNewSeriesValue(-1.238174);
            series.AddNewSeriesValue(-1.646763);
            series.AddNewSeriesValue(-2.055435);
            series.AddNewSeriesValue(-2.46416);
            series.AddNewSeriesValue(-2.872961);
            series.AddNewSeriesValue(-3.281814);
            series.AddNewSeriesValue(-3.690713);
            series.AddNewSeriesValue(-4.099662);
            series.AddNewSeriesValue(-1.647477);
            series.AddNewSeriesValue(-0.013017);

            return series;
        }
    }
}
