using CalibrationCalculations.Common;

namespace CalibrationCalculations.Factories.ReorderSeries
{
    public static class ReorderFactory
    {
        public static IReorderMeasurementSeries Create(MeasurementSeriesReorderTypes reorderType)
        {
            return reorderType switch
            {
                MeasurementSeriesReorderTypes.DetectedNominalForceOrdering => new ReorderByDetectedNominalForceOrdering(),
                MeasurementSeriesReorderTypes.NominalForceAscending => new ReorderByNominalForceAscending(),
                MeasurementSeriesReorderTypes.NominalForceDescending => new ReorderByNominalForceDescending(),
                MeasurementSeriesReorderTypes.OrderTagAscending => new ReorderByOrderTagAscending(),
                MeasurementSeriesReorderTypes.OrderTagDescending => new ReorderByOrderTagDescending(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
