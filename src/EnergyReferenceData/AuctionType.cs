// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// The coded representation of different types of auction.
/// </summary>
/// <remarks>
/// ET0030
/// </remarks>
public enum AuctionType
{
    /// <summary>
    /// Implicit
    /// </summary>
    /// <remarks>
    /// The auction is an implicit auction.
    /// </remarks>
    A01,

    /// <summary>
    /// Explicit
    /// </summary>
    /// <remarks>
    /// The auction is an explicit auction.
    /// </remarks>
    A02,

    /// <summary>
    /// Rule Based
    /// </summary>
    /// <remarks>
    /// The auction is a rule based auction.
    /// </remarks>
    A03,

    /// <summary>
    /// Mixed
    /// </summary>
    /// <remarks>
    /// The auction is partially implicit and partially explicit.
    /// </remarks>
    A04,

    /// <summary>
    /// Explicit/split
    /// </summary>
    /// <remarks>
    /// The auction concerns two explicit auctions on a split border.
    /// </remarks>
    A05,

    /// <summary>
    /// Shadow auction
    /// </summary>
    /// <remarks>
    /// An explicit auction carried out in the case of the failure of an implicit auction.
    /// </remarks>
    A06,

    /// <summary>
    /// Flow-based
    /// </summary>
    /// <remarks>
    /// The allocation is an implicit auction using flow-based capacity calculation.
    /// </remarks>
    A07,

    /// <summary>
    /// Continuous
    /// </summary>
    /// <remarks>
    /// The auction type is continuous, i.e. there is no gate closure time when bids from the market participants are collected. Instead allocation procedure takes place immediately.
    /// </remarks>
    A08
}

