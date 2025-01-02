using CalibrationCalculations.Common.Exceptions;

namespace CalibrationCalculations.Helpers
{
    /// <summary>
    /// Defines the <see cref="ArrayHelper" />
    /// </summary>
    public static class ArrayHelper
    {
        /// <summary>
        /// The StackArray
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arrays">The arrays<see cref="T[][]"/></param>
        /// <returns>The <see cref="T[]"/></returns>
        public static T[] StackArrays<T>(params T[][] arrays)
        {
            // TODO need error handling

            return arrays.SelectMany(array => array).ToArray();
        }

        /// <summary>
        /// The StackArrayNTimes
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array<see cref="T[]"/></param>
        /// <param name="n">The n<see cref="int"/></param>
        /// <returns>The <see cref="T[]"/></returns>
        public static T[] StackArrayNTimes<T>(T[] array, int n)
        {
            // TODO need error handling

            const int MINIMUM_NUMBER_OF_TIMES_TO_STACK = 1;

            if (n < MINIMUM_NUMBER_OF_TIMES_TO_STACK)
                throw new ArgumentException(ExceptionMessages.MINIMUM_ARRAY_STACKING_IS_ONE, nameof(n));

            return Enumerable.Repeat(array, n).SelectMany(a => a).ToArray();
        }

        public static double[] CalculateMeanAcrossX(double[][] jaggedArrays)
        {
            // TODO Add error handling

            int length = GetLengthOfLongestArray(jaggedArrays);

            double[] calculatedMean = new double[length];

            for (int i = 0; i < length; i++)
            {
                double sum = 0;
                int count = 0;
                foreach (double[] array in jaggedArrays)
                {
                    if (i >= array.Length)
                        continue;

                    sum += array[i];
                    count++;
                }
                
                calculatedMean[i] = sum / count;
            }

            return calculatedMean;
        }



        public static int GetLengthOfLongestArray(params double[][] arrays)
        {
            // TODO Add error handling
            return arrays.Max(array => array.Length);
        }
    }
}
