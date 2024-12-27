using CalibrationCalculations.Common;

namespace CalibrationCalculations.Factories.ModifyMeasurementSeriesSize
{
    public static class ModifyMeasurementSeriesSizeFactory
    {
        public static IModifyMeasurementSeriesSize Create(ModifyMeasurementSeriesSizeTypes modifyType) =>
        modifyType switch
        {
            ModifyMeasurementSeriesSizeTypes.RemoveZeroValuedNominalForces => new RemoveZeroValuedNominalForces(),
            _ => throw new NotImplementedException()
        };

    }
}
