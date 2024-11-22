using CertificateGeneration.Interpolation;
using CertificateGeneration.Models;
using CertificateGeneration.Models.Modifiers;
using DevelopmentTests.NISTDataSets;

namespace DevelopmentTests;

[TestClass]
public class DetermineDegreeOfBestFittingPolynomial
{
    [TestMethod]
    public void DetermineDegreeOfBestFittingPolynomial_ValidInput_ReturnsExpectedInterpolatedValues()
    {
        double[] appliedForce = MethodBNistTestData1.GetAppliedForce();
        double[] rawSeries1 = MethodBNistTestData1.GetRawDataSeries1();
        double[] rawSeries2 = MethodBNistTestData1.GetRawDataSeries2();
        double[] rawSeries3 = MethodBNistTestData1.GetRawDataSeries3();

        Application application = new(appliedForce, rawSeries1, rawSeries2, rawSeries3);

        application.InterpolateSeriesData(new NistInterpolator());

        application.ModifySeriesData(new RemoveZeroValueForceItems());

        application.OrderSeriesData(new OrderByAppliedForceAscending());

        application.DetermineDegreeOfBestFittingPolynomial();
    }
}
