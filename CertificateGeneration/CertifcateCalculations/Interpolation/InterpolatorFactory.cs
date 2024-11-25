using CertificateGeneration.CertifcateCalculations.Interpolation;
using CertificateGeneration.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateGeneration.CertifcateCalculations.Interpolation
{
    public static class InterpolatorFactory
    {
        // TODO add error handling

        // TODO use lazy loading

        private static readonly Dictionary<InterpolationTypes, IInterpolate> cache;

        static InterpolatorFactory()
        {
            cache = new Dictionary<InterpolationTypes, IInterpolate>
            {
                { InterpolationTypes.MethodA, new InitialZeroValueInterpolator() },
                { InterpolationTypes.MethodB, new NistInterpolator() }
            };
        }

        // TODO better naming


        public static IInterpolate GetInterpolator(InterpolationTypes interpolationType) => cache[interpolationType];
    }
}
