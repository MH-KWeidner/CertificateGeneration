namespace CertificateGenerationTests.CertificatesTesting
{
    using CertificateGeneration.Interpolation;
    using CertificateGeneration.Models;
    using CertificateGeneration.Models.Modifiers;

    // [Ignore]

    /// <summary>
    /// Defines the <see cref="TestE74v18" />
    /// </summary>
    [TestClass]
    public class TestE74v18
    {
        /// <summary>
        /// The TestBuild
        /// </summary>
        [TestMethod]
        public void TestBuild()
        {
            // Building this certificate:
            // CALIBRATION & ISSUE DATE: 07/01/2024
            // REPORT NO.: U-7989G0124

            Application application = new(
                DataSets.E74v18DataSet1.GetAppliedForce(),
                DataSets.E74v18DataSet1.GetRawDataSeries1(),
                DataSets.E74v18DataSet1.GetRawDataSeries2(),
                DataSets.E74v18DataSet1.GetRawDataSeries3()
            );

            // NIST Interpolate with Zero Reduction (Method B)
            application.InterpolateSeriesData(new NistInterpolator());
            application.ModifySeriesData(new RemoveZeroValueForceItems());
            application.OrderSeriesData(new OrderByAppliedForceAscending());

            application.DetermineDegreeOfBestFittingPolynomial();
        }
    }
}
