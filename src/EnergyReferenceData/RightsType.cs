// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// The rights of use that is accorded to what is acquired in an auction.
/// </summary>
/// <remarks>
/// ET0938
/// </remarks>
public enum RightsType
{
    /// <summary>
    /// Use It Or Lose It
    /// </summary>
    /// <remarks>
    /// Any rights not nominated shall be lost.
    /// </remarks>
    A01,

    /// <summary>
    /// Use It Or Sell It
    /// </summary>
    /// <remarks>
    /// Any rights that are not nominated shall be sold.
    /// </remarks>
    A02,

    /// <summary>
    /// Allocation curtailment possible
    /// </summary>
    /// <remarks>
    /// Rights acquired may be curtailed.
    /// </remarks>
    A03,

    /// <summary>
    /// Nomination curtailment possible
    /// </summary>
    /// <remarks>
    /// Rights acquired may be curtailed at nomination.
    /// </remarks>
    A04,

    /// <summary>
    /// Resale possible
    /// </summary>
    /// <remarks>
    /// Acquired rights may be resold.
    /// </remarks>
    A05,

    /// <summary>
    /// Transfer possible
    /// </summary>
    /// <remarks>
    /// Acquired rights may be transferred.
    /// </remarks>
    A06
}

