using CalibrationCalculations.Common;
using CalibrationCalculations.Factories.ModifySeriesSize;
using CalibrationCalculations.Factories.ReorderSeries;
using CalibrationCalculations.Factories.TransformMeasurementPoints;
using CalibrationCalculations.MathLibrary;
using CalibrationCalculations.Models;
using CalibrationCalculations.StandardCalculations.DegreeOfBestFit;
using CalibrationCalculations.StandardCalculations.Interpolation;


namespace CalibrationCalculations.GenerateE74
{
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
        /// <param name="appliedForces">The appliedForces<see cref="double[]"/></param>
        /// <param name="measurementData">The measurementData<see cref="double[][]"/></param>
        /// <returns>The <see cref="E74Result"/></returns>
        static public E74Result Build(E74Configuration configuration, double[] appliedForces, params double[][] measurementData)
        {
            E74Result result = new();

            MeasurementApplication application = new(appliedForces, measurementData);

            application.InterpolateSeriesData(InterpolatorFactory.Create(configuration.InterpolationType));
            
            application.RemoveValuesByIndex(configuration.TransientForceMeasurementsByIndex);

            // TODO does this need to be an object/interface?
            application.ModifySeriesSize(new RemoveZeroValueForceItems());

            if (configuration.PostInterpolationReorderType != MeasurementSeriesReorderTypes.DoNotReorder)
                application.ReorderSeriesData(ReorderFactory.Create(configuration.PostInterpolationReorderType));

            if (configuration.ApplyTemperatureCorrection)
                application.ApplyTemperatureCorrection(
                    ambientTemperature: configuration.AmbientTemperature,
                    standardCalibrationTemperature: configuration.StandardTemperatureOfCalibration,
                    temperatureCorrectionValuePer1Degree: configuration.TemperatureCorrectionValuePer1Degree);

            if (configuration.NominalizeActualForcesMeasured)
                application.ApplyNominalForceCorrection();

            double[] nominalForces = application.TransformMeasurementPoints(MeasurementPointsToDoubleArrayFactory.Create(MeasurementPointsToArrayTransformTypes.NominalAppliedForces), SERIES_TO_USE_TO_GET_FORCE_VALUES);
            result.NominalForces = nominalForces;

            double[][] measurementValues = application.TransformMeasurementPoints(new MeasurementValuesToArray());
            result.Values = measurementValues;

            int degreeOfFit = SelectDegreeOfFit.Select(configuration.SelectedDegreeOfFit, nominalForces, measurementValues);
            result.DegreeOfFit = degreeOfFit;

            double[] stackedForces = application.StackMeasurementPoints(MeasurementPointsToDoubleArrayFactory.Create(MeasurementPointsToArrayTransformTypes.NominalAppliedForces));

            double[] stackedMeasurementValues = application.StackMeasurementPoints(MeasurementPointsToDoubleArrayFactory.Create(MeasurementPointsToArrayTransformTypes.MeasurementValues));

            double[] aCoffieients = StatisticsMath.FitPolynomialToLeastSquares(stackedForces, stackedMeasurementValues, degreeOfFit);
            result.ACoefficients = aCoffieients;

            result.FittedCurve = StatisticsMath.EvaluateCoefficients(aCoffieients, nominalForces);
            
            return result;
        }
    }
}
