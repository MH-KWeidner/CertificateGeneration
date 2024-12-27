using CalibrationCalculations.Common.Exceptions;
using CalibrationCalculations.Models;

namespace CalibrationCalculations.Factories.ReorderMeasurementSeries
{
    internal class ReorderByOrderTagAscending : IReorderMeasurementSeries
    {
        public List<IMeasurementPoint>? Reorder(List<IMeasurementPoint>? measurementPoints)
        {
            if (measurementPoints == null)
                throw new ArgumentException(ExceptionMessages.IMEASUREMENT_POINT_LIST_CANNOT_BE_NULL, nameof(measurementPoints));

            if (measurementPoints.Any(mp => mp.OrderTag == null))
                throw new ArgumentException(ExceptionMessages.IMEASUREMENT_POINT_LIST_CANNOT_CONTAIN_NULL_ORDER_TAGS, nameof(measurementPoints));

            return new List<IMeasurementPoint>(measurementPoints.OrderBy(mp => mp.OrderTag));
        }
    }
}
