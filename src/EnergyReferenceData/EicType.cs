// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// The coded identification of the type of an EIC code.
/// </summary>
/// <remarks>
/// ET0028
/// </remarks>
public enum EicType
{
    /// <summary>
    /// Substation
    /// </summary>
    /// <remarks>
    /// An EIC code to substations.
    /// </remarks>
    A,

    /// <summary>
    /// Tieline
    /// </summary>
    /// <remarks>
    /// An EIC code to identify tielines.
    /// </remarks>
    T,

    /// <summary>
    /// Location
    /// </summary>
    /// <remarks>
    /// An EIC code to identify locations.
    /// </remarks>
    V,

    /// <summary>
    /// Resource Object
    /// </summary>
    /// <remarks>
    /// An EIC code to identify resource objects.
    /// </remarks>
    W,

    /// <summary>
    /// Party
    /// </summary>
    /// <remarks>
    /// An EIC code to identify parties.
    /// </remarks>
    X,

    /// <summary>
    /// Area or Domain
    /// </summary>
    /// <remarks>
    /// An EIC code to identify areas or domains.
    /// </remarks>
    Y,

    /// <summary>
    /// Measurement point
    /// </summary>
    /// <remarks>
    /// An EIC code to identify measurement points.
    /// </remarks>
    Z
}

