namespace CalibrationCalculationsCertificateTests.LabScheduleModels;

public class LabAnalysisSingleRunResult
{
    public LabAnalysisObject LabObject { get; set; }
    public List<SingleRun> Runs { get; set; } = new();
    public SingleRun MeanRun { get; set; }
    public int MaxResolutionDigits { get; set; }
    public decimal MaxNonRepeatability { get; set; }

    private IList<AssignedAccuracy> accuracies;
    private IList<Instrument> instruments;

    public class stringSingleRunPoint
    {
        public string ForceApplied { get; set; }
        public string Value { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }
        public string BestFitLineY { get; set; }
        public string MeanValue { get; set; }
        public string Error1 { get; set; }
        public string Error2 { get; set; }
        public string Error3 { get; set; }
        public string ExpandedUncertainty { get; set; }
        public string NonLinearity { get; set; }
        public string SEBError { get; set; }
        public string Hysteresis { get; set; }
        public string TUR { get; set; }
        public string PFA { get; set; }
        public string convLowerLimit { get; set; }
        public string convUpperLimit { get; set; }
        public string PassFail { get; set; }
        public bool PassedTest { get; set; }

    }

    public class sameUnitSingleRunResult
    {
        public List<convSingleRunPoint> NormalizedData { get; set; }

        public sameUnitSingleRunResult()
        {
            NormalizedData = new List<convSingleRunPoint>();
        }
    }

    public class convSingleRunPoint
    {
        public decimal ForceApplied { get; set; }
        public decimal Value { get; set; }
        public decimal Value2 { get; set; }
        public decimal Value3 { get; set; }
        public decimal MeanValue { get; set; }
        public decimal Error1 { get; set; }
        public decimal Error2 { get; set; }
        public decimal Error3 { get; set; }

        private decimal _expandedUncertainty;
        public decimal ExpandedUncertainty
        {
            get => _expandedUncertainty;
            set
            {
                if (_expandedUncertainty != value)
                {
                    _expandedUncertainty = value;
                    CalculateTestUuncertaintyRatio();
                }
            }
        }

        public decimal NonLinearity { get; set; }
        public decimal Hysteresis { get; set; }
        public decimal SEBError { get; set; }

        private decimal _convUpperLimit;
        public decimal convUpperLimit
        {
            get => _convUpperLimit;
            set
            {
                if (_convUpperLimit != value)
                {
                    _convUpperLimit = value;
                    CalculateTestUuncertaintyRatio();
                }
            }
        }

        private decimal _convLowerLimit;
        public decimal convLowerLimit
        {
            get => _convLowerLimit;
            set
            {
                if (_convLowerLimit != value)
                {
                    _convLowerLimit = value;
                    CalculateTestUuncertaintyRatio();
                }
            }
        }

        public bool? PassedTest { get; set; }

        public decimal TUR { get; set; }
        public decimal PFA { get; set; }

        private void CalculateTestUuncertaintyRatio()
        {
            // Why the fuck did B3 recalculate every single value, incorrectly, 5 times throughout the program?
            if (convUpperLimit != null && convLowerLimit != null && ExpandedUncertainty != null && ExpandedUncertainty != 0)
                TUR = Math.Abs(Math.Round(0.5m * (convLowerLimit - convUpperLimit) / ExpandedUncertainty, 2));
            else
                TUR = 0;
        }
    }

    public class ssrsHeaders
    {
        public string hdrDirReadSingleTolerance { get; set; }
        public string hdrAnyMultipleStraightLine { get; set; }
        public string hdrAnySingleNonlinNoTolerance { get; set; }
        public string hdrAnyMultipleNonlinNoTolerance { get; set; }
        public string hdrAnySingleStraightLineNonlinNoTolerance { get; set; }
        public string hdrDirReadSingleOrMultipleNoTolerance { get; set; }
        public string hdrDirReadMultipleToleranceOutputs { get; set; }
        public string hdrDirReadMultipleToleranceMean { get; set; }
        public string hdrCertif { get; set; }
        public string hdrAppendix { get; set; }
        public string hdrASTM { get; set; }
        public string hdrASTMIndSettings { get; set; }
    }

    public class GraphRunPoint
    {
        public decimal ForceApplied { get; set; }
        public decimal Value { get; set; }
        public string Equation { get; set; }

        public GraphRunPoint() { }
    }

    public class MultiRawData
    {
        public List<RawDataForCert> RawData { get; set; }

        public MultiRawData()
        {
            RawData = new List<RawDataForCert>();
        }
    }

    public class StringRawDataForCert
    {
        public List<StringiRawData> RawData { get; set; }
        public StringRawDataForCert()
        {
            RawData = new List<StringiRawData>();
        }
    }

    public class StringiRawData
    {
        public string ForceApplied { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }
        public string Value4 { get; set; }
        public string MeanValue { get; set; }
        public string Uncertainty { get; set; }
        public string BestFitLineY { get; set; }
        public string NonLinearity { get; set; }
        public string SEBError { get; set; }
        public string Hysteresis { get; set; }
        public string ChangeFromPrevious { get; set; }
    }

    public class RawDataforCert
    {
        public List<iRawData> RawData { get; set; }
        public RawDataforCert()
        {
            RawData = new List<iRawData>();
        }
    }

    public class iRawData
    {
        public decimal? ForceApplied { get; set; }
        public decimal? Value1 { get; set; }
        public decimal? Value2 { get; set; }
        public decimal? Value3 { get; set; }
        public decimal? Value4 { get; set; }
        public decimal? MeanValue { get; set; }
        public decimal? Uncertainty { get; set; }
        public decimal? BestFitLineY { get; set; }
        public decimal? NonLinearity { get; set; }
        public decimal? SEBError { get; set; }
        public decimal? Hysteresis { get; set; }
        public double ChangeFromPrevious { get; set; }
        public iRawData() { }
    }

    public class iRawDataDisplay
    {
        public string ForceApplied { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }
        public string Value4 { get; set; }
        public iRawDataDisplay() { }
    }

    public class RawDataforCert2Runs
    {
        public List<iRawData2Runs> RawData { get; set; }
        public RawDataforCert2Runs()
        {
            RawData = new List<iRawData2Runs>();
        }
    }

    public class iRawData2Runs
    {
        public decimal? ForceApplied { get; set; }
        public decimal? Value1 { get; set; }
        public decimal? Value2 { get; set; }
        public iRawData2Runs() { }
    }

    public class SingleRun
    {
        public List<SingleRunPoint> NormalizedData { get; set; }
        public decimal StandardDeviation { get; set; }
        public decimal Resolution { get; set; }
        public decimal MaxHysteresis { get; set; }
        public decimal MaxNonLinearity { get; set; }
        public decimal MaxNonRepeatability { get; set; }

        /// <summary>
        /// This run's largest deviation from the Static Error Band. Is already stored as a percentage (don't need to multiply by 100).
        /// </summary>
        public decimal SEBPercentage { get; set; }

        /// <summary>
        /// This run's Static Error Band slope. Is rounded to the readability of the instrument for some dumb reason.
        /// </summary>
        public decimal SEBOutput { get; set; }

        public decimal BeginningZero { get; set; }
        public decimal EndingZero { get; set; }

        public SingleRun()
        {
            NormalizedData = new List<SingleRunPoint>();
        }
    }

    public class SingleRunPoint
    {
        public decimal ForceApplied { get; set; }
        public decimal Value { get; set; }
        public decimal Value2 { get; set; }
        public decimal Value3 { get; set; }
        public decimal PreNormValue { get; set; }
        public decimal Temperature { get; set; }
        public decimal Error1 { get; set; }
        public decimal Error2 { get; set; }
        public decimal Error3 { get; set; }
        public double MaxError { get; set; }
        public decimal NonLinearity { get; set; }
        public decimal Hysterisis { get; set; }

        /// <summary>
        /// This point's deviation from the Static Error Band. Is already stored as a percentage (don't need to multiply by 100).
        /// </summary>
        public decimal SEBError { get; set; }

        public decimal Resolution { get; set; }
        public decimal Median { get; set; }
        public Direction PointDirection { get; set; }
        public Standard Standard { get; set; }
        public List<UncertaintyObject> Uncertainties { get; set; }
        public decimal ExpandedUncertainty { get; set; }
        public decimal TUR { get; set; }
        public double PFA { get; set; }
    }

    public class UncertaintyObject
    {
        public UncertaintyType Type { get; set; }
        public UncertaintyContributor Mode { get; set; }

        public UncertaintyType UncertaintyType { get; set; }

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

    

    
