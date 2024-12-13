using System;
using System.Collections.Generic;
using System.Text;
using CalibrationCalculations.CertificateCreation;
using CalibrationCalculations.IoC.DataTransforms;
using CalibrationCalculations.IoC.Modifiers;
using CalibrationCalculations.Models;
using CalibrationCalculations.StandardCalculations.DegreeOfBestFit;
using CalibrationCalculations.StandardCalculations.Interpolation;

namespace CalibrationCalculations.CertificateCreation
{
    static public class E74Calculator
    {
        const int REFERENCE_SERIES_FOR_FORCE = 0;

        static public E74Result Build(E74Configuration configuration, double[] appliedForces, params double[][] measurementData)
        {
            MeasurementApplication application = new(appliedForces, measurementData);

            application.RemoveSeriesByIndex(configuration.ExcludedSeriesByIndex);
            application.InterpolateSeriesData(InterpolatorFactory.CreateInterpolator(configuration.InterpolationType));
            application.RemoveValuesByIndex(configuration.TransientForceMeasurementsByIndex);
            application.ModifySeriesSize(new RemoveZeroValueForceItems());
            application.ReorderSeriesData(new RereorderByAppliedForceAscending());

            double[] forces = application.Transform(new AppliedForceToArray(), REFERENCE_SERIES_FOR_FORCE);
            double[][] valuesForAllSeries = application.Transform(new SeriesValueToArray());

            configuration.DegreeOfBestFit = SelectBestDegreeOfFit.Select(configuration.SelectedDegreeOfFit, forces, valuesForAllSeries);

            if (configuration.ApplyTemperatureCorrection)
                application.ApplyTemperatureCorrection(
                    ambientTemperature: configuration.AmbientTemperature,
                    standardCalibrationTemperature: configuration.StandardTemperatureOfCalibration,
                    temperatureCorrectionValuePer1Degree: configuration.TemperatureCorrectionValuePer1Degree);

            if(configuration.ApplyNominalForceCorrection)
            {
                
            }

            return new E74Result();
        }
    }
}
