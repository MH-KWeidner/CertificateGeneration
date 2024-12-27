using CalibrationCalculations.Models;

namespace CalibrationCalculations.Factories.ModifyMeasurementSeriesSize
{
    /// <summary>
    /// Removes all SeriesValue items having zero force applied
    /// </summary>
    public class RemoveZeroValuedNominalForces : IModifyMeasurementSeriesSize
    {
        /// <summary>
        /// Removes all SeriesValue items having zero force applied
        /// </summary>
        /// <param name="measurementPoints">The local list of SeriesValues to be modified</param>
        /// <returns>A new list of SeriesValues</returns>
        public List<IMeasurementPoint>? Modify(List<IMeasurementPoint>? measurementPoints)
        {
            // TODO add more exception handling

            // // TODO: fix this
            //ArgumentNullException.ThrowIfNull(measurementPoints);

            return measurementPoints?.Where(mp => mp.AppliedForce > 0).ToList();
        }
    }
}
