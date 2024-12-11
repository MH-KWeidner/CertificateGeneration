using CertificateGeneration.Models;

namespace CertificateGeneration.IoC.Modifiers
{
    /// <summary>
    /// Defines the <see cref="RereorderByAppliedForceAscending" />
    /// </summary>
    public class RereorderByAppliedForceAscending : IReorderSeries
    {
        /// <summary>
        /// The Reorder
        /// </summary>
        /// <param name="seriesValues">The measurementPoints<see cref="List{SeriesValue}?"/></param>
        /// <returns>The <see cref="List{SeriesValue}?"/></returns>
        public List<IMeasurementPoint>? Reorder(List<IMeasurementPoint>? seriesValues)
        {
            // TODO add more exception handling

            // Check for null argument
            if (seriesValues == null)
            {
                // TODO: fix this

                // throw new ArgumentNullException(nameof(measurementPoints), "The measurementPoints list cannot be null.");
            }

            // Ensure the list is not empty
            if (!seriesValues.Any())
            {
                throw new ArgumentException("The seriesValues list cannot be empty.", nameof(seriesValues));

                // TODO: fix this
                // ArgumentNullException.ThrowIfNull(measurementPoints);
            }

            return seriesValues?.OrderBy(sv => sv.AppliedForce).ToList();
        }
    }
}
