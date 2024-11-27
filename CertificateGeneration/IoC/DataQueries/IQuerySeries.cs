using CertificateGeneration.Models;

namespace CertificateGeneration.IoC.DataQueries
{
    /// <summary>
    /// Defines the <see cref="IQuerySeries" />
    /// </summary>
    public interface IQuerySeries
    {
        /// <summary>
        /// The Query
        /// </summary>
        /// <param name="seriesValues">The dataPoints<see cref="List{SeriesValue}?"/></param>
        /// <returns>The <see cref="List{SeriesValue}"/></returns>
        public List<DataPoint> Query(List<DataPoint>? seriesValues);
    }
}
