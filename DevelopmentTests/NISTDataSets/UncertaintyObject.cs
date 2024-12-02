using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentTests.NISTDataSets
{
    public enum UncertaintyType { A, B }

    public enum UncertaintyContributor
    {
        NonLinearity,
        Hysterisis,
        Resolution,
        ReferenceStandard,
        SecondaryStandard,
        ElectricalStandard
    }

    public class UncertaintyObject
    {
        public UncertaintyType Type { get; set; }
        public UncertaintyContributor Mode { get; set; }

        public string Distribution { get; set; }

        public decimal Uncertainty { get; set; }
        public decimal StandardUncertainty { get; set; }
        public decimal Variance { get; set; }

        public int DegreesOfFreedom { get; set; }
        public int EffectiveDegreesOfFreedom { get; set; }

        public decimal Divisor { get; set; }
        public decimal ContributionPercentage { get; set; }
        public decimal u4df { get; set; }
        public decimal CombinedUncertainty { get; set; }
        public decimal ExpandedUncertainty { get; set; }
        public decimal CoverageFactor { get; set; }
    }
}
