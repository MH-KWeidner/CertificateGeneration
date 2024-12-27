using CalibrationCalculations.Common.Exceptions;
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
                throw new ArgumentException(ExceptionMessages.IMEASUREMENT_POINT_LIST_CANNOT_BE_NULL, nameof(measurementPoints));

            if (measurementPoints.Any(mp => mp.OrderTag == null))
                throw new ArgumentException(ExceptionMessages.IMEASUREMENT_POINT_LIST_CANNOT_CONTAIN_NULL_ORDER_TAGS, nameof(measurementPoints));

            return new List<IMeasurementPoint>(measurementPoints.OrderByDescending(mp => mp.OrderTag));
        }
    }
}
