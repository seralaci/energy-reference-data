// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// The contract type defines the conditions under which the capacity is allocated and handled, e.g. daily auction, weekly auction, monthly auction, yearly auction, etc. 	/// The significance of this type is dependent on area specific coded working methods.
/// </summary>
/// <remarks>
/// ET0010
/// </remarks>
public enum ContractType
{
    /// <summary>
    /// Daily contract
    /// </summary>
    /// <remarks>
    /// The condition under which capacity is allocated and handled is by daily auction or a daily transmission allocation procedure.
    /// </remarks>
    A01 = 1,

    /// <summary>
    /// Weekly contract
    /// </summary>
    /// <remarks>
    /// The condition under which capacity is allocated and handled is by weekly auction or a weekly transmission allocation procedure.
    /// </remarks>
    A02 = 2,

    /// <summary>
    /// Monthly contract
    /// </summary>
    /// <remarks>
    /// The condition under which capacity is allocated and handled is by monthly auction or a monthly transmission allocation procedure.
    /// </remarks>
    A03 = 3,

    /// <summary>
    /// Yearly contract
    /// </summary>
    /// <remarks>
    /// The condition under which capacity is allocated and handled is by yearly auction or a yearly transmission allocation procedure.
    /// </remarks>
    A04 = 4,

    /// <summary>
    /// Total contract
    /// </summary>
    /// <remarks>
    /// This is the sum of all capacity contract types for the period covered.
    /// </remarks>
    A05 = 5,

    /// <summary>
    /// Long term contract
    /// </summary>
    /// <remarks>
    /// The condition under which capacity is allocated and handled is by long term trade agreements according to European regulations (EU Directive 1228/2003).
    /// </remarks>
    A06 = 6,

    /// <summary>
    /// Intraday contract
    /// </summary>
    /// <remarks>
    /// The condition under which the capacity is allocated and handled is through an intraday auction and allocation process.
    /// </remarks>
    A07 = 7,

    /// <summary>
    /// Quarter yearly contract
    /// </summary>
    /// <remarks>
    /// The condition under which capacity is allocated and handled is by quarter yearly auction or a quarter yearly transmission allocation procedure.
    /// </remarks>
    A08 = 8,

    /// <summary>
    /// Semestrial contract
    /// </summary>
    /// <remarks>
    /// The condition under which capacity is allocated and handled is by half yearly auction or a half yearly transmission allocation procedure.
    /// </remarks>
    A09 = 9,

    /// <summary>
    /// Multiple year contract
    /// </summary>
    /// <remarks>
    /// The condition under which capacity is allocated and handled is by multiple year auctions.
    /// </remarks>
    A10 = 10,

    /// <summary>
    /// Intraday balancing mechanism contract
    /// </summary>
    /// <remarks>
    /// The condition under which the capacity is allocated and handled is through intraday energy balancing services.
    /// </remarks>
    A11 = 11,

    /// <summary>
    /// Historical contract
    /// </summary>
    /// <remarks>
    /// A Contract established before the EU directive that are valid until the term of the contract.
    /// </remarks>
    A12 = 12,

    /// <summary>
    /// Hourly contract
    /// </summary>
    /// <remarks>
    /// The condition under which capacity is allocated and handled is by hourly auctions.
    /// </remarks>
    A13 = 13,

    /// <summary>
    /// First intraday auction contract
    /// </summary>
    /// <remarks>
    /// The first intraday auction contract (IDA1).
    /// </remarks>
    A14 = 14,

    /// <summary>
    /// Second intraday auction contract
    /// </summary>
    /// <remarks>
    /// The second intraday auction contract (IDA2).
    /// </remarks>
    A15 = 15,

    /// <summary>
    /// Third intraday auction contract
    /// </summary>
    /// <remarks>
    /// The third intraday auction contract (IDA3).
    /// </remarks>
    A16 = 16
}

