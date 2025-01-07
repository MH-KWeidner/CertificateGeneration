namespace CalibrationCalculations.Common.Exceptions;

/// <summary>
/// Defines the <see cref="ExceptionMessages" />
/// </summary>
public static class ExceptionMessages
{
    /// <summary>
    /// Defines the NULL_MEASUREMENT_POINT_LIST
    /// </summary>
    public const string NULL_MEASUREMENT_POINT_LIST = "The IMeasurementPoint list cannot be null.";

    /// <summary>
    /// Defines the FIRST_NOMINAL_FORCE_VALUE_NOT_ZERO
    /// </summary>
    public const string FIRST_NOMINAL_FORCE_VALUE_NOT_ZERO = "The first nominal force value must be zero (0.0).";

    /// <summary>
    /// Defines the MINIMUM_ARRAY_STACKING_IS_ONE
    /// </summary>
    public const string MINIMUM_ARRAY_STACKING_IS_ONE = "The minimum number of times to stack an array is one (1).";

    /// <summary>
    /// Defines the IMEASUREMENT_POINT_LIST_CANNOT_BE_NULL
    /// </summary>
    public const string IMEASUREMENT_POINT_LIST_CANNOT_BE_NULL = "The IMeasurementPoint list cannot be null.";

    /// <summary>
    /// Defines the IMEASUREMENT_POINT_LIST_CANNOT_CONTAIN_NULL_ORDER_TAGS
    /// </summary>
    public const string IMEASUREMENT_POINT_LIST_CANNOT_CONTAIN_NULL_ORDER_TAGS = "The IMeasurementPoint list cannot contain null OrderTags.";

    /// <summary>
    /// Defines the ARGUMENT_EXCEPTION_INVALID_TYPE
    /// </summary>
    public const string ARGUMENT_EXCEPTION_INVALID_TYPE = "Invalid type";
}
