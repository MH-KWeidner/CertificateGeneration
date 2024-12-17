using CalibrationCalculations.Common;
using CalibrationCalculations.StandardCalculations.Interpolation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationCalculations.StandardCalculations.Interpolation
{
    /// <summary>
    /// Defines the <see cref="InterpolatorFactory" />
    /// </summary>
    public static class InterpolatorFactory
    {
        /// <summary>
        /// The Create
        /// </summary>
        /// <param name="interpolationType">The interpolationType<see cref="InterpolationTypes"/></param>
        /// <returns>The <see cref="IInterpolate"/></returns>
        public static IInterpolate Create(InterpolationTypes interpolationType)
        {
            return interpolationType switch
            {
                InterpolationTypes.MethodA => new InitialZeroValueInterpolator(),
                InterpolationTypes.MethodB => new NistInterpolator(),
                _ => throw new ArgumentException("Invalid interpolation type", nameof(interpolationType))
            };
        }
    }
}
