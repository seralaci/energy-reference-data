// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// The identification of the domain that is the common dominator used to aggregate a time series.
/// </summary>
/// <remarks>
/// ET0018
/// </remarks>
public enum ObjectAggregationType
{
    /// <summary>
    /// Area
    /// </summary>
    /// <remarks>
    /// The object being described concerns an area.
    /// </remarks>
    A01,

    /// <summary>
    /// Metering point
    /// </summary>
    /// <remarks>
    /// The object being described concerns a metering point.
    /// </remarks>
    A02,

    /// <summary>
    /// Party
    /// </summary>
    /// <remarks>
    /// The object being described concerns a party.
    /// </remarks>
    A03,

    /// <summary>
    /// Agreement Identification
    /// </summary>
    /// <remarks>
    /// The object being described concerns an agreement identification.
    /// </remarks>
    A04,

    /// <summary>
    /// Accounting point
    /// </summary>
    /// <remarks>
    /// The object being described concerns an accounting point.
    /// </remarks>
    A05,

    /// <summary>
    /// Resource Object
    /// </summary>
    /// <remarks>
    /// The object being described concerns a resource object.
    /// </remarks>
    A06,

    /// <summary>
    /// Tieline
    /// </summary>
    /// <remarks>
    /// The object being described concerns a tieline.
    /// </remarks>
    A07,

    /// <summary>
    /// Resource type
    /// </summary>
    /// <remarks>
    /// The object being described concerns a resource type.
    /// </remarks>
    A08,

    /// <summary>
    /// DC link
    /// </summary>
    /// <remarks>
    /// The object being described concerns a DC link.
    /// </remarks>
    A09,

    /// <summary>
    /// AC link
    /// </summary>
    /// <remarks>
    /// The object being described concerns an AC link.
    /// </remarks>
    A10,

    /// <summary>
    /// Merchant line
    /// </summary>
    /// <remarks>
    /// The object being described concerns a merchant line.
    /// </remarks>
    A11,

    /// <summary>
    /// Bidding zone
    /// </summary>
    /// <remarks>
    /// The largest geographical area within which market participants are able to exchange energy without capacity allocation.
    /// </remarks>
    A12,

    /// <summary>
    /// Virtual bidding zone
    /// </summary>
    /// <remarks>
    /// A non-geographical bidding zone to be able to apply extra constraints to Bidding Zones.
    /// </remarks>
    A13,

    /// <summary>
    /// Metering grid area
    /// </summary>
    /// <remarks>
    /// A physical area where consumption, production and exchange can be measured. It is delimited by the placement of meters for continuous measurement for input to, and withdrawal from the area.
    /// </remarks>
    A14,

    /// <summary>
    /// Scheduling area
    /// </summary>
    /// <remarks>
    /// An area within which the TSOs' obligations regarding scheduling apply due to operational or organisational needs.
    /// </remarks>
    A15,

    /// <summary>
    /// Exchange point
    /// </summary>
    /// <remarks>
    /// The object being described concerns an exchange point.
    /// </remarks>
    A16
}

