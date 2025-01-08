using CalibrationCalculationsCertificateTests.LabScheduleModels;

namespace CalibrationCalculationsCertificateTests.LabScheduleTestData;

public interface ILabScheduleRunResultsList
{
    List<LabAnalysisSingleRunResult> LabScheduleRunResults { get; }
}