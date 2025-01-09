using CalibrationCalculations.Common;
using CalibrationCalculations.Factories.ModifyMeasurementSeriesSize;
using CalibrationCalculations.Factories.ReorderMeasurementSeries;
using CalibrationCalculations.Factories.TransformMeasurementPoints;
using CalibrationCalculations.MathLibrary;
using CalibrationCalculations.Models;
using CalibrationCalculations.StandardCalculations.DegreeOfBestFit;
using CalibrationCalculations.StandardCalculations.Interpolation;


namespace CalibrationCalculations.GenerateE74;

/// <summary>
/// Defines the <see cref="E74Builder" />
/// </summary>
static public class E74Builder
{
    private const int SERIES_TO_USE_TO_GET_FORCE_VALUES = 0;

    /// <summary>
    /// The Build
    /// </summary>
    /// <param name="configuration">The configuration<see cref="E74Configuration"/></param>
    /// <param name="nominalAppliedForces">The nominalAppliedForces<see cref="double[]"/></param>
    /// <param name="measurementData">The measurementData<see cref="double[][]"/></param>
    /// <returns>The <see cref="E74Result"/></returns>
    static public E74Result Build(E74Configuration configuration, double[] nominalAppliedForces, params double[][] measurementData)
    {
        E74Result result = new();

        MeasurementApplication application = new(nominalAppliedForces, measurementData);

        #region Interpolation Sequence
        application.InterpolateMeasurementSeries(InterpolatorFactory.Create(configuration.InterpolationType));

        application.RemoveMeasurementPointsByIndex(configuration.TransientNominalAppliedForcesByIndex); 

        application.ModifySeriesSize(ModifyMeasurementSeriesSizeFactory.Create(ModifyMeasurementSeriesSizeTypes.RemoveZeroValuedNominalForces));

        if (configuration.InterpolationReorderType != MeasurementSeriesReorderTypes.DoNotReorder)
            application.ReorderSeriesData(ReorderFactory.Create(configuration.InterpolationReorderType));

        result.InterpolatedNominalForces = application.TransformMeasurementPoints(MeasurementPointsToArrayFactory.Create(MeasurementPointsToArrayTransformTypes.NominalAppliedForces), SERIES_TO_USE_TO_GET_FORCE_VALUES);
        
        result.InterpolatedValues = application.TransformMeasurementPoints(MeasurementPointsToArrayFactory.Create(MeasurementPointsToArrayTransformTypes.MeasurementValues));    
        #endregion

        if (configuration.ApplyTemperatureCorrection)
            application.ApplyTemperatureCorrection(configuration.AmbientTemperature, configuration.StandardTemperatureOfCalibration, configuration.TemperatureCorrectionValuePer1Degree);

        if (configuration.NominalizeActualForcesMeasured)
            application.ApplyNominalForceCorrection();

        double[] nominalForces = application.TransformMeasurementPoints(MeasurementPointsToArrayFactory.Create(MeasurementPointsToArrayTransformTypes.NominalAppliedForces), SERIES_TO_USE_TO_GET_FORCE_VALUES);
        result.NominalForces = nominalForces;

        double[][] measurementValues = application.TransformMeasurementPoints(MeasurementPointsToArrayFactory.Create(MeasurementPointsToArrayTransformTypes.MeasurementValues));
        result.Values = measurementValues;

        int degreeOfFit = SelectDegreeOfFit.Select(configuration.SelectedDegreeOfFit, nominalForces, measurementValues);
        result.DegreeOfFit = degreeOfFit;

        double[] stackedForces = application.StackMeasurementPoints(MeasurementPointsToArrayFactory.Create(MeasurementPointsToArrayTransformTypes.NominalAppliedForces));

        double[] stackedMeasurementValues = application.StackMeasurementPoints(MeasurementPointsToArrayFactory.Create(MeasurementPointsToArrayTransformTypes.MeasurementValues));

        for(int i = 0; i < stackedMeasurementValues.Length; i++)
        {
            stackedMeasurementValues[i] = Math.Round(stackedMeasurementValues[i], 8);
        }
        
        // TODO need to abstract this
        double[] aCoffieients = StatisticsMath.FitPolynomialToLeastSquares(stackedForces, stackedMeasurementValues, degreeOfFit);
        result.ACoefficients = aCoffieients;

        // TODO need to abstract this
        result.FittedCurve = StatisticsMath.EvaluateCoefficients(aCoffieients, nominalForces);

        return result;
    }
}
