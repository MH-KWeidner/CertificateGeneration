using CalibrationCalculations.Models;

namespace CalibrationCalculations.IoC.ReorderSeries
{
    internal class ReorderByOrderTagAscending : IReorderSeries
    {
        public List<IMeasurementPoint>? Reorder(List<IMeasurementPoint>? measurementPoints)
        {
            throw new NotImplementedException();
        }
    }
}
