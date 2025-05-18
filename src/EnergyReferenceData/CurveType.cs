// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// The type of curve being defined in the time series.
/// </summary>
/// <remarks>
/// ET0042
/// </remarks>
public enum CurveType
{
    /// <summary>
    /// Sequential fixed size block
    /// </summary>
    /// <remarks>
    /// The curve is made of successive Intervals of time (Blocks) of constant duration (size), where the size of the Blocks is equal to the Resolution of the Period.
    /// </remarks>
    A01 = 1,

    /// <summary>
    /// Point
    /// </summary>
    /// <remarks>
    /// The curve is made of successive instants of time (Points).
    /// </remarks>
    A02 = 2,

    /// <summary>
    /// Variable sized Block
    /// </summary>
    /// <remarks>
    /// The curve is made of successive Intervals of time (Blocks) of variable duration (size), where the end date and end time of each Block are equal to the start date and start time of the next Interval. For the last Block the end date and end time of the last Interval would be equal to EndDateTime of TimeInterval.
    /// </remarks>
    A03 = 3,

    /// <summary>
    /// Overlapping breakpoint
    /// </summary>
    /// <remarks>
    /// The curve is made of successive Intervals of time of variable duration (size), where the end date and end time of each interval are equal to the start date and start time of the next Interval.
    /// </remarks>
    A04 = 4,

    /// <summary>
    /// Non-overlapping breakpoint
    /// </summary>
    /// <remarks>
    /// This curve is a restriction of the curve type A04, i.e. overlapping breakpoints. The restriction is that a single Period is allowed.
    /// </remarks>
    A05 = 5
}

