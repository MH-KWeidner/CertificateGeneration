using System;
using System.Collections.Generic;
using System.Text;
using CalibrationCalculations.Models;

namespace CalibrationCalculations.Models
{
    public abstract class AbstractMeasurementPoint : IMeasurementPoint
    {
        /// <summary>
        /// Gets or sets the AppliedForce
        /// </summary>
        public double AppliedForce { get; set; }

        /// <summary>
        /// Gets or sets the RawValue
        /// </summary>
        public double RawValue { get; set; }

        /// <summary>
        /// Gets or sets the Value
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="IMeasurementPoint"/> class.
        /// </summary>
        /// <param name="appliedForce">The appliedForce<see cref="double"/></param>
        /// <param name="rawValue">The rawValue<see cref="double"/></param>
        public AbstractMeasurementPoint(double appliedForce, double rawValue) => (AppliedForce, RawValue, Value) = (appliedForce, rawValue, rawValue);
    }
}
