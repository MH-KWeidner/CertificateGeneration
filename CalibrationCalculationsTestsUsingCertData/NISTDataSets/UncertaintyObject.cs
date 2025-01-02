using CalibrationCalculationsTestsUsingCertData.NISTDataSets;

namespace CalibrationCalculationsTestsUsingCertData.NISTDataSets
{
    /// <summary>
    /// Defines the UncertaintyType
    /// </summary>
    public enum UncertaintyType
    { /// <summary>
      /// Defines the A
      /// </summary>
        A,
        /// <summary>
        /// Defines the B
        /// </summary>
        B
    }

    /// <summary>
    /// Defines the UncertaintyContributor
    /// </summary>
    public enum UncertaintyContributor
    {
        /// <summary>
        /// Defines the NonLinearity
        /// </summary>
        NonLinearity,

        /// <summary>
        /// Defines the Hysterisis
        /// </summary>
        Hysterisis,

        /// <summary>
        /// Defines the Resolution
        /// </summary>
        Resolution,

        /// <summary>
        /// Defines the ReferenceStandard
        /// </summary>
        ReferenceStandard,

        /// <summary>
        /// Defines the SecondaryStandard
        /// </summary>
        SecondaryStandard,

        /// <summary>
        /// Defines the ElectricalStandard
        /// </summary>
        ElectricalStandard
    }

    /// <summary>
    /// Defines the <see cref="UncertaintyObject" />
    /// </summary>
    public class UncertaintyObject
    {
        /// <summary>
        /// Gets or sets the Type
        /// </summary>
        public UncertaintyType Type { get; set; }

        /// <summary>
        /// Gets or sets the Mode
        /// </summary>
        public UncertaintyContributor Mode { get; set; }

        /// <summary>
        /// Gets or sets the Distribution
        /// </summary>
        public string Distribution { get; set; }

        /// <summary>
        /// Gets or sets the Uncertainty
        /// </summary>
        public decimal Uncertainty { get; set; }

        /// <summary>
        /// Gets or sets the StandardUncertainty
        /// </summary>
        public decimal StandardUncertainty { get; set; }

        /// <summary>
        /// Gets or sets the Variance
        /// </summary>
        public decimal Variance { get; set; }

        /// <summary>
        /// Gets or sets the DegreesOfFreedom
        /// </summary>
        public int DegreesOfFreedom { get; set; }

        /// <summary>
        /// Gets or sets the EffectiveDegreesOfFreedom
        /// </summary>
        public int EffectiveDegreesOfFreedom { get; set; }

        /// <summary>
        /// Gets or sets the Divisor
        /// </summary>
        public decimal Divisor { get; set; }

        /// <summary>
        /// Gets or sets the ContributionPercentage
        /// </summary>
        public decimal ContributionPercentage { get; set; }

        /// <summary>
        /// Gets or sets the u4df
        /// </summary>
        public decimal u4df { get; set; }

        /// <summary>
        /// Gets or sets the CombinedUncertainty
        /// </summary>
        public decimal CombinedUncertainty { get; set; }

        /// <summary>
        /// Gets or sets the ExpandedUncertainty
        /// </summary>
        public decimal ExpandedUncertainty { get; set; }

        /// <summary>
        /// Gets or sets the CoverageFactor
        /// </summary>
        public decimal CoverageFactor { get; set; }
    }
}
