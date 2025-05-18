// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// The identification of an analog value.
/// </summary>
/// <remarks>
/// MXM000
/// </remarks>
public enum AnalogType
{
    /// <summary>
    /// Flow
    /// </summary>
    /// <remarks>
    /// This is the computed flow for the monitored element in the constraint situation ("N situation", "N-1 situation" ...) after the capacity calculation. The flow is expressed in A, %, or MW.
    /// </remarks>
    A01 = 1,

    /// <summary>
    /// Permanent admissible transmission limit (PATL)
    /// </summary>
    /// <remarks>
    /// The permanent load of transmission system elements which is allowed for an unlimited period and which does not cause physical damage to the transmission system elements as long as the defined threshold is respected.
    /// </remarks>
    A02 = 2,

    /// <summary>
    /// Flow reliability margin
    /// </summary>
    /// <remarks>
    /// This is the flow reliability margin for a given critical network element. The amount of MW or A that is reserved for this critical network element and shall not be used for the computed outage situation, in order to secure the power network.
    /// </remarks>
    A03 = 3,

    /// <summary>
    /// Spanning margin value
    /// </summary>
    /// <remarks>
    /// This is the margin that is taken into account when spanning (fall-back process) is applied. Spanning marginal value is an historical based parameter which specifies the amount of MW that reduces the RAM when spanning is applied.
    /// </remarks>
    A04 = 4,

    /// <summary>
    /// Long term allocation margin
    /// </summary>
    /// <remarks>
    /// This is the amount of MW that is added to the capacity of the critical network element in order to automatically include the long term allocation domain into the flow based domain.
    /// </remarks>
    A05 = 5,

    /// <summary>
    /// Final adjustment margin value
    /// </summary>
    /// <remarks>
    /// This is the margin that is manually added or subtracted to the capacity of the critical network element. A negative value for final adjustment value simulates the effect of an additional margin due to complex remedial actions (RA) which cannot be modeled and so calculated in the flow based parameter calculation. A positive value for FAV as a consequence of the verification phase of the flow based domain, leading to the need to reduce the margin on one or more CBs for system security reasons.
    /// </remarks>
    A06 = 6,

    /// <summary>
    /// Transitory admissible transmission limit (TATL)
    /// </summary>
    /// <remarks>
    /// The temporary overload of transmission system elements which is allowed for a limited period and which does not cause physical damage to the transmission system elements as long as the defined duration and thresholds are respected.
    /// </remarks>
    A07 = 7,

    /// <summary>
    /// Long admissible flow
    /// </summary>
    /// <remarks>
    /// This is the value, expressed in A or MW, that the overload flow in a network element shall not exceed for a duration no longer than the long duration. The long duration value depends on the TSO network operating rules.
    /// </remarks>
    A08 = 8,

    /// <summary>
    /// Negative Final adjustment margin value
    /// </summary>
    /// <remarks>
    /// This is the margin that is manually added to the capacity of the critical network element in order to simulate the effect of an additional margin due to complex remedial actions (RA) which cannot be modeled and so calculated in the flow based parameter calculation.
    /// </remarks>
    A09 = 9,

    /// <summary>
    /// Minimum voltage level
    /// </summary>
    /// <remarks>
    /// This is the minimum voltage that can be supported by a network element without involving a risk for the security of supply.
    /// </remarks>
    A10 = 10,

    /// <summary>
    /// Maximum voltage level
    /// </summary>
    /// <remarks>
    /// This is the maximum voltage that can be supported by a network element without involving a risk for the security of supply.
    /// </remarks>
    A11 = 11,

    /// <summary>
    /// TATL after automatic RA
    /// </summary>
    /// <remarks>
    /// The Transitory admissible transmission limit (TATL) which is allowed after an automatic Remedial Action (RA) has been applied.
    /// </remarks>
    A12 = 12,

    /// <summary>
    /// TATL after curative RA
    /// </summary>
    /// <remarks>
    /// The Transitory admissible transmission limit (TATL) which is allowed after a curative Remedial Action (RA) has been applied.
    /// </remarks>
    A13 = 13,

    /// <summary>
    /// Computed Voltage
    /// </summary>
    /// <remarks>
    /// This is the computed voltage for a given monitored element.
    /// </remarks>
    A14 = 14,

    /// <summary>
    /// Zero-Balance flow
    /// </summary>
    /// <remarks>
    /// This is the amount of power affected by a contingency that reflects a situation with a scheduled exchange of zero.
    /// </remarks>
    A15 = 15,

    /// <summary>
    /// Available margin after remedial actions
    /// </summary>
    /// <remarks>
    /// This is the available flow margin adjusted for the consideration of remedial actions in capacity calculation.
    /// </remarks>
    A16 = 16,

    /// <summary>
    /// Loss Factor
    /// </summary>
    /// <remarks>
    /// This is the loss factor for an asset.
    /// </remarks>
    A17 = 17,

    /// <summary>
    /// Adjustment for minimum RAM
    /// </summary>
    /// <remarks>
    /// This is the adjustment applied to the capacity of a branch to have a minimum RAM (Remaining Available Margin) available for commercial exchanges.
    /// </remarks>
    A18 = 18,

    /// <summary>
    /// Tap changer
    /// </summary>
    /// <remarks>
    /// The position of a Tap changer.
    /// </remarks>
    A19 = 19,

    /// <summary>
    /// Regulator mode
    /// </summary>
    /// <remarks>
    /// A measurement type indicating the control mode of a regulator, i.e. from voltage regulation to fixed MVAR regulation.
    /// </remarks>
    A20 = 20,

    /// <summary>
    /// Regulator set-point
    /// </summary>
    /// <remarks>
    /// The set-point of a regulator. A regulator can be a tap changer, a synchronous machine, a SVC or a shunt.
    /// </remarks>
    A21 = 21,

    /// <summary>
    /// Reference Flow
    /// </summary>
    /// <remarks>
    /// This is the amount of power affected by a contingency that reflects a situation with scheduled exchanges from a reference situation.
    /// </remarks>
    A22 = 22,

    /// <summary>
    /// CO2 emission
    /// </summary>
    /// <remarks>
    /// This is the CO2 emission from one or several assets.
    /// </remarks>
    A23 = 23,

    /// <summary>
    /// Maximum admissible current (Imax)
    /// </summary>
    /// <remarks>
    /// The maximum admissible current of a critical network element or a critical network element and contingency.
    /// </remarks>
    A24 = 24,

    /// <summary>
    /// Individual value adjustment (IVA)
    /// </summary>
    /// <remarks>
    /// Individual value adjustment resulting from TSO validation process.	/// 
    /// </remarks>
    A25 = 25,

    /// <summary>
    /// Linear flow approximation (F0)
    /// </summary>
    /// <remarks>
    /// The linear approximation of a flow in the reference net position in a situation without any cross-zonal exchanges.
    /// </remarks>
    A26 = 26,

    /// <summary>
    /// Flow without commercial exchanges (F0_Wce)
    /// </summary>
    /// <remarks>
    /// Flow per critical network element and contingency without commercial exchanges within a capacity calculation region.
    /// </remarks>
    A27 = 27,

    /// <summary>
    /// Flow without commercial exchanges between areas (F0_all)
    /// </summary>
    /// <remarks>
    /// Flow per critical network element and contingency without commercial exchanges between bidding zones within the same or different synchronous areas.
    /// </remarks>
    A28 = 28,

    /// <summary>
    /// Flow due to non-costly remedial actions (F_nrao)
    /// </summary>
    /// <remarks>
    /// Expected flow change due to non-costly remedial actions.
    /// </remarks>
    A29 = 29,

    /// <summary>
    /// Flow after long-term nominations (F_LTN)
    /// </summary>
    /// <remarks>
    /// Flow after consideration of long-term nominations.
    /// </remarks>
    A30 = 30,

    /// <summary>
    /// Coordinated value adjustment (CVA)
    /// </summary>
    /// <remarks>
    /// Coordinated value adjustment resulting from coordinated validation process.
    /// </remarks>
    A31 = 31,

    /// <summary>
    /// Minimum remaining available margin as ratio of maximum allowable power flow (Ramr)
    /// </summary>
    /// <remarks>
    /// Percentage of the maximum allowable power flow that needs to be available as minimum Remaining Available Margin. 
    /// </remarks>
    A32 = 32,

    /// <summary>
    /// Flows from already allocated cross-zonal capacities (Faac)
    /// </summary>
    /// <remarks>
    /// Flows resulting from previously allocated cross-zonal capacities.
    /// </remarks>
    A33 = 33,

    /// <summary>
    /// Flow from remedial action (FRA)
    /// </summary>
    /// <remarks>
    /// Flow for increasing the Remaining Available Margin due to remedial action.
    /// </remarks>
    A34 = 34,

    /// <summary>
    /// Assumed external exchanges
    /// </summary>
    /// <remarks>
    /// Flow resulting from assumed commercial exchanges outside the region (F_uaf).
    /// </remarks>
    A35 = 35,

    /// <summary>
    /// Minimum remaining available margin target
    /// </summary>
    /// <remarks>
    /// Target capacity for exchanges by deducing the exchanges not related to the region.
    /// </remarks>
    A36 = 36,

    /// <summary>
    /// Average voltage
    /// </summary>
    /// <remarks>
    /// Average voltage on two connecting nodes of a critical network element resulting from AC load flow calculation with applied reactive power constraints (U).
    /// </remarks>
    A37 = 37,

    /// <summary>
    /// Average power factor
    /// </summary>
    /// <remarks>
    /// Average power factor on two connecting nodes of a critical network element resulting from AC load flow calculation (cos phi).
    /// </remarks>
    A38 = 38,

    /// <summary>
    /// Lower ramp rate
    /// </summary>
    /// <remarks>
    /// The maximum rate that the output can be lowered by.
    /// </remarks>
    A39 = 39,

    /// <summary>
    /// Raise ramp rate
    /// </summary>
    /// <remarks>
    /// The maximum rate that the output can be raised by.
    /// </remarks>
    A40 = 40,

    /// <summary>
    /// Negative reference flow
    /// </summary>
    /// <remarks>
    /// The amount of power negatively affected by a contingency that reflects a situation with scheduled exchanges from a reference situation. 
    /// </remarks>
    A41 = 41,

    /// <summary>
    /// Negative flow due to non-costly remedial actions
    /// </summary>
    /// <remarks>
    /// Negative expected flow change due to non-costly remedial actions.
    /// </remarks>
    A42 = 42
}

