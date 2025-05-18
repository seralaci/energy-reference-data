// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// (synonym MeasurementUnit) The unit of measure that is applied to a quantity. The measurement units shall be in compliance with UN/ECE Recommendation 20.
/// </summary>
/// <remarks>
/// ET0011
/// </remarks>
public enum UnitOfMeasureType
{
    /// <summary>
    /// OKTA unit
    /// </summary>
    /// <remarks>
    /// A unit of measurement of the cloudiness expressed in OKTA or OCTA, i.e. A unit of count defining the number of eighth-parts as a measure of the celestial dome cloud coverage.
    /// </remarks>
    A59,

    /// <summary>
    /// gigawatt
    /// </summary>
    /// <remarks>
    /// GW unit as per UN/CEFACT recommendation 20.
    /// </remarks>
    A90,

    /// <summary>
    /// hectopascal
    /// </summary>
    /// <remarks>
    /// A unit of measurement of the pressure expressed in hectopascal.
    /// </remarks>
    A97,

    /// <summary>
    /// ampere
    /// </summary>
    /// <remarks>
    /// The unit of electrical current in the International system of Units (SI) equivalent to one Coulomb per second.
    /// </remarks>
    AMP,

    /// <summary>
    /// One
    /// </summary>
    /// <remarks>
    /// A unit for dimensionless quantities, also called quantities of dimension one.
    /// </remarks>
    C62,

    /// <summary>
    /// Celsius
    /// </summary>
    /// <remarks>
    /// A unit of measurement of temperature expressed in degree Celsius.
    /// </remarks>
    CEL,

    /// <summary>
    /// watt per square meter
    /// </summary>
    /// <remarks>
    /// A unit of measurement of the density of heat flow rate expressed in watt per square meter.
    /// </remarks>
    D54,

    /// <summary>
    /// degree (unit of angle)
    /// </summary>
    /// <remarks>
    /// A unit of measurement of angles expressed in a 0 to 360 degree gradient.
    /// </remarks>
    DD,

    /// <summary>
    /// Megawatt per Hertz
    /// </summary>
    /// <remarks>
    /// A unit of energy expressed as the load change in million watts that will cause a frequency shift of one hertz.
    /// </remarks>
    E08,

    /// <summary>
    /// gigawatt hour
    /// </summary>
    /// <remarks>
    /// GWh unit as per UN/CEFACT recommendation 20.
    /// </remarks>
    GWH,

    /// <summary>
    /// cubic hectometres
    /// </summary>
    /// <remarks>
    /// A unit of volume equal to one million cubic metres.
    /// </remarks>
    HMQ,

    /// <summary>
    /// Hertz
    /// </summary>
    /// <remarks>
    /// HTZ unit as per UN/CEFACT recommendation 20.
    /// </remarks>
    HTZ,

    /// <summary>
    /// K (Kelvin)
    /// </summary>
    /// <remarks>
    /// Temperature unit refer ISO 80000-5 (Quantities and units, Part 5: Thermodynamics).
    /// </remarks>
    KEL,

    /// <summary>
    /// kilometre
    /// </summary>
    /// <remarks>
    /// km unit as per UN/CEFACT recommendation 20.
    /// </remarks>
    KMT,

    /// <summary>
    /// kilovolt ampere reactive
    /// </summary>
    /// <remarks>
    /// A unit of electrical reactive power represented by a current of one thousand amperes flowing due to a potential difference of one thousand volts where the sine of the phase angle between them is 1. The unity power factor is expressed in thousands of a volt ampere reactive.
    /// </remarks>
    KVR,

    /// <summary>
    /// kilovolt
    /// </summary>
    /// <remarks>
    /// kV unit as per UN/CEFACT recommendation 20.
    /// </remarks>
    KVT,

    /// <summary>
    /// kilowatt hour
    /// </summary>
    /// <remarks>
    /// A total amount of electrical energy transferred or consumed in one hour.
    /// </remarks>
    KWH,

    /// <summary>
    /// kilowatt
    /// </summary>
    /// <remarks>
    /// A unit of bulk power flow, which can be defined as the rate of energy transfer /consumption when a current of 1000 amperes flows due to a potential of 1000 volts at unity power factor expressed in thousands of a watt.
    /// </remarks>
    KWT,

    /// <summary>
    /// megavolt ampere reactive hours
    /// </summary>
    /// <remarks>
    /// Total amount of reactive power across a power system.
    /// </remarks>
    MAH,

    /// <summary>
    /// megavolt ampere reactive
    /// </summary>
    /// <remarks>
    /// A unit of electrical reactive power represented by a current of one thousand amperes flowing due to a potential difference of one thousand volts where the sine of the phase angle between them is 1.
    /// </remarks>
    MAR,

    /// <summary>
    /// megawatt
    /// </summary>
    /// <remarks>
    /// A unit of bulk power flow, which can be defined as the rate of energy transfer /consumption when a current of 1000 amperes flows due to a potential of 1000 volts at unity power factor expressed in millions of a watt.
    /// </remarks>
    MAW,

    /// <summary>
    /// minute
    /// </summary>
    /// <remarks>
    /// A period of time equal to sixty seconds.
    /// </remarks>
    MIN,

    /// <summary>
    /// millimeter
    /// </summary>
    /// <remarks>
    /// A unit of measurement of length expressed in millimeter.
    /// </remarks>
    MMT,

    /// <summary>
    /// cubic metres per second
    /// </summary>
    /// <remarks>
    /// The volume flow rate of cubic metre per second.
    /// </remarks>
    MQS,

    /// <summary>
    /// cubic metre
    /// </summary>
    /// <remarks>
    /// A Cubic metre.
    /// </remarks>
    MTQ,

    /// <summary>
    /// metre
    /// </summary>
    /// <remarks>
    /// The length of a metre.
    /// </remarks>
    MTR,

    /// <summary>
    /// meter per second
    /// </summary>
    /// <remarks>
    /// A unit of measurement of the speed expressed in m/s.
    /// </remarks>
    MTS,

    /// <summary>
    /// millihertz
    /// </summary>
    /// <remarks>
    /// A unit of frequency equal to 0.001 cycle per second.
    /// </remarks>
    MTZ,

    /// <summary>
    /// megavolt-ampere
    /// </summary>
    /// <remarks>
    /// MVA unit as per UN/CEFACT recommendation 20.
    /// </remarks>
    MVA,

    /// <summary>
    /// megawatt hours
    /// </summary>
    /// <remarks>
    /// The total amount of bulk energy transferred or consumed.
    /// </remarks>
    MWH,

    /// <summary>
    /// percent
    /// </summary>
    /// <remarks>
    /// A unit of proportion equal to 0.01.
    /// </remarks>
    P1,

    /// <summary>
    /// second
    /// </summary>
    /// <remarks>
    /// A period of time equal to one second.
    /// </remarks>
    SEC,

    /// <summary>
    /// watt
    /// </summary>
    /// <remarks>
    /// The watt is the International System of Units (SI) standard unit of power (energy per unit time), the equivalent of one joule per second.
    /// </remarks>
    WTT
}

