using CertificateGeneration.Models;
using CertificateGeneration.IoC.Modifiers;
using DevelopmentTests.NISTDataSets;
using CertificateGeneration.CertificateCalculations.Interpolation;

namespace DevelopmentTests
{
    /// <summary>
    /// Defines the <see cref="NistInterpolatorTestWithDataset1" />
    /// </summary>
    [TestClass]
    public class NistInterpolatorTestWithDataset1
    {
        /// <summary>
        /// The InterpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues
        /// </summary>
        [TestMethod]
        public void InterpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues()
        {
            // Arrange
            double[] appliedForce = MethodBNistTestData1.GetAppliedForce();
            Series series1 = Series.CreateSeries(1, appliedForce, MethodBNistTestData1.GetRawDataSeries1());
            Series series2 = Series.CreateSeries(2, appliedForce, MethodBNistTestData1.GetRawDataSeries2());
            Series series3 = Series.CreateSeries(3, appliedForce, MethodBNistTestData1.GetRawDataSeries3());

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
            Assert.AreEqual(-0.08157, Math.Round(series1.GetValue(0), 5));
            Assert.AreEqual(-0.40789, Math.Round(series1.GetValue(1), 5));
            Assert.AreEqual(-0.81585, Math.Round(series1.GetValue(2), 5));
            Assert.AreEqual(-1.22391, Math.Round(series1.GetValue(3), 5));
            Assert.AreEqual(-1.63204, Math.Round(series1.GetValue(4), 5));
            Assert.AreEqual(-2.04022, Math.Round(series1.GetValue(6), 5));
            Assert.AreEqual(-2.44847, Math.Round(series1.GetValue(7), 5));
            Assert.AreEqual(-2.85675, Math.Round(series1.GetValue(8), 5));
            Assert.AreEqual(-3.26505, Math.Round(series1.GetValue(9), 5));
            Assert.AreEqual(-3.67339, Math.Round(series1.GetValue(10), 5));
            Assert.AreEqual(-4.08166, Math.Round(series1.GetValue(11), 5));

            Assert.AreEqual(-0.08157, Math.Round(series2.GetValue(0), 5));
            Assert.AreEqual(-0.40791, Math.Round(series2.GetValue(1), 5));
            Assert.AreEqual(-0.81587, Math.Round(series2.GetValue(2), 5));
            Assert.AreEqual(-1.22394, Math.Round(series2.GetValue(3), 5));
            Assert.AreEqual(-1.63207, Math.Round(series2.GetValue(4), 5));
            Assert.AreEqual(-2.04027, Math.Round(series2.GetValue(6), 5));
            Assert.AreEqual(-2.44851, Math.Round(series2.GetValue(7), 5));
            Assert.AreEqual(-2.85680, Math.Round(series2.GetValue(8), 5));
            Assert.AreEqual(-3.26511, Math.Round(series2.GetValue(9), 5));
            Assert.AreEqual(-3.67344, Math.Round(series2.GetValue(10), 5));
            Assert.AreEqual(-4.08172, Math.Round(series2.GetValue(11), 5));

            Assert.AreEqual(-0.08157, Math.Round(series3.GetValue(0), 5));
            Assert.AreEqual(-0.40790, Math.Round(series3.GetValue(1), 5));
            Assert.AreEqual(-0.81588, Math.Round(series3.GetValue(2), 5));
            Assert.AreEqual(-1.22394, Math.Round(series3.GetValue(3), 5));
            Assert.AreEqual(-1.63207, Math.Round(series3.GetValue(4), 5));
            Assert.AreEqual(-2.04026, Math.Round(series3.GetValue(6), 5));
            Assert.AreEqual(-2.44851, Math.Round(series3.GetValue(7), 5));
            Assert.AreEqual(-2.85679, Math.Round(series3.GetValue(8), 5));
            Assert.AreEqual(-3.26511, Math.Round(series3.GetValue(9), 5));
            Assert.AreEqual(-3.67342, Math.Round(series3.GetValue(10), 5));
            Assert.AreEqual(-4.08168, Math.Round(series3.GetValue(11), 5));
        }
    }
}
