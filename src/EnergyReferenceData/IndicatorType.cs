// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// A boolean indicator to express Yes or No or True or False.
/// </summary>
/// <remarks>
/// ET0029
/// </remarks>
public enum IndicatorType
{
    /// <summary>
    /// YES
    /// </summary>
    /// <remarks>
    /// A positive indication.
    /// </remarks>
    A01,

    /// <summary>
    /// NO
    /// </summary>
    /// <remarks>
    /// A negative indication.
    /// </remarks>
    A02
}

