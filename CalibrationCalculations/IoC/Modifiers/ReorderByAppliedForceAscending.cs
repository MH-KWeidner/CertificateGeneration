using CalibrationCalculations.IoC.Modifiers;
using CalibrationCalculations.Models;

namespace CalibrationCalculations.IoC.Modifiers
{
    /// <summary>
    /// Defines the <see cref="RereorderByAppliedForceAscending" />
    /// </summary>
    public class RereorderByAppliedForceAscending : IReorderSeries
    {
        /// <summary>
        /// The Reorder
        /// </summary>
        /// <param name="IMeasurementPoint">The measurementPoints<see cref="List{IMeasurementPoint}?"/></param>
        /// <returns>The <see cref="List{IMeasurementPoint}?"/></returns>
        public List<IMeasurementPoint>? Reorder(List<IMeasurementPoint>? measurementPoints)
        {
            // TODO add more exception handling

            // Check for null argument
            if (measurementPoints == null)
            {
                // TODO: fix this

                // throw new ArgumentNullException(nameof(measurementPoints), "The measurementPoints list cannot be null.");
            }

            // Ensure the list is not empty
            if (!measurementPoints.Any())
            {
                throw new ArgumentException("The IMeasurementPoint list cannot be empty.", nameof(IMeasurementPoint));

                // TODO: fix this
                // ArgumentNullException.ThrowIfNull(measurementPoints);
            }

            return measurementPoints.OrderBy(mp => mp.AppliedForce).ToList();
        }
    }
}
