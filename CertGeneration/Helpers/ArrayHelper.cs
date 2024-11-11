using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers.Models;

namespace CertGeneration.Helpers
{
    public static class ArrayHelper
    {
        public static DoubleValueArrayElement[] GetElementsByValue(double targetValue, double[] array)
        {
            //TODO add error handling

            return array.Select((value, index) => new DoubleValueArrayElement(index, value))
                         .Where(item => item.Value == targetValue).ToArray();
        }
    }
}
