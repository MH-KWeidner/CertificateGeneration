using CertificateGeneration.IoC.Modifiers;
using CertificateGeneration.IoC.DataTransforms;
using CertificateGeneration.CertificateCalculations.Interpolation;
using CertificateGeneration.CertificateCalculations.TemperatureCorrection;

namespace CertificateGeneration.Models
{
    /// <summary>
    /// Defines the <see cref="MeasurementSeries" />
    /// </summary>
    public class MeasurementSeries
    {
        /// <summary>
        /// Defines the id
        /// </summary>
        private readonly int id;

        /// <summary>
        /// Defines the dataPoints
        /// </summary>
        private List<MeasurementDataPoint> dataPoints;

        /// <summary>
        /// Prevents a default instance of the <see cref="MeasurementSeries"/> class from being created.
        /// </summary>
        /// <param name="seriesId">The seriesId<see cref="int"/></param>
        /// <param name="nominalAppliedForce">The nominalAppliedForce<see cref="double[]"/></param>
        /// <param name="measurementData">The measurementData<see cref="double[]"/></param>
        private MeasurementSeries(int seriesId, double[] nominalAppliedForce, double[] actualAppliedForce, double[] measurementData)
        {
            id = seriesId;

            dataPoints = [];

            dataPoints.AddRange(nominalAppliedForce.Select((force, i) => new MeasurementDataPoint(force, actualAppliedForce[i], measurementData[i])));
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
        /// <param name="value">The valueToAdd<see cref="double"/></param>
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

        
        public void IncreaseValuesByAdd(double valueToAdd)
        {
            if(valueToAdd == 0)
                return;

            // TODO add error handling  

            for (int i = 0; i < dataPoints.Count; i++)
                SetValue(i, GetValue(i) + valueToAdd);
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

            return dataPoints[index].NominalAppliedForce;
        }

        /// <summary>
        /// Count
        /// </summary>
        /// <returns>The number of Data Points<see cref="int"/></returns>
        public int Count()
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
        /// The Reorder
        /// </summary>
        /// <param name="modifier">The modifier<see cref="IReorderSeries"/></param>
        public void ReorderSeries(IReorderSeries modifier)
        {
            //TODO add error handling - List may be null

            // TODO consider renaming method to Reorder  

            dataPoints = modifier.Reorder(dataPoints);
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
        /// Creates a MeasurementSeries object populated with the provided data.
        /// </summary>
        /// <param name="seriesId">The seriesId<see cref="int"/></param>
        /// <param name="nominalAppliedForces">The nominalAppliedForces<see cref="double[]"/></param>
        /// <param name="measurementData">The measurementData<see cref="double[]"/></param>
        /// <returns>The <see cref="MeasurementSeries"/></returns>
        public static MeasurementSeries CreateSeries(int seriesId, double[] nominalAppliedForces, double[] actualAppliedForces, double[] measurementData)
        {
            // TODO consider removing this method in favor of a constructor

            return new MeasurementSeries(seriesId, nominalAppliedForces, actualAppliedForces, measurementData);
        }
    }
}
