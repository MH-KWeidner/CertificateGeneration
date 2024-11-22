namespace CertificateGeneration.Models.Modifiers
{
    /// <summary>
    /// Removes all SeriesValue items having zero force applied
    /// </summary>
    public class RemoveZeroValueForceItems : IModifySeriesSize
    {
        /// <summary>
        /// Removes all SeriesValue items having zero force applied
        /// </summary>
        /// <param name="seriesValues">The local list of SeriesValues to be modified</param>
        /// <returns>A new list of SeriesValues</returns>
        public List<SeriesValue>? Modify(List<SeriesValue>? seriesValues)
        {
            // TODO add more exception handling

            ArgumentNullException.ThrowIfNull(seriesValues);

            return seriesValues?.Where(sv => sv.AppliedForce > 0).ToList();
        }
    }
}
