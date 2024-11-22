namespace CertificateGeneration.Models.TestModifiers
{
    /// <summary>
    /// Defines the <see cref="RemoveSeriesValueForTestPurpose" />
    /// </summary>
    internal class RemoveSeriesValueForTestPurpose : IModifySeriesValueForTestPurpose
    {
        /// <summary>
        /// The Invoke
        /// </summary>
        /// <param name="seriesValues">The seriesValues<see cref="List{SeriesValue}"/></param>
        /// <param name="itemNumber">The itemNumber<see cref="int"/></param>
        /// <returns>The <see cref="List{SeriesValue}"/></returns>
        public List<SeriesValue> Invoke(List<SeriesValue> seriesValues, int itemNumber)
        {
            return seriesValues.Where((seriesValue, index) => index != itemNumber).ToList();
        }
    }
}
