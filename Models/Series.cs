using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Modifiers;
using Models.DataTransform;

namespace Models
{
    public class Series
    {
        private readonly int id;

        // TODO remove if not needed.
        // retain original raw values
        private readonly List<SeriesValue> originalValuesCache;
        
        private List<SeriesValue> seriesValues;

        private Series(int seriesId, double[] appliedForce, double[] rawValue)
        {
            id = seriesId;

            originalValuesCache = [];
            seriesValues = [];

            for (int i = 0; i < appliedForce.Length; i++)
            {
                originalValuesCache.Add(new SeriesValue(i, appliedForce[i], rawValue[i]));
                seriesValues.Add(new SeriesValue(i, appliedForce[i], rawValue[i]));
            }
        }

        public int Id => id;

        public double GetRawValue(int index)
        {
            // TODO add validation for index
            //TODO add error handling

            return seriesValues[index].RawValue;
        }

        public void SetValue(int index, double value)
        {
            // TODO add validation for index
            //TODO add error handling

            seriesValues[index].Value = value;
        }

        public double GetValue(int index)
        {
            // TODO add validation for index
            //TODO add error handling


            return seriesValues[index].Value;

            throw new Exception("Value is null");
        }

        public double GetAppliedForce(int index)
        {
            // TODO add validation for index
            //TODO add error handling

            return seriesValues[index].AppliedForce;
        }

        public int CountValues()
        {
            //TODO add error handling - List may be null

            return seriesValues.Count;
        }

        public void Modify(IModifySeriesSize modifier)
        {
            //TODO add error handling - List may be null

            seriesValues = modifier.Modify(seriesValues);
        }

        public void Modify(IOrderSeries modifier)
        {
            //TODO add error handling - List may be null

            seriesValues = modifier.Order(seriesValues);
        }

        public double[] Transform(ITransformSeriesArray transform)
        {
            return transform.ToArray(seriesValues);
        }


        public static Series CreateSeries(int seriesId, double[] appliedForces, double[] rawValues)
        {
            // TODO consider removing this method in favor of a constructor

            return new Series(seriesId, appliedForces, rawValues);
        }
    }
}
