using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Series
    {
        private readonly int id;
        private List<SeriesValue> seriesValues;

        private Series(int seriesId, double[] appliedForce, double[] rawValue)
        {
            id = seriesId;

            seriesValues = [];

            for (int i = 0; i < appliedForce.Length; i++)
            {
                seriesValues.Add(new SeriesValue(i, appliedForce[i], rawValue[i]));
            }
        }

        public int Id => id;

        public double GetRawValue(int PositionInSeries)
        {
            // TODO add validation for positionInSeries
            //TODO add error handling

            return seriesValues[PositionInSeries].RawValue;
        }

        public void SetInterpolatedValue(int positionInSeries, double value)
        {
            // TODO add validation for positionInSeries
            //TODO add error handling

            seriesValues[positionInSeries].InterpolatedValue = value;
        }

        public double GetInterpolatedValue(int PositionInSeries)
        {
            // TODO add validation for positionInSeries
            //TODO add error handling

            if (seriesValues[PositionInSeries].InterpolatedValue.HasValue)
                return seriesValues[PositionInSeries].InterpolatedValue.Value;

            throw new Exception("Raw value is null");
        }

        public void ZeroReduceAndSortByAppliedForceAscending()
        {
            //TODO consider if this is the best way to order theses values

            //TODO how to test this method

            //change this to use IoC passing in modifier objects

            seriesValues = seriesValues.OrderBy(sv => sv.AppliedForce).Where(sv => sv.AppliedForce > 0).ToList();
        }

        public static Series CreateSeries(int seriesId, double[] appliedForces, double[] rawValues)
        {
            return new Series(seriesId, appliedForces, rawValues);
        }
    }
}
