namespace CertificateGeneration.Models.TestModifiers
{
    internal class RemoveSeriesValueForTestPurpose : IModifySeriesValueForTestPurpose
    {
        public List<SeriesValue> Invoke(List<SeriesValue> seriesValues, int itemNumber)
        {
            return seriesValues.Where((seriesValue, index) => index != itemNumber).ToList();
        }
    }
}
