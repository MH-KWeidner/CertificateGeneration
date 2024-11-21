using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateGeneration.Shared
{
    public enum Units
    {
        None,
        Ounces,
        Pounds,
        Tons,
        Newtons,
        Decanewtons,
        Kilonewtons,
        Grams,
        Kilograms
    }

    public class Enumerations { }
    
    // TODO implement this as needed
    
    // {
        //public enum Units
        //{
        //    [NoUnits("As Calibrated")]
        //    None = 0,

        //    [ForceAbbreviation("ozf")]
        //    [MassAbbreviation("oz")]
        //    Ounces,
        //    [ForceAbbreviation("lbf")]
        //    [MassAbbreviation("lbs")]
        //    Pounds,
        //    [ForceAbbreviation("tonf")]
        //    [MassAbbreviation("ton")]
        //    Tons,

        //    [ForceAbbreviation("N")]
        //    Newtons,
        //    [ForceAbbreviation("daN")]
        //    Decanewtons,
        //    [ForceAbbreviation("kN")]
        //    Kilonewtons,

        //    [ForceAbbreviation("gf")]
        //    [MassAbbreviation("g")]
        //    Grams,
        //    [ForceAbbreviation("kgf")]
        //    [MassAbbreviation("kg")]
        //    Kilograms,
        //}
        ///// <summary>
        ///// Translates from a string representation of the units to the <see cref="Units"/>.
        ///// </summary>
        ///// 
        ///// <param name="units">A string representation of a <see cref="Units"/></param>
        ///// 
        ///// <returns>The corresponding <see cref="Units"/> or <see cref="Data.Enums.Units.None"/> if it's unrecognized.</returns>
        //public static Units GetUnitsFromString(string units) => units.ToUpper() switch
        //{
        //    "OZ" or "OZF" => Units.Ounces,
        //    "LB" or "LBS" or "LBF" => Units.Pounds,
        //    "TON" or "TONF" => Units.Tons,
        //    "N" => Units.Newtons,
        //    "DAN" => Units.Decanewtons,
        //    "KN" => Units.Kilonewtons,
        //    "G" or "GF" => Units.Grams,
        //    "KG" or "KGF" => Units.Kilograms,
        //    _ => Units.None
        //};

        //public class ForceAbbreviationAttribute : Attribute
        //{
        //    public string Abbreviation;

        //    public ForceAbbreviationAttribute(string abbreviation)
        //    {
        //        Abbreviation = abbreviation;
        //    }
        //}
        //public class MassAbbreviationAttribute : Attribute
        //{
        //    public string Abbreviation;

        //    public MassAbbreviationAttribute(string abbreviation)
        //    {
        //        Abbreviation = abbreviation;
        //    }
        //}
        //public class NoUnitsAttribute : Attribute
        //{
        //    public string Description;

        //    public NoUnitsAttribute(string description)
        //    {
        //        Description = description;
        //    }
        //}
    //}
    
}
