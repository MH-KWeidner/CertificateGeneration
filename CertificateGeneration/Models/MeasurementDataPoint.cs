namespace CertificateGeneration.Models
{
    /// <summary>
    /// Defines the <see cref="MeasurementDataPoint" />
    /// </summary>
    public class MeasurementDataPoint
    {
        /// <summary>
        /// Gets or sets the NominalAppliedForce
        /// </summary>
        public double NominalAppliedForce { get; set; }

        /// <summary>
        /// Gets or sets the ActualAppliedForce
        /// </summary>
        public double ActualAppliedForce { get; set; }

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
        /// <param name="nominalAppliedForce">The nominalAppliedForce<see cref="double"/></param>
        /// <param name="actualAppliedForce">The actualAppliedForce<see cref="double"/></param>
        /// <param name="rawValue">The rawValue<see cref="double"/></param>
        public MeasurementDataPoint(double nominalAppliedForce, double actualAppliedForce, double rawValue) => (NominalAppliedForce, ActualAppliedForce, RawValue, Value) = (nominalAppliedForce, actualAppliedForce, rawValue, rawValue);
    }
}
