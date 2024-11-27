using CertificateGeneration.Models;

namespace CertificateGeneration.IoC.DataTransforms
{
    /// <summary>
    /// Defines the <see cref="ITransformToDoubleArray" />
    /// </summary>
    public interface ITransformToDoubleArray
    {
        /// <summary>
        /// The ToArray
        /// </summary>
        /// <param name="seriesValues">The dataPoints<see cref="List{SeriesValue}?"/></param>
        /// <returns>The <see cref="double[]"/></returns>
        public double[] ToArray(List<DataPoint>? seriesValues);
    }
}
