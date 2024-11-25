using CertificateGeneration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateGeneration.CertifcateCalculations.TemperatureCorrection
{
    public class ApplyCelsiusTemperatureCorrection : IApplyTemperatureCorrection
    {
        public void Apply(Series? series, double temperatureWhenMeasured)
        {
            // TODO add error handling and handling for null lists

            ArgumentNullException.ThrowIfNull(series);

            double standardTemperature = StandardTemperaturesOfCalibration.Celsius;

            double correctionValue = TemperatureCorrectionValues.Celsius;

            double correction = (standardTemperature - temperatureWhenMeasured) * correctionValue;

        }
    }
}
