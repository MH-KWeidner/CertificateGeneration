using CertificateGeneration.IoC.Modifiers;
using CertificateGeneration.IoC.DataTransforms;
using CertificateGeneration.CertificateCalculations.Interpolation;

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

        /// <summary>
        /// Defines the dataPoints
        /// </summary>
        private List<DataPoint> dataPoints;

        /// <summary>
        /// A list of the original data points.
        /// </summary>
        private readonly List<DataPoint> originalDataPoints;

        /// <summary>
        /// Prevents a default instance of the <see cref="Series"/> class from being created.
        /// </summary>
        /// <param name="seriesId">The seriesId<see cref="int"/></param>
        /// <param name="appliedForce">The appliedForce<see cref="double[]"/></param>
        /// <param name="rawValue">The rawValue<see cref="double[]"/></param>
        private Series(int seriesId, double[] appliedForce, double[] rawValue)
        {
            id = seriesId;

            dataPoints = [];

            dataPoints.AddRange(appliedForce.Select((force, i) => new DataPoint(force, rawValue[i])));

            originalDataPoints = [];

            originalDataPoints.AddRange(appliedForce.Select((force, i) => new DataPoint(force, rawValue[i])));
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

            return dataPoints[index].RawValue;
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

            dataPoints[index].Value = value;
        }

        public void RemoveValuesByIndex(IList<int>? indexes)
        {
            //TODO add error handling

            if (indexes == null)
                return;

            dataPoints = dataPoints.Where((dp, i) => !indexes.Contains(i)).ToList();
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

            return dataPoints[index].Value;

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

            return dataPoints[index].AppliedForce;
        }

        /// <summary>
        /// The CountValues
        /// </summary>
        /// <returns>The <see cref="int"/></returns>
        public int CountValues()
        {
            //TODO add error handling - List may be null

            return dataPoints.Count;
        }

        /// <summary>
        /// The Modify
        /// </summary>
        /// <param name="modifier">The modifier<see cref="IModifySeriesSize"/></param>
        public void Modify(IModifySeriesSize modifier)
        {
            //TODO add error handling - List may be null

            dataPoints = modifier.Modify(dataPoints);
        }

        /// <summary>
        /// The Order
        /// </summary>
        /// <param name="modifier">The modifier<see cref="IOrderSeries"/></param>
        public void Order(IOrderSeries modifier)
        {
            //TODO add error handling - List may be null

            // TODO consider renaming method to Order  

            dataPoints = modifier.Order(dataPoints);
        }

        /// <summary>
        /// The Transform
        /// </summary>
        /// <param name="transform">The transform<see cref="ITransformToDoubleArray"/></param>
        /// <returns>The <see cref="double[]"/></returns>
        public double[] Transform(ITransformToDoubleArray transform)
        {
            return transform.ToArray(dataPoints);
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
        /// Creates a Series object populated with the provided data.
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
