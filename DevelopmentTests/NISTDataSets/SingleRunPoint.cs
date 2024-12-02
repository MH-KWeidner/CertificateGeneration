using MathNet.Numerics.RootFinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentTests.NISTDataSets
{
    public enum Direction
    {
        Ascending,
        Descending,
        AscendingDesending
    }

    public class SingleRunPoint
    {
        public decimal ForceApplied { get; set; }
        public decimal Value { get; set; }
        public decimal Value2 { get; set; }
        public decimal Value3 { get; set; }
        public decimal PreNormValue { get; set; }
        public Standard Standard { get; set; }
        public decimal Temperature { get; set; }
        public decimal Error1 { get; set; }
        public decimal Error2 { get; set; }
        public decimal Error3 { get; set; }
        public double MaxError { get; set; }
        public decimal NonLinearity { get; set; }
        public decimal Hysterisis { get; set; }
        public decimal SEBError { get; set; }
        public decimal Resolution { get; set; }
        public decimal Median { get; set; }
        public Direction PointDirection { get; set; }
        public List<UncertaintyObject> Uncertainties { get; set; }
        public decimal ExpandedUncertainty { get; set; }
        public decimal TUR { get; set; }
        public double PFA { get; set; }
    }
}
