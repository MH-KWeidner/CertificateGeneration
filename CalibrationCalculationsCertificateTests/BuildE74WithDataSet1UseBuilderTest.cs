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

        // Assert
        const int LABSCH_BEST_DEGREE_FIT = 4;
        Assert.AreEqual(LABSCH_BEST_DEGREE_FIT, result.DegreeOfFit);

        // These interpolatedValues are post interpolation, zero reduction, and reordering

        // TODO decide on handling null array
        double[][] interpolatedValues = result.Values;

        ILabScheduleRunResultsList labSchResults = new LS01_ResultsData();
        
        const int RESULTS_INDEX = 0;
        List<SingleRun> singleRuns = labSchResults.LabScheduleRunResults[RESULTS_INDEX].Runs;

        const int ARRAY_INDEX0 = 0;
        const int ARRAY_INDEX1 = 1;
        const int ARRAY_INDEX2 = 2;

        List<SingleRunPoint> labSchNormalizedPoints1 = singleRuns[ARRAY_INDEX0].NormalizedData;
        List<SingleRunPoint> labSchNormalizedPoints2 = singleRuns[ARRAY_INDEX1].NormalizedData;
        List<SingleRunPoint> labSchNormalizedPoints3 = singleRuns[ARRAY_INDEX2].NormalizedData;

        // Assert
        Assert.AreEqual(interpolatedValues[ARRAY_INDEX0].Length, labSchNormalizedPoints1.Count);
        Assert.AreEqual(interpolatedValues[ARRAY_INDEX1].Length, labSchNormalizedPoints2.Count);
        Assert.AreEqual(interpolatedValues[ARRAY_INDEX2].Length, labSchNormalizedPoints3.Count);

        const int ROUNDING_DIGITS = 8;

        for (int i = 0; i < interpolatedValues[ARRAY_INDEX0].Length; i++)
            Assert.AreEqual(Math.Round(interpolatedValues[0][i], ROUNDING_DIGITS), (double)labSchNormalizedPoints1[i].Value);

        for (int i = 0; i < interpolatedValues[ARRAY_INDEX1].Length; i++)
            Assert.AreEqual(Math.Round(interpolatedValues[1][i], ROUNDING_DIGITS), (double)labSchNormalizedPoints2[i].Value);

        for (int i = 0; i < interpolatedValues[2].Length; i++)
            Assert.AreEqual(Math.Round(interpolatedValues[2][i], ROUNDING_DIGITS), (double)labSchNormalizedPoints3[i].Value);

        // Assert coefficients
        double[] aCoffecients = result.ACoefficients;

        ILabScheduleAdditionalData additionalData = new LS01_AdditionalData();
        double[] labSchACoefficients = additionalData.GetMathNetACoefficients(LABSCH_BEST_DEGREE_FIT);

        Assert.AreEqual(labSchACoefficients.Length, aCoffecients.Length);

        for(int i = 0; i < labSchACoefficients.Length; i++)
            Assert.AreEqual(aCoffecients[i], labSchACoefficients[i]);
    }
}
