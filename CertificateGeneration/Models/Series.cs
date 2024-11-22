using CertificateGeneration.Interpolation;
using CertificateGeneration.Models.DataQueries;
using CertificateGeneration.Models.DataTransform;
using CertificateGeneration.Models.Modifiers;

namespace CertificateGeneration.Models
{
    /// <summary>
    /// Defines the <see cref="Series" />
    /// </summary>
    public class Series
    {
        /// <summary>
        /// Defines the id
        /// </summary>
        private readonly int id;

        // TODO remove if not needed.

        // retain original raw values

        /// <summary>
        /// Defines the originalValuesCache
        /// </summary>
        private readonly List<SeriesValue> originalValuesCache;

        /// <summary>
        /// Defines the seriesValues
        /// </summary>
        private List<SeriesValue> seriesValues;

        /// <summary>
        /// Prevents a default instance of the <see cref="Series"/> class from being created.
        /// </summary>
        /// <param name="seriesId">The seriesId<see cref="int"/></param>
        /// <param name="appliedForce">The appliedForce<see cref="double[]"/></param>
        /// <param name="rawValue">The rawValue<see cref="double[]"/></param>
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

        /// <summary>
        /// Gets the Id
        /// </summary>
        public int Id => id;

        /// <summary>
        /// The GetRawValue
        /// </summary>
        /// <param name="index">The index<see cref="int"/></param>
        /// <returns>The <see cref="double"/></returns>
        public double GetRawValue(int index)
        {
            // TODO add validation for index
            //TODO add error handling

            return seriesValues[index].RawValue;
        }

        /// <summary>
        /// The SetValue
        /// </summary>
        /// <param name="index">The index<see cref="int"/></param>
        /// <param name="value">The value<see cref="double"/></param>
        public void SetValue(int index, double value)
        {
            // TODO add validation for index
            //TODO add error handling

            seriesValues[index].Value = value;
        }

        /// <summary>
        /// The GetValue
        /// </summary>
        /// <param name="index">The index<see cref="int"/></param>
        /// <returns>The <see cref="double"/></returns>
        public double GetValue(int index)
        {
            // TODO add validation for index
            //TODO add error handling

            return seriesValues[index].Value;

            throw new Exception("Value is null");
        }

        /// <summary>
        /// The GetAppliedForce
        /// </summary>
        /// <param name="index">The index<see cref="int"/></param>
        /// <returns>The <see cref="double"/></returns>
        public double GetAppliedForce(int index)
        {
            // TODO add validation for index
            //TODO add error handling

            return seriesValues[index].AppliedForce;
        }

        /// <summary>
        /// The CountValues
        /// </summary>
        /// <returns>The <see cref="int"/></returns>
        public int CountValues()
        {
            //TODO add error handling - List may be null

            return seriesValues.Count;
        }

        /// <summary>
        /// The Modify
        /// </summary>
        /// <param name="modifier">The modifier<see cref="IModifySeriesSize"/></param>
        public void Modify(IModifySeriesSize modifier)
        {
            //TODO add error handling - List may be null

            seriesValues = modifier.Modify(seriesValues);
        }

        /// <summary>
        /// The Order
        /// </summary>
        /// <param name="modifier">The modifier<see cref="IOrderSeries"/></param>
        public void Order(IOrderSeries modifier)
        {
            //TODO add error handling - List may be null

            // TODO consider renaming method to Order  

            seriesValues = modifier.Order(seriesValues);
        }

        /// <summary>
        /// The Transform
        /// </summary>
        /// <param name="transform">The transform<see cref="ITransformToDoubleArray"/></param>
        /// <returns>The <see cref="double[]"/></returns>
        public double[] Transform(ITransformToDoubleArray transform)
        {
            return transform.ToArray(seriesValues);
        }

        /// <summary>
        /// The Query
        /// </summary>
        /// <param name="querySeries">The querySeries<see cref="IQuerySeries"/></param>
        /// <returns>The <see cref="List{SeriesValue}"/></returns>
        public List<SeriesValue> Query(IQuerySeries querySeries)
        {
            return querySeries.Query(seriesValues);
        }

        /// <summary>
        /// The Interpolate
        /// </summary>
        /// <param name="interpolator">The interpolator<see cref="IInterpolate"/></param>
        public void Interpolate(IInterpolate interpolator)
        {
            interpolator.Interpolate(this);
        }

        /// <summary>
        /// The CreateSeries
        /// </summary>
        /// <param name="seriesId">The seriesId<see cref="int"/></param>
        /// <param name="appliedForces">The appliedForces<see cref="double[]"/></param>
        /// <param name="rawValues">The rawValues<see cref="double[]"/></param>
        /// <returns>The <see cref="Series"/></returns>
        public static Series CreateSeries(int seriesId, double[] appliedForces, double[] rawValues)
        {
            // TODO consider removing this method in favor of a constructor

            return new Series(seriesId, appliedForces, rawValues);
        }
    }
}
