// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// Indicates the category of the calculation to be applied to a price.
/// </summary>
/// <remarks>
/// ET0048
/// </remarks>
public enum PriceCategoryType
{
    /// <summary>
    /// Category 1
    /// </summary>
    /// <remarks>
    /// A category one price calculation is to be applied.
    /// </remarks>
    A01 = 1,

    /// <summary>
    /// Category 2
    /// </summary>
    /// <remarks>
    /// A category two price calculation is to be applied.
    /// </remarks>
    A02 = 2,

    /// <summary>
    /// Category 3
    /// </summary>
    /// <remarks>
    /// A category three price calculation is to be applied.
    /// </remarks>
    A03 = 3,

    /// <summary>
    /// Excess balance
    /// </summary>
    /// <remarks>
    /// The category concerns excess balance.
    /// </remarks>
    A04 = 4,

    /// <summary>
    /// Insufficient balance
    /// </summary>
    /// <remarks>
    /// A category concerns insufficient balance.
    /// </remarks>
    A05 = 5,

    /// <summary>
    /// Average bid price
    /// </summary>
    /// <remarks>
    /// The average bid price for a given product.
    /// </remarks>
    A06 = 6,

    /// <summary>
    /// Single marginal bid price
    /// </summary>
    /// <remarks>
    /// The downwards activated bid price  or the upwards activated  bid price for activated balancing reserves.
    /// </remarks>
    A07 = 7,

    /// <summary>
    /// Cross-border marginal price
    /// </summary>
    /// <remarks>
    /// The price determined in accordance with article 3 of the methodology for pricing balancing energy.
    /// </remarks>
    A08 = 8
}

