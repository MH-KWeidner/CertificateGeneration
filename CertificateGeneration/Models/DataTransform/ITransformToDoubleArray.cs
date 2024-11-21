namespace CertificateGeneration.Models.DataTransform
{
    public interface ITransformToDoubleArray
    {
        public double[] ToArray(List<SeriesValue>? seriesValues);
    }
}
