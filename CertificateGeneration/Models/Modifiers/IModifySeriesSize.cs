namespace CertificateGeneration.Models.Modifiers
{
    /// <summary>
    /// Classes that implement this interface will modify the size of a list of SeriesValues
    /// </summary>
    public interface IModifySeriesSize
    {
        /// <summary>
        /// SeriesValues
        /// </summary>
        /// <param name="seriesValues"></param>
        /// <returns>Returns a new list of SeriesValues</returns>
        public List<SeriesValue>? Modify(List<SeriesValue>? seriesValues);
    }
}
