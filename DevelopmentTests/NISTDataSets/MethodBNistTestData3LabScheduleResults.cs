using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentTests.NISTDataSets
{
    public class MethodBNistTestData3LabScheduleResults
    {
    //    var singleRun = new SingleRun
    //    {
    //        NormalizedData = new List<SingleRunPoint>
    //{
    //    new SingleRunPoint
    //    {
    //        ForceApplied = 1000.00000000m,
    //        Value = -0.08157m,
    //        PreNormValue = -0.08157000m,
    //        Standard = new Standard
    //        {
    //            StandardID = 11,
    //            Description = "M-7471",
    //            MaxCapacity = 120000.00000000m,
    //            Nist = "822/268391-03",
    //            StandardTypeID = 1,
    //            ModelNumber = "null",
    //            MaxUncertainty = 0.00160000m,
    //            CertDescription = "",
    //            DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
    //            CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
    //        },
    //        Uncertainties = new List<UncertaintyObject>
    //        {
    //            new UncertaintyObject(),
    //            new UncertaintyObject
    //            {
    //                Mode = UncertaintyContributor.Hysterisis
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.ReferenceStandard
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.Resolution
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.SecondaryStandard
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.ElectricalStandard
    //            }
    //        }
    //    },
    //    new SingleRunPoint
    //    {
    //        ForceApplied = 5000.00000000m,
    //        Value = -0.40791m,
    //        PreNormValue = -0.40791000m,
    //        Standard = new Standard
    //        {
    //            StandardID = 11,
    //            Description = "M-7471",
    //            MaxCapacity = 120000.00000000m,
    //            Nist = "822/268391-03",
    //            StandardTypeID = 1,
    //            ModelNumber = "null",
    //            MaxUncertainty = 0.00160000m,
    //            CertDescription = "",
    //            DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
    //            CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
    //        },
    //        Uncertainties = new List<UncertaintyObject>
    //        {
    //            new UncertaintyObject(),
    //            new UncertaintyObject
    //            {
    //                Mode = UncertaintyContributor.Hysterisis
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.ReferenceStandard
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.Resolution
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.SecondaryStandard
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.ElectricalStandard
    //            }
    //        }
    //    },
    //    new SingleRunPoint
    //    {
    //        ForceApplied = 10000.00000000m,
    //        Value = -0.81587m,
    //        PreNormValue = -0.81588000m,
    //        Standard = new Standard
    //        {
    //            StandardID = 11,
    //            Description = "M-7471",
    //            MaxCapacity = 120000.00000000m,
    //            Nist = "822/268391-03",
    //            StandardTypeID = 1,
    //            ModelNumber = "null",
    //            MaxUncertainty = 0.00160000m,
    //            CertDescription = "",
    //            DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
    //            CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
    //        },
    //        Uncertainties = new List<UncertaintyObject>
    //        {
    //            new UncertaintyObject(),
    //            new UncertaintyObject
    //            {
    //                Mode = UncertaintyContributor.Hysterisis
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.ReferenceStandard
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.Resolution
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.SecondaryStandard
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.ElectricalStandard
    //            }
    //        }
    //    },
    //    new SingleRunPoint
    //    {
    //        ForceApplied = 15000.00000000m,
    //        Value = -1.22394m,
    //        PreNormValue = -1.22395000m,
    //        Standard = new Standard
    //        {
    //            StandardID = 11,
    //            Description = "M-7471",
    //            MaxCapacity = 120000.00000000m,
    //            Nist = "822/268391-03",
    //            StandardTypeID = 1,
    //            ModelNumber = "null",
    //            MaxUncertainty = 0.00160000m,
    //            CertDescription = "",
    //            DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
    //            CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
    //        },
    //        Uncertainties = new List<UncertaintyObject>
    //        {
    //            new UncertaintyObject(),
    //            new UncertaintyObject
    //            {
    //                Mode = UncertaintyContributor.Hysterisis
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.ReferenceStandard
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.Resolution
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.SecondaryStandard
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.ElectricalStandard
    //            }
    //        }
    //    },
    //    new SingleRunPoint
    //    {
    //        ForceApplied = 20000.00000000m,
    //        Value = -1.63207m,
    //        PreNormValue = -1.63208000m,
    //        Standard = new Standard
    //        {
    //            StandardID = 11,
    //            Description = "M-7471",
    //            MaxCapacity = 120000.00000000m,
    //            Nist = "822/268391-03",
    //            StandardTypeID = 1,
    //            ModelNumber = "null",
    //            MaxUncertainty = 0.00160000m,
    //            CertDescription = "",
    //            DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
    //            CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
    //        },
    //        Uncertainties = new List<UncertaintyObject>
    //        {
    //            new UncertaintyObject(),
    //            new UncertaintyObject
    //            {
    //                Mode = UncertaintyContributor.Hysterisis
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.ReferenceStandard
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.Resolution
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.SecondaryStandard
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.ElectricalStandard
    //            }
    //        }
    //    },
    //    new SingleRunPoint
    //    {
    //        ForceApplied = 25000.00000000m,
    //        Value = -2.04027m,
    //        PreNormValue = -2.04028000m,
    //        Standard = new Standard
    //        {
    //            StandardID = 11,
    //            Description = "M-7471",
    //            MaxCapacity = 120000.00000000m,
    //            Nist = "822/268391-03",
    //            StandardTypeID = 1,
    //            ModelNumber = "null",
    //            MaxUncertainty = 0.00160000m,
    //            CertDescription = "",
    //            DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
    //            CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
    //        },
    //        Uncertainties = new List<UncertaintyObject>
    //        {
    //            new UncertaintyObject(),
    //            new UncertaintyObject
    //            {
    //                Mode = UncertaintyContributor.Hysterisis
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.ReferenceStandard
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.Resolution
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.SecondaryStandard
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.ElectricalStandard
    //            }
    //        }
    //    },
    //    new SingleRunPoint
    //    {
    //        ForceApplied = 30000.00000000m,
    //        Value = -2.44851m,
    //        PreNormValue = -2.44853000m,
    //        Standard = new Standard
    //        {
    //            StandardID = 11,
    //            Description = "M-7471",
    //            MaxCapacity = 120000.00000000m,
    //            Nist = "822/268391-03",
    //            StandardTypeID = 1,
    //            ModelNumber = "null",
    //            MaxUncertainty = 0.00160000m,
    //            CertDescription = "",
    //            DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
    //            CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
    //        },
    //        Uncertainties = new List<UncertaintyObject>
    //        {
    //            new UncertaintyObject(),
    //            new UncertaintyObject
    //            {
    //                Mode = UncertaintyContributor.Hysterisis
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.ReferenceStandard
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.Resolution
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.SecondaryStandard
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.ElectricalStandard
    //            }
    //        }
    //    },
    //    new SingleRunPoint
    //    {
    //        ForceApplied = 35000.00000000m,
    //        Value = -2.85680m,
    //        PreNormValue = -2.85682000m,
    //        Standard = new Standard
    //        {
    //            StandardID = 11,
    //            Description = "M-7471",
    //            MaxCapacity = 120000.00000000m,
    //            Nist = "822/268391-03",
    //            StandardTypeID = 1,
    //            ModelNumber = "null",
    //            MaxUncertainty = 0.00160000m,
    //            CertDescription = "",
    //            DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
    //            CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
    //        },
    //        Uncertainties = new List<UncertaintyObject>
    //        {
    //            new UncertaintyObject(),
    //            new UncertaintyObject
    //            {
    //                Mode = UncertaintyContributor.Hysterisis
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.ReferenceStandard
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.Resolution
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.SecondaryStandard
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.ElectricalStandard
    //            }
    //        }
    //    },
    //    new SingleRunPoint
    //    {
    //        ForceApplied = 40000.00000000m,
    //        Value = -3.26511m,
    //        PreNormValue = -3.26513000m,
    //        Standard = new Standard
    //        {
    //            StandardID = 11,
    //            Description = "M-7471",
    //            MaxCapacity = 120000.00000000m,
    //            Nist = "822/268391-03",
    //            StandardTypeID = 1,
    //            ModelNumber = "null",
    //            MaxUncertainty = 0.00160000m,
    //            CertDescription = "",
    //            DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
    //            CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
    //        },
    //        Uncertainties = new List<UncertaintyObject>
    //        {
    //            new UncertaintyObject(),
    //            new UncertaintyObject
    //            {
    //                Mode = UncertaintyContributor.Hysterisis
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.ReferenceStandard
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.Resolution
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.SecondaryStandard
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.ElectricalStandard
    //            }
    //        }
    //    },
    //    new SingleRunPoint
    //    {
    //        ForceApplied = 45000.00000000m,
    //        Value = -3.67344m,
    //        PreNormValue = -3.67346000m,
    //        Standard = new Standard
    //        {
    //            StandardID = 11,
    //            Description = "M-7471",
    //            MaxCapacity = 120000.00000000m,
    //            Nist = "822/268391-03",
    //            StandardTypeID = 1,
    //            ModelNumber = "null",
    //            MaxUncertainty = 0.00160000m,
    //            CertDescription = "",
    //            DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
    //            CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
    //        },
    //        Uncertainties = new List<UncertaintyObject>
    //        {
    //            new UncertaintyObject(),
    //            new UncertaintyObject
    //            {
    //                Mode = UncertaintyContributor.Hysterisis
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.ReferenceStandard
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.Resolution
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.SecondaryStandard
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.ElectricalStandard
    //            }
    //        }
    //    },
    //    new SingleRunPoint
    //    {
    //        ForceApplied = 50000.00000000m,
    //        Value = -4.08172m,
    //        PreNormValue = -4.08175000m,
    //        Standard = new Standard
    //        {
    //            StandardID = 11,
    //            Description = "M-7471",
    //            MaxCapacity = 120000.00000000m,
    //            Nist = "822/268391-03",
    //            StandardTypeID = 1,
    //            ModelNumber = "null",
    //            MaxUncertainty = 0.00160000m,
    //            CertDescription = "",
    //            DateCalibrated = DateTime.ParseExact("2003-11-05T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
    //            CalibrationDueDate = DateTime.ParseExact("2030-06-03T00:00:00.0000000", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)
    //        },
    //        Uncertainties = new List<UncertaintyObject>
    //        {
    //            new UncertaintyObject(),
    //            new UncertaintyObject
    //            {
    //                Mode = UncertaintyContributor.Hysterisis
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.ReferenceStandard
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.Resolution
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.SecondaryStandard
    //            },
    //            new UncertaintyObject
    //            {
    //                Type = UncertaintyType.B,
    //                Mode = UncertaintyContributor.ElectricalStandard
    //            }
    //        }
    //    }
    //},
    //        EndingZero = -0.00003000m
    //    };

    }
}
