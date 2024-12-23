using CalibrationCalculations.IoC.DataTransforms;
using CalibrationCalculations.IoC.ModifySeriesSize;
using CalibrationCalculations.IoC.ReorderSeries;
using CalibrationCalculations.StandardCalculations.DegreeOfBestFit;
using CalibrationCalculations.StandardCalculations.Interpolation;
using CalibrationCalculations.StandardCalculations.TemperatureCorrection;
using CalibrationCalculations.StandardCalculations.Nominalization;

namespace CalibrationCalculations.Models
{
    /// <summary>
    /// Defines the <see cref="MeasurementApplication" />
    /// </summary>
    public class MeasurementApplication
    {
        /// <summary>
        /// Defines the seriesList
        /// </summary>
        private List<MeasurementSeries> seriesList;

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementApplication"/> class.
        /// </summary>
        /// <param name="appliedForce">The appliedForce<see cref="double[]"/></param>
        /// <param name="rawData">The rawData<see cref="double[][]"/></param>
        public MeasurementApplication(double[] appliedForce, params double[][] rawData)
        {
            //TODO add error handling

            seriesList = [];

            seriesList.AddRange(rawData.Select((data, index) => MeasurementSeries.Create(index + 1, appliedForce, data)));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementApplication"/> class.
        /// </summary>
        /// <param name="appliedForce">The appliedForce<see cref="double[]"/></param>
        /// <param name="actualForce">The actualForce<see cref="double[][]"/></param>
        /// <param name="rawData">The rawData<see cref="double[][]"/></param>
        public MeasurementApplication(double[] appliedForce, double[][] actualForce, double[][] rawData)
        {
            //TODO add error handling

            seriesList = [];

            seriesList.AddRange(rawData.Select((data, index) => MeasurementSeries.Create(index + 1, appliedForce, data)));
        }

        /// <summary>
        /// The InterpolateSeriesData
        /// </summary>
        /// <param name="interpolator">The interpolator<see cref="IInterpolate"/></param>
        public void InterpolateSeriesData(IInterpolate interpolator)
        {
            //TODO add error handling

            if (interpolator == null)
                return;

            seriesList?.ForEach(series => MeasurementSeries.Interpolate(interpolator, series));
        }

        /// <summary>
        /// The ModifySeriesSize
        /// </summary>
        /// <param name="modifier">The correction<see cref="IModifySeriesSize"/></param>
        public void ModifySeriesSize(IModifySeriesSize modifier)
        {
            //TODO add error handling

            if (modifier == null)
                return;

            seriesList?.ForEach(series => series.Modify(modifier));
        }

        /// <summary>
        /// The ReorderSeriesData
        /// </summary>
        /// <param name="modifier">The correction<see cref="IReorderSeries"/></param>
        public void ReorderSeriesData(IReorderSeries modifier)
        {
            //TODO add error handling

            if (modifier == null)
                return;

            seriesList?.ForEach(series => series.ReorderSeries(modifier));
        }

        /// <summary>
        /// The RemoveValuesByIndex
        /// </summary>
        /// <param name="indexes">The indexes<see cref="IList{int}"/></param>
        public void RemoveValuesByIndex(IList<int> indexes)
        {
            //TODO add error handling

            if (indexes == null)
                return;

            seriesList?.ForEach(series => series.RemoveValuesByIndex(indexes));
        }

        /// <summary>
        /// The Transform
        /// </summary>
        /// <param name="transform">The transform<see cref="ITransformToDoubleArray"/></param>
        /// <param name="seriesIndex">The seriesIndex<see cref="int"/></param>
        /// <returns>The <see cref="double[]"/></returns>
        public double[] Transform(ITransformToDoubleArray transform, int seriesIndex)
        {
            return seriesList[seriesIndex].Transform(transform);
        }

        /// <summary>
        /// The Transform
        /// </summary>
        /// <param name="transform">The transform<see cref="ITransformToDoubleArray"/></param>
        /// <returns>The <see cref="double[][]"/></returns>
        public double[][] Transform(ITransformToDoubleArray transform)
        {
            //TODO add null check and error handling

            return seriesList.Select(series => series.Transform(transform)).ToArray();
        }

        /// <summary>
        /// The GetDegreeOfBestFittingPolynomial
        /// </summary>
        /// <param name="appliedForce">The appliedForce<see cref="double[]"/></param>
        /// <param name="rawData">The rawData<see cref="double[][]"/></param>
        /// <returns>The <see cref="int"/></returns>
        public int GetDegreeOfBestFittingPolynomial(double[] appliedForce, params double[][] rawData)
        {
            // TODO add error handling

            return DetermineDegreeOfBestFittingPolynomial.Calculate(appliedForce, rawData);
        }

        /// <summary>
        /// The ApplyTemperatureCorrection
        /// </summary>
        /// <param name="ambientTemperature">The ambientTemperature<see cref="double"/></param>
        /// <param name="standardCalibrationTemperature">The standardCalibrationTemperature<see cref="double"/></param>
        /// <param name="temperatureCorrectionValuePer1Degree">The temperatureCorrectionValuePer1Degree<see cref="double"/></param>
        public void ApplyTemperatureCorrection(double ambientTemperature, double standardCalibrationTemperature, double temperatureCorrectionValuePer1Degree)
        {
            //TODO add error handling

            double correctionValue = CalculateTemperatureCorrection.Calculate(ambientTemperature, standardCalibrationTemperature, temperatureCorrectionValuePer1Degree);

            seriesList.ForEach(series => series.IncreaseValuesByAdd(correctionValue));
        }

        public void ApplyNominalForceCorrection()
        {
            //TODO add error handling

            seriesList.ForEach(series => NormalizeMeasurementPoints.Nominalize(series));
        }
    }
}
