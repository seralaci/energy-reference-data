// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// The nature of a price, i.e. an impacted area system operator pays to internal market parties or inverse.
/// </summary>
/// <remarks>
/// ET0049
/// </remarks>
public enum PriceDirectionType
{
    /// <summary>
    /// Expenditure.
    /// </summary>
    /// <remarks>
    /// Expenditure, i.e. the Impacted Area System Operator pays to the internal Market Parties.
    /// </remarks>
    A01,

    /// <summary>
    /// Income.
    /// </summary>
    /// <remarks>
    /// Income, i.e. The Impacted Area System Operator receives from the internal Market Parties.
    /// </remarks>
    A02
}

