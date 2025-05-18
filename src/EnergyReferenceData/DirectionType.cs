// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// The coded identification of the direction of energy flow.
/// </summary>
/// <remarks>
/// ET0026
/// </remarks>
public enum DirectionType
{
    /// <summary>
    /// UP
    /// </summary>
    /// <remarks>
    /// Up signifies that the available power can be used by the Purchasing area to increase energy.
    /// </remarks>
    A01,

    /// <summary>
    /// DOWN
    /// </summary>
    /// <remarks>
    /// Down signifies that the available power can be used by the Purchasing area to decrease energy.
    /// </remarks>
    A02,

    /// <summary>
    /// UP and DOWN
    /// </summary>
    /// <remarks>
    /// Up and Down signifies that the UP and Down values are equal.
    /// </remarks>
    A03,

    /// <summary>
    /// Stable
    /// </summary>
    /// <remarks>
    /// The direction at a given instant in time is considered to be stable.
    /// </remarks>
    A04
}

