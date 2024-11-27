using CertificateGeneration.Models;
using CertificateGeneration.IoC.DataQueries;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace CertificateGeneration.CertificateCalculations.Interpolation
{
    /// <summary>
    /// Defines the <see cref="NistInterpolator" />
    /// </summary>
    public class NistInterpolator : IInterpolate
    {
        /// <summary>
        /// The Interpolate
        /// </summary>
        /// <param name="series">The series<see cref="Series"/></param>
        public void Interpolate(Series series)
        {
            if (series == null)
                return;
            
            // Get positions of zero force values in the series
            IList<int> zeroForcePositions = GetZeroAppliedForcePositions(series);

            //List<DataPoint> zeroAppliedForceItems = series.Query(new QueryZeroForceItems());

            for (int i = 0; i < zeroForcePositions.Count; i++)
            {
                // 2 zero-applied-force values are needed to calculate an interpolation value
                if (i + 1 == zeroForcePositions.Count)
                    break;

                int indexOfStartingZeroAppliedForce = zeroForcePositions[i];

                int indexOfEndingZeroAppliedForce = zeroForcePositions[i + 1];

                // 2 consecutive zero values can not be used to calculate an interpolation value
                if (indexOfEndingZeroAppliedForce - 1 == indexOfStartingZeroAppliedForce)
                    continue;

                int numberItemsWithNonZeroForceApplied = indexOfEndingZeroAppliedForce - indexOfStartingZeroAppliedForce - 1;

                int indexOfItemWithNonZeroForceApplied = indexOfStartingZeroAppliedForce + 1;

                if (numberItemsWithNonZeroForceApplied == 1)
                {
                    var interpolatedValue = InterpolateByZeroForceAverage(
                        startZeroValue: series.GetRawValue(indexOfStartingZeroAppliedForce),
                        endZeroValue: series.GetRawValue(indexOfEndingZeroAppliedForce),
                        forceReading: series.GetRawValue(indexOfItemWithNonZeroForceApplied));

                    series.SetValue(indexOfItemWithNonZeroForceApplied, interpolatedValue);

                    continue;
                }

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
            }
        }

        /// <summary>
        /// The CalculateNISInterpolatedValue
        /// </summary>
        /// <param name="startZeroValue">The startZeroValue<see cref="double"/></param>
        /// <param name="endZeroValue">The endZeroValue<see cref="double"/></param>
        /// <param name="numberOfNonZeroForcePoints">The numberOfNonZeroForcePoints<see cref="int"/></param>
        /// <param name="forceReading">The forceReading<see cref="double"/></param>
        /// <param name="OneBasedSeriesPositionForNonZeroForce">The OneBasedSeriesPositionForNonZeroForce<see cref="int"/></param>
        /// <returns>The <see cref="double"/></returns>
        public static double CalculateNISInterpolatedValue(double startZeroValue, double endZeroValue, int numberOfNonZeroForcePoints, double forceReading, int OneBasedSeriesPositionForNonZeroForce)
        {
            //TODO better naming

            try
            {
                return forceReading - (startZeroValue + (endZeroValue - startZeroValue) * (OneBasedSeriesPositionForNonZeroForce - 1) / (numberOfNonZeroForcePoints - 1));
            }
            catch
            {
                //TODO add specific error handling
                throw new Exception("Error in Statistics.CalculateNISInterpolatedValue");
            }
        }

        /// <summary>
        /// The InterpolateByZeroForceAverage
        /// </summary>
        /// <param name="startZeroValue">The startZeroValue<see cref="double"/></param>
        /// <param name="endZeroValue">The endZeroValue<see cref="double"/></param>
        /// <param name="forceReading">The forceReading<see cref="double"/></param>
        /// <returns>The <see cref="double"/></returns>
        public static double InterpolateByZeroForceAverage(double startZeroValue, double endZeroValue, double forceReading)
        {
            //TODO better naming

            try
            {
                return forceReading - (endZeroValue + startZeroValue) / 2;
            }
            catch
            {
                //TODO add specific error handling
                throw new Exception("Error in Statistics.CalculateNISInterpolatedValue");
            }
        }

        public IList<int> GetZeroAppliedForcePositions(Series series)
        {
            // TODO add null check and error handling

            return Enumerable.Range(0, series.CountValues())
                    .Where(i => series.GetAppliedForce(i) == 0.0)
                    .ToList();
        }
    }
}
