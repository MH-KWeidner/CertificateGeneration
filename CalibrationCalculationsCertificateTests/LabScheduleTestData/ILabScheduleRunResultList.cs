using CalibrationCalculationsCertificateTests.LabScheduleResultModels;

namespace CalibrationCalculationsCertificateTests.LabScheduleTestData;

public interface ILabScheduleRunResultList
{
    List<LabAnalysisSingleRunResult> LabScheduleRunResults { get; }
}