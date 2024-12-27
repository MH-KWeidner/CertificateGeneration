using CalibrationCalculations.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalibrationCalculations.Factories.ReorderSeries
{
    internal class ReorderByOrderTagDescending : IReorderSeries
    {
        public List<IMeasurementPoint>? Reorder(List<IMeasurementPoint>? measurementPoints)
        {
            if (measurementPoints == null)
                throw new ArgumentException("The IMeasurementPoint list cannot be null.", nameof(measurementPoints));

            if (measurementPoints.Any(mp => mp.OrderTag == null))
                throw new ArgumentException("The IMeasurementPoint list cannot contain null OrderTags.", nameof(measurementPoints));

            return new List<IMeasurementPoint>(measurementPoints.OrderByDescending(mp => mp.OrderTag));
        }
    }
}
