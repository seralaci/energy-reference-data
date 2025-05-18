// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// Identification of the role played by a party.
/// </summary>
/// <remarks>
/// ET0005
/// </remarks>
public enum RoleType
{
    /// <summary>
    /// Trade responsible party
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A01 = 1,

    /// <summary>
    /// Consumption responsible party
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A02 = 2,

    /// <summary>
    /// Combined power exchange (not to be used)
    /// </summary>
    /// <remarks>
    /// This role is no longer in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A03 = 3,

    /// <summary>
    /// System operator
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A04 = 4,

    /// <summary>
    /// Imbalance settlement responsible
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A05 = 5,

    /// <summary>
    /// Production responsible party
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A06 = 6,

    /// <summary>
    /// Transmission capacity allocator
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A07 = 7,

    /// <summary>
    /// Balance responsible party
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A08 = 8,

    /// <summary>
    /// Metered data aggregator
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A09 = 9,

    /// <summary>
    /// Billing agent
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A10 = 10,

    /// <summary>
    /// Market operator
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A11 = 11,

    /// <summary>
    /// Energy supplier
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A12 = 12,

    /// <summary>
    /// Consumer
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A13 = 13,

    /// <summary>
    /// Control area operator
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A14 = 14,

    /// <summary>
    /// Control block operator
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A15 = 15,

    /// <summary>
    /// Coordination centre operator
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A16 = 16,

    /// <summary>
    /// Grid access provider
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A17 = 17,

    /// <summary>
    /// Grid operator
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A18 = 18,

    /// <summary>
    /// Meter administrator
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A19 = 19,

    /// <summary>
    /// Party connected to grid
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A20 = 20,

    /// <summary>
    /// Producer
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A21 = 21,

    /// <summary>
    /// Profile maintenance party
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A22 = 22,

    /// <summary>
    /// Meter operator
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A23 = 23,

    /// <summary>
    /// Metered data collector
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A24 = 24,

    /// <summary>
    /// Metered data responsible
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A25 = 25,

    /// <summary>
    /// Metering point administrator
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A26 = 26,

    /// <summary>
    /// Resource Provider
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A27 = 27,

    /// <summary>
    /// Scheduling coordinator
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A28 = 28,

    /// <summary>
    /// Capacity Trader
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A29 = 29,

    /// <summary>
    /// Interconnection Trade Responsible
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A30 = 30,

    /// <summary>
    /// Nomination Validator
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document.
    /// </remarks>
    A31 = 31,

    /// <summary>
    /// Market information aggregator
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document. 	/// A party that collects information from different sources and assembles  it to provide a summary of the market.
    /// </remarks>
    A32 = 32,

    /// <summary>
    /// Information receiver
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document. 	/// A party, not necessarily a market participant, which receives information about the market.
    /// </remarks>
    A33 = 33,

    /// <summary>
    /// Reserve Allocator
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document. 	/// A party that informs the market of reserve requirements, receives tenders against the requirements and in compliance with the prequalification criteria, determines what tenders meet requirements and assigns tenders.
    /// </remarks>
    A34 = 34,

    /// <summary>
    /// MOL Responsible
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document. 	/// A party that Informs the market of reserve requirements, receives tenders against the requirements and in compliance with the prequalification criteria, determines what tenders meet requirements and assigns tenders.
    /// </remarks>
    A35 = 35,

    /// <summary>
    /// Capacity Coordinator
    /// </summary>
    /// <remarks>
    /// A party, acting on behalf of the SOs involved, responsible for establishing a coordinated Offered Capacity and/or NTC and/or ATC between several Scheduling Areas.
    /// </remarks>
    A36 = 36,

    /// <summary>
    /// Reconciliation Accountable
    /// </summary>
    /// <remarks>
    /// Refer to role model definitions in the ENTSO-E Harmonised Role Model Document. 	/// A party that is financially accountable for the reconciled volume of energy products for a profiled local metering point.
    /// </remarks>
    A37 = 37,

    /// <summary>
    /// Reconciliation Responsible
    /// </summary>
    /// <remarks>
    /// A party that is responsible for reconciling, within a metering grid area, the volumes used in the imbalance settlement process for profiled metering points and the actual metered quantities.
    /// </remarks>
    A38 = 38,

    /// <summary>
    /// Data provider
    /// </summary>
    /// <remarks>
    /// A party that is responsible for providing information to a central authority.
    /// </remarks>
    A39 = 39,

    /// <summary>
    /// Local Issuing Office (LIO)
    /// </summary>
    /// <remarks>
    /// A party that is responsible for operating a Local Issuing Office (LIO).
    /// </remarks>
    A40 = 40,

    /// <summary>
    /// Central Issuing Office (CIO)
    /// </summary>
    /// <remarks>
    /// A party that is responsible for operating a Central Issuing Office (CIO).
    /// </remarks>
    A41 = 41,

    /// <summary>
    /// EIC Participant
    /// </summary>
    /// <remarks>
    /// A party that participates in the EIC environment.
    /// </remarks>
    A42 = 42,

    /// <summary>
    /// Weather analyser
    /// </summary>
    /// <remarks>
    /// A party that analyses the current and forecast weather situation and establishes a prognosis of its impact on the renewable energy environment as well as the overall load.
    /// </remarks>
    A43 = 43,

    /// <summary>
    /// Regional Security Coordinator (RSC)
    /// </summary>
    /// <remarks>
    /// The RSC as defined in the System Operation guideline.
    /// </remarks>
    A44 = 44,

    /// <summary>
    /// Energy Service Company (ESCO)
    /// </summary>
    /// <remarks>
    /// A party offering energy-related services to the Party Connected to Grid, but not directly active in the energy value chain or the physical infrastructure itself. The ESCO may provide insight services as well as energy management services.
    /// </remarks>
    A45 = 45,

    /// <summary>
    /// Balancing Service Provider
    /// </summary>
    /// <remarks>
    /// A party with reserve-providing units or reserve-providing groups able to provide balancing services to LFC Operators.
    /// </remarks>
    A46 = 46,

    /// <summary>
    /// Energy trader
    /// </summary>
    /// <remarks>
    /// A party that is selling or buying energy.
    /// </remarks>
    A47 = 47,

    /// <summary>
    /// LFC Operator
    /// </summary>
    /// <remarks>
    /// A party that is responsible for the Load Frequency Control of its LFC Area or LFC Block.
    /// </remarks>
    A48 = 48,

    /// <summary>
    /// Transmission System Operator (TSO)
    /// </summary>
    /// <remarks>
    /// The Transmission System Operator (TSO) is responsible for the transport of electricity on the extra high-voltage and high-voltage interconnected system. This is a market participant and not a role in Harmonised Role Model.
    /// </remarks>
    A49 = 49,

    /// <summary>
    /// Distribution System Operator (DSO)
    /// </summary>
    /// <remarks>
    /// Distribution System Operator (DSO) is responsible for transport of electricity on high-voltage (optionally), medium-voltage and low-voltage distribution systems. This is a market participant and not a role in Harmonised Role Model.
    /// </remarks>
    A50 = 50,

    /// <summary>
    /// Resource Capacity Mechanism Operator
    /// </summary>
    /// <remarks>
    /// Resource capacity mechanism operator is the party responsible to operate the resource capacity mechanism in a member state. It can either be the TSO or an independent party.
    /// </remarks>
    A51 = 51,

    /// <summary>
    /// Resource aggregator
    /// </summary>
    /// <remarks>
    /// A party that aggregates resources for usage by a service provider for energy market services.
    /// </remarks>
    A52 = 52,

    /// <summary>
    /// Cost sharing calculator
    /// </summary>
    /// <remarks>
    /// A party responsible for the mapping of the costs between areas and parties.
    /// </remarks>
    A53 = 53,

    /// <summary>
    /// Settlement responsible
    /// </summary>
    /// <remarks>
    /// A party responsible for settling the costs.
    /// </remarks>
    A54 = 54,

    /// <summary>
    /// Coordinated Capacity Calculator
    /// </summary>
    /// <remarks>
    /// Coordinated Capacity Calculator is the entity or entities with the task of calculating transmission capacity, at regional level or above.
    /// </remarks>
    A55 = 55,

    /// <summary>
    /// Flexibility service provider
    /// </summary>
    /// <remarks>
    /// A party that offers flexibility services based on acquired (aggregated) resources. 
    /// </remarks>
    A56 = 56,

    /// <summary>
    /// Data access provider
    /// </summary>
    /// <remarks>
    /// A party responsible for facilitating access to data.
    /// </remarks>
    A57 = 57,

    /// <summary>
    /// Metered data administrator
    /// </summary>
    /// <remarks>
    /// A party responsible for storing and distributing validated measured data.
    /// </remarks>
    A58 = 58,

    /// <summary>
    /// Permission administrator
    /// </summary>
    /// <remarks>
    /// A party responsible for administrating a register of data access permissions for a set of metering points, making this information available to final customers and eligible parties in the sector, on request.
    /// </remarks>
    A59 = 59
}

