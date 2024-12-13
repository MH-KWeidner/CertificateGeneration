namespace CalibrationCalculations.Models
{
    /// <summary>
    /// Defines the <see cref="IMeasurementPoint" />
    /// </summary>
    public class NominalMeasurementPoint(double appliedForce, double rawValue) : AbstractMeasurementPoint(appliedForce, rawValue)
    {
    }
}
