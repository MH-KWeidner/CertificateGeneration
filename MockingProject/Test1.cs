using CalibrationCalculationsCertificateTests.LabScheduleMockModels;

namespace CalibrationCalculationsCertificateTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TestData1 test1 = new ();
            var data = test1.Get();
        }
    }
}
