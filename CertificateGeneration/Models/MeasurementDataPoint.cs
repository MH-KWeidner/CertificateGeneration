namespace CertificateGeneration.Models
{
    /// <summary>
    /// Defines the <see cref="MeasurementDataPoint" />
    /// </summary>
    public class MeasurementDataPoint
    {
        /// <summary>
        /// Gets or sets the AppliedForce
        /// </summary>
        public double AppliedForce { get; set; }

        /// <summary>
        /// Gets or sets the RawValue
        /// </summary>
        public double RawValue { get; set; }

        /// <summary>
        /// Gets or sets the Value
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementDataPoint"/> class.
        /// </summary>
        /// <param name="appliedForce">The appliedForce<see cref="double"/></param>
        /// <param name="rawValue">The rawValue<see cref="double"/></param>
        public MeasurementDataPoint(double appliedForce, double rawValue) => (AppliedForce, RawValue, Value) = (appliedForce, rawValue, rawValue);
    }
}
