using CalibrationCalculations.Common;
using CalibrationCalculations.Factories.ModifyMeasurementSeriesSize;
using CalibrationCalculations.Factories.ReorderMeasurementSeries;
using CalibrationCalculations.Factories.TransformMeasurementPoints;
using CalibrationCalculations.GenerateE74;
using CalibrationCalculations.Helpers;
using CalibrationCalculations.MathLibrary;
using CalibrationCalculations.Models;
using CalibrationCalculations.StandardCalculations.Interpolation;
using CalibrationCalculationsCertificateTests.LabScheduleTestData;
using CalibrationCalculationsCertificateTests.LabScheduleTestData.LS01_MethodB_Cert_U7989G0124;

namespace CalibrationCalculationsCertificateTests;

[TestClass]
public class ProcessToCreateFittedCurve
{
    [Ignore]
    [TestMethod]
    public void ProcessToCreateFittedCurve_ValidInput_ReturnsExpectedInterpolatedValues()
    {
        // Test the process to create a fitted curve using Data01_Cert_U7989G0124_RawInput

        // Arrange
        E74Configuration configuration = new()
        {
            InterpolationType = InterpolationTypes.MethodB,
            TemperatureUnits = TemperatureUnits.Celsius,
            AmbientTemperature = 50.0,
            SelectedDegreeOfFit = DegreeOfFitTypes.UseCalculatedDegreeOfBestFit,
            TransientNominalAppliedForcesByIndex = [12]
        };


        ILabScheduleRawInput rawInput = new LS01_RawInput();
        MeasurementApplication application = new(rawInput.NominalForcesApplied, rawInput.MeasurementData);
            

        // Act
        application.InterpolateMeasurementSeries(InterpolatorFactory.Create(configuration.InterpolationType));
        application.RemoveMeasurementPointsByIndex(configuration.TransientNominalAppliedForcesByIndex);
        application.ModifySeriesSize(new RemoveZeroValuedNominalForces());
        application.ReorderSeriesData(new ReorderByNominalForceAscending());

        const int REFERENCE_SERIES_FOR_FORCE = 0;
        double[] appliedForces = application.TransformMeasurementPoints(new NominalAppliedForcesToArray(), REFERENCE_SERIES_FOR_FORCE);
        double[][] valuesForAllSeries = application.TransformMeasurementPoints(new MeasurementValuesToArray());

        double[] stackedAppliedForces = ArrayHelper.StackArrayNTimes(appliedForces, valuesForAllSeries.Length);

        double[] stackedMeasurementData = ArrayHelper.StackArrays(valuesForAllSeries);

        const int DEGREE_OF_FIT = 4;

        // Act
        double[] polynomials = StatisticsMath.FitPolynomialToLeastSquares(stackedAppliedForces, stackedMeasurementData, DEGREE_OF_FIT);

        List<double> fittedCurve = [];
        foreach (double force in appliedForces)
            fittedCurve.Add(StatisticsMath.EvaluateCoefficients(polynomials, force));

        // Assert

        //Assert.AreEqual(-0.08157, Math.Round(fittedCurve[0], 5));
        //Assert.AreEqual(-0.40790, Math.Round(fittedCurve[1], 5));
        //Assert.AreEqual(-0.81587, Math.Round(fittedCurve[2], 5));
        //Assert.AreEqual(-1.22393, Math.Round(fittedCurve[3], 5));
        //Assert.AreEqual(-1.63206, Math.Round(fittedCurve[4], 5));
        //Assert.AreEqual(-2.04025, Math.Round(fittedCurve[5], 5));
        //Assert.AreEqual(-2.44850, Math.Round(fittedCurve[6], 5));
        //Assert.AreEqual(-2.85678, Math.Round(fittedCurve[7], 5));
        //Assert.AreEqual(-3.26510, Math.Round(fittedCurve[8], 5));
        //Assert.AreEqual(-3.67341, Math.Round(fittedCurve[9], 5));
        //Assert.AreEqual(-4.08169, Math.Round(fittedCurve[10], 5));
    }
}
