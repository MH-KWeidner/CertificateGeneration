using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateGeneration.Common.Temperature
{
    public enum TemperatureUnits
    {
        // TODO consdider null value
        
        Celsius,
        Fahrenheit
    }

    public class StandardTemperaturesOfCalibration
    {
        public const double Celsius = 23.0;
        
        public const double Fahernheit = 73.0;
    }

    public class TemperatureCorrectionValues
    {
        public const double Celsius = 0.00027;

        // public const double Fahernheit = 73.0;
    }
}
