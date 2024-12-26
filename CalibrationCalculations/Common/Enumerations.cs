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
        MethodB = 1 // NIST Interpolation
    }

    /// <summary>
    /// Defines the DegreeOfFitTypes
    /// </summary>
    public enum DegreeOfFitTypes
    {
        // <summary>
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
    /// Defines the InstrumentClassifications
    /// </summary>
    public enum InstrumentClassifications
    {
        /// <summary>
        /// Defines the A
        /// </summary>
        A = 0,

        /// <summary>
        /// Defines the AA
        /// </summary>
        AA = 1
    }

    public enum MeasurementSeriesReorderTypes
    {
        DoNotReorder = 0,
        DetectedNominalForceOrdering = 1,
        NominalForceAscending = 2,
        NominalForceDescending = 3,
        OrderTagAscending = 4,
        OrderTagDescending = 5
    }

    public enum MeasurementPointsToDoubleArrayTransformTypes
    {
        NominalForceApplied = 0,
        AdjustedValue = 1,
    } 
}
