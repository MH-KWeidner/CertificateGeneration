﻿using CalibrationCalculations.Models;

namespace CalibrationCalculations.Factories.ReorderSeries
{
    /// <summary>
    /// Defines the <see cref="ReorderByNominalForceAscending" />
    /// </summary>
    public class ReorderByNominalForceAscending : IReorderSeries
    {
        /// <summary>
        /// The Reorder
        /// </summary>
        /// <param name="measurementPoints">The measurementPoints<see cref="List{IMeasurementPoint}?"/></param>
        /// <returns>The <see cref="List{IMeasurementPoint}?"/></returns>
        public List<IMeasurementPoint>? Reorder(List<IMeasurementPoint>? measurementPoints)
        {
            if (measurementPoints == null)
                throw new ArgumentException("The IMeasurementPoint list cannot be null.", nameof(measurementPoints));

            return new List<IMeasurementPoint>(measurementPoints.OrderBy(mp => mp.AppliedForce));
        }
    }
}
