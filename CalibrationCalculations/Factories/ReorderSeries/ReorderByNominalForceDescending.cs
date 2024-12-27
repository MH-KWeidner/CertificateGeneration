using CalibrationCalculations.Models;
using CalibrationCalculations.Common.Exceptions;

namespace CalibrationCalculations.Factories.ReorderSeries
{
    /// <summary>
    /// Defines the <see cref="ReorderByNominalForceDescending" />
    /// </summary>
    public class ReorderByNominalForceDescending : IReorderSeries
    {
        /// <summary>
        /// The Reorder
        /// </summary>
        /// <param name="measurementPoints">The measurementPoints<see cref="List{IMeasurementPoint}?"/></param>
        /// <returns>The <see cref="List{IMeasurementPoint}?"/></returns>
        public List<IMeasurementPoint>? Reorder(List<IMeasurementPoint>? measurementPoints)
        {
            if (measurementPoints == null)
                throw new ArgumentException(ExceptionMessages.IMEASUREMENT_POINT_LIST_CANNOT_BE_NULL, nameof(measurementPoints));

            return new List<IMeasurementPoint>(measurementPoints.OrderByDescending(mp => mp.AppliedForce));
        }
    }
}
