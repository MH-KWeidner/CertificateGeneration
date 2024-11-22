namespace CertificateGeneration.Models.DataQueries
{
    /// <summary>
    /// Defines the <see cref="IQuerySeries" />
    /// </summary>
    public interface IQuerySeries
    {
        /// <summary>
        /// The Query
        /// </summary>
        /// <param name="seriesValues">The seriesValues<see cref="List{SeriesValue}?"/></param>
        /// <returns>The <see cref="List{SeriesValue}"/></returns>
        public List<SeriesValue> Query(List<SeriesValue>? seriesValues);
    }
}
