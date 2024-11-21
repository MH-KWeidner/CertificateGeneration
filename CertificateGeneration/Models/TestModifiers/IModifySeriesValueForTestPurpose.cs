namespace CertificateGeneration.Models.TestModifiers
{
    public interface IModifySeriesValueForTestPurpose
    {
        public List<SeriesValue> Invoke(List<SeriesValue> seriesValues, int itemNumber);

    }
}
