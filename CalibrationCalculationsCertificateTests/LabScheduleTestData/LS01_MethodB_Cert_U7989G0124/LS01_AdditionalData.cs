using CalibrationCalculationsCertificateTests.LabScheduleModels;

namespace CalibrationCalculationsCertificateTests.LabScheduleTestData.LS01_MethodB_Cert_U7989G0124;

internal class LS01_AdditionalData : ILabScheduleAdditionalData
{
    // Building this certificate:
    // CALIBRATION & ISSUE DATE: 07/01/2024
    // REPORT NO.: U-7989G0124

    private static readonly double[] mathNetACoefficientsOrder1 =
    [
        0.00045062674071560949D,
        -8.1637694060922238E-05D
    ];

    private static readonly double[] mathNetACoefficientsOrder2 =
    [
        8.2563017532517947E-05D,
        -8.1590436011114647E-05D,
        -9.3439858631529635E-13D
    ];

    private static readonly double[] mathNetACoefficientsOrder3 =
    [
        -1.2681681903523259E-05D,
        -8.1564280993900979E-05D,
        -2.2543421430640695E-12D,
        1.728176221706338E-17D
    ];

    private static readonly double[] mathNetACoefficientsOrder4 =
    [
        4.6584985010982049E-06D,
        -8.1572545289104151E-05D,
        -1.4929851106389877E-12D,
        -6.2003123994545733E-18D,
        2.2993334632372425E-22D
    ];

    private static readonly double[] mathNetACoefficientsOrder5 =
    [
        -1.7538003200909389E-06D,
        -8.15679337353409E-05D,
        -2.1585218120543664E-12D,
        2.9248922299039149E-17D,
        -5.5698075277555627E-22D,
        6.1721062273066225E-27D
    ];
    
    double[] ILabScheduleAdditionalData.GetMathNetACoefficients(int order)
    {
        return order switch
        {
            1 => mathNetACoefficientsOrder1,
            2 => mathNetACoefficientsOrder2,
            3 => mathNetACoefficientsOrder3,
            4 => mathNetACoefficientsOrder4,
            5 => mathNetACoefficientsOrder5,
            _ => throw new NotImplementedException()
        };
    }
}
