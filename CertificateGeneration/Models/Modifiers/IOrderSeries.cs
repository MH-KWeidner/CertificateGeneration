namespace CertificateGeneration.Models.Modifiers
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
        public List<SeriesValue>? Order(List<SeriesValue>? seriesValues);
    }
}
