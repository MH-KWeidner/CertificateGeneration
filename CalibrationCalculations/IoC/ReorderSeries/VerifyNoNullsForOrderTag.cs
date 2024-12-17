using CalibrationCalculations.Models;

namespace CalibrationCalculations.IoC.ReorderSeries
{
    public class VerifyOrderTags
    {
        // TODO better naming for this class and method

        public void FailIfNullOrderTags(List<IMeasurementPoint> measurementPoints)
        {
            if (measurementPoints.Any(mp => mp.OrderTag == null))
            {
                throw new ArgumentException("The IMeasurementPoint list cannot contain null OrderTags.", nameof(measurementPoints));
            }
        }
    }
}
