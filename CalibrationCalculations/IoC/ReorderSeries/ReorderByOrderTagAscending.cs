using CalibrationCalculations.Models;

namespace CalibrationCalculations.IoC.ReorderSeries
{
    internal class ReorderByOrderTagAscending : IReorderSeries
    {
        public List<IMeasurementPoint>? Reorder(List<IMeasurementPoint>? measurementPoints)
        {
            if (measurementPoints == null)
                throw new ArgumentException("The IMeasurementPoint list cannot be null.", nameof(measurementPoints));

            if (measurementPoints.Any(mp => mp.OrderTag == null))
                throw new ArgumentException("The IMeasurementPoint list cannot contain null OrderTags.", nameof(measurementPoints));
            
            return new List<IMeasurementPoint>(measurementPoints.OrderBy(mp => mp.OrderTag));
        }
    }
}
