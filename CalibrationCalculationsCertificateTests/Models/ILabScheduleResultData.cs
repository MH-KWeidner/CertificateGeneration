namespace CalibrationCalculationsCertificateTests.Models
{
    /// <summary>
    /// Defines the <see cref="ILabScheduleResultData" />
    /// </summary>
    public interface ILabScheduleResultData
    {
        /// <summary>
        /// The ACoefficients as returned from the MathNet library
        /// </summary>
        public double[][] MathNetACoefficients { get; }
    }
}
