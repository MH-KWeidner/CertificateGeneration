namespace CertificateGeneration.Shared
{
    /// <summary>
    /// Defines the Units
    /// </summary>
    public enum Units
    {
        /// <summary>
        /// Defines the None
        /// </summary>
        None,

        /// <summary>
        /// Defines the Ounces
        /// </summary>
        Ounces,

        /// <summary>
        /// Defines the Pounds
        /// </summary>
        Pounds,

        /// <summary>
        /// Defines the Tons
        /// </summary>
        Tons,

        /// <summary>
        /// Defines the Newtons
        /// </summary>
        Newtons,

        /// <summary>
        /// Defines the Decanewtons
        /// </summary>
        Decanewtons,

        /// <summary>
        /// Defines the Kilonewtons
        /// </summary>
        Kilonewtons,

        /// <summary>
        /// Defines the Grams
        /// </summary>
        Grams,

        /// <summary>
        /// Defines the Kilograms
        /// </summary>
        Kilograms
    }

    /// <summary>
    /// Defines the <see cref="Enumerations" />
    /// </summary>
    public class Enumerations
    {
    }

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
