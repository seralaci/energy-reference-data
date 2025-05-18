// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

using System.Xml.Serialization;

namespace EnergyReferenceData;

/// <summary>
/// The identification of the nature of an energy product such as power, energy, reactive power, etc.
/// </summary>
/// <remarks>
/// ET0008
/// </remarks>
public enum EnergyProductType
{
    /// <summary>
    /// Active power
    /// </summary>
    /// <remarks>
    /// The product of voltage and the in-phase component of alternating current measured in units of watts and standard multiples thereof.
    /// </remarks>
    [XmlEnum("8716867000016")]
    ActivePower = 1,

    /// <summary>
    /// Reactive power
    /// </summary>
    /// <remarks>
    /// The product of voltage and current and the sine of the phase angle between them, measured in units of voltamperes reactive and standard multiples thereof. (not used for planned schedules).
    /// </remarks>
    [XmlEnum("8716867000023")]
    ReactivePower = 2,

    /// <summary>
    /// Active energy
    /// </summary>
    /// <remarks>
    /// The electrical energy produced, flowing or supplied by an electrical circuit during a time interval, being the integral with respect to time of instantaneous active power, measured in units of watt-hours, or standard multiples thereof.
    /// </remarks>
    [XmlEnum("8716867000030")]
    ActiveEnergy = 3,

    /// <summary>
    /// Reactive energy
    /// </summary>
    /// <remarks>
    /// The integral with respect to time of reactive power (not used for planned schedules).
    /// </remarks>
    [XmlEnum("8716867000030")]
    ReactiveEnergy = 4,

    /// <summary>
    /// Capacitive reactive power
    /// </summary>
    /// <remarks>
    /// Capacitive reactive power.
    /// </remarks>
    [XmlEnum("8716867000115")]
    CapacitiveReactivePower = 5,

    /// <summary>
    /// Inductive reactive power
    /// </summary>
    /// <remarks>
    /// Inductive reactive power.
    /// </remarks>
    [XmlEnum("8716867000122")]
    InductiveReactivePower = 6,

    /// <summary>
    /// Capacitive Reactive energy
    /// </summary>
    /// <remarks>
    /// Capacitive reactive energy.
    /// </remarks>
    [XmlEnum("8716867000139")]
    CapacitiveReactiveEnergy = 7,

    /// <summary>
    /// Inductive Reactive energy
    /// </summary>
    /// <remarks>
    /// Inductive reactive energy.
    /// </remarks>
    [XmlEnum("8716867000146")]
    InductiveReactiveEnergy = 8,

    /// <summary>
    /// Water
    /// </summary>
    /// <remarks>
    /// For hydro power stations, this enables the identification of the quantity of water stored behind a dam (volume, head level, etc.), or the constraints in the flow of water.
    /// </remarks>
    [XmlEnum("8716867009911")]
    Water = 9
}

