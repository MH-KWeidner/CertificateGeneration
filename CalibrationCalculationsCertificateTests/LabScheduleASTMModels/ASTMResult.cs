namespace CalibrationCalculationsCertificateTests.LabScheduleASTMModels
{
    internal class ASTMResult
    {
        // properties specific to the overall ASTM Result
        public IEnumerable<double> ACoefficients { get; set; }

        public IEnumerable<double> BCoefficients { get; set; }
        public IList<double> prevACoefficients { get; set; }
        public IList<decimal> Loads { get; set; }
        public IList<double> ValuesFromCurve { get; set; }
        public IList<double> InverseValuesFromCurve { get; set; }
        public IList<double[]> DeviationFromCurve { get; set; }
        public ChangeFromPreviousObject ChangeFromPrevious { get; set; }
        public LoadingRange ClassALoadingRange { get; set; }
        public LoadingRange ClassAALoadingRange { get; set; }
        public LoadingRange AlternateClassALoadingRange { get; set; }
        public LoadingRange AlternateClassAALoadingRange { get; set; }
        public int DegreeFit { get; set; }
        public bool FTestPass { get; set; }
        public double LowerLimitFactor { get; set; }
        public double StandardDeviationDeflection { get; set; }
        public double StandardDeviationDeflectionAverage { get; set; }
        public double StandardDeviationLoad { get; set; }
        public double Resolution { get; set; }

        
        /// <summary>
        /// Represents an ASTM Loading range for Class A and Class AA, standard and alternative ranges.
        /// </summary>
        public class LoadingRange()
        {
            /// <summary>
            /// The lowest verified value this instrument has been calibrated for.
            /// </summary>
            public double Minimum { get; set; }

            /// <summary>
            /// The highest verified value this instrument has been calibrated for.
            /// </summary>
            public double Maximum { get; set; }

            /// <summary>
            /// Represents the <see cref="Minimum"/>'s value as fitted through the specified coefficients (not part of <see langword="this"/> class).
            /// </summary>
            public double LowerLimitFittedCurveValue { get; set; }

            /// <summary>
            /// Represents the <see cref="Minimum"/>'s value as fitted through the specified previous coefficients (not part of <see langword="this"/> class).
            /// </summary>
            public double LowerLimitFittedPrevCurveValue { get; set; }

            /// <summary>
            /// Represents the <see cref="Minimum"/>'s change from previous. Determined by the following equation, where each of the values is first rounded to the instrument's resolution:<br />
            /// <br />
            /// ((<see cref="LowerLimitFittedCurveValue"/> - <see cref="LowerLimitFittedPrevCurveValue"/>) / <see cref="LowerLimitFittedCurveValue"/>) * 100%<br />
            /// <br />
            /// May be zero if <see langword="this"/> represents an alternate <see cref="LoadingRange"/> and a usable range (less than the <see cref="Maximum"/>) could not be determined.
            /// </summary>
            public double LowerLimitFittedChangeFromPrev { get; set; }
        }

        public class ChangeFromPreviousObject()
        {
            /// <summary>
            /// Contains the previous coefficients used to calculate the <see cref="PreviousValuesFromCurve"/>.
            /// </summary>
            public List<double> PreviousACoefficients { get; set; }

            /// <summary>
            /// Calculated from the <see cref="loads"/> and <see cref="PreviousACoefficients"/>.
            /// </summary>
            public List<double> PreviousValuesFromCurve { get; set; }

            /// <summary>
            /// Represents the percent difference for the <see cref="loads"/> with the following equation. Each value is rounded to the 3rd decimal place.<br />
            /// <br />
            /// ((current value - <see cref="PreviousValuesFromCurve"/>) / current value) * 100%<br />
            /// </summary>
            public List<double> PercentDifferences { get; set; } = [];

            /// <summary>
            /// Represents the deviation between the current and <see cref="PreviousValuesFromCurve"/>, rounded to the instrument's resolution.
            /// </summary>
            public List<double> ChangeFromPrevious { get; set; } = [];
        }
    }
}
