using CertificateGeneration.Models;
using CertificateGeneration.IoC.DataTransforms;

namespace CertificateGeneration.IoC.DataTransforms
{
    /// <summary>
    /// Defines the <see cref="AppliedForceToArray" />
    /// </summary>
    public class AppliedForceToArray : ITransformToDoubleArray
    {
        /// <summary>
        /// The ToArray
        /// </summary>
        /// <param name="seriesValues">The dataPoints<see cref="List{SeriesValue}?"/></param>
        /// <returns>The <see cref="double[]"/></returns>
        public double[] ToArray(List<MeasurementDataPoint>? seriesValues)
        {
            // TODO: fix this

            // ArgumentNullException.ThrowIfNull(dataPoints);

            return seriesValues.Select(sv => sv.NominalAppliedForce).ToArray();
        }
    }
}
