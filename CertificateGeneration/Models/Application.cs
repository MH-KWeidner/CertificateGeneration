using CertificateGeneration.Interpolation;
using CertificateGeneration.MathLib;
using CertificateGeneration.Models.DataTransform;
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

        /// <summary>
        /// The GetSeriesRow
        /// </summary>
        /// <param name="row">The row<see cref="int"/></param>
        /// <returns>The <see cref="IList{double}"/></returns>
        public IList<double> GetSeriesRow(int row)
        {
            // TODO better naming

            // TODO: error handling

            // TODO: tansform with IoC?

            List<double> seriesRow = [];

            foreach (var series in seriesList)
                seriesRow.Add(series.GetValue(row));

            return seriesRow;
        }

        /// <summary>
        /// The DetermineDegreeOfBestFittingPolynomial
        /// </summary>
        /// <returns>The <see cref="int"/></returns>
        public int DetermineDegreeOfBestFittingPolynomial()
        {
            // how to test this??

            const int MIN_DEGREE_OF_FIT = 1;

            const int MAX_DEGREE_OF_FIT = 4;

            double[] stackedAppliedForces = StackData(new AppliedForceToArray());

            double[] stackedSeriesData = StackData(new SeriesValueToArray());

            double[] observedMean = CalculateSeriesMean();

            double[] appliedForces = GetAppliedForces();

            var rangeOfDegrees = Enumerable.Range(MIN_DEGREE_OF_FIT, MAX_DEGREE_OF_FIT).Reverse();

            int returnBestFitDegree = 0;

            // TODO: consider double?
            double currentResidualDeviation = 0;
            double previousResidualDeviation = 0;

            foreach (int degree in rangeOfDegrees)
            {
                returnBestFitDegree = degree;

                double[] polynomials = MathLib.Statistics.FitPolynomialToLeastSquares(stackedAppliedForces, stackedSeriesData, degree);

                double[] predictedFit = new double[appliedForces.Length];

                for (int i = 0; i < predictedFit.Length; i++)
                    predictedFit[i] = MathLib.Statistics.CalculatePolynomial(polynomials, appliedForces[i]);

                previousResidualDeviation = currentResidualDeviation;

                currentResidualDeviation = MathLib.Statistics.CalculateResidualStandardDeviation(observedMean, predictedFit, degree);

                if (degree == MAX_DEGREE_OF_FIT)
                    continue;

                if (IsBestFitPolynomialFit(previousResidualDeviation, currentResidualDeviation, observedMean.Length, degree))
                    break;
            }

            return returnBestFitDegree;
        }

        /// <summary>
        /// The IsBestFitPolynomialFit
        /// </summary>
        /// <param name="previousResidualDeviation">The previousResidualDeviation<see cref="double"/></param>
        /// <param name="currentResidualStandardDeveian">The currentResidualStandardDeveian<see cref="double"/></param>
        /// <param name="numOfNonZeroForceIncrements">The numOfNonZeroForceIncrements<see cref="int"/></param>
        /// <param name="degreeOfPolynomialFit">The degreeOfPolynomialFit<see cref="int"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool IsBestFitPolynomialFit(double previousResidualDeviation, double currentResidualStandardDeveian, int numOfNonZeroForceIncrements, int degreeOfPolynomialFit)
        {
            return (previousResidualDeviation / currentResidualStandardDeveian) > Statistics.CalculateCFactor(numOfNonZeroForceIncrements, degreeOfPolynomialFit);
        }

        /// <summary>
        /// The GetSeriesSize
        /// </summary>
        /// <returns>The <see cref="int"/></returns>
        public int GetSeriesSize()
        {
            // TODO consider verifying that all series are the same size

            return seriesList[0].CountValues();
        }

        /// <summary>
        /// The CalculateSeriesMean
        /// </summary>
        /// <returns>The <see cref="double[]"/></returns>
        public double[] CalculateSeriesMean()
        {
            // TODO : better naming

            int seriesSize = GetSeriesSize();

            double[] seriesMean = new double[seriesSize];

            for (int i = 0; i < seriesSize; i++)
                seriesMean[i] = Statistics.CalculateMean(GetSeriesRow(i));

            return seriesMean;
        }

        /// <summary>
        /// The GetAppliedForces
        /// </summary>
        /// <returns>The <see cref="double[]"/></returns>
        public double[] GetAppliedForces()
        {
            // TODO: better way to handle this wihout using the first series "[0]"

            const int SERIES_TO_USE = 0;

            return seriesList[SERIES_TO_USE].Transform(new AppliedForceToArray());
        }

        /// <summary>
        /// The StackData
        /// </summary>
        /// <param name="transform">The transform<see cref="ITransformToDoubleArray"/></param>
        /// <returns>The <see cref="double[]"/></returns>
        public double[] StackData(ITransformToDoubleArray transform)
        {
            // TODO : add error handling

            // TODO: values need to be ordered

            // TODO: how to test while seriesList is encapsulated

            List<double> stacked = [];

            foreach (var series in seriesList)
                stacked.AddRange(series.Transform(transform));

            return [.. stacked];
        }
    }
}
