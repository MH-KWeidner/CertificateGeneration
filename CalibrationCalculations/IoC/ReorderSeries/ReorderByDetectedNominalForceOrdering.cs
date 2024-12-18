using CalibrationCalculations.Exceptions;
using CalibrationCalculations.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalibrationCalculations.IoC.ReorderSeries
{
    public class ReorderByDetectedNominalForceOrdering : IReorderSeries
    {
        public List<IMeasurementPoint>? Reorder(List<IMeasurementPoint>? measurementPoints)
        {
            // TODO consider how to decompose this method

            if (measurementPoints == null)
                throw new ArgumentException(ExceptionMessages.NULL_MEASUREMENT_POINT_LIST, nameof(measurementPoints));

            const int MINIMUM_NUMBER_OF_POINTS_REQUIRED_FOR_DETECTED_ORDERING = 2;
            if (measurementPoints.Count < MINIMUM_NUMBER_OF_POINTS_REQUIRED_FOR_DETECTED_ORDERING)
                return measurementPoints;

            const int FIRST_ITEM_INDEX = 0;       
            const double EXPECTED_ZERO_VALUE = 0.0;
            
            if (measurementPoints[FIRST_ITEM_INDEX].AppliedForce != EXPECTED_ZERO_VALUE)
                throw new InvalidMeasurementPointException(ExceptionMessages.FIRST_NOMINAL_FORCE_VALUE_NOT_ZERO, nameof(measurementPoints));

            List<IMeasurementPoint> ascendingPoints = [];
            List<IMeasurementPoint> descendingPoints = [];

            // By convention, the first point, which is required to have nominal force of zero, is added to the ascending list
            ascendingPoints.Add(measurementPoints[FIRST_ITEM_INDEX]);

            // Determine ordering for the remaining points, starting with the second point
            const int LOOP_START = 1;
            for (int i = LOOP_START; i < measurementPoints.Count; i++)
            {     
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
