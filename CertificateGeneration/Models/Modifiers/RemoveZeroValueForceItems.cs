namespace CertificateGeneration.Models.Modifiers
{
    public class RemoveZeroValueForceItems : IModifySeriesSize
    {
        public List<SeriesValue>? Modify(List<SeriesValue>? seriesValues)
        {
            // TODO add more exception handling

            ArgumentNullException.ThrowIfNull(seriesValues);

            return seriesValues?.Where(sv => sv.AppliedForce > 0).ToList();
        }
    }
}
