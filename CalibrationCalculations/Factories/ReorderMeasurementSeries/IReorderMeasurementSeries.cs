using CalibrationCalculations.Models;

namespace CalibrationCalculations.Factories.ReorderSeries
{
    /// <summary>
    /// Defines the <see cref="IReorderMeasurementSeries" />
    /// </summary>
    public interface IReorderMeasurementSeries
    {
        /// <summary>
        /// The Reorder
        /// </summary>
        /// <param name="measurementPoints">The measurementPoints<see cref="List{IMeasurementPoint}?"/></param>
        /// <returns>The <see cref="List{IMeasurementPoint}?"/></returns>
        public List<IMeasurementPoint>? Reorder(List<IMeasurementPoint>? measurementPoints);
    }
}
