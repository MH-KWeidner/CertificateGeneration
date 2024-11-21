namespace CertificateGeneration.Models.Modifiers
{
    public interface IModifySeriesSize
    {
        public List<SeriesValue>? Modify(List<SeriesValue>? seriesValues);
    }
}
