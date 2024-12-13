using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationCalculations.Common
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
        CalculatedDegreeOfBestFit
    }

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
