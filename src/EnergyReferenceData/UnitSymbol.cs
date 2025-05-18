// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// The coded representation of different units from IEC 61970.
/// </summary>
/// <remarks>
/// MXM000
/// </remarks>
public enum UnitSymbol
{
    /// <summary>
    /// Ampere
    /// </summary>
    /// <remarks>
    /// The unit of electrical current in the International system of Units (SI) equivalent to one Coulomb per second.
    /// </remarks>
    AMP = 1,

    /// <summary>
    /// One
    /// </summary>
    /// <remarks>
    /// A unit for dimensionless quantities, also called quantities of dimension one.
    /// </remarks>
    C62 = 2,

    /// <summary>
    /// degree (unit of angle)
    /// </summary>
    /// <remarks>
    /// A unit of measurement of angles expressed in a 0 to 360 degree gradient.
    /// </remarks>
    DD = 3,

    /// <summary>
    /// grams per kilowatt hour
    /// </summary>
    /// <remarks>
    /// It represents the mass rate of emissions per unit of work accomplished.
    /// </remarks>
    GKH = 4,

    /// <summary>
    /// Hertz
    /// </summary>
    /// <remarks>
    /// HTZ unit as per UN/CEFACT recommendation 20
    /// </remarks>
    HTZ = 5,

    /// <summary>
    /// kV
    /// </summary>
    /// <remarks>
    /// The symbol of kV
    /// </remarks>
    KVT = 6,

    /// <summary>
    /// MVAr
    /// </summary>
    /// <remarks>
    /// The symbol of MVAr
    /// </remarks>
    MAR = 7,

    /// <summary>
    /// MW
    /// </summary>
    /// <remarks>
    /// The symbol of MW
    /// </remarks>
    MAW = 8,

    /// <summary>
    /// megavolt-ampere
    /// </summary>
    /// <remarks>
    /// MVA unit as per UN/CEFACT recommendation 20
    /// </remarks>
    MVA = 9,

    /// <summary>
    /// Ohm
    /// </summary>
    /// <remarks>
    /// The symbol of Ohm Unit
    /// </remarks>
    OHM = 10,

    /// <summary>
    /// Percent
    /// </summary>
    /// <remarks>
    /// A unit of proportion equal to 0.01.
    /// </remarks>
    P1 = 11
}

