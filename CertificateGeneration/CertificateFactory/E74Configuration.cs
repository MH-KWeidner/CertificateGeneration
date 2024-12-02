using CertificateGeneration.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateGeneration.CertificateFactory
{
    public class E74Configuration
    {
        public InterpolationTypes InterpolationType { get; set; }

        public TemperatureUnits TemperatureUnits { get; set; }
        
        public double AmbientTemperature{ get; set; }

        public IList<int> TransientForceMeasurementsByIndex { get; set; }

        public IList<int> ExcludedSeriesByIndex { get; set; }
    }
}
