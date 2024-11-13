using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers.Models;
using Helpers;
using Models;
using System.Reflection.Metadata.Ecma335;

namespace Interpolation
{
    public static class UsingInitialZeroValue
    {
        public static void InterpolateSeries(IList<Series> series)
        {
            foreach(Series seriesInstance in series)
                InterpolateSeriesInstance(seriesInstance);
        }

        public static void InterpolateSeriesInstance(Series series)
        {
            //TODO consider how to test this
            
            const double DOUBLE_ZERO = 0.0;

            double? currentZeroValue = null;

            int seriesSize = series.CountValues();
            for (int i = 0; i < seriesSize; i++)
            {
                if(series.GetAppliedForce(i) == DOUBLE_ZERO)
                {
                    currentZeroValue = series.GetRawValue(i);
                    continue;
                }

                if (currentZeroValue.HasValue)
                    series.SetValue(i, series.GetRawValue(i) - currentZeroValue.Value);
            }
        }
    }
}
