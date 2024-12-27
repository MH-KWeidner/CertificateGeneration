namespace CalibrationCalculations.Common.Exceptions
{
    public class InvalidMeasurementPointException : Exception
    {
        public InvalidMeasurementPointException()
        {
        }

        public InvalidMeasurementPointException(string message)
            : base(message)
        {
        }

        public InvalidMeasurementPointException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public InvalidMeasurementPointException(string message, string additionalInfo)
            : base($"{message} Additional Info: {additionalInfo}")
        {
        }
    }
}

