using CertificateGeneration.Models;

namespace CertificateGeneration.IoC.Modifiers
{
    /// <summary>
    /// Defines the <see cref="IOrderSeries" />
    /// </summary>
    public interface IOrderSeries
    {
        /// <summary>
        /// The Order
        /// </summary>
        /// <param name="seriesValues">The seriesValues<see cref="List{SeriesValue}?"/></param>
        /// <returns>The <see cref="List{SeriesValue}?"/></returns>
        public List<DataPoint>? Order(List<DataPoint>? seriesValues);
    }
}
