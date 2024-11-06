using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Models
{
    public class DoubleValueArrayElement
    {
        public int Index { get; }
        public double Value { get; }
        public DoubleValueArrayElement(int index, double value) => (Index, Value) = (index, value);
    }
}
