using CertificateGeneration.Models;
using CertificateGeneration.MathLibrary;
using CertificateGeneration.IoC.Modifiers;
using CertificateGeneration.IoC.DataTransforms;
using CertificateGeneration.CertificateCalculations.Interpolation;
using DevelopmentTests.TestData.MethodBTestData1;

namespace DevelopmentTests;

[TestClass]
public class ProcessToCreateFittedCurve
{
    [Ignore]
    [TestMethod]
    public void ProcessToCreateFittedCurve_ValidInput_ReturnsExpectedInterpolatedValues()
    {
        // Test the process to create a fitted curve using MethodBNistTestData1

        // Arrange
        double[] appliedForce = MethodBNistTestData1.GetAppliedForce();
        Series series1 = Series.CreateSeries(1, appliedForce, MethodBNistTestData1.GetRawDataSeries1());
        Series series2 = Series.CreateSeries(2, appliedForce, MethodBNistTestData1.GetRawDataSeries2());
        Series series3 = Series.CreateSeries(3, appliedForce, MethodBNistTestData1.GetRawDataSeries3());

        NistInterpolator nistInterpolator = new();
        series1.Interpolate(nistInterpolator);
        series2.Interpolate(nistInterpolator);
        series3.Interpolate(nistInterpolator);

        RemoveZeroValueForceItems removeZeroValueForceItems = new();
        series1.Modify(removeZeroValueForceItems);
        series2.Modify(removeZeroValueForceItems);
        series3.Modify(removeZeroValueForceItems);

        RereorderByAppliedForceAscending reorderByAppliedForceAscending = new();
        series1.ReorderSeries(reorderByAppliedForceAscending);
        series2.ReorderSeries(reorderByAppliedForceAscending);
        series3.ReorderSeries(reorderByAppliedForceAscending);

        double[] appliedForceData = series1.Transform(new AppliedForceToArray());

        SeriesValueToArray seriesValueToArray = new();
        double[] seriesData1 = series1.Transform(seriesValueToArray);
        double[] seriesData2 = series2.Transform(seriesValueToArray);
        double[] seriesData3 = series3.Transform(seriesValueToArray);

        double[] appliedForceDataStacked = [.. appliedForceData, .. appliedForceData, .. appliedForceData];
        double[] seriesDataStacked = [.. seriesData1, .. seriesData2, .. seriesData3];

        const int DEGREE_OF_FIT = 4;

        // Act
        double[] polynomials = StatisticsMath.FitPolynomialToLeastSquares(appliedForceDataStacked, seriesDataStacked, DEGREE_OF_FIT);

        List<double> fittedCurve = [];
        foreach (double force in appliedForceData)
            fittedCurve.Add(StatisticsMath.EvaluateCoefficients(polynomials, force));

        // Assert
        Assert.AreEqual(-0.08157, Math.Round(fittedCurve[0], 5));
        Assert.AreEqual(-0.40790, Math.Round(fittedCurve[1], 5));
        Assert.AreEqual(-0.81587, Math.Round(fittedCurve[2], 5));
        Assert.AreEqual(-1.22393, Math.Round(fittedCurve[3], 5));
        Assert.AreEqual(-1.63206, Math.Round(fittedCurve[4], 5));
        Assert.AreEqual(-2.04025, Math.Round(fittedCurve[5], 5));
        Assert.AreEqual(-2.44850, Math.Round(fittedCurve[6], 5));
        Assert.AreEqual(-2.85678, Math.Round(fittedCurve[7], 5));
        Assert.AreEqual(-3.26510, Math.Round(fittedCurve[8], 5));
        Assert.AreEqual(-3.67341, Math.Round(fittedCurve[9], 5));
        Assert.AreEqual(-4.08169, Math.Round(fittedCurve[10], 5));
    }
}
