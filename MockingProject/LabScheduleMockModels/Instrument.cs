using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationCalculationsCertificateTests.LabScheduleMockModels
{
    public class Instrument
    {
        public long InstrumentID { get; set; }
        public string SerialNumber { get; set; }
        public string ModelNumber { get; set; }
        public decimal? Capacity { get; set; }
        public string TypeOther { get; set; }
        public long? CustomerID { get; set; }
        public long? InstrumentTypeID { get; set; }
        public long? InstrumentClassID { get; set; }
        public long? CapacityMetricID { get; set; }
        public long? ManufacturerID { get; set; }
        public string CustomerRefNo { get; set; }
        public string AssetNo { get; set; }
        public string InstrumentNo { get; set; }
        public string CustomerRefNoLbl { get; set; }
        public string AssetNoLbl { get; set; }
        public string InstrumentNoLbl { get; set; }
        public string LoadCellConfiguration { get; set; }
        public bool HasChanges { get; set; }
        public ObjStatus ObjectStatus { get; set; }
    }
}
