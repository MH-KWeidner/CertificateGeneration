using CalibrationCalculations.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalibrationCalculations.Common.Exceptions
{
    public static class ExceptionMessages
    {
        public const string NULL_MEASUREMENT_POINT_LIST = "The IMeasurementPoint list cannot be null.";

        public const string FIRST_NOMINAL_FORCE_VALUE_NOT_ZERO = "The first nominal force value must be zero (0.0).";

        public const string MINIMUM_ARRAY_STACKING_IS_ONE = "The minimum number of times to stack an array is one (1).";

        public const string IMEASUREMENT_POINT_LIST_CANNOT_BE_NULL = "The IMeasurementPoint list cannot be null.";

        public const string IMEASUREMENT_POINT_LIST_CANNOT_CONTAIN_NULL_ORDER_TAGS = "The IMeasurementPoint list cannot contain null OrderTags.";
    }
}
