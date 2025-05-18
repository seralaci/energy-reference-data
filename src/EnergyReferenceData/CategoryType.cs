// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// The product category of an auction.
/// </summary>
/// <remarks>
/// ET0037
/// </remarks>
public enum CategoryType
{
    /// <summary>
    /// Base
    /// </summary>
    /// <remarks>
    /// The auction is for a base period.
    /// </remarks>
    A01 = 1,

    /// <summary>
    /// Peak
    /// </summary>
    /// <remarks>
    /// The auction is for a peak period.
    /// </remarks>
    A02 = 2,

    /// <summary>
    /// Off peak
    /// </summary>
    /// <remarks>
    /// The auction is for an off peak period.
    /// </remarks>
    A03 = 3,

    /// <summary>
    /// Hourly
    /// </summary>
    /// <remarks>
    /// The auction is for an hourly period.
    /// </remarks>
    A04 = 4
}

