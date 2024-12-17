using CalibrationCalculations.Common;
using CalibrationCalculations.Generate;
using CalibrationCalculations.Helpers;
using CalibrationCalculations.IoC.DataTransforms;
using CalibrationCalculations.IoC.ModifySeriesSize;
using CalibrationCalculations.IoC.ReorderSeries;
using CalibrationCalculations.MathLibrary;
using CalibrationCalculations.Models;
using CalibrationCalculations.StandardCalculations.DegreeOfBestFit;
using CalibrationCalculations.StandardCalculations.Interpolation;
using DevelopmentTests.NISTDataSets;
using DevelopmentTests.TestData.MethodBTestData1;

namespace DevelopmentTests;

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
            InterpolatedReorderType = ReorderTypes.NominalForceAscending
        };

        configuration.AddTransientForceMeasurementsByIndex(12);

        MeasurementApplication application = new(
            MethodBNistTestData1.GetAppliedForce(),
            MethodBNistTestData1.GetRawDataSeries1(),
            MethodBNistTestData1.GetRawDataSeries2(),
            MethodBNistTestData1.GetRawDataSeries3());

        // Act
        application.InterpolateSeriesData(InterpolatorFactory.Create(configuration.InterpolationType));
        application.RemoveValuesByIndex(configuration.TransientForceMeasurementsByIndex);
        application.ModifySeriesSize(new RemoveZeroValueForceItems());
        
        application.ReorderSeriesData(ReorderFactory.Create(configuration.InterpolatedReorderType));

        const int REFERENCE_SERIES_FOR_FORCE = 0;
        double[] appliedForces = application.Transform(new AppliedForceToArray(), REFERENCE_SERIES_FOR_FORCE);
        double[][] valuesForAllSeries = application.Transform(new SeriesValueToArray());

        // TODO verify if UseCalculatedDegreeOfBestFit always needs to be calculated.
        configuration.DegreeOfBestFit = SelectBestDegreeOfFit.Select(configuration.SelectedDegreeOfFit, appliedForces, valuesForAllSeries);

        const int EXPECTED_DEGREE_OF_BEST_FIT = 4;
        Assert.AreEqual(EXPECTED_DEGREE_OF_BEST_FIT, configuration.DegreeOfBestFit);

        if (configuration.ApplyTemperatureCorrection)
            application.ApplyTemperatureCorrection
            (ambientTemperature: configuration.AmbientTemperature,
                standardCalibrationTemperature: configuration.StandardTemperatureOfCalibration,
                temperatureCorrectionValuePer1Degree: configuration.TemperatureCorrectionValuePer1Degree);

        // Assert
        const int LABSCH_BEST_DEGREE_FIT = 4;
        Assert.AreEqual(LABSCH_BEST_DEGREE_FIT, configuration.DegreeOfBestFit);

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

        double[] stackedAppliedForces = ArrayHelper.StackArrayNTimes(appliedForces, valuesForAllSeries.Length);

        double[] stackedMeasurementData = ArrayHelper.StackArrays(valuesForAllSeries);

        double[] aCoefficients = StatisticsMath.FitPolynomialToLeastSquares(stackedAppliedForces, stackedMeasurementData, configuration.DegreeOfBestFit);

        double[] fittedCurve = StatisticsMath.EvaluateCoefficients(aCoefficients, appliedForces);
    }
}
