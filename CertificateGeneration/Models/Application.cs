using CertificateGeneration.Interpolation;
using CertificateGeneration.Models.Modifiers;

namespace CertificateGeneration.Models
{
    /// <summary>
    /// Defines the <see cref="Application" />
    /// </summary>
    public class Application
    {
        /// <summary>
        /// Defines the seriesList
        /// </summary>
        private List<Series> seriesList;

        /// <summary>
        /// Initializes a new instance of the <see cref="Application"/> class.
        /// </summary>
        /// <param name="appliedForce">The appliedForce<see cref="double[]"/></param>
        /// <param name="rawData">The rawData<see cref="double[][]"/></param>
        public Application(double[] appliedForce, params double[][] rawData)
        {
            seriesList = [];

            foreach (var data in rawData)
                seriesList.Add(Series.CreateSeries(seriesList.Count + 1, appliedForce, data));
        }

        /// <summary>
        /// The InterpolateSeriesData
        /// </summary>
        /// <param name="interpolator">The interpolator<see cref="IInterpolate"/></param>
        public void InterpolateSeriesData(IInterpolate interpolator)
        {
            foreach (var series in seriesList)
                series.Interpolate(interpolator);
        }

        /// <summary>
        /// The ModifySeriesData
        /// </summary>
        /// <param name="modifier">The modifier<see cref="IModifySeriesSize"/></param>
        public void ModifySeriesData(IModifySeriesSize modifier)
        {
            foreach (var series in seriesList)
                series.Modify(modifier);
        }

        /// <summary>
        /// The OrderSeriesData
        /// </summary>
        /// <param name="modifier">The modifier<see cref="IOrderSeries"/></param>
        public void OrderSeriesData(IOrderSeries modifier)
        {
            foreach (var series in seriesList)
                series.Order(modifier);
        }
    }
}
