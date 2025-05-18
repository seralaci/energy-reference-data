// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// The coded type of a document. The message type describes the principal characteristic of a document.	/// This enumeration is used in the XML instances based on IEC 62325.
/// </summary>
/// <remarks>
/// ET0003
/// </remarks>
public enum MessageType
{
    /// <summary>
    /// Balance responsible schedule
    /// </summary>
    /// <remarks>
    /// A schedule which has been prepared by a balance responsible party providing planned schedule information.
    /// </remarks>
    A01 = 1,

    /// <summary>
    /// Allocated capacity schedule
    /// </summary>
    /// <remarks>
    /// A schedule which has been prepared by a capacity allocator providing allocated capacity.
    /// </remarks>
    A02 = 2,

    /// <summary>
    /// Balance area schedule
    /// </summary>
    /// <remarks>
    /// A schedule that provides the planned schedule information for a balance area.
    /// </remarks>
    A03 = 3,

    /// <summary>
    /// System Operator area schedule
    /// </summary>
    /// <remarks>
    /// A compilation of all external schedules concerning two System Operator areas or a connector concerning two System Operator of all balance responsible parties.
    /// </remarks>
    A04 = 4,

    /// <summary>
    /// Control block area schedule
    /// </summary>
    /// <remarks>
    /// A compilation of all the exchange programs of all control areas for one control block with all neighbouring control areas of a neighbouring control block.
    /// </remarks>
    A05 = 5,

    /// <summary>
    /// Coordination center area schedule
    /// </summary>
    /// <remarks>
    /// A compilation of the exchange programs of all exchange blocks divided into UCTE south and north.
    /// </remarks>
    A06 = 6,

    /// <summary>
    /// Intermediate confirmation report
    /// </summary>
    /// <remarks>
    /// An intermediate confirmation report that may be produced between final cutoffs.
    /// </remarks>
    A07 = 7,

    /// <summary>
    /// Final confirmation report
    /// </summary>
    /// <remarks>
    /// A final confirmation report that is produced after a final cutoff.
    /// </remarks>
    A08 = 8,

    /// <summary>
    /// Finalised schedule
    /// </summary>
    /// <remarks>
    /// A compilation of a set of schedules that have been finalized after a given cutoff.
    /// </remarks>
    A09 = 9,

    /// <summary>
    /// Regulation data report
    /// </summary>
    /// <remarks>
    /// A compilation of the time series employed on a given day to ensure the balance of the system.
    /// </remarks>
    A10 = 10,

    /// <summary>
    /// Aggregated energy data report
    /// </summary>
    /// <remarks>
    /// A compilation of the time series of all the meter readings or their equivalent for a given period.
    /// </remarks>
    A11 = 11,

    /// <summary>
    /// Imbalance report
    /// </summary>
    /// <remarks>
    /// The report containing the complete situation of a given period for a party and including the schedules, regulation data and actual or calculated readings.
    /// </remarks>
    A12 = 12,

    /// <summary>
    /// Interconnection Capacity
    /// </summary>
    /// <remarks>
    /// Document for cross-border capacity exchanges.
    /// </remarks>
    A13 = 13,

    /// <summary>
    /// Resource Provider Resource Schedule
    /// </summary>
    /// <remarks>
    /// A document providing the schedules for resource objects submitted by a resource provider.
    /// </remarks>
    A14 = 14,

    /// <summary>
    /// Acquiring System Operator Reserve Schedule
    /// </summary>
    /// <remarks>
    /// A document providing reserve purchases submitted by an Acquiring System Operator.
    /// </remarks>
    A15 = 15,

    /// <summary>
    /// Anomaly Report
    /// </summary>
    /// <remarks>
    /// A document providing anomaly information for the receiving party to correct.
    /// </remarks>
    A16 = 16,

    /// <summary>
    /// Acknowledgement Document
    /// </summary>
    /// <remarks>
    /// A document providing acknowledgement information.
    /// </remarks>
    A17 = 17,

    /// <summary>
    /// Confirmation report
    /// </summary>
    /// <remarks>
    /// A document providing confirmation information.
    /// </remarks>
    A18 = 18,

    /// <summary>
    /// Capacity for Resale
    /// </summary>
    /// <remarks>
    /// A document providing information about capacity for resale.
    /// </remarks>
    A19 = 19,

    /// <summary>
    /// Approved Capacity Transfer
    /// </summary>
    /// <remarks>
    /// A document to approve a capacity transfer.
    /// </remarks>
    A20 = 20,

    /// <summary>
    /// Capacity transfer notification
    /// </summary>
    /// <remarks>
    /// A document notifying a capacity transfer.
    /// </remarks>
    A21 = 21,

    /// <summary>
    /// Transmission rights portfolio
    /// </summary>
    /// <remarks>
    /// A document providing the portfolio of the transmission capacity rights of a market participant.
    /// </remarks>
    A22 = 22,

    /// <summary>
    /// Allocations
    /// </summary>
    /// <remarks>
    /// A document providing the capacity allocations for a border.
    /// </remarks>
    A23 = 23,

    /// <summary>
    /// Bid document
    /// </summary>
    /// <remarks>
    /// A document providing bid information.
    /// </remarks>
    A24 = 24,

    /// <summary>
    /// Allocation result document
    /// </summary>
    /// <remarks>
    /// A document providing the allocation results of an auction.
    /// </remarks>
    A25 = 25,

    /// <summary>
    /// Capacity document
    /// </summary>
    /// <remarks>
    /// A document providing capacity information.
    /// </remarks>
    A26 = 26,

    /// <summary>
    /// Rights document
    /// </summary>
    /// <remarks>
    /// A document providing transmission capacity rights information.
    /// </remarks>
    A27 = 27,

    /// <summary>
    /// Generation availability schedule
    /// </summary>
    /// <remarks>
    /// This document contains information related to energy availability.
    /// </remarks>
    A28 = 28,

    /// <summary>
    /// Cross border schedule
    /// </summary>
    /// <remarks>
    /// This document contains the cross border schedules for all the borders of a given country where energy is exchanged.
    /// </remarks>
    A30 = 29,

    /// <summary>
    /// Agreed capacity
    /// </summary>
    /// <remarks>
    /// The capacity agreed between parties.
    /// </remarks>
    A31 = 30,

    /// <summary>
    /// Proposed capacity
    /// </summary>
    /// <remarks>
    /// The capacity proposed for agreement between parties.
    /// </remarks>
    A32 = 31,

    /// <summary>
    /// System vertical load
    /// </summary>
    /// <remarks>
    /// The sum of all flows out of the transmission grid via directly connected transformers and lines to distribution grids and end consumers as known by the System Operator.
    /// </remarks>
    A33 = 32,

    /// <summary>
    /// Escalation document
    /// </summary>
    /// <remarks>
    /// A document which requesting the escalation of a situation.
    /// </remarks>
    A34 = 33,

    /// <summary>
    /// Trouble shooting document
    /// </summary>
    /// <remarks>
    /// A document providing trouble shooting information for the resolution of a problem.
    /// </remarks>
    A35 = 34,

    /// <summary>
    /// Deactivation document
    /// </summary>
    /// <remarks>
    /// A document providing deactivation information.
    /// </remarks>
    A36 = 35,

    /// <summary>
    /// Reserve tender document
    /// </summary>
    /// <remarks>
    /// The document that is used for the tendering for reserves within the ERRP process.
    /// </remarks>
    A37 = 36,

    /// <summary>
    /// Reserve Allocation Result Document
    /// </summary>
    /// <remarks>
    /// The document used to provide the results of a Reserve auction.
    /// </remarks>
    A38 = 37,

    /// <summary>
    /// SATCR activation
    /// </summary>
    /// <remarks>
    /// The document is used to provide the activation of reserves through the SATCR process.
    /// </remarks>
    A39 = 38,

    /// <summary>
    /// DATCR activation
    /// </summary>
    /// <remarks>
    /// The document is used to provide the activation of reserves through the DATCR process.
    /// </remarks>
    A40 = 39,

    /// <summary>
    /// Activation response
    /// </summary>
    /// <remarks>
    /// The document is used to provide a response to a request to activate reserves.
    /// </remarks>
    A41 = 40,

    /// <summary>
    /// Tender reduction
    /// </summary>
    /// <remarks>
    /// The document is used to provide information concerning the reduction of a previously submitted tender.
    /// </remarks>
    A42 = 41,

    /// <summary>
    /// MOL Document
    /// </summary>
    /// <remarks>
    /// The document is used to provide Merit Order List information.
    /// </remarks>
    A43 = 42,

    /// <summary>
    /// Price Document
    /// </summary>
    /// <remarks>
    /// The document is used to provide market price information.
    /// </remarks>
    A44 = 43,

    /// <summary>
    /// Measurement Value Document
    /// </summary>
    /// <remarks>
    /// The document is used to provide measurement information from measurement devices.
    /// </remarks>
    A45 = 44,

    /// <summary>
    /// SOAM Document
    /// </summary>
    /// <remarks>
    /// The document is used to provide system operator accounting data for matching.
    /// </remarks>
    A46 = 45,

    /// <summary>
    /// SOVA Document
    /// </summary>
    /// <remarks>
    /// The document is used to provide system operator validated accounting data.
    /// </remarks>
    A47 = 46,

    /// <summary>
    /// CCVA Document
    /// </summary>
    /// <remarks>
    /// The document is used to provide coordination center validated accounting data.
    /// </remarks>
    A48 = 47,

    /// <summary>
    /// Daily settlement document
    /// </summary>
    /// <remarks>
    /// The document is used to provide daily settlement information.
    /// </remarks>
    A49 = 48,

    /// <summary>
    /// Weekly settlement document
    /// </summary>
    /// <remarks>
    /// The document is used to provide weekly settlement information.
    /// </remarks>
    A50 = 49,

    /// <summary>
    /// Capacity Auction Specification Document
    /// </summary>
    /// <remarks>
    /// The document is used to provide capacity auction specification information.
    /// </remarks>
    A51 = 50,

    /// <summary>
    /// Market Coupling Results Document
    /// </summary>
    /// <remarks>
    /// The document is used to provide the results of a market coupling auction.
    /// </remarks>
    A52 = 51,

    /// <summary>
    /// Outage publication Document
    /// </summary>
    /// <remarks>
    /// The document is used to provide the outage information for publication.
    /// </remarks>
    A53 = 52,

    /// <summary>
    /// Forced generation outage Document
    /// </summary>
    /// <remarks>
    /// A document providing information on forced generation outages.
    /// </remarks>
    A54 = 53,

    /// <summary>
    /// Summarised Market Schedule
    /// </summary>
    /// <remarks>
    /// A compilation of all external schedules concerning two Market Balance Areas of all balance responsible parties.
    /// </remarks>
    A55 = 54,

    /// <summary>
    /// Compensation Program Schedule
    /// </summary>
    /// <remarks>
    /// A schedule that provides the schedule information for the compensation of unintended deviation.
    /// </remarks>
    A56 = 55,

    /// <summary>
    /// Load Frequency Control Program Schedule
    /// </summary>
    /// <remarks>
    /// A schedule that provides the schedule information for the Load Frequency Control Program of a Control Area or a Control Block.
    /// </remarks>
    A57 = 56,

    /// <summary>
    /// Timeframe Independent Schedule
    /// </summary>
    /// <remarks>
    /// A compilation of all external Timeframe Independent Schedules concerning two System Operators.
    /// </remarks>
    A58 = 57,

    /// <summary>
    /// Information request
    /// </summary>
    /// <remarks>
    /// An information request being made concerning some specific information.
    /// </remarks>
    A59 = 58,

    /// <summary>
    /// status request for a position independently from a specific process
    /// </summary>
    /// <remarks>
    /// A status request concerning the position of an object independently of any ongoing processes.
    /// </remarks>
    A60 = 59,

    /// <summary>
    /// Estimated Net Transfer Capacity
    /// </summary>
    /// <remarks>
    /// The estimated net transfer capacity for a given border.
    /// </remarks>
    A61 = 60,

    /// <summary>
    /// Compensation rights
    /// </summary>
    /// <remarks>
    /// The capacity rights that have been allocated as compensation.
    /// </remarks>
    A62 = 61,

    /// <summary>
    /// Redispatch notice
    /// </summary>
    /// <remarks>
    /// A notice to confirm the actions agreed between System Operators to resolve a congestion situation through redispatch.
    /// </remarks>
    A63 = 62,

    /// <summary>
    /// Tender reduction response
    /// </summary>
    /// <remarks>
    /// A response to a tender reduction request that provides  corrections to the initial document.
    /// </remarks>
    A64 = 63,

    /// <summary>
    /// System total load
    /// </summary>
    /// <remarks>
    /// Total load', including losses without power used for energy storage, is equal to generation deducted with exports, added with imports and deducted with power used for energy storage.
    /// </remarks>
    A65 = 64,

    /// <summary>
    /// Final MOL
    /// </summary>
    /// <remarks>
    /// A document providing the information concerning the situation of the MOL at the end of an activation period.
    /// </remarks>
    A66 = 65,

    /// <summary>
    /// Resource Provider Schedule for production/consumption
    /// </summary>
    /// <remarks>
    /// A document providing the schedules for production/consumption for resource objects submitted by a resource provider.
    /// </remarks>
    A67 = 66,

    /// <summary>
    /// Installed generation per type
    /// </summary>
    /// <remarks>
    /// A document providing the installed generation per generation type.
    /// </remarks>
    A68 = 67,

    /// <summary>
    /// Wind and solar forecast
    /// </summary>
    /// <remarks>
    /// A document providing the forecast of wind and solar generation.
    /// </remarks>
    A69 = 68,

    /// <summary>
    /// Load forecast margin
    /// </summary>
    /// <remarks>
    /// A document providing the load forecast margin for a period.
    /// </remarks>
    A70 = 69,

    /// <summary>
    /// Generation forecast
    /// </summary>
    /// <remarks>
    /// A document providing the generation forecast for a period.
    /// </remarks>
    A71 = 70,

    /// <summary>
    /// Reservoir filling information
    /// </summary>
    /// <remarks>
    /// A document providing information concerning the filling of reservoirs.
    /// </remarks>
    A72 = 71,

    /// <summary>
    /// Actual generation
    /// </summary>
    /// <remarks>
    /// A document providing the actual generation for a period.
    /// </remarks>
    A73 = 72,

    /// <summary>
    /// Wind and solar generation
    /// </summary>
    /// <remarks>
    /// A document providing the generation of wind and solar energy for a period.
    /// </remarks>
    A74 = 73,

    /// <summary>
    /// Actual generation per type
    /// </summary>
    /// <remarks>
    /// A document providing the actual generation per generation type for a period.
    /// </remarks>
    A75 = 74,

    /// <summary>
    /// Load unavailability
    /// </summary>
    /// <remarks>
    /// A document providing the unavailability of units providing load on the network.
    /// </remarks>
    A76 = 75,

    /// <summary>
    /// Production unavailability
    /// </summary>
    /// <remarks>
    /// A document providing the unavailability of production units providing energy to the network.
    /// </remarks>
    A77 = 76,

    /// <summary>
    /// Transmission unavailability
    /// </summary>
    /// <remarks>
    /// A document providing the unavailability of transmission capacity on the network.
    /// </remarks>
    A78 = 77,

    /// <summary>
    /// Offshore grid infrastructure unavailability
    /// </summary>
    /// <remarks>
    /// A document providing the unavailability of an offshore grid infrastructure to the network.
    /// </remarks>
    A79 = 78,

    /// <summary>
    /// Generation unavailability
    /// </summary>
    /// <remarks>
    /// A document providing the unavailability of generation units providing energy to the network.
    /// </remarks>
    A80 = 79,

    /// <summary>
    /// Contracted reserves
    /// </summary>
    /// <remarks>
    /// A document providing the reserves contracted for a period.
    /// </remarks>
    A81 = 80,

    /// <summary>
    /// Accepted offers
    /// </summary>
    /// <remarks>
    /// A document providing the offers of reserves that have been accepted for a period.
    /// </remarks>
    A82 = 81,

    /// <summary>
    /// Activated balancing quantities
    /// </summary>
    /// <remarks>
    /// A document providing the quantities of reserves that have been activated for balancing.
    /// </remarks>
    A83 = 82,

    /// <summary>
    /// Activated balancing prices
    /// </summary>
    /// <remarks>
    /// A document providing the prices of the reserves that have been activated for balancing.
    /// </remarks>
    A84 = 83,

    /// <summary>
    /// Imbalance prices
    /// </summary>
    /// <remarks>
    /// A document providing the prices of reserves due to imbalance for a period.
    /// </remarks>
    A85 = 84,

    /// <summary>
    /// Imbalance volume
    /// </summary>
    /// <remarks>
    /// A document providing the volume of the imbalance for a period.
    /// </remarks>
    A86 = 85,

    /// <summary>
    /// Financial situation
    /// </summary>
    /// <remarks>
    /// A document providing the financial situation for reserves.
    /// </remarks>
    A87 = 86,

    /// <summary>
    /// Cross border balancing
    /// </summary>
    /// <remarks>
    /// A document providing the cross border balancing requirements for a period.
    /// </remarks>
    A88 = 87,

    /// <summary>
    /// Contracted reserve prices
    /// </summary>
    /// <remarks>
    /// A document providing the price of reserves contracted for a period.
    /// </remarks>
    A89 = 88,

    /// <summary>
    /// Interconnection network expansion
    /// </summary>
    /// <remarks>
    /// A document providing information on the expansion of the interconnection network.
    /// </remarks>
    A90 = 89,

    /// <summary>
    /// Counter trade notice
    /// </summary>
    /// <remarks>
    /// A document providing information on counter trades for a period.
    /// </remarks>
    A91 = 90,

    /// <summary>
    /// Congestion costs
    /// </summary>
    /// <remarks>
    /// A document providing the cost of congestion for a period.
    /// </remarks>
    A92 = 91,

    /// <summary>
    /// DC link capacity
    /// </summary>
    /// <remarks>
    /// A document providing the DC links for a period.
    /// </remarks>
    A93 = 92,

    /// <summary>
    /// Non EU allocations
    /// </summary>
    /// <remarks>
    /// A document providing allocations made to non EU member states.
    /// </remarks>
    A94 = 93,

    /// <summary>
    /// Configuration document
    /// </summary>
    /// <remarks>
    /// A document providing configuration information.
    /// </remarks>
    A95 = 94,

    /// <summary>
    /// Redispatch activation document
    /// </summary>
    /// <remarks>
    /// A document enabling the activation of a redispatch notice.
    /// </remarks>
    A96 = 95,

    /// <summary>
    /// Detailed activation history document
    /// </summary>
    /// <remarks>
    /// A document enabling a detailed history of activations.
    /// </remarks>
    A97 = 96,

    /// <summary>
    /// Aggregated activation history document
    /// </summary>
    /// <remarks>
    /// A document enabling an aggregated history of activations.
    /// </remarks>
    A98 = 97,

    /// <summary>
    /// HVDC Link constraints
    /// </summary>
    /// <remarks>
    /// A document providing the information concerning the maximum and minimum active power flow through each link can limited.
    /// </remarks>
    A99 = 98,

    /// <summary>
    /// HVDC Configuration
    /// </summary>
    /// <remarks>
    /// A document providing the information concerning the power set point. The mode in which the  HVDC is managed.
    /// </remarks>
    B01 = 99,

    /// <summary>
    /// HVDC Schedule
    /// </summary>
    /// <remarks>
    /// A document providing the information for operating DC links.
    /// </remarks>
    B02 = 100,

    /// <summary>
    /// EIC code request
    /// </summary>
    /// <remarks>
    /// A document providing the information requesting a new EIC code.
    /// </remarks>
    B03 = 101,

    /// <summary>
    /// EIC code information
    /// </summary>
    /// <remarks>
    /// A document providing EIC information  in a central registry exchange or information to an EIC participant.
    /// </remarks>
    B04 = 102,

    /// <summary>
    /// EIC code publication
    /// </summary>
    /// <remarks>
    /// A document providing EIC publication information in a web site publication of a limited set of information.
    /// </remarks>
    B05 = 103,

    /// <summary>
    /// Critical network element determination
    /// </summary>
    /// <remarks>
    /// A document providing all the elements necessary for the capacity coordinator to determine the transfer capacity and the associated critical network elements.
    /// </remarks>
    B06 = 104,

    /// <summary>
    /// Critical network element publication
    /// </summary>
    /// <remarks>
    /// A document providing all the elements necessary for the market information aggregator and TSOs to know the critical network elements which limit the transfer capacity.
    /// </remarks>
    B07 = 105,

    /// <summary>
    /// Flow based domain
    /// </summary>
    /// <remarks>
    /// A document providing the capacity domain and its limits available for the TSO.
    /// </remarks>
    B08 = 106,

    /// <summary>
    /// Flow based domain publication
    /// </summary>
    /// <remarks>
    /// A document providing the capacity domain and its limits available for the market.
    /// </remarks>
    B09 = 107,

    /// <summary>
    /// Flow based domain market impact publication
    /// </summary>
    /// <remarks>
    /// A document providing the capacity domain and its impacts on the market to be published.
    /// </remarks>
    B10 = 108,

    /// <summary>
    /// Anonymized flow based parameters publication
    /// </summary>
    /// <remarks>
    /// A document providing all the relevant flow based parameters in case of flow based capacity allocation.
    /// </remarks>
    B11 = 109,

    /// <summary>
    /// Critical network element market impact publication
    /// </summary>
    /// <remarks>
    /// A document providing the critical network elements and its impacts on the market to be published.
    /// </remarks>
    B12 = 110,

    /// <summary>
    /// Weather document
    /// </summary>
    /// <remarks>
    /// An estimation or prediction in advance of the weather by analysis of meteorological data and the results of what actually happened with the weather.
    /// </remarks>
    B13 = 111,

    /// <summary>
    /// Energy prognosis document
    /// </summary>
    /// <remarks>
    /// A document to provide the prognosis of energy production/load for a given period.
    /// </remarks>
    B14 = 112,

    /// <summary>
    /// Network constraint document
    /// </summary>
    /// <remarks>
    /// A document providing the network constraint situations used for the load flow studies. A network constraint situation includes contingencies, monitored elements and remedial actions.
    /// </remarks>
    B15 = 113,

    /// <summary>
    /// Aggregated netted external market schedule document
    /// </summary>
    /// <remarks>
    /// A document used to report aggregated netted external market schedules for a given border.
    /// </remarks>
    B16 = 114,

    /// <summary>
    /// Aggregated netted external TSO schedule document
    /// </summary>
    /// <remarks>
    /// A document used to report aggregated netted external TSO schedules for a given border.
    /// </remarks>
    B17 = 115,

    /// <summary>
    /// Reporting status market document
    /// </summary>
    /// <remarks>
    /// A document used to report the status of aggregated netted external market schedules, aggregated netted external TSO schedules and compensation program schedules on a given border.
    /// </remarks>
    B18 = 116,

    /// <summary>
    /// Reporting information market document
    /// </summary>
    /// <remarks>
    /// A document used to report  the information concerning aggregated netted external schedules, aggregated netted external market schedules, aggregated netted external TSO schedules, compensation program schedules, netted area position schedules and netted area AC position schedules to an interested party.
    /// </remarks>
    B19 = 117,

    /// <summary>
    /// Status request for a reporting information market document
    /// </summary>
    /// <remarks>
    /// A document requesting the provision of a reporting information document.
    /// </remarks>
    B20 = 118,

    /// <summary>
    /// Reserve need document
    /// </summary>
    /// <remarks>
    /// Used by a TSO to send its reserve needs.
    /// </remarks>
    B21 = 119,

    /// <summary>
    /// Generation and load shift keys document
    /// </summary>
    /// <remarks>
    /// A document providing the values of the generation and load shift keys to be used on network model.
    /// </remarks>
    B22 = 120,

    /// <summary>
    /// Offers to be activated
    /// </summary>
    /// <remarks>
    /// A document containing the outcome of the process, with the list of offers that are to be activated by the TSO concerned and the results for its reserve needs.
    /// </remarks>
    B23 = 121,

    /// <summary>
    /// Clearing price
    /// </summary>
    /// <remarks>
    /// A document containing the outcome of the process, with the clearing prices for a period.
    /// </remarks>
    B24 = 122,

    /// <summary>
    /// Security analysis report
    /// </summary>
    /// <remarks>
    /// A document providing a report on a performed security analysis.
    /// </remarks>
    B25 = 123,

    /// <summary>
    /// Aggregated netted external schedule document
    /// </summary>
    /// <remarks>
    /// A document used to report aggregated netted external schedules for a given border. 
    /// </remarks>
    B26 = 124,

    /// <summary>
    /// External TSO schedule
    /// </summary>
    /// <remarks>
    /// A document used to report external TSO schedules for a given border or interconnector.
    /// </remarks>
    B27 = 125,

    /// <summary>
    /// Move of scheduled production
    /// </summary>
    /// <remarks>
    /// A document indication a move of scheduled production.
    /// </remarks>
    B28 = 126,

    /// <summary>
    /// PS&LC results document
    /// </summary>
    /// <remarks>
    /// A document providing Pole Splitting &amp; Loss Calculation results.
    /// </remarks>
    B29 = 127,

    /// <summary>
    /// Notification data market document
    /// </summary>
    /// <remarks>
    /// A document used to notify data to any information receiver.
    /// </remarks>
    B30 = 128,

    /// <summary>
    /// Additional Constraint document
    /// </summary>
    /// <remarks>
    /// A document describing additional constraints for a capacity calculation process.
    /// </remarks>
    B31 = 129,

    /// <summary>
    /// Operational state document
    /// </summary>
    /// <remarks>
    /// A document used for exchanging operational states for grid assets.
    /// </remarks>
    B32 = 130,

    /// <summary>
    /// Published offered capacity
    /// </summary>
    /// <remarks>
    /// A document providing the most recent values of offered capacity.
    /// </remarks>
    B33 = 131,

    /// <summary>
    /// Market result document
    /// </summary>
    /// <remarks>
    /// Published prices and volumes
    /// </remarks>
    B34 = 132,

    /// <summary>
    /// Area Configuration document
    /// </summary>
    /// <remarks>
    /// A document containing the definition of areas.
    /// </remarks>
    B35 = 133,

    /// <summary>
    /// Area Composition document
    /// </summary>
    /// <remarks>
    /// A document containing the relations between areas, i.e which Metering Grid Areas a Bidding Zone composed of.
    /// </remarks>
    B36 = 134,

    /// <summary>
    /// Connected Areas document
    /// </summary>
    /// <remarks>
    /// A document containing which other areas an area is connected to i.e. which Metering Grid Areas a Metering Grid Area is connected to.
    /// </remarks>
    B37 = 135,

    /// <summary>
    /// Settlement document
    /// </summary>
    /// <remarks>
    /// A document providing settlement information.
    /// </remarks>
    B38 = 136,

    /// <summary>
    /// Imbalance prognosis document
    /// </summary>
    /// <remarks>
    /// A document to provide the prognosis of energy imbalances for a given period.
    /// </remarks>
    B39 = 137,

    /// <summary>
    /// Complete set of bids
    /// </summary>
    /// <remarks>
    /// Submission of complete set of bids. If there are existing bids, they should be replaced.
    /// </remarks>
    B40 = 138,

    /// <summary>
    /// Merged MOL notice
    /// </summary>
    /// <remarks>
    /// A notice providing information on the MOL merging process.
    /// </remarks>
    B41 = 139,

    /// <summary>
    /// K-factor document
    /// </summary>
    /// <remarks>
    /// A document providing K-factor values.
    /// </remarks>
    B42 = 140,

    /// <summary>
    /// Settlement coordination document
    /// </summary>
    /// <remarks>
    /// A document providing settlement information for coordination between different parties.
    /// </remarks>
    B43 = 141,

    /// <summary>
    /// Financial settlement document
    /// </summary>
    /// <remarks>
    /// A document providing financial settlement information.
    /// </remarks>
    B44 = 142,

    /// <summary>
    /// Bid availability document
    /// </summary>
    /// <remarks>
    /// A document providing the detailed reasons for changing the availability or volume of a bid.
    /// </remarks>
    B45 = 143,

    /// <summary>
    /// Resource capacity unit document
    /// </summary>
    /// <remarks>
    /// A document providing information about resource capacity units.
    /// </remarks>
    B46 = 144,

    /// <summary>
    /// Other market information
    /// </summary>
    /// <remarks>
    /// A document providing other market information.
    /// </remarks>
    B47 = 145,

    /// <summary>
    /// Permission document
    /// </summary>
    /// <remarks>
    /// A document that contains detailed information about permissions.
    /// </remarks>
    B48 = 146,

    /// <summary>
    /// Requested capacity
    /// </summary>
    /// <remarks>
    /// A document providing requested capacity (e.g. ATC, CZCL) value.	/// 
    /// </remarks>
    B49 = 147,

    /// <summary>
    /// Voltage control activation document
    /// </summary>
    /// <remarks>
    /// A document providing the number of generating units to activate for voltage control, by means of their operation in synchronous condenser mode.	/// 
    /// </remarks>
    B50 = 148,

    /// <summary>
    /// Transmission inventory document
    /// </summary>
    /// <remarks>
    /// A document providing a transmission inventory.
    /// </remarks>
    B51 = 149,

    /// <summary>
    /// Transmission inventory
    /// </summary>
    /// <remarks>
    /// A document providing statistics on the transmission grid.
    /// </remarks>
    B52 = 150
}

