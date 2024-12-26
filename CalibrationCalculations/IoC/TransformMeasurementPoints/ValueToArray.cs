using CalibrationCalculations.Models;
using CalibrationCalculations.IoC.TransformMeasurementPoints;

namespace CalibrationCalculations.IoC.TransformMeasurementPoints
{
    /// <summary>
    /// Defines the <see cref="ValueToArray" />
    /// </summary>
    public class ValueToArray : ITransformMeasurementPointsToDoubleArray
    {
        //TODO consider if this transform is needed.

        /// <summary>
        /// The ToArray
        /// </summary>
        /// <param name="measurementPoints">The measurementPoints<see cref="List{IMeasurementPoint}?"/></param>
        /// <returns>The <see cref="double[]"/></returns>
        public double[] ToArray(List<IMeasurementPoint>? measurementPoints)
        {
            // TODO: fix this

            // ArgumentNullException.ThrowIfNull(measurementPoints);

            return measurementPoints.Select(mp => mp.Value).ToArray();
        }
    }
}
