using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Modifiers;

namespace Models
{
    public class Series
    {
        private readonly int id;
        private readonly List<SeriesValue> originalValues;
        private List<SeriesValue> seriesValues;

        private Series(int seriesId, double[] appliedForce, double[] rawValue)
        {
            id = seriesId;

            originalValues = [];
            seriesValues = [];

            for (int i = 0; i < appliedForce.Length; i++)
            {
                originalValues.Add(new SeriesValue(i, appliedForce[i], rawValue[i]));
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

            if (seriesValues[index].Value.HasValue)
                return seriesValues[index].Value.Value;

            throw new Exception("Value is null");
        }

        public double GetAppliedForce(int index)
        {
            // TODO add validation for index
            //TODO add error handling

            return seriesValues[index].AppliedForce;
        }

        public void ZeroReduceAndSortByAppliedForceAscending()
        {
            //TODO consider if this is the best way to order theses values

            //TODO how to test this method

            //change this to use IoC passing in modifier objects

            seriesValues = seriesValues.OrderBy(sv => sv.AppliedForce).Where(sv => sv.AppliedForce > 0).ToList();
        }

        public int CountValues()
        {
            //TODO add error handling - List may be null

            return seriesValues.Count;
        }

        public void Modify(IModifySeries modifier)
        {
            seriesValues = modifier.Modify(seriesValues);
        }

        public static Series CreateSeries(int seriesId, double[] appliedForces, double[] rawValues)
        {
            return new Series(seriesId, appliedForces, rawValues);
        }
    }
}
