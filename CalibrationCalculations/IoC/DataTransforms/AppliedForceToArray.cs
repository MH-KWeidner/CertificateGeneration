using CalibrationCalculations.IoC.DataTransforms;
using CalibrationCalculations.Models;

namespace CalibrationCalculations.IoC.DataTransforms
{
    /// <summary>
    /// Defines the <see cref="AppliedForceToArray" />
    /// </summary>
    public class AppliedForceToArray : ITransformToDoubleArray
    {
        /// <summary>
        /// The ToArray
        /// </summary>
        /// <param name="measurementPoints">The measurementPoints<see cref="List{IMeasurementPoint}?"/></param>
        /// <returns>The <see cref="double[]"/></returns>
        public double[] ToArray(List<IMeasurementPoint>? measurementPoints)
        {
            // TODO: fix this

            // ArgumentNullException.ThrowIfNull(measurementPoints);

            return measurementPoints.Select(mp => mp.AppliedForce).ToArray();
        }
    }
}
