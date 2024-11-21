namespace CertificateGeneration.Models
{
    public class SeriesValue
    {
        //TODO consider making as a private internal class

        //TODO consider chaning index property to id property

        //TODO consider removing nullabe from Value property

        // TODO consider removing rawValue

        // TODO better better name for OriginalIndex

        //TODO consider what should be nullable

        public int OriginalIndex { get; private set; }
        public double AppliedForce { get; set; }
        public double RawValue { get; set; }
        public double Value { get; set; }

        public SeriesValue(int index, double appliedForce, double rawValue) => (OriginalIndex, AppliedForce, RawValue, Value) = (index, appliedForce, rawValue, rawValue);
    }
}
