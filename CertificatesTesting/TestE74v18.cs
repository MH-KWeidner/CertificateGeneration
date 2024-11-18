using Certificates;
using Models;
using Models.Modifiers;
using Interpolation;

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

            Application application = new (
                CertificatesTesting.DataSets.E74v18DataSet1.GetAppliedForce(),
                CertificatesTesting.DataSets.E74v18DataSet1.GetRawDataSeries1(),
                CertificatesTesting.DataSets.E74v18DataSet1.GetRawDataSeries2(),
                CertificatesTesting.DataSets.E74v18DataSet1.GetRawDataSeries3()
            );

            // NIST Interpolate with Zero Reduction (Method B)
            application.Interpolate(new NistInterpolator());
            application.Modify(new RemoveZeroValueForceItems());
            application.Modify(new OrderByAppliedForceAscending());

            application.DetermineDegreeOfBestFittingPolynomial();
        }
    }
}