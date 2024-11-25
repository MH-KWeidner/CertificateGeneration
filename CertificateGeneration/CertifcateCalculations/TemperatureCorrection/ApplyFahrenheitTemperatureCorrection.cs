using CertificateGeneration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateGeneration.CertifcateCalculations.TemperatureCorrection
{
    internal class ApplyFahrenheitTemperatureCorrection : IApplyTemperatureCorrection
    {
        public void Apply(Series? series, double temperatureWhenMeasured)
        {
            // TODO add error handling and for null lists

            double temperatureCorrection = StandardTemperaturesOfCalibration.Fahernheit;
        }
    }
}
