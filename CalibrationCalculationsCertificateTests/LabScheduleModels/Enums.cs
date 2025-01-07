namespace CalibrationCalculationsCertificateTests.LabScheduleModels
{
    public enum Direction
    {
        Ascending,
        Descending,
        AscendingDesending
    }

    public enum ObjStatus : short
    {
        Unchanged = 0,
        Modified = 1,
        New = 2,
        Deleted = 3
    };

    public enum AsReceivedAsReturned
    {
        AsReceived,
        AsReturned,
        AsReceivedAsReturned,
        None
    }

    public enum UncertaintyType
    {
        A,
        B
    }

    public enum UncertaintyContributor
    {
        NonLinearity,
        Hysterisis,
        Resolution,
        ReferenceStandard,
        SecondaryStandard,
        ElectricalStandard
    }


    public class Enums
    {
    }
}
