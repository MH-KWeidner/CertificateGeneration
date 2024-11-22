namespace CertificateGeneration.Models.DataQueries
{
    /// <summary>
    /// Defines the <see cref="QueryZeroForceItems" />
    /// </summary>
    public class QueryZeroForceItems : IQuerySeries
    {
        /// <summary>
        /// The Query
        /// </summary>
        /// <param name="seriesValues">The seriesValues<see cref="List{SeriesValue}?"/></param>
        /// <returns>The <see cref="List{SeriesValue}"/></returns>
        public List<SeriesValue> Query(List<SeriesValue>? seriesValues)
        {
            ArgumentNullException.ThrowIfNull(seriesValues);

            return seriesValues.Where(sv => sv.AppliedForce == 0).ToList();
        }
    }
}
