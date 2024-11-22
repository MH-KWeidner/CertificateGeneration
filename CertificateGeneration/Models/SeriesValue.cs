namespace CertificateGeneration.Models
{
    /// <summary>
    /// Defines the <see cref="SeriesValue" />
    /// </summary>
    public class SeriesValue
    {
        //TODO consider making as a private internal class

        //TODO consider chaning index property to id property

        //TODO consider removing nullabe from Value property

        // TODO consider removing rawValue

        // TODO better better name for OriginalIndex

        //TODO consider what should be nullable

        /// <summary>
        /// Gets the OriginalIndex
        /// </summary>
        public int OriginalIndex { get; private set; }

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
        /// Initializes a new instance of the <see cref="SeriesValue"/> class.
        /// </summary>
        /// <param name="index">The index<see cref="int"/></param>
        /// <param name="appliedForce">The appliedForce<see cref="double"/></param>
        /// <param name="rawValue">The rawValue<see cref="double"/></param>
        public SeriesValue(int index, double appliedForce, double rawValue) => (OriginalIndex, AppliedForce, RawValue, Value) = (index, appliedForce, rawValue, rawValue);
    }
}
