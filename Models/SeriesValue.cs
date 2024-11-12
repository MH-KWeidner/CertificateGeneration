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

        public int PositionInSeries { get; set; }
        public double AppliedForce { get; set; }
        public double RawValue { get; set; }
        public double? InterpolatedValue { get; set; } = null;

        public SeriesValue(int positionInSeries, double rawValue) => (PositionInSeries, RawValue) = (positionInSeries, rawValue);

        public SeriesValue(int positionInSeries, double appliedForce, double rawValue) => (PositionInSeries, AppliedForce, RawValue) = (positionInSeries, appliedForce, rawValue);
    }
}
