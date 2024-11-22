namespace CertificateGeneration.Models.DataTransform
{
    /// <summary>
    /// Defines the <see cref="SeriesValueToArray" />
    /// </summary>
    public class SeriesValueToArray : ITransformToDoubleArray
    {
        //TODO consider if this transform is needed.

        /// <summary>
        /// The ToArray
        /// </summary>
        /// <param name="seriesValues">The seriesValues<see cref="List{SeriesValue}?"/></param>
        /// <returns>The <see cref="double[]"/></returns>
        public double[] ToArray(List<SeriesValue>? seriesValues)
        {
            ArgumentNullException.ThrowIfNull(seriesValues);

            return seriesValues.Select(sv => sv.Value).ToArray();
        }
    }
}
