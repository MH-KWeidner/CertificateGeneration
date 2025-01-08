using CalibrationCalculations.Common;
using CalibrationCalculations.GenerateE74;
using CalibrationCalculationsCertificateTests.LabScheduleModels;
using CalibrationCalculationsCertificateTests.LabScheduleTestData;
using CalibrationCalculationsCertificateTests.LabScheduleTestData.LS01_MethodB_Cert_U7989G0124;
using System.Collections.Generic;
using static CalibrationCalculationsCertificateTests.LabScheduleModels.LabAnalysisSingleRunResult;

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
        ILabScheduleRawInput rawInput = new LS01_RawInput();
        E74Result result = E74Builder.Build(configuration, rawInput.NominalForcesApplied, rawInput.MeasurementData);

        // These values are post interpolation, zero reduction, and reordering

        // TODO decide on handling null array
        double[][] values = result.Values;

        // Assert
        const int LABSCH_BEST_DEGREE_FIT = 4;
        Assert.AreEqual(LABSCH_BEST_DEGREE_FIT, result.DegreeOfFit);

        ILabScheduleRunResultsList labSchResults = new LS01_ResultsData();
        List <LabAnalysisSingleRunResult> zz = labSchResults.LabScheduleRunResults;

        List<LabAnalysisSingleRunResult> labSchResult = new LS01_ResultsData().LabScheduleRunResults;
        
        List<SingleRunPoint> LabSchedulePointsSeries1 = labSchResult[0].Runs[0].NormalizedData;
        List<SingleRunPoint> LabSchedulePointsSeries2 = labSchResult[0].Runs[1].NormalizedData;
        List<SingleRunPoint> LabSchedulePointsSeries3 = labSchResult[0].Runs[2].NormalizedData;

        // Assert
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

        // Assert coefficients
        double[] aCoffecients = result.ACoefficients;

        ILabScheduleAdditionalData additionalData = new LS01_AdditionalData();
        double[] labSchACoefficients = additionalData.GetMathNetACoefficients(LABSCH_BEST_DEGREE_FIT);

        Assert.AreEqual(labSchACoefficients.Length, aCoffecients.Length);

        for(int i = 0; i < labSchACoefficients.Length; i++)
            Assert.AreEqual(aCoffecients[i], labSchACoefficients[i]);
    }
}
