using CertificateGeneration.Models;
using CertificateGeneration.IoC.Modifiers;
using DevelopmentTests.NISTDataSets;
using CertificateGeneration.CertifcateCalculations.Interpolation;

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

        ForceApplication application = new(appliedForce, rawSeries1, rawSeries2, rawSeries3);

        application.InterpolateSeriesData(new NistInterpolator());

        application.ModifySeriesData(new RemoveZeroValueForceItems());

        application.OrderSeriesData(new OrderByAppliedForceAscending());

        
    }
}
