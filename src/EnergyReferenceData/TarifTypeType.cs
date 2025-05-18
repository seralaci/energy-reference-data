// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// The standard tariff types as defined in the RGCE policies.
/// </summary>
/// <remarks>
/// ET0039
/// </remarks>
public enum TarifTypeType
{
    /// <summary>
    /// Winter HT
    /// </summary>
    /// <remarks>
    /// Winter HT tariff.
    /// </remarks>
    A01 = 1,

    /// <summary>
    /// Winter HHT
    /// </summary>
    /// <remarks>
    /// Winter HHT tariff.
    /// </remarks>
    A02 = 2,

    /// <summary>
    /// Winter NT
    /// </summary>
    /// <remarks>
    /// Winter NT tariff.
    /// </remarks>
    A03 = 3,

    /// <summary>
    /// Summer HT
    /// </summary>
    /// <remarks>
    /// Summer HT tariff.
    /// </remarks>
    A04 = 4,

    /// <summary>
    /// Summer HHT1
    /// </summary>
    /// <remarks>
    /// Summer HHT1 tariff.
    /// </remarks>
    A05 = 5,

    /// <summary>
    /// Summer HHT2
    /// </summary>
    /// <remarks>
    /// Summer HHT2 tariff.
    /// </remarks>
    A06 = 6,

    /// <summary>
    /// Summer NT
    /// </summary>
    /// <remarks>
    /// Summer NT tariff.
    /// </remarks>
    A07 = 7
}

