using CertificateGeneration.CertificateCalculations.DegreeOfBestFit;
using CertificateGeneration.CertificateCalculations.Interpolation;
using CertificateGeneration.IoC.DataTransforms;
using CertificateGeneration.IoC.Modifiers;
using CertificateGeneration.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CertificateGeneration.CertificateCreation
{
    static public class E74CertificateBuilder
    {
        const int REFERENCE_SERIES_FOR_FORCE = 0;

        static public E74CertificateResult Build(E74CertificateConfiguration configuration, double[] nominalAppliedForces, double[][] actualAppliedForces, double[][] measurementData)
        {
            MeasurementApplication application = new(nominalAppliedForces, actualAppliedForces, measurementData);

            application.RemoveSeriesByIndex(configuration.ExcludedSeriesByIndex);
            application.InterpolateSeriesData(InterpolatorFactory.CreateInterpolator(configuration.InterpolationType));
            application.RemoveValuesByIndex(configuration.TransientForceMeasurementsByIndex);
            application.ModifySeriesSize(new RemoveZeroValueForceItems());
            application.ReorderSeriesData(new RereorderByAppliedForceAscending());

            double[] forces = application.Transform(new AppliedForceToArray(), REFERENCE_SERIES_FOR_FORCE);
            double[][] valuesForAllSeries = application.Transform(new SeriesValueToArray());

            configuration.DegreeOfBestFit = SelectBestDegreeOfFit.Select(configuration.SelectedDegreeOfFit, forces, valuesForAllSeries);

            if (configuration.ApplyTemperatureCorrection)
                application.ApplyTemperatureCorrection
                (ambientTemperature: configuration.AmbientTemperature,
                    standardCalibrationTemperature: configuration.StandardTemperatureOfCalibration,
                    temperatureCorrectionValuePer1Degree: configuration.TemperatureCorrectionValuePer1Degree);

            return new E74CertificateResult();
        }
    }
}
