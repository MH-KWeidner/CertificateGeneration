using CalibrationCalculations.Models;

namespace CalibrationCalculations.Models
{
    /// <summary>
    /// Defines the <see cref="IMeasurementPoint" />
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="IMeasurementPoint"/> class.
    /// </remarks>
    /// <param name="appliedForce">The appliedForce<see cref="double"/></param>
    /// <param name="rawValue">The rawValue<see cref="double"/></param>
    public class NominalMeasurementPoint(double appliedForce, double rawValue) : AbstractMeasurementPoint(appliedForce, rawValue)
    {
        // TODO decide on naming convention for properties and class
    }
}
