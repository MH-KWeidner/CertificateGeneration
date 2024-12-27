using CalibrationCalculations.Common.Exceptions;
using CalibrationCalculations.Models;

namespace CalibrationCalculations.Factories.ReorderMeasurementSeries
{
    public class ReorderByDetectedNominalForceOrdering : IReorderMeasurementSeries
    {
        public List<IMeasurementPoint>? Reorder(List<IMeasurementPoint>? measurementPoints)
        {
            // TODO consider how to decompose this method

            if (measurementPoints == null)
                throw new ArgumentException(ExceptionMessages.NULL_MEASUREMENT_POINT_LIST, nameof(measurementPoints));

            // Return the list, if there are fewer than two points. There is no need to reorder
            const int MINIMUM_NUMBER_OF_POINTS_REQUIRED_FOR_DETECTED_ORDERING = 2;
            if (measurementPoints.Count < MINIMUM_NUMBER_OF_POINTS_REQUIRED_FOR_DETECTED_ORDERING)
                return measurementPoints;

            const int FIRST_ITEM_INDEX = 0;
            const double EXPECTED_ZERO_VALUE = 0.0;

            // By convention, the first item is of nominal force zero.
            if (measurementPoints[FIRST_ITEM_INDEX].AppliedForce != EXPECTED_ZERO_VALUE)
                throw new InvalidMeasurementPointException(ExceptionMessages.FIRST_NOMINAL_FORCE_VALUE_NOT_ZERO, nameof(measurementPoints));

            List<IMeasurementPoint> ascendingPoints = [];
            List<IMeasurementPoint> descendingPoints = [];
            List<IMeasurementPoint> currentList = ascendingPoints;

            // By convention, the first point, (having zero nominal force), is added to the ascending list.
            ascendingPoints.Add(measurementPoints[FIRST_ITEM_INDEX]);

            // Determine ordering for the remaining points, starting with the second point
            const int LOOP_START = 1;
            for (int i = LOOP_START; i < measurementPoints.Count; i++)
            {
                // currentList remains the same if the measurement point has the same applied force as the previous measure point

                if (measurementPoints[i - 1].AppliedForce < measurementPoints[i].AppliedForce)
                    currentList = ascendingPoints;
                else if (measurementPoints[i - 1].AppliedForce > measurementPoints[i].AppliedForce)
                    currentList = descendingPoints;

                currentList.Add(measurementPoints[i]);
            }

            ascendingPoints = new List<IMeasurementPoint>(ascendingPoints.OrderBy(mp => mp.AppliedForce));
            descendingPoints = new List<IMeasurementPoint>(descendingPoints.OrderByDescending(mp => mp.AppliedForce));

            return new List<IMeasurementPoint>(ascendingPoints.Concat(descendingPoints));
        }
    }
}
