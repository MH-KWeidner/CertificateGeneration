using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalibrationCalculations.Common;

namespace CalibrationCalculations.CertificateCreation
{
    public class E74Configuration
    {
        private readonly IList<int> transientForceMeasurementsByIndex = [];

        private readonly IList<int> excludedSeriesByIndex = [];

        public InterpolationTypes InterpolationType { get; set; }

        public TemperatureUnits TemperatureUnits { get; set; }

        public double AmbientTemperature { get; set; }
        
        public bool ApplyTemperatureCorrection { get; set; }

        public double StandardTemperatureOfCalibration { get; set; }

        public double TemperatureCorrectionValuePer1Degree { get; set; }

        public DegreeOfFitTypes SelectedDegreeOfFit { get; set; }

        public int DegreeOfBestFit { get; set; }

        public InstrumentClassifications InstrumentClassification { get; set; }

        public bool ApplyNominalForceCorrection { get; set; }

        public IList<int> TransientForceMeasurementsByIndex => transientForceMeasurementsByIndex;

        public void AddTransientForceMeasurementsByIndex(int index) => transientForceMeasurementsByIndex.Add(index);

        public IList<int> ExcludedSeriesByIndex => excludedSeriesByIndex;

        public void AddExcludedSeriesByIndex(int index) => excludedSeriesByIndex.Add(index);


    }
}
