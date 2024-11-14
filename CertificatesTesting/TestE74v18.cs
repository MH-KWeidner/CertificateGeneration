using Certificates;

namespace CertificatesTesting
{
    [TestClass]
    public class TestE74v18
    {
        [TestMethod]
        public void TestBuild()
        {
            // Building this certificate:
            // CALIBRATION & ISSUE DATE: 07/01/2024
            // REPORT NO.: U-7989G0124
        
            Certificates.CertificateE74v18 certificate = new();

            certificate.LoadRawData(
                CertificatesTesting.DataSets.E74v18DataSet1.GetAppliedForce(),
                CertificatesTesting.DataSets.E74v18DataSet1.GetRawDataSeries1(),
                CertificatesTesting.DataSets.E74v18DataSet1.GetRawDataSeries2(),
                CertificatesTesting.DataSets.E74v18DataSet1.GetRawDataSeries3()
            );

            // Apply interpolation


        }


    }
}