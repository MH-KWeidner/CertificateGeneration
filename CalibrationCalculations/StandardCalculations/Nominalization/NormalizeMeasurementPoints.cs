using CalibrationCalculations.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalibrationCalculations.StandardCalculations.Nominalization
{
    /// <summary>
    /// Defines the <see cref="NormalizeMeasurementPoints" />
    /// </summary>
    public static class NormalizeMeasurementPoints
    {
        /// <summary>
        /// The Nominalize
        /// </summary>
        /// <param name="series">The series<see cref="MeasurementSeries"/></param>
        public static void Nominalize(MeasurementSeries series)
        {
            foreach (ActualMeasurementPoint amp in series.GetEnumerable().OfType<ActualMeasurementPoint>())
            {
                // verify if this is correct to do
                if (amp.ActualAppliedForce == 0)
                    continue;

                double nominalAdjustedValue = amp.AppliedForce * amp.Value / amp.ActualAppliedForce;

                // verify if this is correct to do
                amp.Value = nominalAdjustedValue;
            }
        }
    }
}
