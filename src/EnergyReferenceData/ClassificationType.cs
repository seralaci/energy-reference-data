// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// Indicates the classification mechanism used to group a set of objects together. The grouping may be of a detailed or a summary nature.
/// </summary>
/// <remarks>
/// ET0013
/// </remarks>
public enum ClassificationType
{
    /// <summary>
    /// Detail type 
    /// </summary>
    /// <remarks>
    /// The Time Series content provides detailed information.
    /// </remarks>
    A01 = 1,

    /// <summary>
    /// Summary type 
    /// </summary>
    /// <remarks>
    /// The Time Series content provides aggregated information.
    /// </remarks>
    A02 = 2
}

