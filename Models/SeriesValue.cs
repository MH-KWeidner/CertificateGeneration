using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SeriesValue
    {
        //TODO make as private internal class

        public int Index { get; set; }
        public double AppliedForce { get; set; }
        public double RawValue { get; set; }
        public double? Value { get; set; } = null;

        public SeriesValue(int seriesPosition, double appliedForce, double rawValue) => (Index, AppliedForce, RawValue) = (seriesPosition, appliedForce, rawValue);
    }
}
