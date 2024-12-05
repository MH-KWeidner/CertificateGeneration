using CertificateGeneration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateGeneration.CertificateCalculations.TemperatureCorrection
{
    public class ApplyCelsiusTemperatureCorrection : IApplyTemperatureCorrection
    {
        public void Apply(Series? series, double ambientTemperature)
        {
            // TODO add error handling and handling for null lists

            // TODO: fix this
            // ArgumentNullException.ThrowIfNull(series);

            double standardTemperature = StandardTemperaturesOfCalibration.Celsius;

            double correctionValue = TemperatureCorrectionValues.Celsius;

            double appliedCorrection = (standardTemperature - ambientTemperature) * correctionValue;

            // TODO verify correct based on appliedCorrection being neg or pos

            for (int i = 0; i < series?.CountValues(); i++)
            {
                series?.SetValue(i, series.GetValue(i) + appliedCorrection);
            }
        }
    }
}
