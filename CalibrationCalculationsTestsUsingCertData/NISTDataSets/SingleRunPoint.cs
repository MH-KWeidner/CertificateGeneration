using CalibrationCalculationsTestsUsingCertData.NISTDataSets;

namespace CalibrationCalculationsTestsUsingCertData.NISTDataSets
{
    /// <summary>
    /// Defines the Direction
    /// </summary>
    public enum Direction
    {
        /// <summary>
        /// Defines the Ascending
        /// </summary>
        Ascending,

        /// <summary>
        /// Defines the Descending
        /// </summary>
        Descending,

        /// <summary>
        /// Defines the AscendingDesending
        /// </summary>
        AscendingDesending
    }

    /// <summary>
    /// Defines the <see cref="SingleRunPoint" />
    /// </summary>
    public class SingleRunPoint
    {
        /// <summary>
        /// Gets or sets the ForceApplied
        /// </summary>
        public decimal ForceApplied { get; set; }

        /// <summary>
        /// Gets or sets the Value
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// Gets or sets the Value2
        /// </summary>
        public decimal Value2 { get; set; }

        /// <summary>
        /// Gets or sets the Value3
        /// </summary>
        public decimal Value3 { get; set; }

        /// <summary>
        /// Gets or sets the PreNormValue
        /// </summary>
        public decimal PreNormValue { get; set; }

        /// <summary>
        /// Gets or sets the Standard
        /// </summary>
        public Standard Standard { get; set; }

        /// <summary>
        /// Gets or sets the Temperature
        /// </summary>
        public decimal Temperature { get; set; }

        /// <summary>
        /// Gets or sets the Error1
        /// </summary>
        public decimal Error1 { get; set; }

        /// <summary>
        /// Gets or sets the Error2
        /// </summary>
        public decimal Error2 { get; set; }

        /// <summary>
        /// Gets or sets the Error3
        /// </summary>
        public decimal Error3 { get; set; }

        /// <summary>
        /// Gets or sets the MaxError
        /// </summary>
        public double MaxError { get; set; }

        /// <summary>
        /// Gets or sets the NonLinearity
        /// </summary>
        public decimal NonLinearity { get; set; }

        /// <summary>
        /// Gets or sets the Hysterisis
        /// </summary>
        public decimal Hysterisis { get; set; }

        /// <summary>
        /// Gets or sets the SEBError
        /// </summary>
        public decimal SEBError { get; set; }

        /// <summary>
        /// Gets or sets the Resolution
        /// </summary>
        public decimal Resolution { get; set; }

        /// <summary>
        /// Gets or sets the Median
        /// </summary>
        public decimal Median { get; set; }

        /// <summary>
        /// Gets or sets the PointDirection
        /// </summary>
        public Direction PointDirection { get; set; }

        /// <summary>
        /// Gets or sets the Uncertainties
        /// </summary>
        public List<UncertaintyObject> Uncertainties { get; set; }

        /// <summary>
        /// Gets or sets the ExpandedUncertainty
        /// </summary>
        public decimal ExpandedUncertainty { get; set; }

        /// <summary>
        /// Gets or sets the TUR
        /// </summary>
        public decimal TUR { get; set; }

        /// <summary>
        /// Gets or sets the PFA
        /// </summary>
        public double PFA { get; set; }
    }
}
