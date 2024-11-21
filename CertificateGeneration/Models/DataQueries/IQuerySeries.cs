namespace CertificateGeneration.Models.DataQueries
{
    public interface IQuerySeries
    {
        public List<SeriesValue> Query(List<SeriesValue>? seriesValues);
    }
}
