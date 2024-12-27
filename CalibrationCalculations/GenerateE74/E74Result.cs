namespace CalibrationCalculations.GenerateE74
{
    /// <summary>
    /// Defines the <see cref="E74Result" />
    /// </summary>
    public class E74Result
    {
        /// <summary>
        /// Gets or sets the ACoefficients
        /// </summary>
        public double[]? ACoefficients { get; set; }

        /// <summary>
        /// Gets or sets the FittedCurve
        /// </summary>
        public double[]? FittedCurve { get; set; }

        /// <summary>
        /// Gets or sets the NominalForces
        /// </summary>
        public double[]? NominalForces { get; set; }

        /// <summary>
        /// Gets or sets the Values
        /// </summary>
        public double[][]? Values { get; set; }

        public int DegreeOfFit { get; set; }
    }
}
