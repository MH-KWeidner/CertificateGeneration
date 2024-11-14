using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SeriesValue
    {
        //TODO consider making as a private internal class

        //TODO consider chaning index property to id property

        //TODO consider removing nullabe from Value property

        public int CacheIndex { get; private set; }
        //public int Id { get; private set; }
        public double AppliedForce { get; set; }
        public double RawValue { get; set; }
        public double Value { get; set; }

        public SeriesValue(int index, double appliedForce, double rawValue) => (CacheIndex, Id, AppliedForce, RawValue, Value) = (index, index, appliedForce, rawValue, rawValue);
    }
}
