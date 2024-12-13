using CertificateGeneration.Models;

namespace CertificateGeneration.CertificateCalculations.Interpolation
{
    /// <summary>
    /// Defines the <see cref="IInterpolate" />
    /// </summary>
    public interface IInterpolate
    {
        /// <summary>
        /// The Interpolate
        /// </summary>
        /// <param name="series">The series<see cref="MeasurementSeries"/></param>
        public void Interpolate(MeasurementSeries series);
    }
}
