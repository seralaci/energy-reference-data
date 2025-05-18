// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// The quality of an object.
/// </summary>
/// <remarks>
/// ET0036
/// </remarks>
public enum QualityType
{
    /// <summary>
    /// Adjusted
    /// </summary>
    /// <remarks>
    /// The contents of the object have been adjusted.
    /// </remarks>
    A01 = 1,

    /// <summary>
    /// Not available
    /// </summary>
    /// <remarks>
    /// The contents of the object are not available.
    /// </remarks>
    A02 = 2,

    /// <summary>
    /// Estimated
    /// </summary>
    /// <remarks>
    /// The contents of the object are estimated. The code is typically used when measured values are missing and an estimate is made based on historical data. 
    /// </remarks>
    A03 = 3,

    /// <summary>
    /// As provided
    /// </summary>
    /// <remarks>
    /// The contents of the object are as provided.
    /// </remarks>
    A04 = 4,

    /// <summary>
    /// Incomplete
    /// </summary>
    /// <remarks>
    /// The contents of the object are calculated based on incomplete data.
    /// </remarks>
    A05 = 5,

    /// <summary>
    /// Calculated
    /// </summary>
    /// <remarks>
    /// The contents of the object are calculated. The code is typically used when a value is calculated based on several other known values.
    /// </remarks>
    A06 = 6
}

