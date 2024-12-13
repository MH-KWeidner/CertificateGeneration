using CertificateGeneration.CertificateCalculations.Interpolation;
using CertificateGeneration.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateGeneration.CertificateCalculations.Interpolation
{
    public static class InterpolatorFactory
    {
        public static IInterpolate CreateInterpolator(InterpolationTypes interpolationType)
        {
            return interpolationType switch
            {
                InterpolationTypes.MethodA => new InitialZeroValueInterpolator(),
                InterpolationTypes.MethodB => new NistInterpolator(),
                _ => throw new ArgumentException("Invalid interpolation type", nameof(interpolationType))
            };
        }
    }
}
