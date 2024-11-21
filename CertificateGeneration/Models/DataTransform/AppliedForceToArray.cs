namespace CertificateGeneration.Models.DataTransform
{
    public class AppliedForceToArray : ITransformToDoubleArray
    {
        public double[] ToArray(List<SeriesValue>? seriesValues)
        {
            ArgumentNullException.ThrowIfNull(seriesValues);

            return seriesValues.Select(sv => sv.AppliedForce).ToArray();
        }
    }
}
