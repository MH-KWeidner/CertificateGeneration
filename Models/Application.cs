using Models.Interpolation;
using Models.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLib;
using Models.DataTransform;
using System.Drawing;

namespace Models
{
    public class Application
    {
        private List<Series> seriesList;

        public Application(double[] appliedForce, params double[][] rawData)
        {
            seriesList = [];

            foreach (var data in rawData)
                seriesList.Add(Series.CreateSeries(seriesList.Count + 1, appliedForce, data));
        }

        public void Interpolate(IInterpolate interpolator)
        {
            foreach (var series in seriesList)
                series.Interpolate(interpolator);
        }

        public void Modify(IModifySeriesSize modifier)
        {
            foreach (var series in seriesList)
                series.Modify(modifier);
        }

        public void Modify(IOrderSeries modifier)
        {
            foreach (var series in seriesList)
                series.Modify(modifier);
        }

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

        public int DetermineDegreeOfBestFittingPolynomial()
        {
            // TODO: consider best way to get series size

            // TODO: test for symmetry of series data and applied forces

            //TODO; what are the boundry conditions for the degree of the polynomial?

            double[] appliedForces = GetAppliedForces();

            double[] seriesMean = CalculateSeriesMean();

            const int MAX_DEGREE_OF_FIT = 5;

            int degreeOfFit = MAX_DEGREE_OF_FIT;

            double[] residualStandardDeviations = new double[MAX_DEGREE_OF_FIT];

            for (int i = MAX_DEGREE_OF_FIT; i >= 1; i--)
            {
                double[] bestFit = Statistics.FitPolynomialToLeastSquares(appliedForces, seriesMean, degreeOfFit);

                residualStandardDeviations[i] = MathLib.Statistics.CalculateResidualStandardDeviation(seriesMean, bestFit, degreeOfFit); 
                
                if (i == MAX_DEGREE_OF_FIT)
                    continue;

                if (IsBestFitPolynomialFit(residualStandardDeviations[i], residualStandardDeviations[i + 1], seriesMean.Length, degreeOfFit))
                    break;

                degreeOfFit--;
            }

            return degreeOfFit;
        }

        public bool IsBestFitPolynomialFit(double residualStandardDeviation1, double residualStandardDeveian2, int numOfNonZeroForceIncrements, int degreeOfPolynomialFit)
        { 
            return (residualStandardDeviation1 / residualStandardDeveian2) > Statistics.CalculateCFactor(numOfNonZeroForceIncrements, degreeOfPolynomialFit);
        }

        public int GetSeriesSize()
        {
            // TODO consider verifying that all series are the same size

            return seriesList[0].CountValues();
        }

        public double[] CalculateSeriesMean()
        {
            // TODO : better naming

            int seriesSize = GetSeriesSize();

            double[] seriesMean = new double[seriesSize];

            for (int i = 0; i < seriesSize; i++)
                seriesMean[i] = Statistics.CalculateMean(GetSeriesRow(i));

            return seriesMean;
        }

        public double[] GetAppliedForces()
        {
            return seriesList[0].Transform(new AppliedForceToArray());
        }


    }
}
