using CertificateGeneration.CertificateCalculations.Interpolation;
using CertificateGeneration.IoC.Modifiers;
using CertificateGeneration.CertificateCalculations.DegreeOfBestFit;
using CertificateGeneration.IoC.DataTransforms;
using CertificateGeneration.CertificateCalculations.TemperatureCorrection;
using System.Runtime.CompilerServices;


namespace CertificateGeneration.Models
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
        /// The InterpolateSeriesData
        /// </summary>
        /// <param name="interpolator">The interpolator<see cref="IInterpolate"/></param>
        public void InterpolateSeriesData(IInterpolate interpolator)
        {
            //TODO add error handling

            if (interpolator == null)
                return;

            seriesList?.ForEach(series => series.Interpolate(interpolator));
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
 
        public void RemoveValuesByIndex(IList<int> indexes)
        {
            //TODO add error handling

            if (indexes == null)
                return;

            seriesList?.ForEach(series => series.RemoveValuesByIndex(indexes));
        }

        public void RemoveSeriesByIndex(IList<int> indexes)
        {
            // TODO consider that not including a series is incombant on the client application
            
            //TODO add error handling

            if (indexes == null)
                return;

            seriesList = seriesList.Where((series, index) => !indexes.Contains(index)).ToList();
        }

        public double[] Transform(ITransformToDoubleArray transform, int seriesIndex)
        {
            return seriesList[seriesIndex].Transform(transform);
        }

        public double[][] Transform(ITransformToDoubleArray transform)
        {
            //TODO add null check and error handling

            return seriesList.Select(series => series.Transform(transform)).ToArray();
        }

        public int GetDegreeOfBestFittingPolynomial(double[] appliedForce, params double[][] rawData)
        {
            // TODO add error handling

            return DetermineDegreeOfBestFittingPolynomial.Calculate(appliedForce, rawData);
        }
    
        public void ApplyTemperatureCorrection(double ambientTemperature, double standardCalibrationTemperature, double temperatureCorrectionValuePer1Degree)
        {
            //TODO add error handling

            double correctionValue = CalculateTemperatureCorrection.Calculate(ambientTemperature, standardCalibrationTemperature, temperatureCorrectionValuePer1Degree);

            seriesList.ForEach(series => series.IncreaseValuesByAdd(correctionValue));
        }
    }
}
