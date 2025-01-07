namespace CalibrationCalculations.Models;

/// <summary>
/// Defines the <see cref="IMeasurementPoint" />
/// </summary>
public class NominalMeasurementPoint : AbstractMeasurementPoint, IMeasurementPoint
{
    public NominalMeasurementPoint(double appliedForce, double rawValue) : base(appliedForce, rawValue)
    {
    }

    public NominalMeasurementPoint(double appliedForce, double rawValue, int? orderTag) : base(appliedForce, rawValue, orderTag)
    {
    }
}
