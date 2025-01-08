using CalibrationCalculationsCertificateTests.LabScheduleResultModels;

namespace CalibrationCalculationsCertificateTests.LabScheduleTestData;

public interface ILabScheduleRunResultsList
{
    List<LabAnalysisSingleRunResult> LabScheduleRunResults { get; }
}