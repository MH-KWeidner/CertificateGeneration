using CalibrationCalculations.Common;
using CalibrationCalculations.Factories.ReorderSeries;
using CalibrationCalculations.Factories.TransformMeasurementPoints;

namespace CalibrationCalculations.Factories.TransformMeasurementPoints
{
    public static class MeasurementPointsToDoubleArrayFactory
    {
        public static ITransformMeasurementPointsToArray Create(MeasurementPointsToArrayTransformTypes transformType)
        {
            return transformType switch
            {
                MeasurementPointsToArrayTransformTypes.NominalAppliedForces => new NominalAppliedForcesToArray(),
                MeasurementPointsToArrayTransformTypes.MeasurementValues => new MeasurementValuesToArray(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
