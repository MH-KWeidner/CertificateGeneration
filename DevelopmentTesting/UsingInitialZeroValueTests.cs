using DevelopmentTesting.InitialZeroDataSets;
using Interpolation;
using Models;
using Models.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DevelopmentTesting
{
    [TestClass]
    public class UsingInitialZeroValueTests
    {
        [TestMethod]
        public void interpolateSeries_ValidInput_ReturnsExpectedInterpolatedValues()
        {
            // Arrange
            double[] appliedForce = TestData1.GetAppliedForce();
            var seriesList = new List<Series>
            {
                Series.CreateSeries(1, appliedForce, TestData1.GetRawDataSeries1()),
                Series.CreateSeries(2, appliedForce, TestData1.GetRawDataSeries2()),
                Series.CreateSeries(3, appliedForce, TestData1.GetRawDataSeries3()),
            };

            // Act
            UsingInitialZeroValue.InterpolateSeries(seriesList);
            
            IModifySeries zeroReduction = new ZeroReduction();
            seriesList[0].Modify(zeroReduction);
            seriesList[1].Modify(zeroReduction);
            seriesList[2].Modify(zeroReduction);

            //seriesList[0].ZeroReduceAndSortByAppliedForceAscending();
            //seriesList[1].ZeroReduceAndSortByAppliedForceAscending();
            //seriesList[2].ZeroReduceAndSortByAppliedForceAscending();

            // Assert
            Assert.AreEqual(-0.08193, seriesList[0].GetValue(1));
            Assert.AreEqual(-0.40851, seriesList[0].GetValue(2));
        }
    }
}
