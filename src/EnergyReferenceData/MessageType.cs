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
    A01,

    /// <summary>
    /// Allocated capacity schedule
    /// </summary>
    /// <remarks>
    /// A schedule which has been prepared by a capacity allocator providing allocated capacity.
    /// </remarks>
    A02,

    /// <summary>
    /// Balance area schedule
    /// </summary>
    /// <remarks>
    /// A schedule that provides the planned schedule information for a balance area.
    /// </remarks>
    A03,

    /// <summary>
    /// System Operator area schedule
    /// </summary>
    /// <remarks>
    /// A compilation of all external schedules concerning two System Operator areas or a connector concerning two System Operator of all balance responsible parties.
    /// </remarks>
    A04,

    /// <summary>
    /// Control block area schedule
    /// </summary>
    /// <remarks>
    /// A compilation of all the exchange programs of all control areas for one control block with all neighbouring control areas of a neighbouring control block.
    /// </remarks>
    A05,

    /// <summary>
    /// Coordination center area schedule
    /// </summary>
    /// <remarks>
    /// A compilation of the exchange programs of all exchange blocks divided into UCTE south and north.
    /// </remarks>
    A06,

    /// <summary>
    /// Intermediate confirmation report
    /// </summary>
    /// <remarks>
    /// An intermediate confirmation report that may be produced between final cutoffs.
    /// </remarks>
    A07,

    /// <summary>
    /// Final confirmation report
    /// </summary>
    /// <remarks>
    /// A final confirmation report that is produced after a final cutoff.
    /// </remarks>
    A08,

    /// <summary>
    /// Finalised schedule
    /// </summary>
    /// <remarks>
    /// A compilation of a set of schedules that have been finalized after a given cutoff.
    /// </remarks>
    A09,

    /// <summary>
    /// Regulation data report
    /// </summary>
    /// <remarks>
    /// A compilation of the time series employed on a given day to ensure the balance of the system.
    /// </remarks>
    A10,

    /// <summary>
    /// Aggregated energy data report
    /// </summary>
    /// <remarks>
    /// A compilation of the time series of all the meter readings or their equivalent for a given period.
    /// </remarks>
    A11,

    /// <summary>
    /// Imbalance report
    /// </summary>
    /// <remarks>
    /// The report containing the complete situation of a given period for a party and including the schedules, regulation data and actual or calculated readings.
    /// </remarks>
    A12,

    /// <summary>
    /// Interconnection Capacity
    /// </summary>
    /// <remarks>
    /// Document for cross-border capacity exchanges.
    /// </remarks>
    A13,

    /// <summary>
    /// Resource Provider Resource Schedule
    /// </summary>
    /// <remarks>
    /// A document providing the schedules for resource objects submitted by a resource provider.
    /// </remarks>
    A14,

    /// <summary>
    /// Acquiring System Operator Reserve Schedule
    /// </summary>
    /// <remarks>
    /// A document providing reserve purchases submitted by an Acquiring System Operator.
    /// </remarks>
    A15,

    /// <summary>
    /// Anomaly Report
    /// </summary>
    /// <remarks>
    /// A document providing anomaly information for the receiving party to correct.
    /// </remarks>
    A16,

    /// <summary>
    /// Acknowledgement Document
    /// </summary>
    /// <remarks>
    /// A document providing acknowledgement information.
    /// </remarks>
    A17,

    /// <summary>
    /// Confirmation report
    /// </summary>
    /// <remarks>
    /// A document providing confirmation information.
    /// </remarks>
    A18,

    /// <summary>
    /// Capacity for Resale
    /// </summary>
    /// <remarks>
    /// A document providing information about capacity for resale.
    /// </remarks>
    A19,

    /// <summary>
    /// Approved Capacity Transfer
    /// </summary>
    /// <remarks>
    /// A document to approve a capacity transfer.
    /// </remarks>
    A20,

    /// <summary>
    /// Capacity transfer notification
    /// </summary>
    /// <remarks>
    /// A document notifying a capacity transfer.
    /// </remarks>
    A21,

    /// <summary>
    /// Transmission rights portfolio
    /// </summary>
    /// <remarks>
    /// A document providing the portfolio of the transmission capacity rights of a market participant.
    /// </remarks>
    A22,

    /// <summary>
    /// Allocations
    /// </summary>
    /// <remarks>
    /// A document providing the capacity allocations for a border.
    /// </remarks>
    A23,

    /// <summary>
    /// Bid document
    /// </summary>
    /// <remarks>
    /// A document providing bid information.
    /// </remarks>
    A24,

    /// <summary>
    /// Allocation result document
    /// </summary>
    /// <remarks>
    /// A document providing the allocation results of an auction.
    /// </remarks>
    A25,

    /// <summary>
    /// Capacity document
    /// </summary>
    /// <remarks>
    /// A document providing capacity information.
    /// </remarks>
    A26,

    /// <summary>
    /// Rights document
    /// </summary>
    /// <remarks>
    /// A document providing transmission capacity rights information.
    /// </remarks>
    A27,

    /// <summary>
    /// Generation availability schedule
    /// </summary>
    /// <remarks>
    /// This document contains information related to energy availability.
    /// </remarks>
    A28,

    /// <summary>
    /// Cross border schedule
    /// </summary>
    /// <remarks>
    /// This document contains the cross border schedules for all the borders of a given country where energy is exchanged.
    /// </remarks>
    A30,

    /// <summary>
    /// Agreed capacity
    /// </summary>
    /// <remarks>
    /// The capacity agreed between parties.
    /// </remarks>
    A31,

    /// <summary>
    /// Proposed capacity
    /// </summary>
    /// <remarks>
    /// The capacity proposed for agreement between parties.
    /// </remarks>
    A32,

    /// <summary>
    /// System vertical load
    /// </summary>
    /// <remarks>
    /// The sum of all flows out of the transmission grid via directly connected transformers and lines to distribution grids and end consumers as known by the System Operator.
    /// </remarks>
    A33,

    /// <summary>
    /// Escalation document
    /// </summary>
    /// <remarks>
    /// A document which requesting the escalation of a situation.
    /// </remarks>
    A34,

    /// <summary>
    /// Trouble shooting document
    /// </summary>
    /// <remarks>
    /// A document providing trouble shooting information for the resolution of a problem.
    /// </remarks>
    A35,

    /// <summary>
    /// Deactivation document
    /// </summary>
    /// <remarks>
    /// A document providing deactivation information.
    /// </remarks>
    A36,

    /// <summary>
    /// Reserve tender document
    /// </summary>
    /// <remarks>
    /// The document that is used for the tendering for reserves within the ERRP process.
    /// </remarks>
    A37,

    /// <summary>
    /// Reserve Allocation Result Document
    /// </summary>
    /// <remarks>
    /// The document used to provide the results of a Reserve auction.
    /// </remarks>
    A38,

    /// <summary>
    /// SATCR activation
    /// </summary>
    /// <remarks>
    /// The document is used to provide the activation of reserves through the SATCR process.
    /// </remarks>
    A39,

    /// <summary>
    /// DATCR activation
    /// </summary>
    /// <remarks>
    /// The document is used to provide the activation of reserves through the DATCR process.
    /// </remarks>
    A40,

    /// <summary>
    /// Activation response
    /// </summary>
    /// <remarks>
    /// The document is used to provide a response to a request to activate reserves.
    /// </remarks>
    A41,

    /// <summary>
    /// Tender reduction
    /// </summary>
    /// <remarks>
    /// The document is used to provide information concerning the reduction of a previously submitted tender.
    /// </remarks>
    A42,

    /// <summary>
    /// MOL Document
    /// </summary>
    /// <remarks>
    /// The document is used to provide Merit Order List information.
    /// </remarks>
    A43,

    /// <summary>
    /// Price Document
    /// </summary>
    /// <remarks>
    /// The document is used to provide market price information.
    /// </remarks>
    A44,

    /// <summary>
    /// Measurement Value Document
    /// </summary>
    /// <remarks>
    /// The document is used to provide measurement information from measurement devices.
    /// </remarks>
    A45,

    /// <summary>
    /// SOAM Document
    /// </summary>
    /// <remarks>
    /// The document is used to provide system operator accounting data for matching.
    /// </remarks>
    A46,

    /// <summary>
    /// SOVA Document
    /// </summary>
    /// <remarks>
    /// The document is used to provide system operator validated accounting data.
    /// </remarks>
    A47,

    /// <summary>
    /// CCVA Document
    /// </summary>
    /// <remarks>
    /// The document is used to provide coordination center validated accounting data.
    /// </remarks>
    A48,

    /// <summary>
    /// Daily settlement document
    /// </summary>
    /// <remarks>
    /// The document is used to provide daily settlement information.
    /// </remarks>
    A49,

    /// <summary>
    /// Weekly settlement document
    /// </summary>
    /// <remarks>
    /// The document is used to provide weekly settlement information.
    /// </remarks>
    A50,

    /// <summary>
    /// Capacity Auction Specification Document
    /// </summary>
    /// <remarks>
    /// The document is used to provide capacity auction specification information.
    /// </remarks>
    A51,

    /// <summary>
    /// Market Coupling Results Document
    /// </summary>
    /// <remarks>
    /// The document is used to provide the results of a market coupling auction.
    /// </remarks>
    A52,

    /// <summary>
    /// Outage publication Document
    /// </summary>
    /// <remarks>
    /// The document is used to provide the outage information for publication.
    /// </remarks>
    A53,

    /// <summary>
    /// Forced generation outage Document
    /// </summary>
    /// <remarks>
    /// A document providing information on forced generation outages.
    /// </remarks>
    A54,

    /// <summary>
    /// Summarised Market Schedule
    /// </summary>
    /// <remarks>
    /// A compilation of all external schedules concerning two Market Balance Areas of all balance responsible parties.
    /// </remarks>
    A55,

    /// <summary>
    /// Compensation Program Schedule
    /// </summary>
    /// <remarks>
    /// A schedule that provides the schedule information for the compensation of unintended deviation.
    /// </remarks>
    A56,

    /// <summary>
    /// Load Frequency Control Program Schedule
    /// </summary>
    /// <remarks>
    /// A schedule that provides the schedule information for the Load Frequency Control Program of a Control Area or a Control Block.
    /// </remarks>
    A57,

    /// <summary>
    /// Timeframe Independent Schedule
    /// </summary>
    /// <remarks>
    /// A compilation of all external Timeframe Independent Schedules concerning two System Operators.
    /// </remarks>
    A58,

    /// <summary>
    /// Information request
    /// </summary>
    /// <remarks>
    /// An information request being made concerning some specific information.
    /// </remarks>
    A59,

    /// <summary>
    /// status request for a position independently from a specific process
    /// </summary>
    /// <remarks>
    /// A status request concerning the position of an object independently of any ongoing processes.
    /// </remarks>
    A60,

    /// <summary>
    /// Estimated Net Transfer Capacity
    /// </summary>
    /// <remarks>
    /// The estimated net transfer capacity for a given border.
    /// </remarks>
    A61,

    /// <summary>
    /// Compensation rights
    /// </summary>
    /// <remarks>
    /// The capacity rights that have been allocated as compensation.
    /// </remarks>
    A62,

    /// <summary>
    /// Redispatch notice
    /// </summary>
    /// <remarks>
    /// A notice to confirm the actions agreed between System Operators to resolve a congestion situation through redispatch.
    /// </remarks>
    A63,

    /// <summary>
    /// Tender reduction response
    /// </summary>
    /// <remarks>
    /// A response to a tender reduction request that provides  corrections to the initial document.
    /// </remarks>
    A64,

    /// <summary>
    /// System total load
    /// </summary>
    /// <remarks>
    /// Total load', including losses without power used for energy storage, is equal to generation deducted with exports, added with imports and deducted with power used for energy storage.
    /// </remarks>
    A65,

    /// <summary>
    /// Final MOL
    /// </summary>
    /// <remarks>
    /// A document providing the information concerning the situation of the MOL at the end of an activation period.
    /// </remarks>
    A66,

    /// <summary>
    /// Resource Provider Schedule for production/consumption
    /// </summary>
    /// <remarks>
    /// A document providing the schedules for production/consumption for resource objects submitted by a resource provider.
    /// </remarks>
    A67,

    /// <summary>
    /// Installed generation per type
    /// </summary>
    /// <remarks>
    /// A document providing the installed generation per generation type.
    /// </remarks>
    A68,

    /// <summary>
    /// Wind and solar forecast
    /// </summary>
    /// <remarks>
    /// A document providing the forecast of wind and solar generation.
    /// </remarks>
    A69,

    /// <summary>
    /// Load forecast margin
    /// </summary>
    /// <remarks>
    /// A document providing the load forecast margin for a period.
    /// </remarks>
    A70,

    /// <summary>
    /// Generation forecast
    /// </summary>
    /// <remarks>
    /// A document providing the generation forecast for a period.
    /// </remarks>
    A71,

    /// <summary>
    /// Reservoir filling information
    /// </summary>
    /// <remarks>
    /// A document providing information concerning the filling of reservoirs.
    /// </remarks>
    A72,

    /// <summary>
    /// Actual generation
    /// </summary>
    /// <remarks>
    /// A document providing the actual generation for a period.
    /// </remarks>
    A73,

    /// <summary>
    /// Wind and solar generation
    /// </summary>
    /// <remarks>
    /// A document providing the generation of wind and solar energy for a period.
    /// </remarks>
    A74,

    /// <summary>
    /// Actual generation per type
    /// </summary>
    /// <remarks>
    /// A document providing the actual generation per generation type for a period.
    /// </remarks>
    A75,

    /// <summary>
    /// Load unavailability
    /// </summary>
    /// <remarks>
    /// A document providing the unavailability of units providing load on the network.
    /// </remarks>
    A76,

    /// <summary>
    /// Production unavailability
    /// </summary>
    /// <remarks>
    /// A document providing the unavailability of production units providing energy to the network.
    /// </remarks>
    A77,

    /// <summary>
    /// Transmission unavailability
    /// </summary>
    /// <remarks>
    /// A document providing the unavailability of transmission capacity on the network.
    /// </remarks>
    A78,

    /// <summary>
    /// Offshore grid infrastructure unavailability
    /// </summary>
    /// <remarks>
    /// A document providing the unavailability of an offshore grid infrastructure to the network.
    /// </remarks>
    A79,

    /// <summary>
    /// Generation unavailability
    /// </summary>
    /// <remarks>
    /// A document providing the unavailability of generation units providing energy to the network.
    /// </remarks>
    A80,

    /// <summary>
    /// Contracted reserves
    /// </summary>
    /// <remarks>
    /// A document providing the reserves contracted for a period.
    /// </remarks>
    A81,

    /// <summary>
    /// Accepted offers
    /// </summary>
    /// <remarks>
    /// A document providing the offers of reserves that have been accepted for a period.
    /// </remarks>
    A82,

    /// <summary>
    /// Activated balancing quantities
    /// </summary>
    /// <remarks>
    /// A document providing the quantities of reserves that have been activated for balancing.
    /// </remarks>
    A83,

    /// <summary>
    /// Activated balancing prices
    /// </summary>
    /// <remarks>
    /// A document providing the prices of the reserves that have been activated for balancing.
    /// </remarks>
    A84,

    /// <summary>
    /// Imbalance prices
    /// </summary>
    /// <remarks>
    /// A document providing the prices of reserves due to imbalance for a period.
    /// </remarks>
    A85,

    /// <summary>
    /// Imbalance volume
    /// </summary>
    /// <remarks>
    /// A document providing the volume of the imbalance for a period.
    /// </remarks>
    A86,

    /// <summary>
    /// Financial situation
    /// </summary>
    /// <remarks>
    /// A document providing the financial situation for reserves.
    /// </remarks>
    A87,

    /// <summary>
    /// Cross border balancing
    /// </summary>
    /// <remarks>
    /// A document providing the cross border balancing requirements for a period.
    /// </remarks>
    A88,

    /// <summary>
    /// Contracted reserve prices
    /// </summary>
    /// <remarks>
    /// A document providing the price of reserves contracted for a period.
    /// </remarks>
    A89,

    /// <summary>
    /// Interconnection network expansion
    /// </summary>
    /// <remarks>
    /// A document providing information on the expansion of the interconnection network.
    /// </remarks>
    A90,

    /// <summary>
    /// Counter trade notice
    /// </summary>
    /// <remarks>
    /// A document providing information on counter trades for a period.
    /// </remarks>
    A91,

    /// <summary>
    /// Congestion costs
    /// </summary>
    /// <remarks>
    /// A document providing the cost of congestion for a period.
    /// </remarks>
    A92,

    /// <summary>
    /// DC link capacity
    /// </summary>
    /// <remarks>
    /// A document providing the DC links for a period.
    /// </remarks>
    A93,

    /// <summary>
    /// Non EU allocations
    /// </summary>
    /// <remarks>
    /// A document providing allocations made to non EU member states.
    /// </remarks>
    A94,

    /// <summary>
    /// Configuration document
    /// </summary>
    /// <remarks>
    /// A document providing configuration information.
    /// </remarks>
    A95,

    /// <summary>
    /// Redispatch activation document
    /// </summary>
    /// <remarks>
    /// A document enabling the activation of a redispatch notice.
    /// </remarks>
    A96,

    /// <summary>
    /// Detailed activation history document
    /// </summary>
    /// <remarks>
    /// A document enabling a detailed history of activations.
    /// </remarks>
    A97,

    /// <summary>
    /// Aggregated activation history document
    /// </summary>
    /// <remarks>
    /// A document enabling an aggregated history of activations.
    /// </remarks>
    A98,

    /// <summary>
    /// HVDC Link constraints
    /// </summary>
    /// <remarks>
    /// A document providing the information concerning the maximum and minimum active power flow through each link can limited.
    /// </remarks>
    A99,

    /// <summary>
    /// HVDC Configuration
    /// </summary>
    /// <remarks>
    /// A document providing the information concerning the power set point. The mode in which the  HVDC is managed.
    /// </remarks>
    B01,

    /// <summary>
    /// HVDC Schedule
    /// </summary>
    /// <remarks>
    /// A document providing the information for operating DC links.
    /// </remarks>
    B02,

    /// <summary>
    /// EIC code request
    /// </summary>
    /// <remarks>
    /// A document providing the information requesting a new EIC code.
    /// </remarks>
    B03,

    /// <summary>
    /// EIC code information
    /// </summary>
    /// <remarks>
    /// A document providing EIC information  in a central registry exchange or information to an EIC participant.
    /// </remarks>
    B04,

    /// <summary>
    /// EIC code publication
    /// </summary>
    /// <remarks>
    /// A document providing EIC publication information in a web site publication of a limited set of information.
    /// </remarks>
    B05,

    /// <summary>
    /// Critical network element determination
    /// </summary>
    /// <remarks>
    /// A document providing all the elements necessary for the capacity coordinator to determine the transfer capacity and the associated critical network elements.
    /// </remarks>
    B06,

    /// <summary>
    /// Critical network element publication
    /// </summary>
    /// <remarks>
    /// A document providing all the elements necessary for the market information aggregator and TSOs to know the critical network elements which limit the transfer capacity.
    /// </remarks>
    B07,

    /// <summary>
    /// Flow based domain
    /// </summary>
    /// <remarks>
    /// A document providing the capacity domain and its limits available for the TSO.
    /// </remarks>
    B08,

    /// <summary>
    /// Flow based domain publication
    /// </summary>
    /// <remarks>
    /// A document providing the capacity domain and its limits available for the market.
    /// </remarks>
    B09,

    /// <summary>
    /// Flow based domain market impact publication
    /// </summary>
    /// <remarks>
    /// A document providing the capacity domain and its impacts on the market to be published.
    /// </remarks>
    B10,

    /// <summary>
    /// Anonymized flow based parameters publication
    /// </summary>
    /// <remarks>
    /// A document providing all the relevant flow based parameters in case of flow based capacity allocation.
    /// </remarks>
    B11,

    /// <summary>
    /// Critical network element market impact publication
    /// </summary>
    /// <remarks>
    /// A document providing the critical network elements and its impacts on the market to be published.
    /// </remarks>
    B12,

    /// <summary>
    /// Weather document
    /// </summary>
    /// <remarks>
    /// An estimation or prediction in advance of the weather by analysis of meteorological data and the results of what actually happened with the weather.
    /// </remarks>
    B13,

    /// <summary>
    /// Energy prognosis document
    /// </summary>
    /// <remarks>
    /// A document to provide the prognosis of energy production/load for a given period.
    /// </remarks>
    B14,

    /// <summary>
    /// Network constraint document
    /// </summary>
    /// <remarks>
    /// A document providing the network constraint situations used for the load flow studies. A network constraint situation includes contingencies, monitored elements and remedial actions.
    /// </remarks>
    B15,

    /// <summary>
    /// Aggregated netted external market schedule document
    /// </summary>
    /// <remarks>
    /// A document used to report aggregated netted external market schedules for a given border.
    /// </remarks>
    B16,

    /// <summary>
    /// Aggregated netted external TSO schedule document
    /// </summary>
    /// <remarks>
    /// A document used to report aggregated netted external TSO schedules for a given border.
    /// </remarks>
    B17,

    /// <summary>
    /// Reporting status market document
    /// </summary>
    /// <remarks>
    /// A document used to report the status of aggregated netted external market schedules, aggregated netted external TSO schedules and compensation program schedules on a given border.
    /// </remarks>
    B18,

    /// <summary>
    /// Reporting information market document
    /// </summary>
    /// <remarks>
    /// A document used to report  the information concerning aggregated netted external schedules, aggregated netted external market schedules, aggregated netted external TSO schedules, compensation program schedules, netted area position schedules and netted area AC position schedules to an interested party.
    /// </remarks>
    B19,

    /// <summary>
    /// Status request for a reporting information market document
    /// </summary>
    /// <remarks>
    /// A document requesting the provision of a reporting information document.
    /// </remarks>
    B20,

    /// <summary>
    /// Reserve need document
    /// </summary>
    /// <remarks>
    /// Used by a TSO to send its reserve needs.
    /// </remarks>
    B21,

    /// <summary>
    /// Generation and load shift keys document
    /// </summary>
    /// <remarks>
    /// A document providing the values of the generation and load shift keys to be used on network model.
    /// </remarks>
    B22,

    /// <summary>
    /// Offers to be activated
    /// </summary>
    /// <remarks>
    /// A document containing the outcome of the process, with the list of offers that are to be activated by the TSO concerned and the results for its reserve needs.
    /// </remarks>
    B23,

    /// <summary>
    /// Clearing price
    /// </summary>
    /// <remarks>
    /// A document containing the outcome of the process, with the clearing prices for a period.
    /// </remarks>
    B24,

    /// <summary>
    /// Security analysis report
    /// </summary>
    /// <remarks>
    /// A document providing a report on a performed security analysis.
    /// </remarks>
    B25,

    /// <summary>
    /// Aggregated netted external schedule document
    /// </summary>
    /// <remarks>
    /// A document used to report aggregated netted external schedules for a given border. 
    /// </remarks>
    B26,

    /// <summary>
    /// External TSO schedule
    /// </summary>
    /// <remarks>
    /// A document used to report external TSO schedules for a given border or interconnector.
    /// </remarks>
    B27,

    /// <summary>
    /// Move of scheduled production
    /// </summary>
    /// <remarks>
    /// A document indication a move of scheduled production.
    /// </remarks>
    B28,

    /// <summary>
    /// PS&LC results document
    /// </summary>
    /// <remarks>
    /// A document providing Pole Splitting &amp; Loss Calculation results.
    /// </remarks>
    B29,

    /// <summary>
    /// Notification data market document
    /// </summary>
    /// <remarks>
    /// A document used to notify data to any information receiver.
    /// </remarks>
    B30,

    /// <summary>
    /// Additional Constraint document
    /// </summary>
    /// <remarks>
    /// A document describing additional constraints for a capacity calculation process.
    /// </remarks>
    B31,

    /// <summary>
    /// Operational state document
    /// </summary>
    /// <remarks>
    /// A document used for exchanging operational states for grid assets.
    /// </remarks>
    B32,

    /// <summary>
    /// Published offered capacity
    /// </summary>
    /// <remarks>
    /// A document providing the most recent values of offered capacity.
    /// </remarks>
    B33,

    /// <summary>
    /// Market result document
    /// </summary>
    /// <remarks>
    /// Published prices and volumes
    /// </remarks>
    B34,

    /// <summary>
    /// Area Configuration document
    /// </summary>
    /// <remarks>
    /// A document containing the definition of areas.
    /// </remarks>
    B35,

    /// <summary>
    /// Area Composition document
    /// </summary>
    /// <remarks>
    /// A document containing the relations between areas, i.e which Metering Grid Areas a Bidding Zone composed of.
    /// </remarks>
    B36,

    /// <summary>
    /// Connected Areas document
    /// </summary>
    /// <remarks>
    /// A document containing which other areas an area is connected to i.e. which Metering Grid Areas a Metering Grid Area is connected to.
    /// </remarks>
    B37,

    /// <summary>
    /// Settlement document
    /// </summary>
    /// <remarks>
    /// A document providing settlement information.
    /// </remarks>
    B38,

    /// <summary>
    /// Imbalance prognosis document
    /// </summary>
    /// <remarks>
    /// A document to provide the prognosis of energy imbalances for a given period.
    /// </remarks>
    B39,

    /// <summary>
    /// Complete set of bids
    /// </summary>
    /// <remarks>
    /// Submission of complete set of bids. If there are existing bids, they should be replaced.
    /// </remarks>
    B40,

    /// <summary>
    /// Merged MOL notice
    /// </summary>
    /// <remarks>
    /// A notice providing information on the MOL merging process.
    /// </remarks>
    B41,

    /// <summary>
    /// K-factor document
    /// </summary>
    /// <remarks>
    /// A document providing K-factor values.
    /// </remarks>
    B42,

    /// <summary>
    /// Settlement coordination document
    /// </summary>
    /// <remarks>
    /// A document providing settlement information for coordination between different parties.
    /// </remarks>
    B43,

    /// <summary>
    /// Financial settlement document
    /// </summary>
    /// <remarks>
    /// A document providing financial settlement information.
    /// </remarks>
    B44,

    /// <summary>
    /// Bid availability document
    /// </summary>
    /// <remarks>
    /// A document providing the detailed reasons for changing the availability or volume of a bid.
    /// </remarks>
    B45,

    /// <summary>
    /// Resource capacity unit document
    /// </summary>
    /// <remarks>
    /// A document providing information about resource capacity units.
    /// </remarks>
    B46,

    /// <summary>
    /// Other market information
    /// </summary>
    /// <remarks>
    /// A document providing other market information.
    /// </remarks>
    B47,

    /// <summary>
    /// Permission document
    /// </summary>
    /// <remarks>
    /// A document that contains detailed information about permissions.
    /// </remarks>
    B48,

    /// <summary>
    /// Requested capacity
    /// </summary>
    /// <remarks>
    /// A document providing requested capacity (e.g. ATC, CZCL) value.	/// 
    /// </remarks>
    B49,

    /// <summary>
    /// Voltage control activation document
    /// </summary>
    /// <remarks>
    /// A document providing the number of generating units to activate for voltage control, by means of their operation in synchronous condenser mode.	/// 
    /// </remarks>
    B50,

    /// <summary>
    /// Transmission inventory document
    /// </summary>
    /// <remarks>
    /// A document providing a transmission inventory.
    /// </remarks>
    B51,

    /// <summary>
    /// Transmission inventory
    /// </summary>
    /// <remarks>
    /// A document providing statistics on the transmission grid.
    /// </remarks>
    B52
}

