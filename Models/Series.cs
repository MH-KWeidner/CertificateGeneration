using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Series
    {
        private int id;
        private readonly List<SeriesValue> seriesValues;

       public Series(int seriesId)
        {
            id = seriesId;
            seriesValues = [];
        }

        public void AddNewSeriesValue(double rawValue)
        {
            //TODO add error handling

            seriesValues.Add(new SeriesValue(seriesValues.Count, rawValue));
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
    }
}
