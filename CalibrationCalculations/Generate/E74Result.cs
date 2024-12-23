﻿namespace CalibrationCalculations.Generate
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
        /// Gets or sets the AdjustedMeasurements
        /// </summary>
        public double[][]? AdjustedMeasurements { get; set; }
    }
}
