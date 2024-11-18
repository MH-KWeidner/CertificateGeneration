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

            double[] appliedForces = GetAppliedForces();

            double[] seriesMean = CalculateSeriesMean();
            
            const int SAMPLE_COUNT = 5;
            
            const int MAX_DEGREE = 5;

            int bestFitDegree = MAX_DEGREE;

            double[] residualStandardDeviation = new double[SAMPLE_COUNT];
            double[] cFactors = new double[SAMPLE_COUNT];

            for (int i = 0; i < SAMPLE_COUNT; i++)
            {
                double[] bestFit = Statistics.FitPolynomialToLeastSquares(appliedForces, seriesMean, bestFitDegree);

                residualStandardDeviation[i] = 0.0;
                foreach (double value in bestFit)
                    residualStandardDeviation[i] += Math.Pow(value, 2);

                residualStandardDeviation[i] = residualStandardDeviation[i] / (bestFit.Length - bestFitDegree - 1);

                residualStandardDeviation[i] = Math.Sqrt(residualStandardDeviation[i]);

                cFactors[i] = Statistics.CFactor(seriesMean.Length, bestFitDegree);

                if (i == 0)
                    continue;
                
                if ((residualStandardDeviation[i] / residualStandardDeviation[i-1]) > cFactors[i-1])
                    break;

                bestFitDegree--;
            }

            return bestFitDegree;
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
                seriesMean[i] = Statistics.GetMean(GetSeriesRow(i));

            return seriesMean;
        }

        public double[] GetAppliedForces()
        {
            return seriesList[0].Transform(new AppliedForceToArray());
        }

    }
}
