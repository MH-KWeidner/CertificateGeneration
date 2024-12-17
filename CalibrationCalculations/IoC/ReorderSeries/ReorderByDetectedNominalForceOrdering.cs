using CalibrationCalculations.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalibrationCalculations.IoC.ReorderSeries
{
    internal class ReorderByDetectedNominalForceOrdering : IReorderSeries
    {
        public List<IMeasurementPoint>? Reorder(List<IMeasurementPoint>? measurementPoints)
        {
            // TODO where to put these checks 

            if (measurementPoints == null)
                throw new ArgumentException("The IMeasurementPoint list cannot be null.", nameof(measurementPoints));

            if (measurementPoints.Count == 0)
                return measurementPoints;

            if (measurementPoints[0].AppliedForce != 0)
                throw new ArgumentException("The data must start with ZERO nominal force measurement.", nameof(measurementPoints));

            List<IMeasurementPoint> ascendingPoints = new List<IMeasurementPoint>();
            List<IMeasurementPoint> descendingPoints = new List<IMeasurementPoint>();

            for (int i = 0; i < measurementPoints.Count; i++)
            {
                if (measurementPoints[i].AppliedForce == 0)
                    continue;

                if (measurementPoints[i - 1].AppliedForce <= measurementPoints[i].AppliedForce)
                {
                    ascendingPoints.Add(measurementPoints[i]);
                    continue;
                }

                descendingPoints.Add(measurementPoints[i]);
            }

            ascendingPoints = new List<IMeasurementPoint>(ascendingPoints.OrderBy(mp => mp.AppliedForce));
            descendingPoints = new List<IMeasurementPoint>(descendingPoints.OrderByDescending(mp => mp.AppliedForce));

            return new List<IMeasurementPoint>(ascendingPoints.Concat(descendingPoints));
        }
    }
}
