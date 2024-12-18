using System;
using System.Collections.Generic;
using System.Text;

namespace CalibrationCalculations.Exceptions
{
    public class ExceptionMessages
    {
        public const string NULL_MEASUREMENT_POINT_LIST = "The IMeasurementPoint list cannot be null.";
        public const string FIRST_NOMINAL_FORCE_VALUE_NOT_ZERO = "The first nominal force value must be zero (0.0).";
    }
}
