using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Models
{
    public class DoubleValueArrayElement
    {
        public int ArrayPosition { get; }
        public double Value { get; }
        public DoubleValueArrayElement(int arrayPosition, double value) => (ArrayPosition, Value) = (arrayPosition, value);
    }
}
