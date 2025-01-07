namespace CalibrationCalculationsCertificateTests.LabScheduleModels
{
    public class AssignedAccuracy
    {
        public long AssignedAccuracyID { get; set; }
        public string DeviationCriteria { get; set; }
        public string Type { get; set; }
        public decimal? Accuracy { get; set; }
        public decimal? From { get; set; }
        public decimal? To { get; set; }
        public long InstrumentID { get; set; }
        public double? FixedValue { get; set; }
        public double? Count { get; set; }
        public bool HasChanges { get; set; }
        public ObjStatus ObjectStatus { get; set; }
    }
}
