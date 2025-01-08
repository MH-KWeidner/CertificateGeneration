namespace CalibrationCalculationsCertificateTests.LabScheduleResultModels
{
    public class Standard
    {
        public long StandardID { get; set; }
        public string Description { get; set; }
        public string SerialNumber { get; set; }
        public decimal? MaxCapacity { get; set; }
        public string Nist { get; set; }
        public long? StandardTypeID { get; set; }
        public string ModelNumber { get; set; }
        public decimal? MaxUncertainty { get; set; }
        public string CertDescription { get; set; }
        public DateTime? DateCalibrated { get; set; }
        public DateTime? CalibrationDueDate { get; set; }
        public decimal? Slope { get; set; }
        public decimal? Intercept { get; set; }
        public bool HasChanges { get; set; }
        public ObjStatus ObjectStatus { get; set; }
    }
}
