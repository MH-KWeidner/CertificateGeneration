namespace CalibrationCalculationsCertificateTests.LabScheduleTestData
{
    public interface ILabScheduleInputData
    {
        public double[] NominalForcesApplied { get; }

        public double[][] MeasurementData { get; }
        
    }
}
