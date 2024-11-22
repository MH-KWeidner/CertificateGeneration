using CertificateGeneration.Models;

namespace CertificateGeneration.Interpolation
{
    /// <summary>
    /// Defines the <see cref="InitialZeroValueInterpolator" />
    /// </summary>
    public class InitialZeroValueInterpolator : IInterpolate
    {
        /// <summary>
        /// The Interpolate
        /// </summary>
        /// <param name="series">The series<see cref="Series"/></param>
        public void Interpolate(Series series)
        {
            const double DOUBLE_ZERO = 0.0;

            double? currentZeroValue = null;

            int seriesSize = series.CountValues();
            for (int i = 0; i < seriesSize; i++)
            {
                if (series.GetAppliedForce(i) == DOUBLE_ZERO)
                {
                    currentZeroValue = series.GetRawValue(i);
                    continue;
                }

                if (currentZeroValue.HasValue)
                    series.SetValue(i, series.GetRawValue(i) - currentZeroValue.Value);
            }
        }
    }
}
