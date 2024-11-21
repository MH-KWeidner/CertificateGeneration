using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateGeneration.Models.DataTransform
{
    public class AppliedForceToArray : ITransformToDoubleArray
    {
        public double[] ToArray(List<SeriesValue>? seriesValues)
        {
            ArgumentNullException.ThrowIfNull(seriesValues);

            return seriesValues.Select(sv => sv.AppliedForce).ToArray();
        }
    }
}
