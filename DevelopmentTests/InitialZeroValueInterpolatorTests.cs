using DevelopmentTests.InitialZeroDataSets;
using CertificateGeneration.Models;
using CertificateGeneration.Models.Modifiers;
using CertificateGeneration.Interpolation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentTests
{
    [Ignore]
    [TestClass]
    public class InitialZeroValueInterpolatorTests
    {
        [TestMethod]
        public void interpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues()
        {
            // Arrange
            double[] appliedForce = MethodAInitialZeroTestData1.GetAppliedForce();
            Series series = Series.CreateSeries(1, appliedForce, MethodAInitialZeroTestData1.GetRawDataSeries1());

            // Act
            InitialZeroValueInterpolator interoplater = new InitialZeroValueInterpolator();
            interoplater.Interpolate(series);
            
            IModifySeriesSize removeZeroValueForceItems = new RemoveZeroValueForceItems();
            series.Modify(removeZeroValueForceItems);

            IOrderSeries orderByAppliedForceAscending = new OrderByAppliedForceAscending();
            series.Order(orderByAppliedForceAscending);

            // Assert
            Assert.AreEqual(-0.08193, series.GetValue(1));
            Assert.AreEqual(-0.40851, series.GetValue(2));
        }
    }
}
