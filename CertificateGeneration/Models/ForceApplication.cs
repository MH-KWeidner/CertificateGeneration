using CertificateGeneration.CertificateCalculations.Interpolation;
using CertificateGeneration.IoC.Modifiers;
using MathNet.Numerics;

namespace CertificateGeneration.Models
{
    /// <summary>
    /// Defines the <see cref="ForceApplication" />
    /// </summary>
    public class ForceApplication
    {
        /// <summary>
        /// Defines the seriesList
        /// </summary>
        private List<Series> seriesList;

        /// <summary>
        /// Initializes a new instance of the <see cref="ForceApplication"/> class.
        /// </summary>
        /// <param name="appliedForce">The appliedForce<see cref="double[]"/></param>
        /// <param name="rawData">The rawData<see cref="double[][]"/></param>
        public ForceApplication(double[] appliedForce, params double[][] rawData)
        {
            //TODO add error handling

            seriesList = [];

            seriesList.AddRange(rawData.Select((data, index) => Series.CreateSeries(index + 1, appliedForce, data)));
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
        /// The ModifySeriesData
        /// </summary>
        /// <param name="modifier">The modifier<see cref="IModifySeriesSize"/></param>
        public void ModifySeriesData(IModifySeriesSize modifier)
        {
            //TODO add error handling

            if (modifier == null)
                return;

            seriesList?.ForEach(series => series.Modify(modifier));
        }

        /// <summary>
        /// The OrderSeriesData
        /// </summary>
        /// <param name="modifier">The modifier<see cref="IOrderSeries"/></param>
        public void OrderSeriesData(IOrderSeries modifier)
        {
            //TODO add error handling

            if (modifier == null)
                return;

            seriesList?.ForEach(series => series.Order(modifier));
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
            //TODO add error handling

            if (indexes == null)
                return;

            seriesList = seriesList.Where((series, index) => !indexes.Contains(index)).ToList();
        }

    }
}
