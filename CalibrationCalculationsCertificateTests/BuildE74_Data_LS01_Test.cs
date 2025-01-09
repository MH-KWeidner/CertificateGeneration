using CalibrationCalculations.Common;
using CalibrationCalculations.GenerateE74;
using CalibrationCalculationsCertificateTests.LabScheduleASTMModels;
using CalibrationCalculationsCertificateTests.LabScheduleTestData;
using CalibrationCalculationsCertificateTests.LabScheduleTestData.LS01_MethodB_Cert_U7989G0124;
using static CalibrationCalculationsCertificateTests.LabScheduleResultModels.LabAnalysisSingleRunResult;

namespace CalibrationCalculationsCertificateTests;

[TestClass]
public class BuildE74_Data_LS01_Test
{
    [TestMethod]
    public void BuildE74_ValidLS01Input_CorrectOutput()
    {
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
        E74Result calCalcResult = E74Builder.Build(configuration, rawInput.NominalForcesApplied, rawInput.MeasurementData);

        // Assert best degree of fit (CalibrationCalculations vs LabSchedule)
        const int LABSCH_CALCULATED_BEST_DEGREE_FIT = 4;
        Assert.AreEqual(LABSCH_CALCULATED_BEST_DEGREE_FIT, calCalcResult.DegreeOfFit);

        double[][] calCalcInterpolatedValues = calCalcResult.InterpolatedValues;

        const int ARRAY_INDEX0 = 0;
        const int ARRAY_INDEX1 = 1;
        const int ARRAY_INDEX2 = 2;

        double[] calCalcInterpolatedValues1 = calCalcInterpolatedValues[ARRAY_INDEX0];
        double[] calCalcInterpolatedValues2 = calCalcInterpolatedValues[ARRAY_INDEX1];
        double[] calCalcInterpolatedValues3 = calCalcInterpolatedValues[ARRAY_INDEX2];

        const int RESULTS_INDEX = 0;
        ILabScheduleRunResultList labSchRunResultList = new LS01_ResultsData();
        List<SingleRun> singleRuns = labSchRunResultList.LabScheduleRunResults[RESULTS_INDEX].Runs;

        const int LIST_INDEX0 = 0;
        const int LIST_INDEX1 = 1;
        const int LIST_INDEX2 = 2;

        List<SingleRunPoint> labSchNormalizedPoints1 = singleRuns[LIST_INDEX0].NormalizedData;
        List<SingleRunPoint> labSchNormalizedPoints2 = singleRuns[LIST_INDEX1].NormalizedData;
        List<SingleRunPoint> labSchNormalizedPoints3 = singleRuns[LIST_INDEX2].NormalizedData;

        // Assert number of values after interpolation (CalibrationCalculations vs LabSchedule)
        Assert.AreEqual(calCalcInterpolatedValues1.Length, labSchNormalizedPoints1.Count);
        Assert.AreEqual(calCalcInterpolatedValues2.Length, labSchNormalizedPoints2.Count);
        Assert.AreEqual(calCalcInterpolatedValues3.Length, labSchNormalizedPoints3.Count);

        // Assert values after interpolation (CalibrationCalculations vs LabSchedule)
        const int LABSCH_ROUNDING_DIGITS = 8;

        for (int i = 0; i < calCalcInterpolatedValues1.Length; i++)
            Assert.AreEqual(Math.Round(calCalcInterpolatedValues1[i], LABSCH_ROUNDING_DIGITS), (double)labSchNormalizedPoints1[i].Value);

        for (int i = 0; i < calCalcInterpolatedValues2.Length; i++)
            Assert.AreEqual(Math.Round(calCalcInterpolatedValues2[i], LABSCH_ROUNDING_DIGITS), (double)labSchNormalizedPoints2[i].Value);

        for (int i = 0; i < calCalcInterpolatedValues3.Length; i++)
            Assert.AreEqual(Math.Round(calCalcInterpolatedValues3[i], LABSCH_ROUNDING_DIGITS), (double)labSchNormalizedPoints3[i].Value);

        // Convert coefficients to scientific notation with 6 decimal places. (LabSchedule uses same convertion on ACoefficients.)
        const string E6_FORMAT_STRING = "E6";
        var calCalcConvertedACoefficients = calCalcResult.ACoefficients.Select(coeff => Convert.ToDouble(coeff.ToString(E6_FORMAT_STRING)));

        ILabScheduleASTMResults astmResults = new LS01_ASTMResults();
        List<ASTMResult> astmResultLists = astmResults.ASTMLists;

        // Get the ASTM result that matches the calculated degree of fit.
        ASTMResult? labSchDegreeOfFitASTMResult = astmResultLists.FirstOrDefault(fit => fit.DegreeFit == calCalcResult.DegreeOfFit);

        // Assert the number of coefficients (CalibrationCalculations vs LabSchedule)
        Assert.AreEqual(labSchDegreeOfFitASTMResult.ACoefficients.Count(), calCalcConvertedACoefficients.Count());

        // Assert the converted values of the coefficients (CalibrationCalculations vs LabSchedule)
        foreach (var (expected, actual) in calCalcConvertedACoefficients.Zip(labSchDegreeOfFitASTMResult.ACoefficients, (e, a) => (e, a)))
            Assert.AreEqual(expected, actual);

        double[] fittedCurve = calCalcResult.FittedCurve;

        var labSchFittedCurve = labSchDegreeOfFitASTMResult.ValuesFromCurve;

    }
}
