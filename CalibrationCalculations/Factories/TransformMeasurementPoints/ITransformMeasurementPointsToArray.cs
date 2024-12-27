using CalibrationCalculations.Models;

namespace CalibrationCalculations.Factories.TransformMeasurementPoints
{
    /// <summary>
    /// Defines the <see cref="ITransformMeasurementPointsToArray" />
    /// </summary>
    public interface ITransformMeasurementPointsToArray
    {
        /// <summary>
        /// The ToArray
        /// </summary>
        /// <param name="measurementPoints">The measurementPoints<see cref="List{IMeasurementPoint}?"/></param>
        /// <returns>The <see cref="double[]"/></returns>
        public double[] ToArray(List<IMeasurementPoint>? measurementPoints);
    }
}
