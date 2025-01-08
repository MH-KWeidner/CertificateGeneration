namespace CalibrationCalculationsCertificateTests.LabScheduleResultModels;

public class Indicator
{
    public long IndicatorID { get; set; }
    public string IndicatorSerialNumber { get; set; }
    public string IndicatorManufacturer { get; set; }
    public long CustomerID { get; set; }
    public string CustomerRefNo { get; set; }
    public string AssetNo { get; set; }
    public string InstrumentNo { get; set; }
    public string IndicatorModelNo { get; set; }
    public bool HasChanges { get; set; }
    public ObjStatus ObjectStatus { get; set; }
}
