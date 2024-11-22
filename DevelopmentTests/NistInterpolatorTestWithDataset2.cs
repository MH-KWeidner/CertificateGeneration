using CertificateGeneration.Interpolation;
using CertificateGeneration.Models;
using CertificateGeneration.Models.Modifiers;
using DevelopmentTests.NISTDataSets;

namespace DevelopmentTests
{
    /// <summary>
    /// Defines the <see cref="NistInterpolatorTestWithDataset2" />
    /// </summary>
    [TestClass]
    public class NistInterpolatorTestWithDataset2
    {
        /// <summary>
        /// The InterpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues
        /// </summary>
        [TestMethod]
        public void InterpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues()
        {
            // Arrange
            double[] appliedForce = MethodBNistTestData2.GetAppliedForce();
            Series series1 = Series.CreateSeries(1, appliedForce, MethodBNistTestData2.GetRawDataSeries1());
            Series series2 = Series.CreateSeries(2, appliedForce, MethodBNistTestData2.GetRawDataSeries2());
            Series series3 = Series.CreateSeries(3, appliedForce, MethodBNistTestData2.GetRawDataSeries3());

            // Act
            series1.Interpolate(new NistInterpolator());
            series2.Interpolate(new NistInterpolator());
            series3.Interpolate(new NistInterpolator());

            series1.Modify(new RemoveZeroValueForceItems());
            series2.Modify(new RemoveZeroValueForceItems());
            series3.Modify(new RemoveZeroValueForceItems());

            series1.Order(new OrderByAppliedForceAscending());
            series2.Order(new OrderByAppliedForceAscending());
            series3.Order(new OrderByAppliedForceAscending());

            // Assert
            Assert.AreEqual(-0.08158, Math.Round(series1.GetValue(0), 5));
            Assert.AreEqual(-0.40821, Math.Round(series1.GetValue(1), 5));
            Assert.AreEqual(-0.81663, Math.Round(series1.GetValue(2), 5));
            Assert.AreEqual(-1.22513, Math.Round(series1.GetValue(3), 5));
            Assert.AreEqual(-1.63370, Math.Round(series1.GetValue(4), 5));
            Assert.AreEqual(-2.04234, Math.Round(series1.GetValue(6), 5));
            Assert.AreEqual(-2.45106, Math.Round(series1.GetValue(7), 5));
            Assert.AreEqual(-2.85984, Math.Round(series1.GetValue(8), 5));
            Assert.AreEqual(-3.26867, Math.Round(series1.GetValue(9), 5));
            Assert.AreEqual(-3.67757, Math.Round(series1.GetValue(10), 5));
            Assert.AreEqual(-4.08651, Math.Round(series1.GetValue(11), 5));

            Assert.AreEqual(-0.08163, Math.Round(series2.GetValue(0), 5));
            Assert.AreEqual(-0.40833, Math.Round(series2.GetValue(1), 5));
            Assert.AreEqual(-0.81676, Math.Round(series2.GetValue(2), 5));
            Assert.AreEqual(-1.22526, Math.Round(series2.GetValue(3), 5));
            Assert.AreEqual(-1.63383, Math.Round(series2.GetValue(4), 5));
            Assert.AreEqual(-2.04248, Math.Round(series2.GetValue(6), 5));
            Assert.AreEqual(-2.45120, Math.Round(series2.GetValue(7), 5));
            Assert.AreEqual(-2.85999, Math.Round(series2.GetValue(8), 5));
            Assert.AreEqual(-3.26882, Math.Round(series2.GetValue(9), 5));
            Assert.AreEqual(-3.67773, Math.Round(series2.GetValue(10), 5));
            Assert.AreEqual(-4.08668, Math.Round(series2.GetValue(11), 5));

            Assert.AreEqual(-0.08163, Math.Round(series3.GetValue(0), 5));
            Assert.AreEqual(-0.40832, Math.Round(series3.GetValue(1), 5));
            Assert.AreEqual(-0.81675, Math.Round(series3.GetValue(2), 5));
            Assert.AreEqual(-1.22525, Math.Round(series3.GetValue(3), 5));
            Assert.AreEqual(-1.63383, Math.Round(series3.GetValue(4), 5));
            Assert.AreEqual(-2.04249, Math.Round(series3.GetValue(6), 5));
            Assert.AreEqual(-2.45120, Math.Round(series3.GetValue(7), 5));
            Assert.AreEqual(-2.85999, Math.Round(series3.GetValue(8), 5));
            Assert.AreEqual(-3.26883, Math.Round(series3.GetValue(9), 5));
            Assert.AreEqual(-3.67772, Math.Round(series3.GetValue(10), 5));
            Assert.AreEqual(-4.08666, Math.Round(series3.GetValue(11), 5));
        }
    }
}
