using CalibrationCalculations.Common;

namespace CalibrationCalculations.Factories.TransformMeasurementPoints;

/// <summary>
/// Defines the <see cref="MeasurementPointsToArrayFactory" />
/// </summary>
public static class MeasurementPointsToArrayFactory
{
    /// <summary>
    /// The Create
    /// </summary>
    /// <param name="transformType">The transformType<see cref="MeasurementPointsToArrayTransformTypes"/></param>
    /// <returns>The <see cref="ITransformMeasurementPointsToArray"/></returns>
    public static ITransformMeasurementPointsToArray Create(MeasurementPointsToArrayTransformTypes transformType)
    {
        return transformType switch
        {
            MeasurementPointsToArrayTransformTypes.NominalAppliedForces => new NominalAppliedForcesToArray(),
            MeasurementPointsToArrayTransformTypes.MeasurementValues => new MeasurementValuesToArray(),
            _ => throw new NotImplementedException()
        };
    }
}
