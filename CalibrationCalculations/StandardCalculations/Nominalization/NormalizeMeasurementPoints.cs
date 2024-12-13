using System;
using System.Collections.Generic;
using System.Text;
using CalibrationCalculations.Models;

namespace CalibrationCalculations.StandardCalculations.Nominalization
{
    public static class NormalizeMeasurementPoints
    {
        public static void Nominalize(MeasurementSeries series)
        {
            foreach (IMeasurementPoint mp in series.GetEnumerable())
            {
                if (mp is not ActualMeasurementPoint)
                    continue;

                ActualMeasurementPoint amp = (ActualMeasurementPoint)mp;

                // verify if this is correct to do
                if (amp.ActualAppliedForce == 0)
                    continue;

                double nominalValue = amp.AppliedForce * amp.Value / amp.ActualAppliedForce;


                // verify if this is correct to do
                amp.Value = nominalValue;
            }
        }
    }
}
