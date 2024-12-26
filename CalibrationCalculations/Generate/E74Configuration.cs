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
        private readonly IList<int> transientForceMeasurementsByIndex = [];

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

        /// <summary>
        /// Gets or sets the DegreeOfBestFit
        /// </summary>
        public int DegreeOfBestFit { get; set; }

        /// <summary>
        /// Gets or sets the InstrumentClassification
        /// </summary>
        public InstrumentClassifications InstrumentClassification { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether ApplyNominalForceCorrection
        /// </summary>
        public bool ApplyNominalForceCorrection { get; set; }

        /// <summary>
        /// Gets the TransientForceMeasurementsByIndex
        /// </summary>
        public IList<int> TransientForceMeasurementsByIndex => transientForceMeasurementsByIndex;

        /// <summary>
        /// The AddTransientForceMeasurementsByIndex
        /// </summary>
        /// <param name="index">The index<see cref="int"/></param>
        public void AddTransientForceMeasurementsByIndex(int index) => transientForceMeasurementsByIndex.Add(index);

        public MeasurementSeriesReorderTypes InterpolatedReorderType { get; set; }

    }
}
