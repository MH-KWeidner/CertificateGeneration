using CalibrationCalculations.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalibrationCalculations.IoC.ReorderSeries
{
    internal class ReorderbyDetectedOrdering : IReorderSeries
    {
        public List<IMeasurementPoint>? Reorder(List<IMeasurementPoint>? measurementPoints)
        {
            throw new NotImplementedException();
        }
    }
}
