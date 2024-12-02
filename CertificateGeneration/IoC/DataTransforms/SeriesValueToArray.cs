using CertificateGeneration.Models;
using CertificateGeneration.IoC.DataTransforms;

namespace CertificateGeneration.IoC.DataTransforms
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
        /// <param name="seriesValues">The dataPoints<see cref="List{SeriesValue}?"/></param>
        /// <returns>The <see cref="double[]"/></returns>
        public double[] ToArray(List<DataPoint>? seriesValues)
        {
            // TODO: fix this

            // ArgumentNullException.ThrowIfNull(dataPoints);

            return seriesValues.Select(sv => sv.Value).ToArray();
        }
    }
}
