using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateGeneration.Common
{
    public enum InterpolationTypes
    {
        MethodA, // Initial Zero Value
        MethodB // NIST Interpolation
    }

    public enum DegreeOfFitTypes
    {
        One,
        Two,
        Three,
        Four,
        Five,
        DegreeOfBestFit
    }

    // TODO better naming for this enum
    public enum TemperatureUnits
    {
        Celsius,
        Fahrenheit
    }
    
    public enum InstrumentClassifications
    {   
        A,
        AA
    }

}
