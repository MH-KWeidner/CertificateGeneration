using CalibrationCalculations.Common;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace CalibrationCalculations.IoC.ReorderSeries
{
    public static class ReorderFactory
    {
        public static IReorderSeries Create(ReorderTypes reorderType)
        {
            return reorderType switch
            {
                ReorderTypes.DetectedNominalForceOrdering => new ReorderByDetectedNominalForceOrdering(),
                ReorderTypes.NominalForceAscending => new ReorderByNominalForceAscending(),
                ReorderTypes.NominalForceDescending => new ReorderByNominalForceDescending(),
                ReorderTypes.OrderTagAscending => new ReorderByOrderTagAscending(),
                ReorderTypes.OrderTagDescending => new ReorderByOrderTagDescending(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
