// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// The identification of the different terms of payment.
/// </summary>
/// <remarks>
/// ET0041
/// </remarks>
public enum PaymentTermsType
{
    /// <summary>
    /// Pay as bid
    /// </summary>
    /// <remarks>
    /// The amount to be paid shall correspond to the amount bid.
    /// </remarks>
    A01 = 1,

    /// <summary>
    /// Pay as cleared
    /// </summary>
    /// <remarks>
    /// The amount to be paid shall correspond to the amount calculated for clearing.
    /// </remarks>
    A02 = 2,

    /// <summary>
    /// No payment terms
    /// </summary>
    /// <remarks>
    /// There are no payment terms to be used.
    /// </remarks>
    A03 = 3
}

