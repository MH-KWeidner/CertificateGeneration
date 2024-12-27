namespace CalibrationCalculations.Common
{
    /// <summary>
    /// Defines the InterpolationTypes
    /// </summary>
    public enum InterpolationTypes
    {
        /// <summary>
        /// Defines the MethodA
        /// </summary>
        MethodA = 0, // Initial Zero Value

        /// <summary>
        /// Defines the MethodB
        /// </summary>
        MethodB = 1 // NIST Interpolation    }
    }

    /// <summary>
    /// Defines the DegreeOfFitTypes
    /// </summary>
    public enum DegreeOfFitTypes
    {
        // <summary>
        /// Defines the UseCalculatedDegreeOfBestFit
        /// </summary>

        /// <summary>
        /// Defines the UseCalculatedDegreeOfBestFit
        /// </summary>
        UseCalculatedDegreeOfBestFit = 0,

        /// <summary>
        /// Defines the One
        /// </summary>
        One = 1,

        /// <summary>
        /// Defines the Two
        /// </summary>
        Two = 2,

        /// <summary>
        /// Defines the Three
        /// </summary>
        Three = 3,

        /// <summary>
        /// Defines the Four
        /// </summary>
        Four = 4,

        /// <summary>
        /// Defines the Five
        /// </summary>
        Five = 5
    }

    /// <summary>
    /// Defines the TemperatureUnits
    /// </summary>
    public enum TemperatureUnits
    {
        /// <summary>
        /// Defines the Celsius
        /// </summary>
        Celsius = 0,

        /// <summary>
        /// Defines the Fahrenheit
        /// </summary>
        Fahrenheit = 1
    }

    /// <summary>
    /// Defines the MeasurementSeriesReorderTypes
    /// </summary>
    public enum MeasurementSeriesReorderTypes
    {
        /// <summary>
        /// Defines the DoNotReorder
        /// </summary>
        DoNotReorder = 0,

        /// <summary>
        /// Defines the DetectedNominalForceOrdering
        /// </summary>
        DetectedNominalForceOrdering = 1,

        /// <summary>
        /// Defines the NominalForceAscending
        /// </summary>
        NominalForceAscending = 2,

        /// <summary>
        /// Defines the NominalForceDescending
        /// </summary>
        NominalForceDescending = 3,

        /// <summary>
        /// Defines the OrderTagAscending
        /// </summary>
        OrderTagAscending = 4,

        /// <summary>
        /// Defines the OrderTagDescending
        /// </summary>
        OrderTagDescending = 5
    }

    /// <summary>
    /// Defines the MeasurementPointsToArrayTransformTypes
    /// </summary>
    public enum MeasurementPointsToArrayTransformTypes
    {
        /// <summary>
        /// Defines the NominalAppliedForces
        /// </summary>
        NominalAppliedForces = 0,

        /// <summary>
        /// Defines the MeasurementValues
        /// </summary>
        MeasurementValues = 1,
    }

    /// <summary>
    /// Defines the ModifyMeasurementSeriesSizeTypes
    /// </summary>
    public enum ModifyMeasurementSeriesSizeTypes
    {
        /// <summary>
        /// Defines the RemoveZeroValuedNominalForces
        /// </summary>
        RemoveZeroValuedNominalForces = 0
    }
}
