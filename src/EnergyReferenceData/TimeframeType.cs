// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// The identification of the timeframe.
/// </summary>
/// <remarks>
/// ET0053
/// </remarks>
public enum TimeframeType
{
    /// <summary>
    /// Real time
    /// </summary>
    /// <remarks>
    /// The information provided concerns real time timeframe.
    /// </remarks>
    A01 = 1,

    /// <summary>
    /// Intraday
    /// </summary>
    /// <remarks>
    /// The information provided concerns an intra day timeframe. 
    /// </remarks>
    A02 = 2,

    /// <summary>
    /// Hour-1
    /// </summary>
    /// <remarks>
    /// The information provided concerns 1 hour ahead for given delivery hour.
    /// </remarks>
    A03 = 3,

    /// <summary>
    /// Hour-2
    /// </summary>
    /// <remarks>
    /// The information provided concerns 2 hours ahead for given delivery hour.
    /// </remarks>
    A04 = 4,

    /// <summary>
    /// Hour-3
    /// </summary>
    /// <remarks>
    /// The information provided concerns 3 hours ahead for given delivery hour.
    /// </remarks>
    A05 = 5,

    /// <summary>
    /// Hour-4
    /// </summary>
    /// <remarks>
    /// The information provided concerns 4 hours ahead for given delivery hour.
    /// </remarks>
    A06 = 6,

    /// <summary>
    /// Hour-5
    /// </summary>
    /// <remarks>
    /// The information provided concerns 5 hours ahead for given delivery hour.
    /// </remarks>
    A07 = 7,

    /// <summary>
    /// Hour-6
    /// </summary>
    /// <remarks>
    /// The information provided concerns 6 hours ahead for given delivery hour.
    /// </remarks>
    A08 = 8,

    /// <summary>
    /// Hour-7
    /// </summary>
    /// <remarks>
    /// The information provided concerns 7 hours ahead for given delivery hour.
    /// </remarks>
    A09 = 9,

    /// <summary>
    /// Hour-8
    /// </summary>
    /// <remarks>
    /// The information provided concerns 8 hours ahead for given delivery hour.
    /// </remarks>
    A10 = 10,

    /// <summary>
    /// Hour-9
    /// </summary>
    /// <remarks>
    /// The information provided concerns 9 hours ahead for given delivery hour.
    /// </remarks>
    A11 = 11,

    /// <summary>
    /// Hour-10
    /// </summary>
    /// <remarks>
    /// The information provided concerns 10 hours ahead for given delivery hour.
    /// </remarks>
    A12 = 12,

    /// <summary>
    /// Hour-11
    /// </summary>
    /// <remarks>
    /// The information provided concerns 11 hours ahead for given delivery hour.
    /// </remarks>
    A13 = 13,

    /// <summary>
    /// Hour-12
    /// </summary>
    /// <remarks>
    /// The information provided concerns 12 hours ahead for given delivery hour.
    /// </remarks>
    A14 = 14,

    /// <summary>
    /// Hour-13
    /// </summary>
    /// <remarks>
    /// The information provided concerns 13 hours ahead for given delivery hour.
    /// </remarks>
    A15 = 15,

    /// <summary>
    /// Hour-14
    /// </summary>
    /// <remarks>
    /// The information provided concerns 14 hours ahead for given delivery hour.
    /// </remarks>
    A16 = 16,

    /// <summary>
    /// Hour-15
    /// </summary>
    /// <remarks>
    /// The information provided concerns 15 hours ahead for given delivery hour.
    /// </remarks>
    A17 = 17,

    /// <summary>
    /// Hour-16
    /// </summary>
    /// <remarks>
    /// The information provided concerns 16 hours ahead for given delivery hour.
    /// </remarks>
    A18 = 18,

    /// <summary>
    /// Hour-17
    /// </summary>
    /// <remarks>
    /// The information provided concerns 17 hours ahead for given delivery hour.
    /// </remarks>
    A19 = 19,

    /// <summary>
    /// Hour-18
    /// </summary>
    /// <remarks>
    /// The information provided concerns 18 hours ahead for given delivery hour.
    /// </remarks>
    A20 = 20,

    /// <summary>
    /// Hour-19
    /// </summary>
    /// <remarks>
    /// The information provided concerns 19 hours ahead for given delivery hour.
    /// </remarks>
    A21 = 21,

    /// <summary>
    /// Hour-20
    /// </summary>
    /// <remarks>
    /// The information provided concerns 20 hours ahead for given delivery hour.
    /// </remarks>
    A22 = 22,

    /// <summary>
    /// Hour-21
    /// </summary>
    /// <remarks>
    /// The information provided concerns 21 hours ahead for given delivery hour.
    /// </remarks>
    A23 = 23,

    /// <summary>
    /// Hour-22
    /// </summary>
    /// <remarks>
    /// The information provided concerns 22 hours ahead for given delivery hour.
    /// </remarks>
    A24 = 24,

    /// <summary>
    /// Hour-23
    /// </summary>
    /// <remarks>
    /// The information provided concerns 23 hours ahead for given delivery hour.
    /// </remarks>
    A25 = 25,

    /// <summary>
    /// Hour-24
    /// </summary>
    /// <remarks>
    /// The information provided concerns 24 hours ahead for given delivery hour.
    /// </remarks>
    A26 = 26,

    /// <summary>
    /// Hour-25
    /// </summary>
    /// <remarks>
    /// The information provided concerns 25 hours ahead for given delivery hour.
    /// </remarks>
    A27 = 27,

    /// <summary>
    /// Hour-26
    /// </summary>
    /// <remarks>
    /// The information provided concerns 26 hours ahead for given delivery hour.
    /// </remarks>
    A28 = 28,

    /// <summary>
    /// Hour-27
    /// </summary>
    /// <remarks>
    /// The information provided concerns 27 hours ahead for given delivery hour.
    /// </remarks>
    A29 = 29,

    /// <summary>
    /// Hour-28
    /// </summary>
    /// <remarks>
    /// The information provided concerns 28 hours ahead for given delivery hour.
    /// </remarks>
    A30 = 30,

    /// <summary>
    /// Hour-29
    /// </summary>
    /// <remarks>
    /// The information provided concerns 29 hours ahead for given delivery hour.
    /// </remarks>
    A31 = 31,

    /// <summary>
    /// Hour-30
    /// </summary>
    /// <remarks>
    /// The information provided concerns 30 hours ahead for given delivery hour.
    /// </remarks>
    A32 = 32,

    /// <summary>
    /// Hour-31
    /// </summary>
    /// <remarks>
    /// The information provided concerns 31 hours ahead for given delivery hour.
    /// </remarks>
    A33 = 33,

    /// <summary>
    /// Day ahead
    /// </summary>
    /// <remarks>
    /// The information provided concerns day ahead timeframe.
    /// </remarks>
    A34 = 34,

    /// <summary>
    /// Day-2
    /// </summary>
    /// <remarks>
    /// The information provided concerns two days ahead timeframe.	/// 
    /// </remarks>
    A35 = 35,

    /// <summary>
    /// Day-3
    /// </summary>
    /// <remarks>
    /// The information provided concerns three days ahead timeframe.	/// 
    /// </remarks>
    A36 = 36,

    /// <summary>
    /// Day-4
    /// </summary>
    /// <remarks>
    /// The information provided concerns four days ahead timeframe.
    /// </remarks>
    A37 = 37,

    /// <summary>
    /// Day-5
    /// </summary>
    /// <remarks>
    /// The information provided concerns five days ahead timeframe.	/// 	/// 
    /// </remarks>
    A38 = 38,

    /// <summary>
    /// Day-6
    /// </summary>
    /// <remarks>
    /// The information provided concerns six days ahead timeframe.	/// 	/// 
    /// </remarks>
    A39 = 39,

    /// <summary>
    /// Day-7
    /// </summary>
    /// <remarks>
    /// The information provided concerns seven days ahead timeframe.	/// 	/// 
    /// </remarks>
    A40 = 40,

    /// <summary>
    /// Week ahead
    /// </summary>
    /// <remarks>
    /// The information provided concerns next week ahead timeframe.
    /// </remarks>
    A41 = 41,

    /// <summary>
    /// Week-0
    /// </summary>
    /// <remarks>
    /// The information provided concerns current week timeframe.	/// 
    /// </remarks>
    A42 = 42,

    /// <summary>
    /// Week+1
    /// </summary>
    /// <remarks>
    /// The information provided concerns previous week timeframe.	/// 
    /// </remarks>
    A43 = 43,

    /// <summary>
    /// Month ahead
    /// </summary>
    /// <remarks>
    /// The information provided concerns month ahead timeframe.	/// 
    /// </remarks>
    A44 = 44,

    /// <summary>
    /// Year ahead
    /// </summary>
    /// <remarks>
    /// The information provided concerns year ahead timeframe.
    /// </remarks>
    A45 = 45,

    /// <summary>
    /// Year-10
    /// </summary>
    /// <remarks>
    /// The information provided concerns 10 years ahead timeframe.
    /// </remarks>
    A46 = 46
}

