using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace InterpolationTests
{
    //TODO remove this class when no longer needed

    // Test data from https://mhforce.com/interpolated-zero-reduction-methods/

    public static class TestData1
    {
        public static double[] GetAppliedForce()
        {
            int SeriesSize = 13;
            var appliedForce = new double[SeriesSize];
            
            appliedForce[0] = 0;
            appliedForce[1] = 500;
            appliedForce[2] = 2500;
            appliedForce[3] = 5000;
            appliedForce[4] = 7500;
            appliedForce[5] = 10000;
            appliedForce[6] = 12500;
            appliedForce[7] = 15000;
            appliedForce[8] = 17500;
            appliedForce[9] = 20000;
            appliedForce[10] = 22500;
            appliedForce[11] = 25000;
            appliedForce[12] = 0;
            
            return appliedForce;
        }
            
        public static Series GetSeries1()
        {
            var series = new Series(1);

            series.AddNewSeriesValue(0.00002);
            series.AddNewSeriesValue(-0.08191);
            series.AddNewSeriesValue(-0.40848);
            series.AddNewSeriesValue(-0.81670);
            series.AddNewSeriesValue(-1.22496);
            series.AddNewSeriesValue(-1.63328);
            series.AddNewSeriesValue(-2.04170);
            series.AddNewSeriesValue(-2.45015);
            series.AddNewSeriesValue(-2.85863);
            series.AddNewSeriesValue(-3.26713);
            series.AddNewSeriesValue(-3.67564);
            series.AddNewSeriesValue(-4.08417);
            series.AddNewSeriesValue(0.00012);

            return series;
        }
    }
}
