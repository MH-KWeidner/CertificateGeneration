using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationCalculationsCertificateTests.LabScheduleMockModels
{
    public class SecondaryStandard
    {
        public long SecondaryStandardID { get; set; }
        public Nullable<long> LabTaskID { get; set; }
        public Nullable<long> StandardID { get; set; }
        public string BridgeType { get; set; }

        public virtual Standard Standard { get; set; }
        
        public bool HasChanges { get; set; }
        public ObjStatus ObjectStatus { get; set; }
    }
}
