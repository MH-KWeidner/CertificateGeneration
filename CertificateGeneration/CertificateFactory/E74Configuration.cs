using CertificateGeneration.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateGeneration.CertificateFactory
{
    public class E74Configuration
    {
        public InterpolationTypes InterpolationType { get; set; }

        public TemperatureUnits TemperatureUnits { get; set; }
        
        public double TemperatureWhenMeasured{ get; set; }

        // Items in dataExclusionsByIndex are removed from the applied force array and series data
        //Occurs after interpolation,but before zero rduction and sorting by applied force.
        /// <summary>
        /// By index, items are removed from the applied force data and series data.
        /// </summary>
        /// <remarks> 
        /// Remove items after interpolation, but before zero reduction and sorting by applied force.
        /// </remarks>
        public IList<int> DataExclusionsByIndex { get; set; }
    }
}
