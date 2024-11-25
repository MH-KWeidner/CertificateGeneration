using CertificateGeneration.Models;

namespace CertificateGeneration.CertificateFactory
{
    /// <summary>
    /// Defines the <see cref="CertificateE74" />
    /// </summary>
    public class CertificateE74
    {
        /// <summary>
        /// Defines the seriesList
        /// </summary>
        private List<Series> seriesList;

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateE74"/> class.
        /// </summary>
        public CertificateE74()
        {
            seriesList = [];
        }

        /// <summary>
        /// The LoadRawData
        /// </summary>
        /// <param name="appliedForce">The appliedForce<see cref="double[]"/></param>
        /// <param name="rawData">The rawData<see cref="double[][]"/></param>
        public void LoadRawData(double[] appliedForce, params double[][] rawData)
        {
            foreach (var data in rawData)
                seriesList.Add(Series.CreateSeries(seriesList.Count + 1, appliedForce, data));
        }
    }
}
