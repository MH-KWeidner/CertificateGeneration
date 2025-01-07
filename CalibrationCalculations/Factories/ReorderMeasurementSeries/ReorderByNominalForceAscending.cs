using CalibrationCalculations.Common.Exceptions;
using CalibrationCalculations.Models;

namespace CalibrationCalculations.Factories.ReorderMeasurementSeries;

/// <summary>
/// Defines the <see cref="ReorderByNominalForceAscending" />
/// </summary>
public class ReorderByNominalForceAscending : IReorderMeasurementSeries
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

        return new List<IMeasurementPoint>(measurementPoints.OrderBy(mp => mp.AppliedForce));
    }
}
