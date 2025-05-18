// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// The identification of the method of allocation in an auction.
/// </summary>
/// <remarks>
/// ET0040
/// </remarks>
public enum AllocationModeType
{
    /// <summary>
    /// Order by price with pro rata
    /// </summary>
    /// <remarks>
    /// The allocation method is by price with eventual pro rata.
    /// </remarks>
    A01,

    /// <summary>
    /// Order by price with first come - first served
    /// </summary>
    /// <remarks>
    /// The allocation method is by price with eventual use of first come first served.
    /// </remarks>
    A02,

    /// <summary>
    /// First come - First served
    /// </summary>
    /// <remarks>
    /// The allocation method is first come first served.
    /// </remarks>
    A03,

    /// <summary>
    /// Pro rata
    /// </summary>
    /// <remarks>
    /// The allocation method is pro rata.
    /// </remarks>
    A04
}

