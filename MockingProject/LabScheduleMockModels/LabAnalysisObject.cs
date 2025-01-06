namespace CalibrationCalculationsCertificateTests.LabScheduleMockModels
{
    public class LabAnalysisObject
    {
        public long TaskID { get; set; }
        public short DecimalPlaces { get; set; }
        public string Method { get; set; }
        public string InstrumentType { get; set; }
        public decimal InstrumentCapacity { get; set; }
        public string DataDirection { get; set; }
        public decimal MaxForceApplied { get; set; }
        public decimal Readability { get; set; }
        public IList<decimal> NonRepeatabilityList { get; set; }
        public string CompressionTensionType { get; set; }
        public string UnitsOfForce { get; set; }
        public bool IsDirectRead { get; set; }
        public string ReportNumber { get; set; }
        public string AssignedAccuracyStr { get; set; }
        public bool addMeanColumn { get; set; }
        public bool TempCorrect { get; set; }
        public UnitsReadOnInstrument ReadOnInstrument { get; set; }
        public IList<SecondaryStandard> SecondaryStandardList { get; set; }
        public IList<Indicator> Indicators { get; set; }
        public IList<LabData> Data { get; set; }
        public AsReceivedAsReturned AsReceivedAsReturned { get; set; }
        public decimal NormalizedTemperature { get; set; }
        public long InstrumentItemID { get; set; }
        public bool IsMultiBridge { get; set; }
        public decimal Capacity { get; set; }
        public string SerialNumber { get; set; }
        public int InstrumentReadingPrecision { get; set; }
        public int ExpandedUncertaintyPrecision { get; set; }
    }

    public class LabData
    {
        private IList<LabdataRun> _labDataRunList;
        public IList<LabdataRun> LabdataRunList
        {
            get
            {
                _labDataRunList ??= new List<LabdataRun>();
                return _labDataRunList;
            }
            set { if (_labDataRunList != value) _labDataRunList = value; }
        }
        public string BridgeName { get; set; }
    }

    public class LabdataRun
    {
        public int RunNumber { get; set; }
        public IList<LabdataStandard> LabdataStandardList { get; set; }
    }

    public class LabdataStandard
    {
        public int PrimaryStandardId { get; set; }
        public int NumExclusions { get; set; }
        public List<int> ExclusionIndex { get; set; }
        public IList<LabdataStandardResponse> LabdataStandardResponseList { get; set; }
    }

    public class LabdataStandardResponse
    {
        public Direction StandardDirection { get; set; }
        public int NumExclusions { get; set; }
        public List<int> ExclusionIndex { get; set; }
        public IList<LabdataResponse> LabdataResponseList { get; set; }
    }

    public class LabdataResponse
    {
        public decimal ForceApplied { get; set; }
        public decimal Value { get; set; }
        public decimal NormalizedValue { get; set; }
        public decimal Temperature { get; set; }
    }
}
