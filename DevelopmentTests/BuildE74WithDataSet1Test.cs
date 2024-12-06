using CertificateGeneration.CertificateCalculations.Interpolation;
using CertificateGeneration.CertificateCreation;
using CertificateGeneration.Common;
using CertificateGeneration.IoC.DataTransforms;
using CertificateGeneration.IoC.Modifiers;
using CertificateGeneration.Models;
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
            AmbientTemperature = 50.0,
            SelectedDegreeOfFit = DegreeOfFitTypes.DegreeOfBestFit
        };

        configuration.AddTransientForceMeasurementsByIndex(12);

        ForceApplication application = new(
            MethodBNistTestData1.GetAppliedForce(),
            MethodBNistTestData1.GetRawDataSeries1(),
            MethodBNistTestData1.GetRawDataSeries2(),
            MethodBNistTestData1.GetRawDataSeries3());

        // Act
        //application.RemoveSeriesByIndex(configuration.ExcludedSeriesByIndex);
        application.InterpolateSeriesData(InterpolatorFactory.CreateInterpolator(configuration.InterpolationType));
        application.RemoveValuesByIndex(configuration.TransientForceMeasurementsByIndex);
        application.ModifySeriesSize(new RemoveZeroValueForceItems());
        application.ReorderSeriesData(new RereorderByAppliedForceAscending());

        const int REFERENCE_SERIES_FOR_FORCE = 0;
        double[] appliedForce = application.Transform(new AppliedForceToArray(), REFERENCE_SERIES_FOR_FORCE);
        double[][] valuesForAllSeries = application.Transform(new SeriesValueToArray());

        configuration.CalculatedDegreeOfBestFit = application.GetDegreeOfBestFittingPolynomial(appliedForce, valuesForAllSeries);

        if (configuration.ApplyTemperatureCorrection)
            application.ApplyTemperatureCorrection
            (ambientTemperature: configuration.AmbientTemperature,
                standardCalibrationTemperature: configuration.StandardTemperatureOfCalibration,
                temperatureCorrectionValuePer1Degree: configuration.TemperatureCorrectionValuePer1Degree);
            
        // Assert
        const int LABSCH_BEST_DEGREE_FIT = 4;
        Assert.AreEqual(LABSCH_BEST_DEGREE_FIT, configuration.CalculatedDegreeOfBestFit);
    }
}
