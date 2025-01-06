using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationCalculationsCertificateTests.LabScheduleMockModels
{
    public class UnitsReadOnInstrument
    {
        public long UnitsReadOnInstrumentID { get; set; }
        public string Description { get; set; }
        public bool HasChanges { get; set; }
        public ObjStatus ObjectStatus { get; set; }
    }
}
