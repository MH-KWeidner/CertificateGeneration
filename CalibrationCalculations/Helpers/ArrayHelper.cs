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

        /// <summary>
        /// The CalculateMeanAcrossX
        /// </summary>
        /// <param name="dataArrays">The dataArrays<see cref="double[][]"/></param>
        /// <returns>The <see cref="double[]"/></returns>
        public static double[] CalculateMeanAcrossX(double[][] dataArrays)
        {
            // TODO Add error handling

            const int RANGE_START = 0;

            const int ARRAY_FOR_LENGTH_REFERENCE = 0;

            return Enumerable.Range(RANGE_START, dataArrays[ARRAY_FOR_LENGTH_REFERENCE].Length)
                             .Select(i => dataArrays.Average(array => array[i]))
                             .ToArray();
        }
    }
}
