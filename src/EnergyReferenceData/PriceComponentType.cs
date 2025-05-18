// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// Indicates the component type for  a price.
/// </summary>
/// <remarks>
/// ET0052
/// </remarks>
public enum PriceComponentType
{
    /// <summary>
    /// Scarcity
    /// </summary>
    /// <remarks>
    /// A scarcity component to be used in nationally defined scarcity situations.
    /// </remarks>
    A01,

    /// <summary>
    /// Incentive
    /// </summary>
    /// <remarks>
    /// An incentive component to be used to fulfil nationally defined boundary conditions.
    /// </remarks>
    A02,

    /// <summary>
    /// Financial neutrality
    /// </summary>
    /// <remarks>
    /// A component related to the financial neutrality of the connecting TSO.
    /// </remarks>
    A03
}

