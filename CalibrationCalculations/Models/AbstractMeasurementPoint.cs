namespace CalibrationCalculations.Models
{
    /// <summary>
    /// Defines the <see cref="AbstractMeasurementPoint" />
    /// </summary>
    public abstract class AbstractMeasurementPoint : IMeasurementPoint
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
        /// Gets or sets the Value
        /// </summary>
        public int? OrderTag { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractMeasurementPoint"/> class.
        /// </summary>
        /// <param name="appliedForce">The appliedForce<see cref="double"/></param>
        /// <param name="rawValue">The rawValue<see cref="double"/></param>
        public AbstractMeasurementPoint(double appliedForce, double rawValue) => (AppliedForce, RawValue, Value, OrderTag) = (appliedForce, rawValue, rawValue, null);

        public AbstractMeasurementPoint(double appliedForce, double rawValue, int? orderTag) => (AppliedForce, RawValue, Value, OrderTag) = (appliedForce, rawValue, rawValue, orderTag);

    }
}
