namespace CalibrationCalculationsCertificateTests.LabScheduleModels
{
    /// <summary>
    /// Defines the <see cref="ILabScheduleAdditionalData" />
    /// </summary>
    internal interface ILabScheduleAdditionalData
    {
        /// <summary>
        /// The ACoefficients as returned from the MathNet library
        /// </summary>
        internal double[][] MathNetACoefficients { get; }
    }
}
