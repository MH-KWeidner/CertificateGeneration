namespace CertificateGeneration.Models
{
    public interface IMeasurementPoint
    {
        double AppliedForce { get; set; }
        double RawValue { get; set; }
        double Value { get; set; }
    }
}