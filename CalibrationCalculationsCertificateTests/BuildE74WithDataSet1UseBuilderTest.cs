using CalibrationCalculations.Common;
using CalibrationCalculations.GenerateE74;
using CalibrationCalculationsCertificateTests.NISTDataSets;
using CalibrationCalculationsCertificateTests.TestData.MethodBTestData1;

namespace CalibrationCalculationsCertificateTests;

[TestClass]
public class BuildE74WithDataSet1UseBuilderTest
{
    [TestMethod]
    public void BuildE74UsingBuilder()
    {
        // Building this certificate:
        // CALIBRATION & ISSUE DATE: 07/01/2024
        // REPORT NO.: U-7989G0124

        // Arrange
        E74Configuration configuration = new()
        {
            InterpolationType = InterpolationTypes.MethodB,
            TemperatureUnits = TemperatureUnits.Celsius,
            AmbientTemperature = 0.0,
            ApplyTemperatureCorrection = false,
            SelectedDegreeOfFit = DegreeOfFitTypes.UseCalculatedDegreeOfBestFit,
            InterpolationReorderType = MeasurementSeriesReorderTypes.NominalForceAscending,
            TransientNominalAppliedForcesByIndex = [12]
        };

        // Act
        E74Result result = E74Builder.Build(configuration, MethodBNistTestData1.GetAppliedForce(),
            MethodBNistTestData1.GetRawDataSeries1(),
            MethodBNistTestData1.GetRawDataSeries2(),
            MethodBNistTestData1.GetRawDataSeries3());

        // TODO decide on handling null array
        double[][] valuesForAllSeries = result.Values;

        // Assert
        const int LABSCH_BEST_DEGREE_FIT = 4;
        Assert.AreEqual(LABSCH_BEST_DEGREE_FIT, result.DegreeOfFit);

        List<SingleRunPoint> LabSchedulePointsSeries1 = MethodBLabScheduleResultsTestData1Series1.dataList;
        List<SingleRunPoint> LabSchedulePointsSeries2 = MethodBLabScheduleResultsTestData1Series2.dataList;
        List<SingleRunPoint> LabSchedulePointsSeries3 = MethodBLabScheduleResultsTestData1Series3.dataList;

        // Assert
        Assert.AreEqual(valuesForAllSeries[0].Length, LabSchedulePointsSeries1.Count);
        Assert.AreEqual(valuesForAllSeries[1].Length, LabSchedulePointsSeries2.Count);
        Assert.AreEqual(valuesForAllSeries[2].Length, LabSchedulePointsSeries3.Count);

        const int ROUNDING_DIGITS = 8;

        for (int i = 0; i < valuesForAllSeries[0].Length; i++)
            Assert.AreEqual(Math.Round(valuesForAllSeries[0][i], ROUNDING_DIGITS), (double)LabSchedulePointsSeries1[i].Value);

        for (int i = 0; i < valuesForAllSeries[1].Length; i++)
            Assert.AreEqual(Math.Round(valuesForAllSeries[1][i], ROUNDING_DIGITS), (double)LabSchedulePointsSeries2[i].Value);

        for (int i = 0; i < valuesForAllSeries[2].Length; i++)
            Assert.AreEqual(Math.Round(valuesForAllSeries[2][i], ROUNDING_DIGITS), (double)LabSchedulePointsSeries3[i].Value);
    }
}
