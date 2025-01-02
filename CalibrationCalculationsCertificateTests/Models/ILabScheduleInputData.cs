namespace CalibrationCalculationsCertificateTests.Models
{
    public interface ILabScheduleInputData
    {
        public double[] NominalForcesApplied { get; }

        public double[][] MeasurementData { get; }
    }
}
