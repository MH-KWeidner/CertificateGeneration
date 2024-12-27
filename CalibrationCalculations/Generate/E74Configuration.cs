using CalibrationCalculations.Common;

namespace CalibrationCalculations.Generate
{
    /// <summary>
    /// Defines the <see cref="E74Configuration" />
    /// </summary>
    public class E74Configuration
    {
        /// <summary>
        /// Defines the transientForceMeasurementsByIndex
        /// </summary>
        
        // TODO need to test for null array
        public int[] TransientForceMeasurementsByIndex { get; set; }

        /// <summary>
        /// Gets or sets the InterpolationType
        /// </summary>
        public InterpolationTypes InterpolationType { get; set; }

        /// <summary>
        /// Gets or sets the TemperatureUnits
        /// </summary>
        public TemperatureUnits TemperatureUnits { get; set; }

        /// <summary>
        /// Gets or sets the AmbientTemperature
        /// </summary>
        public double AmbientTemperature { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether ApplyTemperatureCorrection
        /// </summary>
        public bool ApplyTemperatureCorrection { get; set; }

        /// <summary>
        /// Gets or sets the StandardTemperatureOfCalibration
        /// </summary>
        public double StandardTemperatureOfCalibration { get; set; }

        /// <summary>
        /// Gets or sets the TemperatureCorrectionValuePer1Degree
        /// </summary>
        public double TemperatureCorrectionValuePer1Degree { get; set; }

        /// <summary>
        /// Gets or sets the SelectedDegreeOfFit
        /// </summary>
        public DegreeOfFitTypes SelectedDegreeOfFit { get; set; }

        // TODO remove if not needed
        /// <summary>
        /// Gets or sets the InstrumentClassification
        /// </summary>
        public InstrumentClassifications InstrumentClassification { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to NominalizeActualForcesMeasured
        /// </summary>
        public bool NominalizeActualForcesMeasured { get; set; }

        public MeasurementSeriesReorderTypes PostInterpolationReorderType { get; set; }
    }
}
