using CalibrationCalculations.Common;

namespace CalibrationCalculations.Factories.ReorderMeasurementSeries
{
    /// <summary>
    /// Defines the <see cref="ReorderFactory" />
    /// </summary>
    public static class ReorderFactory
    {
        /// <summary>
        /// The Create
        /// </summary>
        /// <param name="reorderType">The reorderType<see cref="MeasurementSeriesReorderTypes"/></param>
        /// <returns>The <see cref="IReorderMeasurementSeries"/></returns>
        public static IReorderMeasurementSeries Create(MeasurementSeriesReorderTypes reorderType)
        {
            return reorderType switch
            {
                MeasurementSeriesReorderTypes.DetectedNominalForceOrdering => new ReorderByDetectedNominalForceOrdering(),
                MeasurementSeriesReorderTypes.NominalForceAscending => new ReorderByNominalForceAscending(),
                MeasurementSeriesReorderTypes.NominalForceDescending => new ReorderByNominalForceDescending(),
                MeasurementSeriesReorderTypes.OrderTagAscending => new ReorderByOrderTagAscending(),
                MeasurementSeriesReorderTypes.OrderTagDescending => new ReorderByOrderTagDescending(),
                _ => throw new NotImplementedException()
            };
        }
    }
}
