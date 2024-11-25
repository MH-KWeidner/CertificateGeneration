using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CertificateGeneration.CertifcateCalculations.TemperatureCorrection
{
    public static class ApplyTemperatureCorrectionFactory
    {
        // TODO use lazy loading

        private static readonly Dictionary<TemperatureUnits, IApplyTemperatureCorrection> cache;

        static ApplyTemperatureCorrectionFactory()
        {
            cache = new Dictionary<TemperatureUnits, IApplyTemperatureCorrection>
            {
                { TemperatureUnits.Celsius, new ApplyCelsiusTemperatureCorrection() },
                { TemperatureUnits.Fahrenheit, new ApplyFahrenheitTemperatureCorrection() }
            };
        }

        public static IApplyTemperatureCorrection GetTemperatureCorrection(TemperatureUnits unit) => cache[unit];
    }
}
