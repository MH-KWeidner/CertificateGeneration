using CertificateGeneration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateGeneration.CertificateCalculations.TemperatureCorrection
{
    public interface IApplyTemperatureCorrection
    {
        void Apply(Series? series, double ambientTemperature);
    }
}
