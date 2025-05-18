// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// The coded identification of the HVDC mode.
/// </summary>
/// <remarks>
/// MXM000
/// </remarks>
public enum HVDCModeType
{
    /// <summary>
    /// Setpoint schedule
    /// </summary>
    /// <remarks>
    /// The code for the "power setpoint" mode of operation of the HVDC link.
    /// </remarks>
    A01,

    /// <summary>
    /// Proportional external signal
    /// </summary>
    /// <remarks>
    /// The code for the "Proportional external signal" mode of operation of the HVDC link.
    /// </remarks>
    A02,

    /// <summary>
    /// AC emulation
    /// </summary>
    /// <remarks>
    /// The code for the "AC emulation" mode of operation of the HVDC link.
    /// </remarks>
    A03
}

