using CalibrationCalculations.Models;

namespace CalibrationCalculations.IoC.Modifiers
{
    /// <summary>
    /// Defines the <see cref="IReorderSeries" />
    /// </summary>
    public interface IReorderSeries
    {
        /// <summary>
        /// The Reorder
        /// </summary>
        /// <param name="seriesValues">The measurementPoints<see cref="List{IMeasurementPoint}?"/></param>
        /// <returns>The <see cref="List{IMeasurementPoint}?"/></returns>
        public List<IMeasurementPoint>? Reorder(List<IMeasurementPoint>? measurementPoints);
    }
}
