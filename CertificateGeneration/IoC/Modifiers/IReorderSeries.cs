using CertificateGeneration.Models;

namespace CertificateGeneration.IoC.Modifiers
{
    /// <summary>
    /// Defines the <see cref="IReorderSeries" />
    /// </summary>
    public interface IReorderSeries
    {
        /// <summary>
        /// The Reorder
        /// </summary>
        /// <param name="seriesValues">The dataPoints<see cref="List{SeriesValue}?"/></param>
        /// <returns>The <see cref="List{SeriesValue}?"/></returns>
        public List<MeasurementDataPoint>? Reorder(List<MeasurementDataPoint>? seriesValues);
    }
}
