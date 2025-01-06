using CalibrationCalculationsCertificateTests.LabscheduleMockModels;

namespace CalibrationCalculationsCertificateTests.LabScheduleMockModels
{
    public interface IMockLabScheduleData
    {
        public List<LabAnalysisSingleRunResult> Get();
    }
}
