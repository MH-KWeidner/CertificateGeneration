namespace CertificateGeneration.Models.DataTransform
{
    public class SeriesValueToArray : ITransformToDoubleArray
    {
        //TODO consider if this transform is needed.

        public double[] ToArray(List<SeriesValue>? seriesValues)
        {
            ArgumentNullException.ThrowIfNull(seriesValues);

            return seriesValues.Select(sv => sv.Value).ToArray();
        }
    }
}
