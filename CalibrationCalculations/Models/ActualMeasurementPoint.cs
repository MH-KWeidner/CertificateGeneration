namespace CalibrationCalculations.Models;

/// <summary>
/// Defines the <see cref="ActualMeasurementPoint" />
/// </summary>
public class ActualMeasurementPoint(double appliedForce, double rawValue, double actualAppliedForce) : AbstractMeasurementPoint(appliedForce, rawValue)
{
    /// <summary>
    /// Gets the ActualAppliedForce
    /// </summary>
    public double ActualAppliedForce { get; private set; } = actualAppliedForce;
}
