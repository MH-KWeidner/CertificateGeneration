namespace CalibrationCalculations.Models
{
    /// <summary>
    /// Defines the <see cref="IMeasurementPoint" />
    /// </summary>
    public interface IMeasurementPoint
    {
        /// <summary>
        /// Gets or sets the AppliedForce
        /// </summary>
        double AppliedForce { get; set; }

        /// <summary>
        /// Gets or sets the RawValue
        /// </summary>
        double RawValue { get; set; }

        /// <summary>
        /// Gets or sets the Value
        /// </summary>
        double Value { get; set; }
    }
}
