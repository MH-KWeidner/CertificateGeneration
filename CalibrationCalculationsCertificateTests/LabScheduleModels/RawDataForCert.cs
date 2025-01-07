namespace CalibrationCalculationsCertificateTests.LabScheduleModels;

public class RawDataForCert
{
    public long? LabTaskID { get; set; }
    public string Description { get; set; }
    public decimal? ForceApplied { get; set; }
    public decimal? Result { get; set; }
    public decimal? TemperatureCorrectTo { get; set; }
    public string CompressionTension { get; set; }
    public int? Row { get; set; }
    public int? Bridge { get; set; }
    public string BridgeName { get; set; }
    public short? RunNumber { get; set; }
    public decimal? MaxUncertainty { get; set; }
    public bool HasChanges { get; set; }
    public ObjStatus ObjectStatus { get; set; }
}
