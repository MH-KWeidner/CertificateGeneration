namespace CertificateGeneration.Models.Modifiers
{
    public interface IOrderSeries
    {
        public List<SeriesValue>? Order(List<SeriesValue>? seriesValues);
    }
}
