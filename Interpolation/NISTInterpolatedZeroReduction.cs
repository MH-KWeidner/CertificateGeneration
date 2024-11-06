using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Helpers.Models;
using Helpers;
using Models;

namespace Interpolation
{
    public static class NISTInterpolatedZeroReduction
    {
        public static void Calculate(double[] appliedForce,  List<Series> seriesData)
        {
            const double DOUBLE_ZERO = 0.0;
            
            var zeroValuedElements = ArrayHelper.GetElementsByValue(DOUBLE_ZERO, appliedForce);

            DoubleValueArrayElement zeroStartElement;
            DoubleValueArrayElement zeroEndElement;

            for (int i = 0; i < zeroValuedElements.Length; i++)
            {
                if (i + 1 == zeroValuedElements.Length)
                    break;

                zeroStartElement = zeroValuedElements[i];
                zeroEndElement = zeroValuedElements[i + 1];

                // 2 consecutive zero values can not be used for interpolation
                if (zeroEndElement.Index - 1 == zeroStartElement.Index)
                    continue;

                foreach (var series in seriesData)
                {
                    CalculateNISInterpolatedValues(zeroStartElement, zeroEndElement, series.DataPoints);
                }
            }
        }

        public static void CalculateNISInterpolatedValues(DoubleValueArrayElement zeroStartElement, DoubleValueArrayElement zeroEndElement, List<DataPoint> dataPoints)
        {
            //TODO maybe not modify the collections and objects passed as parameters

            int numberOfNonZeroForcePoints = zeroEndElement.Index - zeroStartElement.Index + 1;

            for (int j = zeroStartElement.Index + 1; j < zeroEndElement.Index; j++)
            {
                var x = CalculateNISInterpolatedValue(
                     startZeroValue: dataPoints[zeroStartElement.Index].Raw,
                     endZeroValue: dataPoints[zeroEndElement.Index].Raw,
                     numberOfNonZeroForcePoints: numberOfNonZeroForcePoints,
                     forceReading: dataPoints[j].Raw,
                     seriesPositionOfForceReading: j);
            }
        }

        public static double CalculateNISInterpolatedValue(double startZeroValue, double endZeroValue, int numberOfNonZeroForcePoints, double forceReading, int seriesPositionOfForceReading)
        {
            //TODO beter naming
            try
            {
                return forceReading - (startZeroValue + ((endZeroValue - startZeroValue) * (seriesPositionOfForceReading - 1) / (numberOfNonZeroForcePoints - 1)));
            }
            catch
            {
                //TODO add specific error handling
                throw new Exception("Error in Statistics.CalculateNISInterpolatedValue");
            }
        }
    }
}
