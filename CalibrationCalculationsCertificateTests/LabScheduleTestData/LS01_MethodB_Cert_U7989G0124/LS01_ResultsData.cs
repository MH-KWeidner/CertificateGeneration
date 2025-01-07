using System.Globalization;

using static CalibrationCalculationsCertificateTests.LabScheduleModels.LabAnalysisSingleRunResult;

namespace CalibrationCalculationsCertificateTests.LabScheduleTestData.LS01_MethodB_Cert_U7989G0124;

public class LS01_ResultsData : ILabScheduleRunResults
{
    // Building this certificate:
    // CALIBRATION & ISSUE DATE: 07/01/2024
    // REPORT NO.: U-7989G0124

    public List<LabAnalysisSingleRunResult> LabScheduleRunResults =>

        new List<LabAnalysisSingleRunResult>
        {
            new LabAnalysisSingleRunResult
            {
                LabObject = new LabAnalysisObject
    {
        TaskID = 58886,
        DecimalPlaces = 0,
        Method = "Method B",
        InstrumentType = "Load Cell",
        InstrumentCapacity = 50000.00000000m,
        DataDirection = "Ascending",
        MaxForceApplied = 50000.00000000m,
        Readability = 0.00000001m,
        NonRepeatabilityList = new List<decimal>(),
        CompressionTensionType = "C",
        UnitsOfForce = "lbf",
        ReportNumber = "U-7989G0124",
        AssignedAccuracyStr = "** Not Assigned",
        ReadOnInstrument = new UnitsReadOnInstrument
        {
            UnitsReadOnInstrumentID = 25,
            Description = "mV/V"
        },
        SecondaryStandardList = new List<SecondaryStandard>
        {
            new SecondaryStandard
            {
                SecondaryStandardID = 410993,
                LabTaskID = 58886,
                StandardID = 18
            }
        },
        Indicators = new List<Indicator>
        {
            new Indicator
            {
                IndicatorID = 5163,
                IndicatorSerialNumber = "61151",
                IndicatorManufacturer = "MOREHOUSE",
                CustomerID = 8240,
                CustomerRefNo = "KLD77125000001",
                IndicatorModelNo = "4215",
                HasChanges = true,
                ObjectStatus = ObjStatus.New
            }
        },
        Data = new List<LabData>
        {
            new LabData
            {
                LabdataRunList = new List<LabdataRun>
                {
                    new LabdataRun
                    {
                        RunNumber = 1,
                        LabdataStandardList = new List<LabdataStandard>
                        {
                            new LabdataStandard
                            {
                                PrimaryStandardId = 11,
                                NumExclusions = 1,
                                ExclusionIndex = new List<int>
                                {
                                    12
                                },
                                LabdataStandardResponseList = new List<LabdataStandardResponse>
                                {
                                    new LabdataStandardResponse
                                    {
                                        NumExclusions = 1,
                                        ExclusionIndex = new List<int>
                                        {
                                            11
                                        },
                                        LabdataResponseList = new List<LabdataResponse>
                                        {
                                            new LabdataResponse
                                            {
                                                Value = -0.00001000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 1000.00000000m,
                                                Value = -0.08158000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 5000.00000000m,
                                                Value = -0.40790000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 10000.00000000m,
                                                Value = -0.81587000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 15000.00000000m,
                                                Value = -1.22393000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 20000.00000000m,
                                                Value = -1.63206000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 25000.00000000m,
                                                Value = -2.04025000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 30000.00000000m,
                                                Value = -2.44850000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 35000.00000000m,
                                                Value = -2.85679000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 40000.00000000m,
                                                Value = -3.26509000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 45000.00000000m,
                                                Value = -3.67343000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 50000.00000000m,
                                                Value = -4.08171000m
                                            },
                                            new LabdataResponse
                                            {
                                                Value = -0.00005000m
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new LabdataRun
                    {
                        RunNumber = 2,
                        LabdataStandardList = new List<LabdataStandard>
                        {
                            new LabdataStandard
                            {
                                PrimaryStandardId = 11,
                                NumExclusions = 1,
                                ExclusionIndex = new List<int>
                                {
                                    12
                                },
                                LabdataStandardResponseList = new List<LabdataStandardResponse>
                                {
                                    new LabdataStandardResponse
                                    {
                                        NumExclusions = 1,
                                        ExclusionIndex = new List<int>
                                        {
                                            11
                                        },
                                        LabdataResponseList = new List<LabdataResponse>
                                        {
                                            new LabdataResponse(),
                                            new LabdataResponse
                                            {
                                                ForceApplied = 1000.00000000m,
                                                Value = -0.08157000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 5000.00000000m,
                                                Value = -0.40791000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 10000.00000000m,
                                                Value = -0.81588000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 15000.00000000m,
                                                Value = -1.22395000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 20000.00000000m,
                                                Value = -1.63208000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 25000.00000000m,
                                                Value = -2.04028000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 30000.00000000m,
                                                Value = -2.44853000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 35000.00000000m,
                                                Value = -2.85682000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 40000.00000000m,
                                                Value = -3.26513000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 45000.00000000m,
                                                Value = -3.67346000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 50000.00000000m,
                                                Value = -4.08175000m
                                            },
                                            new LabdataResponse
                                            {
                                                Value = -0.00003000m
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new LabdataRun
                    {
                        RunNumber = 3,
                        LabdataStandardList = new List<LabdataStandard>
                        {
                            new LabdataStandard
                            {
                                PrimaryStandardId = 11,
                                NumExclusions = 1,
                                ExclusionIndex = new List<int>
                                {
                                    12
                                },
                                LabdataStandardResponseList = new List<LabdataStandardResponse>
                                {
                                    new LabdataStandardResponse
                                    {
                                        NumExclusions = 1,
                                        ExclusionIndex = new List<int>
                                        {
                                            11
                                        },
                                        LabdataResponseList = new List<LabdataResponse>
                                        {
                                            new LabdataResponse
                                            {
                                                Value = -0.00001000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 1000.00000000m,
                                                Value = -0.08158000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 5000.00000000m,
                                                Value = -0.40791000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 10000.00000000m,
                                                Value = -0.81589000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 15000.00000000m,
                                                Value = -1.22396000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 20000.00000000m,
                                                Value = -1.63209000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 25000.00000000m,
                                                Value = -2.04028000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 30000.00000000m,
                                                Value = -2.44853000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 35000.00000000m,
                                                Value = -2.85681000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 40000.00000000m,
                                                Value = -3.26513000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 45000.00000000m,
                                                Value = -3.67345000m
                                            },
                                            new LabdataResponse
                                            {
                                                ForceApplied = 50000.00000000m,
                                                Value = -4.08171000m
                                            },
                                            new LabdataResponse
                                            {
                                                Value = -0.00003000m
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        },
        AsReceivedAsReturned = AsReceivedAsReturned.AsReceivedAsReturned,
        InstrumentItemID = 57775,
        Capacity = 50000.00000000m,
        SerialNumber = "U-7989",
        InstrumentReadingPrecision = 8,
        ExpandedUncertaintyPrecision = 3
    },
                Runs = new List<SingleRun>
                {
                    new SingleRun
                    {
                        NormalizedData = new List<SingleRunPoint>
                        {
                            new SingleRunPoint
                            {
                                ForceApplied = 1000m,
                                Value = -0.08157000m,
                                PreNormValue = -0.08158000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.002m,
                                Hysterisis = -1m,
                                SEBError = -0.0013279358060934544949683500m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.016m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 5000m,
                                Value = -0.40788636m,
                                PreNormValue = -0.40790000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.007m,
                                Hysterisis = -1m,
                                SEBError = -0.0057487667311649500279303500m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.08m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 10000m,
                                Value = -0.81585273m,
                                PreNormValue = -0.81587000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.012m,
                                Hysterisis = -1m,
                                SEBError = -0.009537085358172066750652200m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.16m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 15000m,
                                Value = -1.22390909m,
                                PreNormValue = -1.22393000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.014m,
                                Hysterisis = -1m,
                                SEBError = -0.0111204205469444200796018500m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.24m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 20000m,
                                Value = -1.63203545m,
                                PreNormValue = -1.63206000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.015m,
                                Hysterisis = -1m,
                                SEBError = -0.0109885780417904100619123900m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.32m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 25000m,
                                Value = -2.04022182m,
                                PreNormValue = -2.04025000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.015m,
                                Hysterisis = -1m,
                                SEBError = -0.0093863382021718134094827500m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.4m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 30000m,
                                Value = -2.44846818m,
                                PreNormValue = -2.44850000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.013m,
                                Hysterisis = -1m,
                                SEBError = -0.0063141910788583233689833900m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.48m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 35000m,
                                Value = -2.85675455m,
                                PreNormValue = -2.85679000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.010m,
                                Hysterisis = -1m,
                                SEBError = -0.0022616973907734933642121600m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.56m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 40000m,
                                Value = -3.26505091m,
                                PreNormValue = -3.26509000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.007m,
                                Hysterisis = -1m,
                                SEBError = 0.0020355766567731133524579900m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.64m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 45000m,
                                Value = -3.67338727m,
                                PreNormValue = -3.67343000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.003m,
                                Hysterisis = -1m,
                                SEBError = 0.0073129522437062134100647800m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.72m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 50000m,
                                Value = -4.08166364m,
                                PreNormValue = -4.08171000m,
                                Error1 = -123456789.987654m,
                                Hysterisis = -1m,
                                SEBError = 0.0111204205469444200796018500m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.8m,
                                PFA = 100D
                            }
                        },
                        Resolution = 0.0001m,
                        MaxHysteresis = -1m,
                        MaxNonLinearity = 0.015m,
                        SEBPercentage = -0.0111204205469444200796018500m,
                        SEBOutput = -4.08120979m,
                        BeginningZero = -0.00001000m,
                        EndingZero = -0.00005000m
                    },
                    new SingleRun
                    {
                        NormalizedData = new List<SingleRunPoint>
                        {
                            new SingleRunPoint
                            {
                                ForceApplied = 1000m,
                                Value = -0.08157000m,
                                PreNormValue = -0.08157000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.002m,
                                Hysterisis = -1m,
                                SEBError = -0.0013622547417207090334628300m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.016m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 5000m,
                                Value = -0.40790727m,
                                PreNormValue = -0.40791000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.006m,
                                Hysterisis = -1m,
                                SEBError = -0.0054080374247866804499713100m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.08m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 10000m,
                                Value = -0.81587455m,
                                PreNormValue = -0.81588000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.012m,
                                Hysterisis = -1m,
                                SEBError = -0.0093457027631083696010471700m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.16m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 15000m,
                                Value = -1.22394182m,
                                PreNormValue = -1.22395000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.014m,
                                Hysterisis = -1m,
                                SEBError = -0.010833401347128534339915800m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.24m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 20000m,
                                Value = -1.63206909m,
                                PreNormValue = -1.63208000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.015m,
                                Hysterisis = -1m,
                                SEBError = -0.0108509728658612556871209200m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.32m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 25000m,
                                Value = -2.04026636m,
                                PreNormValue = -2.04028000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.015m,
                                Hysterisis = -1m,
                                SEBError = -0.0091533961417586264107186200m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.4m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 30000m,
                                Value = -2.44851364m,
                                PreNormValue = -2.44853000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.013m,
                                Hysterisis = -1m,
                                SEBError = -0.0062304685087389130673647800m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.48m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 35000m,
                                Value = -2.85680091m,
                                PreNormValue = -2.85682000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.010m,
                                Hysterisis = -1m,
                                SEBError = -0.0023277011867051187034672200m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.56m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 40000m,
                                Value = -3.26510818m,
                                PreNormValue = -3.26513000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.007m,
                                Hysterisis = -1m,
                                SEBError = 0.0020651084904244901243181800m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.64m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 45000m,
                                Value = -3.67343545m,
                                PreNormValue = -3.67346000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.003m,
                                Hysterisis = -1m,
                                SEBError = 0.0069479605226499134159914100m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.72m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 50000m,
                                Value = -4.08172273m,
                                PreNormValue = -4.08175000m,
                                Error1 = -123456789.987654m,
                                Hysterisis = -1m,
                                SEBError = 0.0108509728658612556871209200m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.8m,
                                PFA = 100D
                            }
                        },
                        Resolution = 0.0001m,
                        MaxHysteresis = -1m,
                        MaxNonLinearity = 0.015m,
                        SEBPercentage = -0.0108509728658612556871209200m,
                        SEBOutput = -4.08127987m,
                        EndingZero = -0.00003000m
                    },
                    new SingleRun
                    {
                        NormalizedData = new List<SingleRunPoint>
                        {
                            new SingleRunPoint
                            {
                                ForceApplied = 1000m,
                                Value = -0.08157000m,
                                PreNormValue = -0.08158000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.002m,
                                Hysterisis = -1m,
                                SEBError = -0.0013481424248877140589151600m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.016m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 5000m,
                                Value = -0.40789818m,
                                PreNormValue = -0.40791000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.007m,
                                Hysterisis = -1m,
                                SEBError = -0.0055601917554552564544796600m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.08m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 10000m,
                                Value = -0.81587636m,
                                PreNormValue = -0.81589000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.011m,
                                Hysterisis = -1m,
                                SEBError = -0.0091602002498340266655452400m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.16m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 15000m,
                                Value = -1.22394455m,
                                PreNormValue = -1.22396000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.014m,
                                Hysterisis = -1m,
                                SEBError = -0.0105547575525941152919895500m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.24m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 20000m,
                                Value = -1.63207273m,
                                PreNormValue = -1.63209000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.015m,
                                Hysterisis = -1m,
                                SEBError = -0.0104794224324544737966537200m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.32m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 25000m,
                                Value = -2.04026091m,
                                PreNormValue = -2.04028000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.014m,
                                Hysterisis = -1m,
                                SEBError = -0.0089339498665074676187573300m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.4m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 30000m,
                                Value = -2.44850909m,
                                PreNormValue = -2.44853000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.012m,
                                Hysterisis = -1m,
                                SEBError = -0.0059183398547530967583003800m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.48m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 35000m,
                                Value = -2.85678727m,
                                PreNormValue = -2.85681000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.010m,
                                Hysterisis = -1m,
                                SEBError = -0.0021676611200950435565631400m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.56m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 40000m,
                                Value = -3.26510545m,
                                PreNormValue = -3.26513000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.006m,
                                Hysterisis = -1m,
                                SEBError = 0.0025631092451012527668811300m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.64m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 45000m,
                                Value = -3.67342364m,
                                PreNormValue = -3.67345000m,
                                Error1 = -123456789.987654m,
                                NonLinearity = 0.002m,
                                Hysterisis = -1m,
                                SEBError = 0.0072941246332051836511058400m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.72m,
                                PFA = 100D
                            },
                            new SingleRunPoint
                            {
                                ForceApplied = 50000m,
                                Value = -4.08168182m,
                                PreNormValue = -4.08171000m,
                                Error1 = -123456789.987654m,
                                Hysterisis = -1m,
                                SEBError = 0.0105547575525941152919895500m,
                                Resolution = 0.0001m,
                                Median = 0.010m,
                                Standard = new Standard
                                {
                                    StandardID = 11,
                                    Description = "M-7471",
                                    MaxCapacity = 120000.00000000m,
                                    Nist = "822/268391-03",
                                    StandardTypeID = 1,
                                    ModelNumber = "null",
                                    MaxUncertainty = 0.00160000m,
                                    CertDescription = "",
                                    DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                                    CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
                                },
                                Uncertainties = new List<UncertaintyObject>
                                {
                                    new UncertaintyObject(),
                                    new UncertaintyObject
                                    {
                                        Mode = UncertaintyContributor.Hysterisis
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ReferenceStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.Resolution
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.SecondaryStandard
                                    },
                                    new UncertaintyObject
                                    {
                                        Type = UncertaintyType.B,
                                        Mode = UncertaintyContributor.ElectricalStandard
                                    }
                                },
                                ExpandedUncertainty = 0.8m,
                                PFA = 100D
                            }
                        },
                        Resolution = 0.0001m,
                        MaxHysteresis = -1m,
                        MaxNonLinearity = 0.015m,
                        SEBPercentage = -0.0105547575525941152919895500m,
                        SEBOutput = -4.08125105m,
                        BeginningZero = -0.00001000m,
                        EndingZero = -0.00003000m
                    }
                },
                MeanRun = new SingleRun
                {
                    NormalizedData = new List<SingleRunPoint>
                    {
                        new SingleRunPoint
                        {
                            ForceApplied = 1000.00000000m,
                            Value = -0.08157000m,
                            Error1 = -1000.08157000m,
                            NonLinearity = 0.002m,
                            Hysterisis = -1m,
                            SEBError = -0.001m,
                            Resolution = 0.0001225940909648154958930980m,
                            ExpandedUncertainty = 0.016m
                        },
                        new SingleRunPoint
                        {
                            ForceApplied = 5000.00000000m,
                            Value = -0.40789727m,
                            Error1 = -5000.40789727m,
                            NonLinearity = 0.007m,
                            Hysterisis = -1m,
                            SEBError = -0.006m,
                            Resolution = 0.0001225798839006694013911885m,
                            ExpandedUncertainty = 0.08m
                        },
                        new SingleRunPoint
                        {
                            ForceApplied = 10000.00000000m,
                            Value = -0.81586788m,
                            Error1 = -10000.81586788m,
                            NonLinearity = 0.012m,
                            Hysterisis = -1m,
                            SEBError = -0.009m,
                            Resolution = 0.0001225688649490650373440366m,
                            ExpandedUncertainty = 0.16m
                        },
                        new SingleRunPoint
                        {
                            ForceApplied = 15000.00000000m,
                            Value = -1.22393182m,
                            Error1 = -15001.22393182m,
                            NonLinearity = 0.014m,
                            Hysterisis = -1m,
                            SEBError = -0.011m,
                            Resolution = 0.0001225558462888888696430819m,
                            ExpandedUncertainty = 0.24m
                        },
                        new SingleRunPoint
                        {
                            ForceApplied = 20000.00000000m,
                            Value = -1.63205909m,
                            Error1 = -20001.63205909m,
                            NonLinearity = 0.015m,
                            Hysterisis = -1m,
                            SEBError = -0.011m,
                            Resolution = 0.0001225445826229245167832741m,
                            ExpandedUncertainty = 0.32m
                        },
                        new SingleRunPoint
                        {
                            ForceApplied = 25000.00000000m,
                            Value = -2.0402496966666666666666666667m,
                            Error1 = -25002.040249696666666666666667m,
                            NonLinearity = 0.015m,
                            Hysterisis = -1m,
                            SEBError = -0.009m,
                            Resolution = 0.0001225340214035795412747429m,
                            ExpandedUncertainty = 0.4m
                        },
                        new SingleRunPoint
                        {
                            ForceApplied = 30000.00000000m,
                            Value = -2.44849697m,
                            Error1 = -30002.44849697m,
                            NonLinearity = 0.013m,
                            Hysterisis = -1m,
                            SEBError = -0.006m,
                            Resolution = 0.0001225241459049058982498965m,
                            ExpandedUncertainty = 0.48m
                        },
                        new SingleRunPoint
                        {
                            ForceApplied = 35000.00000000m,
                            Value = -2.85678091m,
                            Error1 = -35002.85678091m,
                            NonLinearity = 0.010m,
                            Hysterisis = -1m,
                            SEBError = -0.002m,
                            Resolution = 0.0001225155204499038744976772m,
                            ExpandedUncertainty = 0.56m
                        },
                        new SingleRunPoint
                        {
                            ForceApplied = 40000.00000000m,
                            Value = -3.26508818m,
                            Error1 = -40003.26508818m,
                            NonLinearity = 0.007m,
                            Hysterisis = -1m,
                            SEBError = 0.002m,
                            Resolution = 0.0001225081767929465231165671m,
                            ExpandedUncertainty = 0.64m
                        },
                        new SingleRunPoint
                        {
                            ForceApplied = 45000.00000000m,
                            Value = -3.6734154533333333333333333333m,
                            Error1 = -45003.673415453333333333333333m,
                            NonLinearity = 0.003m,
                            Hysterisis = -1m,
                            SEBError = 0.007m,
                            Resolution = 0.0001225017985895553064568694m,
                            ExpandedUncertainty = 0.72m
                        },
                        new SingleRunPoint
                        {
                            ForceApplied = 50000.00000000m,
                            Value = -4.0816893966666666666666666667m,
                            Error1 = -50004.081689396666666666666667m,
                            Hysterisis = -1m,
                            SEBError = 0.011m,
                            Resolution = 0.0001224982970062169984534810m,
                            ExpandedUncertainty = 0.8m
                        }
                    },
                    Resolution = 0.0001m,
                    MaxHysteresis = -1m,
                    MaxNonLinearity = 0.015m,
                    MaxNonRepeatability = -1m,
                    SEBPercentage = 0.011m,
                    SEBOutput = -4.08124690m
                },
                MaxResolutionDigits = 4,
                MaxNonRepeatability = -1m
            }
        };
}
