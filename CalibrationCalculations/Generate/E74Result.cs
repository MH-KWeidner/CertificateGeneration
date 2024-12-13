namespace CalibrationCalculations.Generate
{
    /// <summary>
    /// Defines the <see cref="E74Result" />
    /// </summary>
    public class E74Result
    {
        /// <summary>
        /// Gets or sets the DegreeOfBestFit
        /// </summary>
        public int DegreeOfBestFit { get; set; }

        /// <summary>
        /// Gets or sets the ACoefficients
        /// </summary>
        internal double[]? ACoefficients { get; set; }

        /// <summary>
        /// Gets or sets the FittedCurve
        /// </summary>
        internal double[]? FittedCurve { get; set; }

        /// <summary>
        /// Gets or sets the interpolatedForces
        /// </summary>
        internal double[]? interpolatedForces { get; set; }

        /// <summary>
        /// Gets or sets the interpolatedMeasurements
        /// </summary>
        internal double[][]? interpolatedMeasurements { get; set; }
    }
}
