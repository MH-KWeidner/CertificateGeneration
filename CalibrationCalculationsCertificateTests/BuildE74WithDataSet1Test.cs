using CalibrationCalculations.Common;
using CalibrationCalculations.GenerateE74;
using CalibrationCalculationsCertificateTests.LabScheduleCertificateTestData.MethodBTestData1;
using CalibrationCalculationsCertificateTests.NISTDataSets;

namespace CalibrationCalculationsCertificateTests;

[TestClass]
public class BuildE74WithDataSet1Test
{
    [TestMethod]
    public void BuildE74()
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
        E74Result result = E74Builder.Build(configuration, Data01_RawInput.GetAppliedForce(),
            Data01_RawInput.GetRawDataSeries1(),
            Data01_RawInput.GetRawDataSeries2(),
            Data01_RawInput.GetRawDataSeries3());

        // Assert
        const int LABSCH_BEST_DEGREE_FIT = 4;
        Assert.AreEqual(LABSCH_BEST_DEGREE_FIT, result.DegreeOfFit);

        List<SingleRunPoint> LabSchedulePointsSeries1 = Data01_ResultSeries1.dataList;
        List<SingleRunPoint> LabSchedulePointsSeries2 = Data01_ResultSeries2.dataList;
        List<SingleRunPoint> LabSchedulePointsSeries3 = Data01_ResultSeries3.dataList;

        double[][] values = result.Values;

        Assert.AreEqual(values[0].Length, LabSchedulePointsSeries1.Count);
        Assert.AreEqual(values[1].Length, LabSchedulePointsSeries2.Count);
        Assert.AreEqual(values[2].Length, LabSchedulePointsSeries3.Count);

        const int ROUNDING_DIGITS = 8;

        for (int i = 0; i < values[0].Length; i++)
            Assert.AreEqual(Math.Round(values[0][i], ROUNDING_DIGITS), (double)LabSchedulePointsSeries1[i].Value);

        for (int i = 0; i < values[1].Length; i++)
            Assert.AreEqual(Math.Round(values[1][i], ROUNDING_DIGITS), (double)LabSchedulePointsSeries2[i].Value);

        for (int i = 0; i < values[2].Length; i++)
            Assert.AreEqual(Math.Round(values[2][i], ROUNDING_DIGITS), (double)LabSchedulePointsSeries3[i].Value);

        //double[] stackedAppliedForces = ArrayHelper.StackArrayNTimes(appliedForces, valuesForAllSeries.Length);

        //double[] stackedMeasurementData = ArrayHelper.StackArrays(valuesForAllSeries);

        //double[] aCoefficients = StatisticsMath.FitPolynomialToLeastSquares(stackedAppliedForces, stackedMeasurementData, configuration.DegreeOfFit);

        //double[] fittedCurve = StatisticsMath.EvaluateCoefficients(aCoefficients, appliedForces);
    }
}
