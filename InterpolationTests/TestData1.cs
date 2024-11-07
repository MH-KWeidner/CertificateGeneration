using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace InterpolationTests
{
    //TODO remove this class when no longer needed

    public static class TestData1
    {
        private static int SeriesSize = 15;

        public static double[] GetAppliedForce()
        {
           var appliedForce = new double[SeriesSize];
            appliedForce[0] = 0;
            appliedForce[1] = 10;
            appliedForce[2] = 20;
            appliedForce[3] = 30;
            appliedForce[4] = 40;
            appliedForce[5] = 50;
            appliedForce[6] = 60;
            appliedForce[7] = 70;
            appliedForce[8] = 80;
            appliedForce[9] = 90;
            appliedForce[10] = 100;
            appliedForce[11] = 0;
            appliedForce[12] = 0;
            appliedForce[13] = 2;
            appliedForce[14] = 0;
           
            return appliedForce;
        }
            
        public static Series GetSeries1()
        {
            var series = new Series(1);

            series.AddNewSeriesValue(0.00000);
            series.AddNewSeriesValue(-0.21162);
            series.AddNewSeriesValue(-0.42326);
            series.AddNewSeriesValue(-0.63491);
            series.AddNewSeriesValue(-0.84657);
            series.AddNewSeriesValue(-1.05826);
            series.AddNewSeriesValue(-1.26996);
            series.AddNewSeriesValue(-1.48167);
            series.AddNewSeriesValue(-1.69339);
            series.AddNewSeriesValue(-1.90509);
            series.AddNewSeriesValue(-2.11680);
            series.AddNewSeriesValue(-0.00018);
            series.AddNewSeriesValue(0.00000);
            series.AddNewSeriesValue(-0.04234);
            series.AddNewSeriesValue(0.00000);

            return series;
        }

        public static Series GetSeries2()
        {
            var series = new Series(2);

            series.AddNewSeriesValue(-0.00002);
            series.AddNewSeriesValue(-0.21163);
            series.AddNewSeriesValue(-0.42326);
            series.AddNewSeriesValue(-0.63490);
            series.AddNewSeriesValue(-0.84655);
            series.AddNewSeriesValue(-1.05824);
            series.AddNewSeriesValue(-1.26992);
            series.AddNewSeriesValue(-1.48161);
            series.AddNewSeriesValue(-1.69334);
            series.AddNewSeriesValue(-1.90505);
            series.AddNewSeriesValue(-2.11674);
            series.AddNewSeriesValue(-0.00015);
            series.AddNewSeriesValue(-0.00001);
            series.AddNewSeriesValue(-0.04231);
            series.AddNewSeriesValue(-0.00001);

            return series;
        }

    }
}
