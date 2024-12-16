using CalibrationCalculations.IoC.DataTransforms;
using CalibrationCalculations.IoC.ModifySeriesSize;
using CalibrationCalculations.IoC.ReorderSeries;
using CalibrationCalculations.StandardCalculations.Interpolation;

namespace CalibrationCalculations.Models
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
        /// Defines the measurementPoints
        /// </summary>
        private List<IMeasurementPoint> measurementPoints;

        /// <summary>
        /// Prevents a default instance of the <see cref="MeasurementSeries"/> class from being created.
        /// </summary>
        /// <param name="seriesId">The id<see cref="int"/></param>
        /// <param name="appliedForce">The nominalForces<see cref="double[]"/></param>
        /// <param name="rawValue">The measurementData<see cref="double[]"/></param>
        private MeasurementSeries(int seriesId, double[] appliedForce, double[] rawValue)
        {
            id = seriesId;

            measurementPoints = [];

            measurementPoints.AddRange(appliedForce.Select((force, i) => new NominalMeasurementPoint(force, rawValue[i])));
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="MeasurementSeries"/> class from being created.
        /// </summary>
        /// <param name="seriesId">The seriesId<see cref="int"/></param>
        /// <param name="nominalForces">The nominalForces<see cref="double[]"/></param>
        /// <param name="actualForces">The actualForces<see cref="double[]"/></param>
        /// <param name="measurementData">The measurementData<see cref="double[]"/></param>
        private MeasurementSeries(int seriesId, double[] nominalForces, double[] actualForces, double[] measurementData)
        {
            seriesId = id;

            measurementPoints = [];

            measurementPoints.AddRange(nominalForces.Select((force, i) => new ActualMeasurementPoint(force, actualForces[i], measurementData[i])));
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

            return measurementPoints[index].RawValue;
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

            measurementPoints[index].Value = value;
        }

        /// <summary>
        /// The RemoveValuesByIndex
        /// </summary>
        /// <param name="indexes">The indexes<see cref="IList{int}?"/></param>
        public void RemoveValuesByIndex(IList<int>? indexes)
        {
            //TODO add error handling

            if (indexes == null)
                return;

            measurementPoints = measurementPoints.Where((dp, i) => !indexes.Contains(i)).ToList();
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

            return measurementPoints[index].Value;
        }

        /// <summary>
        /// The GetEnumerable
        /// </summary>
        /// <returns>The <see cref="IEnumerable{IMeasurementPoint}"/></returns>
        public IEnumerable<IMeasurementPoint> GetEnumerable()
        {
            // TODO revisit this as it may expose the internal list
            return measurementPoints;
        }

        /// <summary>
        /// The IncreaseValuesByAdd
        /// </summary>
        /// <param name="valueToAdd">The valueToAdd<see cref="double"/></param>
        public void IncreaseValuesByAdd(double valueToAdd)
        {
            if (valueToAdd == 0)
                return;

            // TODO add error handling  

            for (int i = 0; i < measurementPoints.Count; i++)
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

            return measurementPoints[index].AppliedForce;
        }

        /// <summary>
        /// Count
        /// </summary>
        /// <returns>The number of Data Points<see cref="int"/></returns>
        public int Count()
        {
            //TODO add error handling - List may be null

            return measurementPoints.Count;
        }

        /// <summary>
        /// The Modify
        /// </summary>
        /// <param name="modifier">The modifier<see cref="IModifySeriesSize"/></param>
        public void Modify(IModifySeriesSize modifier)
        {
            //TODO add error handling - List may be null

            measurementPoints = modifier.Modify(measurementPoints);
        }

        /// <summary>
        /// The Reorder
        /// </summary>
        /// <param name="modifier">The modifier<see cref="IReorderSeries"/></param>
        public void ReorderSeries(IReorderSeries modifier)
        {
            //TODO add error handling - List may be null

            // TODO consider renaming method to Reorder  

            measurementPoints = modifier.Reorder(measurementPoints);
        }

        /// <summary>
        /// The Transform
        /// </summary>
        /// <param name="transform">The transform<see cref="ITransformToDoubleArray"/></param>
        /// <returns>The <see cref="double[]"/></returns>
        public double[] Transform(ITransformToDoubleArray transform)
        {
            return transform.ToArray(measurementPoints);
        }

        /// <summary>
        /// The Interpolate
        /// </summary>
        /// <param name="interpolator">The interpolator<see cref="IInterpolate"/></param>
        /// <param name="series">The series<see cref="MeasurementSeries"/></param>
        public static void Interpolate(IInterpolate interpolator, MeasurementSeries series)
        {
            interpolator.Interpolate(series);
        }

        /// <summary>
        /// Creates a MeasurementSeries object populated with the provided data
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <param name="nominalForces">The nominalForces<see cref="double[]"/></param>
        /// <param name="measurementData">The measurementData<see cref="double[]"/></param>
        /// <returns>The <see cref="MeasurementSeries"/></returns>
        public static MeasurementSeries Create(int id, double[] nominalForces, double[] measurementData)
        {
            //TODO condider removing the Id property

            // TODO consider removing this method in favor of a constructor

            return new MeasurementSeries(id, nominalForces, measurementData);
        }

        /// <summary>
        /// The Create
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <param name="nominalForces">The nominalForces<see cref="double[]"/></param>
        /// <param name="actualForces">The actualForces<see cref="double[]"/></param>
        /// <param name="measurementData">The measurementData<see cref="double[]"/></param>
        /// <returns>The <see cref="MeasurementSeries"/></returns>
        public static MeasurementSeries Create(int id, double[] nominalForces, double[] actualForces, double[] measurementData)
        {
            //TODO condider removing the Id property

            // TODO consider removing this method in favor of a constructor

            return new MeasurementSeries(id, nominalForces, actualForces, measurementData);
        }
    }
}
