// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

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
    _8716867000016,

    /// <summary>
    /// Reactive power
    /// </summary>
    /// <remarks>
    /// The product of voltage and current and the sine of the phase angle between them, measured in units of voltamperes reactive and standard multiples thereof. (not used for planned schedules).
    /// </remarks>
    _8716867000023,

    /// <summary>
    /// Active energy
    /// </summary>
    /// <remarks>
    /// The electrical energy produced, flowing or supplied by an electrical circuit during a time interval, being the integral with respect to time of instantaneous active power, measured in units of watt-hours, or standard multiples thereof.
    /// </remarks>
    _8716867000030,

    /// <summary>
    /// Reactive energy
    /// </summary>
    /// <remarks>
    /// The integral with respect to time of reactive power (not used for planned schedules).
    /// </remarks>
    _8716867000047,

    /// <summary>
    /// Capacitive reactive power
    /// </summary>
    /// <remarks>
    /// Capacitive reactive power.
    /// </remarks>
    _8716867000115,

    /// <summary>
    /// Inductive reactive power
    /// </summary>
    /// <remarks>
    /// Inductive reactive power.
    /// </remarks>
    _8716867000122,

    /// <summary>
    /// Capacitive Reactive energy
    /// </summary>
    /// <remarks>
    /// Capacitive reactive energy.
    /// </remarks>
    _8716867000139,

    /// <summary>
    /// Inductive Reactive energy
    /// </summary>
    /// <remarks>
    /// Inductive reactive energy.
    /// </remarks>
    _8716867000146,

    /// <summary>
    /// Water
    /// </summary>
    /// <remarks>
    /// For hydro power stations, this enables the identification of the quantity of water stored behind a dam (volume, head level, etc.), or the constraints in the flow of water.
    /// </remarks>
    _8716867009911
}

