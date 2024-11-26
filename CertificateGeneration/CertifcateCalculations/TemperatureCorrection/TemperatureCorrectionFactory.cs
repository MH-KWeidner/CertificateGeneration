using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CertificateGeneration.CertifcateCalculations.TemperatureCorrection
{
    public static class TemperatureCorrectionFactory
    {
        public static IApplyTemperatureCorrection CreateTemperatureCorrection(TemperatureUnits unit)
        {
            return unit switch
            {
                TemperatureUnits.Celsius => new ApplyCelsiusTemperatureCorrection(),
                TemperatureUnits.Fahrenheit => new ApplyFahrenheitTemperatureCorrection(),
                _ => throw new ArgumentException("Invalid temperature unit", nameof(unit))
            };
        }
    }
}
