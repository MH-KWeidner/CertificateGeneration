using Models.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DataTransform
{
    public interface ITransformToDoubleArray
    {
        public double[] ToArray(List<SeriesValue>? seriesValues);
    }
}
