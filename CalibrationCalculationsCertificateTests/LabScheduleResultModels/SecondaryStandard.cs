namespace CalibrationCalculationsCertificateTests.LabScheduleResultModels;

public class SecondaryStandard
{
    public long SecondaryStandardID { get; set; }
    public long? LabTaskID { get; set; }
    public long? StandardID { get; set; }
    public string BridgeType { get; set; }

    public virtual Standard Standard { get; set; }

    public bool HasChanges { get; set; }
    public ObjStatus ObjectStatus { get; set; }
}
