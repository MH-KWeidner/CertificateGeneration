using CalibrationCalculationsCertificateTests.LabScheduleASTMModels;
using static CalibrationCalculationsCertificateTests.LabScheduleASTMModels.ASTMResult;

namespace CalibrationCalculationsCertificateTests.LabScheduleTestData.LS01_MethodB_Cert_U7989G0124
{
    internal class LS01_ASTMResults : ILabScheduleASTMResults
    {
        public List<ASTMResult> ASTMLists =>

            new List<ASTMResult>
            {
                new ASTMResult
                {
                    ACoefficients = new double[]
                    {
                        0.0004506267D,
                        -8.163769E-05D
                    },
                    BCoefficients = new double[]
                    {
                        5.520488D,
                        -12249.24D
                    },
                    prevACoefficients = new List<double>
                    {
                        -2.453782E-06D,
                        -8.157835E-05D,
                        -1.216461E-12D,
                        -1.283601E-17D,
                        2.823759E-22D
                    },
                    Loads = new List<decimal>
                    {
                        1000.00000000m,
                        5000.00000000m,
                        10000.00000000m,
                        15000.00000000m,
                        20000.00000000m,
                        25000.00000000m,
                        30000.00000000m,
                        35000.00000000m,
                        40000.00000000m,
                        45000.00000000m,
                        50000.00000000m
                    },
                    ValuesFromCurve = new List<double>
                    {
                        -0.08118707D,
                        -0.40773784D,
                        -0.81592631D,
                        -1.22411478D,
                        -1.63230325D,
                        -2.04049172D,
                        -2.4486802D,
                        -2.85686867D,
                        -3.26505714D,
                        -3.67324561D,
                        -4.08143408D
                    },
                    InverseValuesFromCurve = new List<double>
                    {
                        1000.00062508D,
                        5000.00052129D,
                        10000.00039156D,
                        15000.00026182D,
                        20000.00013209D,
                        25000.00000236D,
                        29999.99987263D,
                        34999.99974289D,
                        39999.99961316D,
                        44999.99948343D,
                        49999.9993537D
                    },
                    DeviationFromCurve = new List<double[]>
                    {
                        new double[]
                        {
                            -0.00038293267979337686D,
                            -0.00014851643610441778D,
                            7.358386850675469E-05D,
                            0.0002056941731178874D,
                            0.00026780447772911664D,
                            0.00026990478234001358D,
                            0.0002120150869515669D,
                            0.00011411539156291894D,
                            6.2256961741447014E-06D,
                            -0.00014166399921489159D,
                            -0.0002295636946048063D
                        },
                        new double[]
                        {
                            -0.00038293267979337686D,
                            -0.00016942643610440289D,
                            5.1763868506804478E-05D,
                            0.00017296417311785106D,
                            0.00023416447772928173D,
                            0.00022536478234025381D,
                            0.00016655508695162524D,
                            6.775539156267385E-05D,
                            -5.1044303825964477E-05D,
                            -0.00018984399921473383D,
                            -0.00028865369460451262D
                        },
                        new double[]
                        {
                            -0.00038293267979337686D,
                            -0.0001603364361044135D,
                            4.9953868506813492E-05D,
                            0.00017023417311801126D,
                            0.00023052447772919926D,
                            0.0002308147823399942D,
                            0.00017110508695150628D,
                            8.1395391562821828E-05D,
                            -4.8314303826124672E-05D,
                            -0.0001780339992150104D,
                            -0.000247743694604452D
                        }
                    },
                    ChangeFromPrevious = new ChangeFromPreviousObject
                    {
                        PreviousACoefficients = new List<double>
                        {
                            -2.453782E-06D,
                            -8.157835E-05D,
                            -1.216461E-12D,
                            -1.283601E-17D,
                            2.823759E-22D
                        },
                        PreviousValuesFromCurve = new List<double>
                        {
                            -0.08158203D,
                            -0.40792604D,
                            -0.81591761D,
                            -1.22398043D,
                            -1.63211355D,
                            -2.04031175D,
                            -2.44856562D,
                            -2.85686147D,
                            -3.26518141D,
                            -3.6735033D,
                            -4.08180076D
                        },
                        PercentDifferences = new List<double>
                        {
                            -0.486D,
                            -0.046D,
                            0.001D,
                            0.011D,
                            0.012D,
                            0.009D,
                            0.005D,
                            0D,
                            -0.004D,
                            -0.007D,
                            -0.009D
                        },
                        ChangeFromPrevious = new List<double>
                        {
                            0.00039496D,
                            0.0001882D,
                            -8.7E-06D,
                            -0.00013435D,
                            -0.0001897D,
                            -0.00017997D,
                            -0.00011458D,
                            -7.2E-06D,
                            0.00012427D,
                            0.00025769D,
                            0.00036668D
                        }
                    },
                    ClassALoadingRange = new LoadingRange
                    {
                        Minimum = 2502.04D,
                        Maximum = 50000D,
                        LowerLimitFittedCurveValue = -0.20381014930747426D,
                        LowerLimitFittedPrevCurveValue = -0.20412255389789338D,
                        LowerLimitFittedChangeFromPrev = -0.153D
                    },
                    ClassAALoadingRange = new LoadingRange
                    {
                        Minimum = 12510.2D,
                        Maximum = 50000D,
                        LowerLimitFittedCurveValue = -1.0208532535002337D,
                        LowerLimitFittedPrevCurveValue = -1.0207725255894049D,
                        LowerLimitFittedChangeFromPrev = 0.008D
                    },
                    DegreeFit = 1,
                    LowerLimitFactor = 6.2551D,
                    StandardDeviationDeflection = 0.000213D,
                    StandardDeviationDeflectionAverage = 0.00022691440522015519D,
                    StandardDeviationLoad = 2.6062800476937422D,
                    Resolution = 0.0001D
                },
                new ASTMResult
                {
                    ACoefficients = new double[]
                    {
                        8.256302E-05D,
                        -8.159044E-05D,
                        -9.343986E-13D
                    },
                    BCoefficients = new double[]
                    {
                        1.013369D,
                        -12256.33D,
                        -1.717349D
                    },
                    prevACoefficients = new List<double>
                    {
                        -2.453782E-06D,
                        -8.157835E-05D,
                        -1.216461E-12D,
                        -1.283601E-17D,
                        2.823759E-22D
                    },
                    Loads = new List<decimal>
                    {
                        1000.00000000m,
                        5000.00000000m,
                        10000.00000000m,
                        15000.00000000m,
                        20000.00000000m,
                        25000.00000000m,
                        30000.00000000m,
                        35000.00000000m,
                        40000.00000000m,
                        45000.00000000m,
                        50000.00000000m
                    },
                    ValuesFromCurve = new List<double>
                    {
                        -0.08150881D,
                        -0.40789298D,
                        -0.81591524D,
                        -1.22398422D,
                        -1.63209992D,
                        -2.04026234D,
                        -2.44847148D,
                        -2.85672734D,
                        -3.26502992D,
                        -3.67337921D,
                        -4.08177523D
                    },
                    InverseValuesFromCurve = new List<double>
                    {
                        1000.00107497D,
                        4999.99994677D,
                        9999.99924406D,
                        14999.99914417D,
                        19999.99945066D,
                        24999.99996706D,
                        30000.00049688D,
                        35000.00084359D,
                        40000.00081067D,
                        45000.00020156D,
                        49999.99881967D
                    },
                    DeviationFromCurve = new List<double[]>
                    {
                        new double[]
                        {
                            -6.1192607831564438E-05D,
                            6.6170026986056563E-06D,
                            6.2506952245522385E-05D,
                            7.51268311081077E-05D,
                            6.44666392866089E-05D,
                            4.0516376780264096E-05D,
                            3.2960435905060592E-06D,
                            -2.7214360283522865E-05D,
                            -2.0994834842191779E-05D,
                            -8.055380085192354E-06D,
                            0.00011159400398774721D
                        },
                        new double[]
                        {
                            -6.1192607831564438E-05D,
                            -1.4292997301379451E-05D,
                            4.0686952245572172E-05D,
                            4.2396831108071353E-05D,
                            3.0826639286773982E-05D,
                            -4.0236232194956756E-06D,
                            -4.21639564094356E-05D,
                            -7.3574360283767959E-05D,
                            -7.8264834842300957E-05D,
                            -5.6235380085034592E-05D,
                            5.2504003988040893E-05D
                        },
                        new double[]
                        {
                            -6.1192607831564438E-05D,
                            -5.2029973013900666E-06D,
                            3.8876952245581187E-05D,
                            3.9666831108231548E-05D,
                            2.7186639286691516E-05D,
                            1.4263767802447092E-06D,
                            -3.7613956409554561E-05D,
                            -5.9934360283619981E-05D,
                            -7.5534834842461152E-05D,
                            -4.4425380085311161E-05D,
                            9.3414003988101513E-05D
                        }
                    },
                    ChangeFromPrevious = new ChangeFromPreviousObject
                    {
                        PreviousACoefficients = new List<double>
                        {
                            -2.453782E-06D,
                            -8.157835E-05D,
                            -1.216461E-12D,
                            -1.283601E-17D,
                            2.823759E-22D
                        },
                        PreviousValuesFromCurve = new List<double>
                        {
                            -0.08158203D,
                            -0.40792604D,
                            -0.81591761D,
                            -1.22398043D,
                            -1.63211355D,
                            -2.04031175D,
                            -2.44856562D,
                            -2.85686147D,
                            -3.26518141D,
                            -3.6735033D,
                            -4.08180076D
                        },
                        PercentDifferences = new List<double>
                        {
                            -0.09D,
                            -0.008D,
                            0D,
                            0D,
                            -0.001D,
                            -0.002D,
                            -0.004D,
                            -0.005D,
                            -0.005D,
                            -0.003D,
                            -0.001D
                        },
                        ChangeFromPrevious = new List<double>
                        {
                            7.322E-05D,
                            3.306E-05D,
                            2.37E-06D,
                            -3.79E-06D,
                            1.363E-05D,
                            4.941E-05D,
                            9.414E-05D,
                            0.00013413D,
                            0.00015149D,
                            0.00012409D,
                            2.553E-05D
                        }
                    },
                    ClassALoadingRange = new LoadingRange
                    {
                        Minimum = 1000D,
                        Maximum = 50000D,
                        LowerLimitFittedCurveValue = -0.081508807392168439D,
                        LowerLimitFittedPrevCurveValue = -0.081582032796634091D,
                        LowerLimitFittedChangeFromPrev = -0.09D
                    },
                    ClassAALoadingRange = new LoadingRange
                    {
                        Minimum = 3212.2D,
                        Maximum = 50000D,
                        LowerLimitFittedCurveValue = -0.26201187687581134D,
                        LowerLimitFittedPrevCurveValue = -0.26206137675105484D,
                        LowerLimitFittedChangeFromPrev = -0.019D
                    },
                    DegreeFit = 2,
                    LowerLimitFactor = 1.6061D,
                    StandardDeviationDeflection = 5.4600000000000006E-05D,
                    StandardDeviationDeflectionAverage = 5.7199091298890119E-05D,
                    StandardDeviationLoad = 0.66919926142477815D,
                    Resolution = 0.0001D
                },
                new ASTMResult
                {
                    ACoefficients = new double[]
                    {
                        -1.268168E-05D,
                        -8.156428E-05D,
                        -2.254342E-12D,
                        1.728176E-17D
                    },
                    BCoefficients = new double[]
                    {
                        -0.1544386D,
                        -12260.26D,
                        -4.146353D,
                        -0.3895865D
                    },
                    prevACoefficients = new List<double>
                    {
                        -2.453782E-06D,
                        -8.157835E-05D,
                        -1.216461E-12D,
                        -1.283601E-17D,
                        2.823759E-22D
                    },
                    Loads = new List<decimal>
                    {
                        1000.00000000m,
                        5000.00000000m,
                        10000.00000000m,
                        15000.00000000m,
                        20000.00000000m,
                        25000.00000000m,
                        30000.00000000m,
                        35000.00000000m,
                        40000.00000000m,
                        45000.00000000m,
                        50000.00000000m
                    },
                    ValuesFromCurve = new List<double>
                    {
                        -0.0815792D,
                        -0.40788828D,
                        -0.81586364D,
                        -1.2239258D,
                        -1.63206178D,
                        -2.04025864D,
                        -2.44850341D,
                        -2.85678313D,
                        -3.26508484D,
                        -3.67339557D,
                        -4.08170237D
                    },
                    InverseValuesFromCurve = new List<double>
                    {
                        1000.0005631D,
                        4999.99951096D,
                        9999.99943713D,
                        14999.99991177D,
                        20000.00036353D,
                        25000.00050836D,
                        30000.00029913D,
                        34999.99987524D,
                        39999.99951215D,
                        44999.99957093D,
                        50000.0004477D
                    },
                    DeviationFromCurve = new List<double[]>
                    {
                        new double[]
                        {
                            9.1997361853501936E-06D,
                            1.9249847079128024E-06D,
                            1.0914073002576963E-05D,
                            1.6707625124956493E-05D,
                            2.6334319412013585E-05D,
                            3.6822834201366561E-05D,
                            3.5231847830274887E-05D,
                            2.8580038635261928E-05D,
                            3.39260849533396E-05D,
                            8.2986651221972352E-06D,
                            3.8726457479043574E-05D
                        },
                        new double[]
                        {
                            9.1997361853501936E-06D,
                            -1.8985015292072305E-05D,
                            -1.090592699737325E-05D,
                            -1.6022374875079848E-05D,
                            -7.3056805878213282E-06D,
                            -7.71716579839321E-06D,
                            -1.0228152169666771E-05D,
                            -1.7779961364983166E-05D,
                            -2.3343915046769581E-05D,
                            -3.9881334877645E-05D,
                            -2.0363542520662747E-05D
                        },
                        new double[]
                        {
                            9.1997361853501936E-06D,
                            -9.89501529208292E-06D,
                            -1.2715926997364235E-05D,
                            -1.8752374874919653E-05D,
                            -1.0945680587903794E-05D,
                            -2.267165798652826E-06D,
                            -5.6781521697857329E-06D,
                            -4.1399613648351874E-06D,
                            -2.0613915046929776E-05D,
                            -2.8071334877921572E-05D,
                            2.0546457479397873E-05D
                        }
                    },
                    ChangeFromPrevious = new ChangeFromPreviousObject
                    {
                        PreviousACoefficients = new List<double>
                        {
                            -2.453782E-06D,
                            -8.157835E-05D,
                            -1.216461E-12D,
                            -1.283601E-17D,
                            2.823759E-22D
                        },
                        PreviousValuesFromCurve = new List<double>
                        {
                            -0.08158203D,
                            -0.40792604D,
                            -0.81591761D,
                            -1.22398043D,
                            -1.63211355D,
                            -2.04031175D,
                            -2.44856562D,
                            -2.85686147D,
                            -3.26518141D,
                            -3.6735033D,
                            -4.08180076D
                        },
                        PercentDifferences = new List<double>
                        {
                            -0.003D,
                            -0.009D,
                            -0.007D,
                            -0.004D,
                            -0.003D,
                            -0.003D,
                            -0.003D,
                            -0.003D,
                            -0.003D,
                            -0.003D,
                            -0.002D
                        },
                        ChangeFromPrevious = new List<double>
                        {
                            2.83E-06D,
                            3.776E-05D,
                            5.397E-05D,
                            5.463E-05D,
                            5.177E-05D,
                            5.311E-05D,
                            6.221E-05D,
                            7.834E-05D,
                            9.657E-05D,
                            0.00010773D,
                            9.839E-05D
                        }
                    },
                    ClassALoadingRange = new LoadingRange
                    {
                        Minimum = 1000D,
                        Maximum = 50000D,
                        LowerLimitFittedCurveValue = -0.081579199736185354D,
                        LowerLimitFittedPrevCurveValue = -0.081582032796634091D,
                        LowerLimitFittedChangeFromPrev = -0.003D
                    },
                    ClassAALoadingRange = new LoadingRange
                    {
                        Minimum = 1279.6D,
                        Maximum = 50000D,
                        LowerLimitFittedCurveValue = -0.10438599063926528D,
                        LowerLimitFittedPrevCurveValue = -0.10439212838302629D,
                        LowerLimitFittedChangeFromPrev = -0.006D
                    },
                    DegreeFit = 3,
                    LowerLimitFactor = 0.6398D,
                    StandardDeviationDeflection = 2.18E-05D,
                    StandardDeviationDeflectionAverage = 1.1514551287193503E-05D,
                    StandardDeviationLoad = 0.26656542638626107D,
                    Resolution = 0.0001D
                },
                new ASTMResult
                {
                    ACoefficients = new double[]
                    {
                        4.658499E-06D,
                        -8.157255E-05D,
                        -1.492985E-12D,
                        -6.200312E-18D,
                        2.299333E-22D
                    },
                    BCoefficients = new double[]
                    {
                        0.05700769D,
                        -12259.03D,
                        -2.752924D,
                        0.1368935D,
                        0.0631523D
                    },
                    prevACoefficients = new List<double>
                    {
                        -2.453782E-06D,
                        -8.157835E-05D,
                        -1.216461E-12D,
                        -1.283601E-17D,
                        2.823759E-22D
                    },
                    Loads = new List<decimal>
                    {
                        1000.00000000m,
                        5000.00000000m,
                        10000.00000000m,
                        15000.00000000m,
                        20000.00000000m,
                        25000.00000000m,
                        30000.00000000m,
                        35000.00000000m,
                        40000.00000000m,
                        45000.00000000m,
                        50000.00000000m
                    },
                    ValuesFromCurve = new List<double>
                    {
                        -0.08156939D,
                        -0.40789602D,
                        -0.81587399D,
                        -1.22392873D,
                        -1.63205625D,
                        -2.04024915D,
                        -2.44849655D,
                        -2.85678413D,
                        -3.26509412D,
                        -3.67340531D,
                        -4.08169302D
                    },
                    InverseValuesFromCurve = new List<double>
                    {
                        999.9999734D,
                        5000.00006529D,
                        9999.99999696D,
                        14999.99995151D,
                        19999.99997842D,
                        25000.00002862D,
                        30000.00004344D,
                        35000.00001046D,
                        39999.9999738D,
                        44999.99998638D,
                        49999.99999172D
                    },
                    DeviationFromCurve = new List<double[]>
                    {
                        new double[]
                        {
                            -6.1425390725233786E-07D,
                            9.6639054940617086E-06D,
                            2.126388254053424E-05D,
                            1.9638166645519206E-05D,
                            2.0804491621229104E-05D,
                            2.7331591085477669E-05D,
                            2.8369198461497547E-05D,
                            2.9578046976563854E-05D,
                            4.3209869663662914E-05D,
                            1.8037399360792961E-05D,
                            2.9384368712470632E-05D
                        },
                        new double[]
                        {
                            -6.1425390725233786E-07D,
                            -1.1246094505923399E-05D,
                            -5.5611745941597235E-07D,
                            -1.3091833354517135E-05D,
                            -1.2835508378605809E-05D,
                            -1.7208408914282103E-05D,
                            -1.7090801538444111E-05D,
                            -1.678195302368124E-05D,
                            -1.4060130336446264E-05D,
                            -3.0142600639049277E-05D,
                            -2.970563128723569E-05D
                        },
                        new double[]
                        {
                            -6.1425390725233786E-07D,
                            -2.1560945059340142E-06D,
                            -2.3661174594069578E-06D,
                            -1.582183335435694E-05D,
                            -1.6475508378688275E-05D,
                            -1.1758408914541718E-05D,
                            -1.2540801538563073E-05D,
                            -3.1419530235332616E-06D,
                            -1.1330130336606459E-05D,
                            -1.8332600639325847E-05D,
                            1.120436871282493E-05D
                        }
                    },
                    ChangeFromPrevious = new ChangeFromPreviousObject
                    {
                        PreviousACoefficients = new List<double>
                        {
                            -2.453782E-06D,
                            -8.157835E-05D,
                            -1.216461E-12D,
                            -1.283601E-17D,
                            2.823759E-22D
                        },
                        PreviousValuesFromCurve = new List<double>
                        {
                            -0.08158203D,
                            -0.40792604D,
                            -0.81591761D,
                            -1.22398043D,
                            -1.63211355D,
                            -2.04031175D,
                            -2.44856562D,
                            -2.85686147D,
                            -3.26518141D,
                            -3.6735033D,
                            -4.08180076D
                        },
                        PercentDifferences = new List<double>
                        {
                            -0.015D,
                            -0.007D,
                            -0.005D,
                            -0.004D,
                            -0.004D,
                            -0.003D,
                            -0.003D,
                            -0.003D,
                            -0.003D,
                            -0.003D,
                            -0.003D
                        },
                        ChangeFromPrevious = new List<double>
                        {
                            1.264E-05D,
                            3.002E-05D,
                            4.362E-05D,
                            5.17E-05D,
                            5.73E-05D,
                            6.26E-05D,
                            6.907E-05D,
                            7.734E-05D,
                            8.729E-05D,
                            9.799E-05D,
                            0.00010774D
                        }
                    },
                    ClassALoadingRange = new LoadingRange
                    {
                        Minimum = 1000D,
                        Maximum = 50000D,
                        LowerLimitFittedCurveValue = -0.081569385746092751D,
                        LowerLimitFittedPrevCurveValue = -0.081582032796634091D,
                        LowerLimitFittedChangeFromPrev = -0.015D
                    },
                    ClassAALoadingRange = new LoadingRange
                    {
                        Minimum = 1197D,
                        Maximum = 50000D,
                        LowerLimitFittedCurveValue = -0.097639827537004731D,
                        LowerLimitFittedPrevCurveValue = -0.097653503123253826D,
                        LowerLimitFittedChangeFromPrev = -0.014D
                    },
                    DegreeFit = 4,
                    LowerLimitFactor = 0.5985D,
                    StandardDeviationDeflection = 2.04E-05D,
                    StandardDeviationDeflectionAverage = 6.043197524921266E-06D,
                    StandardDeviationLoad = 0.2493791696195844D,
                    Resolution = 0.0001D
                },
                new ASTMResult
                {
                    ACoefficients = new double[]
                    {
                        -1.7538E-06D,
                        -8.156793E-05D,
                        -2.158522E-12D,
                        2.924892E-17D,
                        -5.569808E-22D,
                        6.172106E-27D
                    },
                    BCoefficients = new double[]
                    {
                        -0.02146411D,
                        -12259.72D,
                        -3.975424D,
                        -0.6608052D,
                        -0.1537711D,
                        -0.02084272D
                    },
                    prevACoefficients = new List<double>
                    {
                        -2.453782E-06D,
                        -8.157835E-05D,
                        -1.216461E-12D,
                        -1.283601E-17D,
                        2.823759E-22D
                    },
                    Loads = new List<decimal>
                    {
                        1000.00000000m,
                        5000.00000000m,
                        10000.00000000m,
                        15000.00000000m,
                        20000.00000000m,
                        25000.00000000m,
                        30000.00000000m,
                        35000.00000000m,
                        40000.00000000m,
                        45000.00000000m,
                        50000.00000000m
                    },
                    ValuesFromCurve = new List<double>
                    {
                        -0.08157182D,
                        -0.40789206D,
                        -0.81587265D,
                        -1.22393122D,
                        -1.63205921D,
                        -2.04024946D,
                        -2.44849389D,
                        -2.85678122D,
                        -3.26509465D,
                        -3.67340951D,
                        -4.08169098D
                    },
                    InverseValuesFromCurve = new List<double>
                    {
                        1000.00000067D,
                        4999.99999069D,
                        10000.00002803D,
                        15000.00000954D,
                        19999.99997802D,
                        24999.99998166D,
                        30000.00001226D,
                        35000.00002564D,
                        40000.00000376D,
                        44999.99998995D,
                        49999.99997978D
                    },
                    DeviationFromCurve = new List<double[]>
                    {
                        new double[]
                        {
                            1.8173593593906467E-06D,
                            5.698232177109297E-06D,
                            1.9917009540515451E-05D,
                            2.2132332829549739E-05D,
                            2.3762034084384709E-05D,
                            2.7635037131101825E-05D,
                            2.5706817746939947E-05D,
                            2.6674863823572537E-05D,
                            4.3744135534318218E-05D,
                            2.2242525495208554E-05D,
                            2.73363189347009E-05D
                        },
                        new double[]
                        {
                            1.8173593593906467E-06D,
                            -1.521176782287581E-05D,
                            -1.9029904594347613E-06D,
                            -1.0597667170486602E-05D,
                            -9.8779659154502042E-06D,
                            -1.6904962868657947E-05D,
                            -1.9753182253001711E-05D,
                            -1.9685136176672557E-05D,
                            -1.352586446579096E-05D,
                            -2.5937474504633684E-05D,
                            -3.1753681065005424E-05D
                        },
                        new double[]
                        {
                            1.8173593593906467E-06D,
                            -6.1217678228864258E-06D,
                            -3.7129904594257468E-06D,
                            -1.3327667170326407E-05D,
                            -1.351796591553267E-05D,
                            -1.1454962868917562E-05D,
                            -1.5203182253120673E-05D,
                            -6.0451361765245792E-06D,
                            -1.0795864465951155E-05D,
                            -1.4127474504910253E-05D,
                            9.1563189350551966E-06D
                        }
                    },
                    ChangeFromPrevious = new ChangeFromPreviousObject
                    {
                        PreviousACoefficients = new List<double>
                        {
                            -2.453782E-06D,
                            -8.157835E-05D,
                            -1.216461E-12D,
                            -1.283601E-17D,
                            2.823759E-22D
                        },
                        PreviousValuesFromCurve = new List<double>
                        {
                            -0.08158203D,
                            -0.40792604D,
                            -0.81591761D,
                            -1.22398043D,
                            -1.63211355D,
                            -2.04031175D,
                            -2.44856562D,
                            -2.85686147D,
                            -3.26518141D,
                            -3.6735033D,
                            -4.08180076D
                        },
                        PercentDifferences = new List<double>
                        {
                            -0.013D,
                            -0.008D,
                            -0.006D,
                            -0.004D,
                            -0.003D,
                            -0.003D,
                            -0.003D,
                            -0.003D,
                            -0.003D,
                            -0.003D,
                            -0.003D
                        },
                        ChangeFromPrevious = new List<double>
                        {
                            1.021E-05D,
                            3.398E-05D,
                            4.496E-05D,
                            4.921E-05D,
                            5.434E-05D,
                            6.229E-05D,
                            7.173E-05D,
                            8.025E-05D,
                            8.676E-05D,
                            9.379E-05D,
                            0.00010978D
                        }
                    },
                    ClassALoadingRange = new LoadingRange
                    {
                        Minimum = 1000D,
                        Maximum = 50000D,
                        LowerLimitFittedCurveValue = -0.0815718173593594D,
                        LowerLimitFittedPrevCurveValue = -0.081582032796634091D,
                        LowerLimitFittedChangeFromPrev = -0.013D
                    },
                    ClassAALoadingRange = new LoadingRange
                    {
                        Minimum = 1207D,
                        Maximum = 50000D,
                        LowerLimitFittedCurveValue = -0.098457344193754848D,
                        LowerLimitFittedPrevCurveValue = -0.098469316403729121D,
                        LowerLimitFittedChangeFromPrev = -0.012D
                    },
                    DegreeFit = 5,
                    LowerLimitFactor = 0.6035D,
                    StandardDeviationDeflection = 2.05E-05D,
                    StandardDeviationDeflectionAverage = 5.3465552282402147E-06D,
                    StandardDeviationLoad = 0.25143953719762485D,
                    Resolution = 0.0001D
                }
            };

    }
}
