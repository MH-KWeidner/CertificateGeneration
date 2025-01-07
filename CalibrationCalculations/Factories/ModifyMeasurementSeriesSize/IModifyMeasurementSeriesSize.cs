using CalibrationCalculations.Models;

namespace CalibrationCalculations.Factories.ModifyMeasurementSeriesSize;

/// <summary>
/// Classes that implement this interface will modify the size of a list of SeriesValues
/// </summary>
public interface IModifyMeasurementSeriesSize
{
    /// <summary>
    /// SeriesValues
    /// </summary>
    /// <param name="measurementPoints"></param>
    /// <returns>Returns a new list of SeriesValues</returns>
    public List<IMeasurementPoint>? Modify(List<IMeasurementPoint>? measurementPoints);
}
