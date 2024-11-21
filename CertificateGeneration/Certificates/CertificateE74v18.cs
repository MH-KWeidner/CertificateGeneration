using CertificateGeneration.Models;

namespace CertificateGeneration.Certificates
{
    public class CertificateE74v18
    {
        private List<Series> seriesList;

        public CertificateE74v18()
        {
            seriesList = [];
        }

        public void LoadRawData(double[] appliedForce, params double[][] rawData)
        {
            foreach (var data in rawData)
                seriesList.Add(Series.CreateSeries(seriesList.Count + 1, appliedForce, data));
        }

    }
}
