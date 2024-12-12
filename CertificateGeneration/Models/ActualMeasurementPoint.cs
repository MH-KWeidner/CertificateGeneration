using System;
using System.Collections.Generic;
using System.Text;

namespace CertificateGeneration.Models
{
    public class ActualMeasurementPoint(double appliedForce, double rawValue, double actualAppliedForce) : AbstractMeasurementPoint(appliedForce, rawValue)
    {
        public double ActualAppliedForce { get; private set; } = actualAppliedForce;
    }
}