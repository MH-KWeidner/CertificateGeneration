using CertificateGeneration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CertificateGeneration.Models.DataQueries;

namespace CertificateGeneration.Interpolation
{
    public class NistInterpolator : IInterpolate
    {
        public void Interpolate(Series series)
        {
            List<SeriesValue> zeroAppliedForceItems = series.Query(new QueryZeroForceItems());

            for (int i = 0; i < zeroAppliedForceItems.Count; i++)
            {
                // 2 zero-applied-force values are needed to calculate an interpolation value
                if (i + 1 == zeroAppliedForceItems.Count)
                    break;

                int indexOfStartingZeroAppliedForce = zeroAppliedForceItems[i].OriginalIndex;
                
                int indexOfEndingZeroAppliedForce = zeroAppliedForceItems[i + 1].OriginalIndex;

                // 2 consecutive zero values can not be used to calculate an interpolation value
                if (indexOfEndingZeroAppliedForce - 1 == indexOfStartingZeroAppliedForce)
                    continue;

                int numberItemsWithNonZeroForceApplied = indexOfEndingZeroAppliedForce - indexOfStartingZeroAppliedForce - 1;

                int indexOfItemWithNonZeroForceApplied = indexOfStartingZeroAppliedForce + 1;

                #region Interpolate a non-zero-applied-force point between 2 zero force points
                if (numberItemsWithNonZeroForceApplied == 1)
                {
                    var interpolatedValue = InterpolateByZeroForceAverage(
                        startZeroValue: series.GetRawValue(indexOfStartingZeroAppliedForce),
                        endZeroValue: series.GetRawValue(indexOfEndingZeroAppliedForce),
                        forceReading: series.GetRawValue(indexOfItemWithNonZeroForceApplied));

                    series.SetValue(indexOfItemWithNonZeroForceApplied, interpolatedValue);

                    continue;
                }
                #endregion

                #region Interpolate for when there is more than 1 non-zero-applied-force points between 2 zero force points
                int OneBasedSeriesPositionForNonZeroForce = 1;
                
                for (int j = indexOfItemWithNonZeroForceApplied; j < indexOfEndingZeroAppliedForce; j++)
                {
                    var interpolatedValue = CalculateNISInterpolatedValue(
                         startZeroValue: series.GetRawValue(indexOfStartingZeroAppliedForce),
                         endZeroValue: series.GetRawValue(indexOfEndingZeroAppliedForce),
                         numberOfNonZeroForcePoints: numberItemsWithNonZeroForceApplied,
                         forceReading: series.GetRawValue(j),
                         OneBasedSeriesPositionForNonZeroForce: OneBasedSeriesPositionForNonZeroForce);

                    series.SetValue(j, interpolatedValue);

                    OneBasedSeriesPositionForNonZeroForce++;
                }
                #endregion
            }
        }

        public static double CalculateNISInterpolatedValue(double startZeroValue, double endZeroValue, int numberOfNonZeroForcePoints, double forceReading, int OneBasedSeriesPositionForNonZeroForce)
        {
            //TODO better naming

            try
            {
                return forceReading - (startZeroValue + ((endZeroValue - startZeroValue) * (OneBasedSeriesPositionForNonZeroForce - 1) / (numberOfNonZeroForcePoints - 1)));
            }
            catch
            {
                //TODO add specific error handling
                throw new Exception("Error in Statistics.CalculateNISInterpolatedValue");
            }
        }

        public static double InterpolateByZeroForceAverage(double startZeroValue, double endZeroValue, double forceReading)
        {
            //TODO better naming

            try
            {
                return forceReading - ((endZeroValue + startZeroValue) / 2);
            }
            catch
            {
                //TODO add specific error handling
                throw new Exception("Error in Statistics.CalculateNISInterpolatedValue");
            }
        }
    }
}
