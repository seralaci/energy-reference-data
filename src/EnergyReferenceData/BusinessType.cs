// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// The exact business nature identifying the principal characteristic of a time series.
/// </summary>
/// <remarks>
/// ET0017
/// </remarks>
public enum BusinessType
{
    /// <summary>
    /// Production
    /// </summary>
    /// <remarks>
    /// The nature of the business being described is production details.
    /// </remarks>
    A01 = 1,

    /// <summary>
    /// Internal trade
    /// </summary>
    /// <remarks>
    /// The nature of the business being described is internal trade details.
    /// </remarks>
    A02 = 2,

    /// <summary>
    /// External trade explicit capacity
    /// </summary>
    /// <remarks>
    /// The nature of the business being described is external trade details between two areas with limited capacity requiring a capacity agreement identification.
    /// </remarks>
    A03 = 3,

    /// <summary>
    /// Consumption
    /// </summary>
    /// <remarks>
    /// The nature of the business being described is consumption details.
    /// </remarks>
    A04 = 4,

    /// <summary>
    /// External trade total
    /// </summary>
    /// <remarks>
    /// The nature of the business being described is external trade total.
    /// </remarks>
    A05 = 5,

    /// <summary>
    /// External trade without explicit capacity
    /// </summary>
    /// <remarks>
    /// The nature of the business being described is external trade details between two areas without requiring capacity allocation information.
    /// </remarks>
    A06 = 6,

    /// <summary>
    /// Net Production / Consumption
    /// </summary>
    /// <remarks>
    /// Net production/consumption - where signed values will be used. 	/// With the following rules: In area=Out area, In party=Out party, + means production and - means consumption.
    /// </remarks>
    A07 = 7,

    /// <summary>
    /// Net internal trade
    /// </summary>
    /// <remarks>
    /// Net internal trade - where the direction from out party (seller) to in party (buyer) is positive and the opposite direction is negative (with minus signs).
    /// </remarks>
    A08 = 8,

    /// <summary>
    /// IPP (Independent Power Producer)
    /// </summary>
    /// <remarks>
    /// A time series concerning the production schedule from an IPP.
    /// </remarks>
    A09 = 9,

    /// <summary>
    /// Tertiary control 
    /// </summary>
    /// <remarks>
    /// A time series concerning tertiary reserve.
    /// </remarks>
    A10 = 10,

    /// <summary>
    /// Primary control
    /// </summary>
    /// <remarks>
    /// A time series concerning primary reserve.
    /// </remarks>
    A11 = 11,

    /// <summary>
    /// Secondary control
    /// </summary>
    /// <remarks>
    /// A time series concerning secondary reserve.
    /// </remarks>
    A12 = 12,

    /// <summary>
    /// Load profile
    /// </summary>
    /// <remarks>
    /// A time series concerning a load profile as calculated by a metered data aggregator.
    /// </remarks>
    A13 = 13,

    /// <summary>
    /// Aggregated energy data
    /// </summary>
    /// <remarks>
    /// A time series concerning adjusted metered readings received from a metered data collector and aggregated and validated by a metered data aggregator.
    /// </remarks>
    A14 = 14,

    /// <summary>
    /// Losses
    /// </summary>
    /// <remarks>
    /// A time series concerning losses that have been calculated for a tieline or an area.
    /// </remarks>
    A15 = 15,

    /// <summary>
    /// Transits (CBT)
    /// </summary>
    /// <remarks>
    /// A time series concerning inter area transit flows determined for CBT requirements.
    /// </remarks>
    A16 = 16,

    /// <summary>
    /// Settlement deviation
    /// </summary>
    /// <remarks>
    /// A time series concerning the imbalance energy calculated by an imbalance settlement responsible.
    /// </remarks>
    A17 = 17,

    /// <summary>
    /// Technical constraint deviation
    /// </summary>
    /// <remarks>
    /// A time series defining the imbalance between schedules accepted by the system operator due to technical constraints and schedules declared by the balance responsible party.
    /// </remarks>
    A18 = 18,

    /// <summary>
    /// Balance energy deviation
    /// </summary>
    /// <remarks>
    /// A time series defining the imbalance between the schedule of a balance responsible party that has been corrected by the system operator after using balance energy bids and the schedule that was accepted by the system operator due to technical constraints.
    /// </remarks>
    A19 = 19,

    /// <summary>
    /// Imbalance volume
    /// </summary>
    /// <remarks>
    /// A time series defining the imbalance between the actual meter readings and the schedule of the balance responsible party corrected by the system operator after using balance energy bids.
    /// </remarks>
    A20 = 20,

    /// <summary>
    /// Unintended energy
    /// </summary>
    /// <remarks>
    /// A timeseries concerning the volume of an unintended cross-border exchange of energy.
    /// </remarks>
    A21 = 21,

    /// <summary>
    /// Frequency control
    /// </summary>
    /// <remarks>
    /// A time series concerning primary and secondary reserve.
    /// </remarks>
    A22 = 22,

    /// <summary>
    /// Balance management
    /// </summary>
    /// <remarks>
    /// A time series concerning energy balancing services.
    /// </remarks>
    A23 = 23,

    /// <summary>
    /// Total trade
    /// </summary>
    /// <remarks>
    /// A time series concerning the total of both the internal and external trades.
    /// </remarks>
    A24 = 24,

    /// <summary>
    /// General Capacity Information
    /// </summary>
    /// <remarks>
    /// A time series providing the total capacity available on a TSO border.
    /// </remarks>
    A25 = 25,

    /// <summary>
    /// Available transfer capacity (ATC)
    /// </summary>
    /// <remarks>
    /// Available transfer capacity for cross-border exchanges.
    /// </remarks>
    A26 = 26,

    /// <summary>
    /// Net transfer capacity (NTC)
    /// </summary>
    /// <remarks>
    /// Net transfer capacity for cross-border exchanges.
    /// </remarks>
    A27 = 27,

    /// <summary>
    /// Control Area Program
    /// </summary>
    /// <remarks>
    /// A time series providing the total exchanges between two TSOs (including the commercial transactions, the compensation program and the losses compensation program). 	/// Note this definition might change when UCTE brings forward its coding requirements.
    /// </remarks>
    A28 = 28,

    /// <summary>
    /// Already allocated capacity (AAC)
    /// </summary>
    /// <remarks>
    /// The already allocated capacity is the total amount of allocated transmission rights.
    /// </remarks>
    A29 = 29,

    /// <summary>
    /// Internal inter area trade
    /// </summary>
    /// <remarks>
    /// A trade that occurs between internal areas within a market balance area.
    /// </remarks>
    A30 = 30,

    /// <summary>
    /// Offered Capacity
    /// </summary>
    /// <remarks>
    /// The time series provides the offered capacity.
    /// </remarks>
    A31 = 31,

    /// <summary>
    /// Capacity transfer notification
    /// </summary>
    /// <remarks>
    /// The time series provides information concerning the notification of the transfer of capacity to another market participant.
    /// </remarks>
    A32 = 32,

    /// <summary>
    /// Authorised AAC
    /// </summary>
    /// <remarks>
    /// The time series in question provides the amount of transmission capacity rights to be nominated.
    /// </remarks>
    A33 = 33,

    /// <summary>
    /// Capacity rights
    /// </summary>
    /// <remarks>
    /// The time series in question provides the capacity rights allocated for a given border.
    /// </remarks>
    A34 = 34,

    /// <summary>
    /// Minimum authorised AAC
    /// </summary>
    /// <remarks>
    /// The time series in question provides the minimum amount of transmission capacity rights to be nominated.
    /// </remarks>
    A35 = 35,

    /// <summary>
    /// Maximum authorised AAC
    /// </summary>
    /// <remarks>
    /// The time series in question provides the maximum amount of transmission capacity rights to be nominated.
    /// </remarks>
    A36 = 36,

    /// <summary>
    /// Installed generation
    /// </summary>
    /// <remarks>
    /// The time series in question provides the installed generation.
    /// </remarks>
    A37 = 37,

    /// <summary>
    /// Available generation
    /// </summary>
    /// <remarks>
    /// The time series in question provides the available generation.
    /// </remarks>
    A38 = 38,

    /// <summary>
    /// Interconnection Trade Responsible Designation
    /// </summary>
    /// <remarks>
    /// The Time series in question provides the designation of the ITR that may nominate the capacity in question.
    /// </remarks>
    A40 = 39,

    /// <summary>
    /// Released AAC
    /// </summary>
    /// <remarks>
    /// The already allocated capacity (AAC) that has been released for resale.
    /// </remarks>
    A41 = 40,

    /// <summary>
    /// Requested capacity (with price)
    /// </summary>
    /// <remarks>
    /// The time series in question provides information concerning the requested capacity including price information.
    /// </remarks>
    A42 = 41,

    /// <summary>
    /// Requested capacity (without price)
    /// </summary>
    /// <remarks>
    /// The time series in question provides information concerning the requested capacity but excludes price information.
    /// </remarks>
    A43 = 42,

    /// <summary>
    /// Compensation program
    /// </summary>
    /// <remarks>
    /// Compensation of unintentional deviation is performed by exporting to / importing from the interconnected system during the compensation period by means of schedules as calculated during the accounting of unintentional deviations.
    /// </remarks>
    A44 = 43,

    /// <summary>
    /// Schedule activated reserves
    /// </summary>
    /// <remarks>
    /// The cross border or internal reserves that are to be activated through schedule nomination.
    /// </remarks>
    A45 = 44,

    /// <summary>
    /// System Operator redispatching
    /// </summary>
    /// <remarks>
    /// The cross border redispatching between System Operators that are to be activated through schedule nomination.
    /// </remarks>
    A46 = 45,

    /// <summary>
    /// Market capacity price
    /// </summary>
    /// <remarks>
    /// The price of the capacity offered on a given market.
    /// </remarks>
    A47 = 46,

    /// <summary>
    /// Market capacity price differential
    /// </summary>
    /// <remarks>
    /// The difference between the price of capacity in a Market Balance Area receiving the capacity (In Area) and the price of capacity in a Market Balance Area providing the capacity (Out Area), i.e. In Area Price - Out Area price.
    /// </remarks>
    A48 = 47,

    /// <summary>
    /// Inflow
    /// </summary>
    /// <remarks>
    /// The volume of water that flows into a reservoir in a given interval.
    /// </remarks>
    A49 = 48,

    /// <summary>
    /// Water extraction
    /// </summary>
    /// <remarks>
    /// The volume of water that can be extracted from a reservoir in a given interval.
    /// </remarks>
    A50 = 49,

    /// <summary>
    /// Turbined water
    /// </summary>
    /// <remarks>
    /// The volume of water that can be turbined in a plant in a given interval.
    /// </remarks>
    A51 = 50,

    /// <summary>
    /// Water spillage
    /// </summary>
    /// <remarks>
    /// The volume of water that is not turbined going through the spillway in a given interval.
    /// </remarks>
    A52 = 51,

    /// <summary>
    /// Planned maintenance
    /// </summary>
    /// <remarks>
    /// Maintenance has been planned for the object in question with a forecast ending date.
    /// </remarks>
    A53 = 52,

    /// <summary>
    /// Unplanned outage
    /// </summary>
    /// <remarks>
    /// An unplanned outage has occurred on the object in question.
    /// </remarks>
    A54 = 53,

    /// <summary>
    /// Use it Or Sell it (UIOSI) pricing
    /// </summary>
    /// <remarks>
    /// The time series provides information on the capacity resold in the "use it or sell it" process and its corresponding price.
    /// </remarks>
    A55 = 54,

    /// <summary>
    /// Compensation for auction cancellation where capacity is for resale
    /// </summary>
    /// <remarks>
    /// The time series provides information on the compensation of the capacity for resale following an auction cancellation.
    /// </remarks>
    A56 = 55,

    /// <summary>
    /// Resale pricing
    /// </summary>
    /// <remarks>
    /// For each Physical Transmission Rights holder, this document contains the resold capacity and its corresponding price.
    /// </remarks>
    A57 = 56,

    /// <summary>
    /// Curtailed capacity compensation
    /// </summary>
    /// <remarks>
    /// The time series provides information to compensate a party when curtailment is applied on the capacity obtained in a previous auction, resale or transfer.
    /// </remarks>
    A58 = 57,

    /// <summary>
    /// Use it Or Sell it (UIOSI) compensation
    /// </summary>
    /// <remarks>
    /// The time series provides information on the compensation for the capacity following an auction cancellation.
    /// </remarks>
    A59 = 58,

    /// <summary>
    /// Minimum possible
    /// </summary>
    /// <remarks>
    /// The time series provides a schedule of minimum possible values for a Resource Object. The nature of the flow could be defined by the attribute Direction.
    /// </remarks>
    A60 = 59,

    /// <summary>
    /// Maximum available
    /// </summary>
    /// <remarks>
    /// The time series provides a schedule of maximum available values for a Resource Object. The nature of the flow could be defined by the attribute Direction.
    /// </remarks>
    A61 = 60,

    /// <summary>
    /// Spot price
    /// </summary>
    /// <remarks>
    /// The time series provides the market spot prices from an auction.
    /// </remarks>
    A62 = 61,

    /// <summary>
    /// Minimum ATC
    /// </summary>
    /// <remarks>
    /// The Available Transmission Capacity that must be guaranteed because of regulatory constraints.
    /// </remarks>
    A63 = 62,

    /// <summary>
    /// Meter Measurement data 
    /// </summary>
    /// <remarks>
    /// The data as provided for a meter measurement source.
    /// </remarks>
    A64 = 63,

    /// <summary>
    /// Accounting Point Relevant data 
    /// </summary>
    /// <remarks>
    /// The metered data that is to be considered relevant for accounting purposes.
    /// </remarks>
    A65 = 64,

    /// <summary>
    /// Energy flow
    /// </summary>
    /// <remarks>
    /// Energy flow information.
    /// </remarks>
    A66 = 65,

    /// <summary>
    /// Power plant energy Schedule
    /// </summary>
    /// <remarks>
    /// Energy flow scheduled for a power plant.
    /// </remarks>
    A67 = 66,

    /// <summary>
    /// Compensation Requirements for the compensation period
    /// </summary>
    /// <remarks>
    /// The time series provides the compensation requirements for a given compensation period.
    /// </remarks>
    A68 = 67,

    /// <summary>
    /// Market coupling results
    /// </summary>
    /// <remarks>
    /// The time series provides the results of a market coupling auction.
    /// </remarks>
    A69 = 68,

    /// <summary>
    /// Production, unavailable
    /// </summary>
    /// <remarks>
    /// Production capacity that normally would be available, but due to maintenance or similar is temporarily unavailable.
    /// </remarks>
    A70 = 69,

    /// <summary>
    /// Supplementary available generation
    /// </summary>
    /// <remarks>
    /// The supplementary generation that is available.
    /// </remarks>
    A71 = 70,

    /// <summary>
    /// Interruptible consumption
    /// </summary>
    /// <remarks>
    /// The consumption that may be interrupted on request.
    /// </remarks>
    A72 = 71,

    /// <summary>
    /// Summarised Market Balance Area Schedule
    /// </summary>
    /// <remarks>
    /// A time series providing the total exchanges based on commercial transactions between two Market Balance Areas.
    /// </remarks>
    A73 = 72,

    /// <summary>
    /// Load Frequency Control Program Schedule
    /// </summary>
    /// <remarks>
    /// A time series providing the schedule information for the Load Frequency Control Program.
    /// </remarks>
    A74 = 73,

    /// <summary>
    /// Timeframe Independent Schedule
    /// </summary>
    /// <remarks>
    /// A time series providing the total exchanges of Timeframe Independent Schedules between two System Operators.
    /// </remarks>
    A75 = 74,

    /// <summary>
    /// Consumption curtailment
    /// </summary>
    /// <remarks>
    /// A time series providing the amount of voluntary consumption curtailed by the energy supplier of an end-consumer.
    /// </remarks>
    A76 = 75,

    /// <summary>
    /// Production, dispatchable
    /// </summary>
    /// <remarks>
    /// The nature of the business being described is dispatchable production details, i.e. generation output that can be changed by a request (activation order) of the TSO according with the applicable Market Rules. 
    /// </remarks>
    A77 = 76,

    /// <summary>
    /// Consumption, dispatchable
    /// </summary>
    /// <remarks>
    /// The nature of the business being described is dispatchable consumption details, i.e. consumption output that can be changed by a request (activation order) of the TSO according with the applicable Market Rules. 
    /// </remarks>
    A78 = 77,

    /// <summary>
    /// Production, non-dispatchable
    /// </summary>
    /// <remarks>
    /// The nature of the business being described is non-dispatchable production details, i.e. generation output that cannot be modified by an activation order.
    /// </remarks>
    A79 = 78,

    /// <summary>
    /// Consumption, non-dispatchable
    /// </summary>
    /// <remarks>
    /// The nature of the business being described is non-dispatchable consumption details, i.e. consumption output that cannot be modified by an activation order.
    /// </remarks>
    A80 = 79,

    /// <summary>
    /// Total Transfer Capacity (TTC)
    /// </summary>
    /// <remarks>
    /// The Total Transfer Capacity is the maximum exchange program between two areas compatible with operational security standards applicable at each system if future network conditions, generation and load patterns were perfectly known in advance.
    /// </remarks>
    A81 = 80,

    /// <summary>
    /// Mutual Emergency Assistance Service (MEAS) 
    /// </summary>
    /// <remarks>
    /// The cross border Mutual Emergency Assistance Service between System Operators that are to be activated through schedule nomination.
    /// </remarks>
    A82 = 81,

    /// <summary>
    /// Auction cancelation 
    /// </summary>
    /// <remarks>
    /// The time series covers auction cancellation right.
    /// </remarks>
    A83 = 82,

    /// <summary>
    /// Nomination curtailment
    /// </summary>
    /// <remarks>
    /// The time series covers nomination curtailment rights 
    /// </remarks>
    A84 = 83,

    /// <summary>
    /// Internal redispatch
    /// </summary>
    /// <remarks>
    /// Redispatch to relieve Market Balance Area internal congestion.
    /// </remarks>
    A85 = 84,

    /// <summary>
    /// Control area balance energy
    /// </summary>
    /// <remarks>
    /// A sum of secondary, tertiary control as well as other energy that was used to balance a control area.
    /// </remarks>
    A86 = 85,

    /// <summary>
    /// Balancing energy price
    /// </summary>
    /// <remarks>
    /// Price of energy used to balance.
    /// </remarks>
    A87 = 86,

    /// <summary>
    /// Economised secondary reserve
    /// </summary>
    /// <remarks>
    /// The activated secondary reserve that had been economised due to pooled reserve management.
    /// </remarks>
    A88 = 87,

    /// <summary>
    /// Spinning reserve
    /// </summary>
    /// <remarks>
    /// The extra generating capacity that is available by increasing the production of generators that are already connected to the power system.
    /// </remarks>
    A89 = 88,

    /// <summary>
    /// Solar
    /// </summary>
    /// <remarks>
    /// The business being described concerns solar power.
    /// </remarks>
    A90 = 89,

    /// <summary>
    /// positive forecast margin
    /// </summary>
    /// <remarks>
    /// The business being described concerns a positive forecast margin.
    /// </remarks>
    A91 = 90,

    /// <summary>
    /// Negative forecast margin
    /// </summary>
    /// <remarks>
    /// The business being described concerns a negative forecast margin.
    /// </remarks>
    A92 = 91,

    /// <summary>
    /// Wind generation
    /// </summary>
    /// <remarks>
    /// The business being described concerns wind generation.
    /// </remarks>
    A93 = 92,

    /// <summary>
    /// Solar generation
    /// </summary>
    /// <remarks>
    /// The business being described concerns solar generation.
    /// </remarks>
    A94 = 93,

    /// <summary>
    /// Frequency containment reserve
    /// </summary>
    /// <remarks>
    /// The business being described concerns frequency containment reserve.
    /// </remarks>
    A95 = 94,

    /// <summary>
    /// Automatic frequency restoration reserve
    /// </summary>
    /// <remarks>
    /// The business being described concerns automatic frequency restoration reserve.
    /// </remarks>
    A96 = 95,

    /// <summary>
    /// Manual frequency restoration reserve
    /// </summary>
    /// <remarks>
    /// The business being described concerns manual frequency restoration reserve.
    /// </remarks>
    A97 = 96,

    /// <summary>
    /// Replacement reserve
    /// </summary>
    /// <remarks>
    /// The business being described concerns replacement reserve.
    /// </remarks>
    A98 = 97,

    /// <summary>
    /// Financial information
    /// </summary>
    /// <remarks>
    /// The business being described concerns financial information.
    /// </remarks>
    A99 = 98,

    /// <summary>
    /// Interconnector network evolution
    /// </summary>
    /// <remarks>
    /// The business being described concerns interconnector network evolution.
    /// </remarks>
    B01 = 99,

    /// <summary>
    /// Interconnector network dismantling
    /// </summary>
    /// <remarks>
    /// The business being described concerns interconnector network dismantling.
    /// </remarks>
    B02 = 100,

    /// <summary>
    /// Counter trade
    /// </summary>
    /// <remarks>
    /// The business being described concerns counter trades.
    /// </remarks>
    B03 = 101,

    /// <summary>
    /// Congestion costs
    /// </summary>
    /// <remarks>
    /// The business being described concerns congestion costs.
    /// </remarks>
    B04 = 102,

    /// <summary>
    /// Capacity allocated (including price)
    /// </summary>
    /// <remarks>
    /// The business being described concerns capacity allocation and includes price information.
    /// </remarks>
    B05 = 103,

    /// <summary>
    /// DC link constraint
    /// </summary>
    /// <remarks>
    /// The business being described concerns DC link constraints.
    /// </remarks>
    B06 = 104,

    /// <summary>
    /// Auction revenue
    /// </summary>
    /// <remarks>
    /// The business being described concerns auction revenue.
    /// </remarks>
    B07 = 105,

    /// <summary>
    /// Total nominated capacity
    /// </summary>
    /// <remarks>
    /// The business being described concerns the total nominated capacity.
    /// </remarks>
    B08 = 106,

    /// <summary>
    /// Net position
    /// </summary>
    /// <remarks>
    /// The business being described concerns net position.
    /// </remarks>
    B09 = 107,

    /// <summary>
    /// Congestion income
    /// </summary>
    /// <remarks>
    /// The business being described concerns congestion income.
    /// </remarks>
    B10 = 108,

    /// <summary>
    /// Production unit
    /// </summary>
    /// <remarks>
    /// The business being described concerns a production unit.
    /// </remarks>
    B11 = 109,

    /// <summary>
    /// Rounded market coupling results
    /// </summary>
    /// <remarks>
    /// Rounded outputs of the market coupling to be sent to TSOs and Market Participants.
    /// </remarks>
    B12 = 110,

    /// <summary>
    /// Allocation Revenue
    /// </summary>
    /// <remarks>
    /// The time series provides information on the revenue generated by the allocations.
    /// </remarks>
    B13 = 111,

    /// <summary>
    /// Production deviation
    /// </summary>
    /// <remarks>
    /// A time series concerning the imbalance energy between the metered production and the schedules calculated by an imbalance settlement responsible.
    /// </remarks>
    B14 = 112,

    /// <summary>
    /// Consumption deviation
    /// </summary>
    /// <remarks>
    /// A time series concerning the imbalance energy between  metered consumption and the forecasted consumption calculated by an imbalance settlement responsible.
    /// </remarks>
    B15 = 113,

    /// <summary>
    /// Transmission asset
    /// </summary>
    /// <remarks>
    /// The business being described concerns a transmission asset.
    /// </remarks>
    B16 = 114,

    /// <summary>
    /// Consumption unit
    /// </summary>
    /// <remarks>
    /// The business being described concerns a consumption unit.
    /// </remarks>
    B17 = 115,

    /// <summary>
    /// In-feed ATC
    /// </summary>
    /// <remarks>
    /// Available Transfer Capacity at the in-feed side of a DC tieline.
    /// </remarks>
    B18 = 116,

    /// <summary>
    /// Out-feed ATC
    /// </summary>
    /// <remarks>
    /// Available Transfer Capacity at the out-feed side of a DC tieline.
    /// </remarks>
    B19 = 117,

    /// <summary>
    /// Balance up regulation price
    /// </summary>
    /// <remarks>
    /// A time series concerning balance regulation market prices for up regulation.
    /// </remarks>
    B20 = 118,

    /// <summary>
    /// Balance down regulation price
    /// </summary>
    /// <remarks>
    /// A time series concerning balance regulation market prices for down regulation.
    /// </remarks>
    B21 = 119,

    /// <summary>
    /// Main direction
    /// </summary>
    /// <remarks>
    /// A time series concerning the direction of balance regulations.
    /// </remarks>
    B22 = 120,

    /// <summary>
    /// Consumption imbalance price
    /// </summary>
    /// <remarks>
    /// A time series concerning imbalance prices for consumption.
    /// </remarks>
    B23 = 121,

    /// <summary>
    /// Production sales imbalance price
    /// </summary>
    /// <remarks>
    /// A time series concerning imbalance prices for production sales.
    /// </remarks>
    B24 = 122,

    /// <summary>
    /// Production purchase imbalance price
    /// </summary>
    /// <remarks>
    /// A time series concerning imbalance prices for production purchase.
    /// </remarks>
    B25 = 123,

    /// <summary>
    /// Average balance price between MBAs
    /// </summary>
    /// <remarks>
    /// A time series concerning the average prices between Market Balance Areas.
    /// </remarks>
    B26 = 124,

    /// <summary>
    /// Pumped
    /// </summary>
    /// <remarks>
    /// A time series concerning the electricity consumption related to pumping.
    /// </remarks>
    B27 = 125,

    /// <summary>
    /// Large installation consumption
    /// </summary>
    /// <remarks>
    /// A time series concerning consumption from large installation.
    /// </remarks>
    B28 = 126,

    /// <summary>
    /// Metering Grid Area (MGA) imbalance
    /// </summary>
    /// <remarks>
    /// A time series concerning imbalance between reported consumption, production and exchange in a Metering Grid Area.
    /// </remarks>
    B29 = 127,

    /// <summary>
    /// HVDC Link settings
    /// </summary>
    /// <remarks>
    /// The time series in question provides HVDC Link settings.
    /// </remarks>
    B30 = 128,

    /// <summary>
    /// Transmission Reliability Margin (TRM)
    /// </summary>
    /// <remarks>
    /// A time series concerning Transmission Reliability Margin (TRM).
    /// </remarks>
    B31 = 129,

    /// <summary>
    /// Imbalance component for a pool
    /// </summary>
    /// <remarks>
    /// This information is used to provide to a pool manager the combined imbalance of all the pool participants.
    /// </remarks>
    B32 = 130,

    /// <summary>
    /// Area Control error (ACE)
    /// </summary>
    /// <remarks>
    /// The sum of the instantaneous difference between the actual and the set-point value of the measured total power value and Control Program including Virtual Tie-Lines for the power interchange of a LFC Area or a LFC Block and the frequency bias given by the product of the K-Factor of the LFC Area or the LFC Block and the Frequency Deviation.
    /// </remarks>
    B33 = 131,

    /// <summary>
    /// Area Control Error after Imbalance Netting
    /// </summary>
    /// <remarks>
    /// A time series concerning the Area Control Error after applying the  imbalance netting energy correction.
    /// </remarks>
    B34 = 132,

    /// <summary>
    /// Implicit and explicit trade total
    /// </summary>
    /// <remarks>
    /// The sum of cross border schedules based on implicit and explicit trades including long term, yearly, monthly, weekly, daily processes. 
    /// </remarks>
    B35 = 133,

    /// <summary>
    /// Production units own consumption
    /// </summary>
    /// <remarks>
    /// The consumption of one or more production units.
    /// </remarks>
    B36 = 134,

    /// <summary>
    /// Constraint situation
    /// </summary>
    /// <remarks>
    /// The timeseries describes the constraint situation for a given TimeInterval.	/// A constraint situation can be: 	/// - composed of a list of network elements in outage associated for each outage to a list of network elements on which remedial actions have been carried out accordingly to contingency process 	/// - or it can be an external constraint.
    /// </remarks>
    B37 = 135,

    /// <summary>
    /// Initial domain
    /// </summary>
    /// <remarks>
    /// The timeseries describe the full flow based domain for a given TimeInterval. 	/// Critical network elements are displayed in details and their impact on the market is quantified.
    /// </remarks>
    B38 = 136,

    /// <summary>
    /// Flow based domain adjusted to long term schedules
    /// </summary>
    /// <remarks>
    /// The timeseries describe the full flow based domain for a given TimeInterval adjusted to the latest update of the schedules. 	/// Critical network elements are displayed in details and their impact on the market is quantified.
    /// </remarks>
    B39 = 137,

    /// <summary>
    /// Network element constraint
    /// </summary>
    /// <remarks>
    /// The timeSeries describes limiting elements which are overloaded.
    /// </remarks>
    B40 = 138,

    /// <summary>
    /// Calculation opposition (Red Flag)
    /// </summary>
    /// <remarks>
    /// The timeSeries describes a party who is opposed to the calculation result and imposes its transfer capacity value.
    /// </remarks>
    B41 = 139,

    /// <summary>
    /// Base case proportional shift key
    /// </summary>
    /// <remarks>
    /// The GSK or LSK are proportional to the base case generation or load.
    /// </remarks>
    B42 = 140,

    /// <summary>
    /// Proportional to participation factors shift key
    /// </summary>
    /// <remarks>
    /// The GSK or LSK are proportional to the participation factors.
    /// </remarks>
    B43 = 141,

    /// <summary>
    /// Proportional to the remaining capacity shift key
    /// </summary>
    /// <remarks>
    /// The GSK is proportional to the remaining available capacity.
    /// </remarks>
    B44 = 142,

    /// <summary>
    /// Merit order shift key
    /// </summary>
    /// <remarks>
    /// The GSK is proportional to a merit order list.
    /// </remarks>
    B45 = 143,

    /// <summary>
    /// Wind speed
    /// </summary>
    /// <remarks>
    /// The TimeSeries provides information on the wind speed.
    /// </remarks>
    B46 = 144,

    /// <summary>
    /// Wind direction
    /// </summary>
    /// <remarks>
    /// The TimeSeries provides information on the wind direction.
    /// </remarks>
    B47 = 145,

    /// <summary>
    /// Solar irradiance
    /// </summary>
    /// <remarks>
    /// The TimeSeries provides information on the power per unit area produced by the sun in the form of electromagnetic radiation.
    /// </remarks>
    B48 = 146,

    /// <summary>
    /// Air temperature
    /// </summary>
    /// <remarks>
    /// The TimeSeries provides information on the air temperature.
    /// </remarks>
    B49 = 147,

    /// <summary>
    /// Cloudiness
    /// </summary>
    /// <remarks>
    /// The TimeSeries provides information on the cloudiness, i.e. the level of coverage of the sky with clouds.
    /// </remarks>
    B50 = 148,

    /// <summary>
    /// Air humidity
    /// </summary>
    /// <remarks>
    /// The TimeSeries provides information on the level of humidity of the air.
    /// </remarks>
    B51 = 149,

    /// <summary>
    /// Atmospheric pressure
    /// </summary>
    /// <remarks>
    /// The TimeSeries provides information on the atmospheric pressure.
    /// </remarks>
    B52 = 150,

    /// <summary>
    /// Precipitation
    /// </summary>
    /// <remarks>
    /// The TimeSeries provides information on the amount of rain, snow, etc. that falls on the ground.
    /// </remarks>
    B53 = 151,

    /// <summary>
    /// Network constraint situation that constraints the market
    /// </summary>
    /// <remarks>
    /// The TimeSeries describes the network elements, that constraints the market, to be taken into account to simulate a network constraint during the network load flow studies. The network situation includes the contingencies, the remedial actions, the monitored network elements and the potential additional constraints.
    /// </remarks>
    B54 = 152,

    /// <summary>
    /// Contingency
    /// </summary>
    /// <remarks>
    /// The TimeSeries describes the network elements part of the contingency to be simulated for a given TimeInterval.
    /// </remarks>
    B55 = 153,

    /// <summary>
    /// Remedial Action
    /// </summary>
    /// <remarks>
    /// The TimeSeries describes a set of remedial actions for a given TimeInterval.
    /// </remarks>
    B56 = 154,

    /// <summary>
    /// Monitored Network Element
    /// </summary>
    /// <remarks>
    /// The TimeSeries describes the network elements to be monitored during the network load flow studies.
    /// </remarks>
    B57 = 155,

    /// <summary>
    /// Busbar
    /// </summary>
    /// <remarks>
    /// The TimeSeries describes the network elements that composed a busbar.
    /// </remarks>
    B58 = 156,

    /// <summary>
    /// Network Element
    /// </summary>
    /// <remarks>
    /// The TimeSeries describes network elements.
    /// </remarks>
    B59 = 157,

    /// <summary>
    /// SPS
    /// </summary>
    /// <remarks>
    /// The TimeSeries describes the network elements managed by a Special Protection System (automation).
    /// </remarks>
    B60 = 158,

    /// <summary>
    /// Aggregated netted external market schedule
    /// </summary>
    /// <remarks>
    /// The aggregated netted external market schedules for a given border.
    /// </remarks>
    B61 = 159,

    /// <summary>
    /// Aggregated netted external TSO schedule
    /// </summary>
    /// <remarks>
    /// The aggregated netted external TSO schedules for a given border.
    /// </remarks>
    B62 = 160,

    /// <summary>
    /// Aggregated netted external schedule
    /// </summary>
    /// <remarks>
    /// The aggregated netted external schedules for a given border.
    /// </remarks>
    B63 = 161,

    /// <summary>
    /// Netted area AC position
    /// </summary>
    /// <remarks>
    /// The AC position for a given area.
    /// </remarks>
    B64 = 162,

    /// <summary>
    /// Netted area position
    /// </summary>
    /// <remarks>
    /// The netted aggregation of all AC external schedules of an area plus the aggregated External Netted Schedules of related HVDC links of an area.
    /// </remarks>
    B65 = 163,

    /// <summary>
    /// Interconnection shift key
    /// </summary>
    /// <remarks>
    /// The shift key series describes the amount of power to be shifted from a border area.	/// 
    /// </remarks>
    B66 = 164,

    /// <summary>
    /// DC flow with losses
    /// </summary>
    /// <remarks>
    /// DC flow with losses refers to the values at the importing end of the DC line.
    /// </remarks>
    B67 = 165,

    /// <summary>
    /// DC flow without losses
    /// </summary>
    /// <remarks>
    /// DC flow without losses refers to the values at the exporting end of the DC line.
    /// </remarks>
    B68 = 166,

    /// <summary>
    /// minimum value of netted area position
    /// </summary>
    /// <remarks>
    /// That value which a netted area position must not fall below for a given area.
    /// </remarks>
    B69 = 167,

    /// <summary>
    /// maximum value of netted area position
    /// </summary>
    /// <remarks>
    /// That value which a netted area position must not exceed for a given optimisation area. 
    /// </remarks>
    B70 = 168,

    /// <summary>
    /// maximum value of DC flow
    /// </summary>
    /// <remarks>
    /// That value which a balanced DC flow must not exceed for a given DC line on exporting end. When aligning DC flows CGMA algorithm will respect this constraint.
    /// </remarks>
    B71 = 169,

    /// <summary>
    /// minimum value of DC flow
    /// </summary>
    /// <remarks>
    /// That value which a balanced DC flow must not fall below for a given DC line on exporting end. Currently this business type is only included for consistency reasons. It is always set to 0. This constraint might, however, be used in future. When aligning DC flows the CGMA algorithm will respect this constraint.
    /// </remarks>
    B72 = 170,

    /// <summary>
    /// indicative AC flow
    /// </summary>
    /// <remarks>
    /// It is the hypothetical flow on the aggregate of all AC tie lines of an electrical border between two optimisation areas. It results from the adjustments to the preliminary netted area positions of all optimisation areas made by the CGMA algorithm. Indicative AC flows are an artefact of the CGMA algorithm, and do not correspond to physical flows
    /// </remarks>
    B73 = 171,

    /// <summary>
    /// Offer
    /// </summary>
    /// <remarks>
    /// The time series provides an offer to provide reserves. 
    /// </remarks>
    B74 = 172,

    /// <summary>
    /// Need
    /// </summary>
    /// <remarks>
    /// The time series provides a requirement for reserves.	/// 
    /// </remarks>
    B75 = 173,

    /// <summary>
    /// Opportunity costs or benefits
    /// </summary>
    /// <remarks>
    /// The time series describes any opportunity costs or benefits.
    /// </remarks>
    B76 = 174,

    /// <summary>
    /// Financial compensation or penalties
    /// </summary>
    /// <remarks>
    /// The time series describes any financial compensation or penalties
    /// </remarks>
    B77 = 175,

    /// <summary>
    /// Global radiation
    /// </summary>
    /// <remarks>
    /// The total short-wave radiation from the Global radiation is the total short-wave radiation from the sky falling onto a horizontal surface on the ground. It includes both the direct solar radiation and the diffuse radiation resulting from reflected or scattered sunlight.
    /// </remarks>
    B78 = 176,

    /// <summary>
    /// Diffuse radiation
    /// </summary>
    /// <remarks>
    /// Radiation resulting from reflected or scattered sunlight.
    /// </remarks>
    B79 = 177,

    /// <summary>
    /// Direct solar radiation
    /// </summary>
    /// <remarks>
    /// Radiation resulting from direct sunlight
    /// </remarks>
    B80 = 178,

    /// <summary>
    /// Outage (OUT)
    /// </summary>
    /// <remarks>
    /// Outage process: Element is out of operation due to planned maintenance or due to an unplanned/forced outage. Outage may be used as a synonym for unavailability. 
    /// </remarks>
    B81 = 179,

    /// <summary>
    /// Special switching state (SSS)
    /// </summary>
    /// <remarks>
    /// Outage Process: This state applies to grid elements which are in operation in an exceptional state (e.g. separated nodes operation).
    /// </remarks>
    B82 = 180,

    /// <summary>
    /// Testing (TEST)
    /// </summary>
    /// <remarks>
    /// Outage process: TESTING means any element status is possible - ON or OUT. This status applies either between first connection and final commissioning of the relevant asset, or directly following maintenance of the relevant asset.
    /// </remarks>
    B83 = 181,

    /// <summary>
    /// Auxiliary busbar operation
    /// </summary>
    /// <remarks>
    /// Outage process: Element is in operation but connected via auxiliary busbar
    /// </remarks>
    B84 = 182,

    /// <summary>
    /// Automatic reclosing
    /// </summary>
    /// <remarks>
    /// Outage process: Protection function Automatic reclosing is switched off for electric line
    /// </remarks>
    B85 = 183,

    /// <summary>
    /// Busbar protection
    /// </summary>
    /// <remarks>
    /// Protection function busbar protection is switched off
    /// </remarks>
    B86 = 184,

    /// <summary>
    /// Phase Shift Angle
    /// </summary>
    /// <remarks>
    /// The maximum phase shift angle allowed between two network elements. 
    /// </remarks>
    B87 = 185,

    /// <summary>
    /// Base Case Network Situation
    /// </summary>
    /// <remarks>
    /// The TimeSeries describes the network elements to be taken into account to simulate a base case network situation during the network load flow studies, without any contingency.
    /// </remarks>
    B88 = 186,

    /// <summary>
    /// Inter-TSO assistance
    /// </summary>
    /// <remarks>
    /// Cross border assistance schedule between TSOs not interconnected directly. 
    /// </remarks>
    B89 = 187,

    /// <summary>
    /// FlexibleNeed
    /// </summary>
    /// <remarks>
    /// The business type indicates that the need is optional.
    /// </remarks>
    B90 = 188,

    /// <summary>
    /// GLSK Limitation
    /// </summary>
    /// <remarks>
    /// A constraint related to a GLSK maximum or minimum limitation in the production or/and consumption shift.
    /// </remarks>
    B91 = 189,

    /// <summary>
    /// Capacity ramping limitation
    /// </summary>
    /// <remarks>
    /// A constraint related to a ramping limitation on the capacity offered at a given border.
    /// </remarks>
    B92 = 190,

    /// <summary>
    /// interconnector capacity
    /// </summary>
    /// <remarks>
    /// The maximum capacity that can be exchanged on an interconnector, excluding external factor on both ends. 
    /// </remarks>
    B93 = 191,

    /// <summary>
    /// Must Run
    /// </summary>
    /// <remarks>
    /// A time series concerning must run generation.
    /// </remarks>
    B94 = 192,

    /// <summary>
    /// Procured capacity
    /// </summary>
    /// <remarks>
    /// An accepted offer of balancing capacity.
    /// </remarks>
    B95 = 193,

    /// <summary>
    /// Used capacity
    /// </summary>
    /// <remarks>
    /// The used cross-zonal balancing capacity.
    /// </remarks>
    B96 = 194,

    /// <summary>
    /// Estimated costs
    /// </summary>
    /// <remarks>
    /// Estimated costs of the process.
    /// </remarks>
    B97 = 195,

    /// <summary>
    /// Estimated benefits
    /// </summary>
    /// <remarks>
    /// Estimated benefits of the process.
    /// </remarks>
    B98 = 196,

    /// <summary>
    /// Load Shedding
    /// </summary>
    /// <remarks>
    /// A time series concerning a load shedding used to avoid failure of the power system.
    /// </remarks>
    B99 = 197,

    /// <summary>
    /// Remaining Capacity
    /// </summary>
    /// <remarks>
    /// A time series concerning the remaining capacity.
    /// </remarks>
    C01 = 198,

    /// <summary>
    /// Indicator of generation capacity adequacy
    /// </summary>
    /// <remarks>
    /// Indicator of adequacy, it indicates if there is final generation remaining capacity after SMTA calculation.
    /// </remarks>
    C02 = 199,

    /// <summary>
    /// Income from price divergence without congestions
    /// </summary>
    /// <remarks>
    /// The time series describes income due to price divergence without congestion between bidding zones.
    /// </remarks>
    C03 = 200,

    /// <summary>
    /// Push-button
    /// </summary>
    /// <remarks>
    /// The cross-border Push-button service between System Operators.
    /// </remarks>
    C04 = 201,

    /// <summary>
    /// Intertripping
    /// </summary>
    /// <remarks>
    /// The cross-border Intertripping service between System Operators.
    /// </remarks>
    C05 = 202,

    /// <summary>
    /// Emergency instruction
    /// </summary>
    /// <remarks>
    /// The cross-border Emergency instruction service between System Operators.
    /// </remarks>
    C06 = 203,

    /// <summary>
    /// Ramp management
    /// </summary>
    /// <remarks>
    /// The schedule resulting from cross-border Ramp management service between System Operators.
    /// </remarks>
    C07 = 204,

    /// <summary>
    /// Profile smoothing
    /// </summary>
    /// <remarks>
    /// The schedule resulting from cross-border Profile smoothing service between System Operators.
    /// </remarks>
    C08 = 205,

    /// <summary>
    /// Emergency reallocation deselection
    /// </summary>
    /// <remarks>
    /// The schedule resulting from cross-border Emergency reallocation deselection service between System Operators.
    /// </remarks>
    C09 = 206,

    /// <summary>
    /// SO-SO-trade
    /// </summary>
    /// <remarks>
    /// The generic cross border trade between System Operators.
    /// </remarks>
    C10 = 207,

    /// <summary>
    /// Production reduction
    /// </summary>
    /// <remarks>
    /// A time series providing the volume of production reduced by an energy provider / producer / supplier.
    /// </remarks>
    C11 = 208,

    /// <summary>
    /// Maximum power exchange
    /// </summary>
    /// <remarks>
    /// The timeseries provides the maximum admissible power flow between two bidding zones respecting operational security limits taking into account N-1 criterion.
    /// </remarks>
    C12 = 209,

    /// <summary>
    /// Maximum power exchange after remedial actions
    /// </summary>
    /// <remarks>
    /// The timeseries provides the maximum admissible power flow between two bidding zones after remedial actions.
    /// </remarks>
    C13 = 210,

    /// <summary>
    /// Network constraint situation that cannot limit the market
    /// </summary>
    /// <remarks>
    /// The TimeSeries describes the network elements, that cannot limit the market, to be taken into account to simulate a network constraint during the network load flow studies. The network situation includes the contingencies, the remedial actions, the monitored network elements and the potential additional constraints.
    /// </remarks>
    C14 = 211,

    /// <summary>
    /// Flat participation for all generators or loads
    /// </summary>
    /// <remarks>
    /// Flat GSK factors of all generators or loads, independently of the size.
    /// </remarks>
    C15 = 212,

    /// <summary>
    /// Proportional to installed capacity of generators
    /// </summary>
    /// <remarks>
    /// Generators participate relative to their maximum (installed) capacity (MW).
    /// </remarks>
    C16 = 213,

    /// <summary>
    /// Market price and total volume
    /// </summary>
    /// <remarks>
    /// A time series concerning market price and total volume.
    /// </remarks>
    C17 = 214,

    /// <summary>
    /// Import price
    /// </summary>
    /// <remarks>
    /// A time series concerning import price (the volume-weighted price average of all accepted bids).
    /// </remarks>
    C18 = 215,

    /// <summary>
    /// Capacity allocated (excluding price)
    /// </summary>
    /// <remarks>
    /// The business being described concerns capacity allocation and excludes price information.
    /// </remarks>
    C19 = 216,

    /// <summary>
    /// Common Grid Model Equipment
    /// </summary>
    /// <remarks>
    /// The timeseries provides equipment related to the Common Grid Model (CGM).
    /// </remarks>
    C20 = 217,

    /// <summary>
    /// Exchanged balancing reserve capacity
    /// </summary>
    /// <remarks>
    /// The balancing reserve capacity exchanged between areas.
    /// </remarks>
    C21 = 218,

    /// <summary>
    /// Shared balancing reserve capacity
    /// </summary>
    /// <remarks>
    /// The balancing reserve capacity shared between areas.
    /// </remarks>
    C22 = 219,

    /// <summary>
    /// Share of reserve capacity
    /// </summary>
    /// <remarks>
    /// A time series concerning the share of reserve capacity.
    /// </remarks>
    C23 = 220,

    /// <summary>
    /// Actual reserve capacity
    /// </summary>
    /// <remarks>
    /// A timeseries concerning actual reserve capacity.
    /// </remarks>
    C24 = 221,

    /// <summary>
    /// K-factor
    /// </summary>
    /// <remarks>
    /// K-factor as stated in the SO GL Art. 2 (45). It is also known as Frequency Bias.
    /// </remarks>
    C25 = 222,

    /// <summary>
    /// Frequency Containment Reserve-Normal (FCR-N)
    /// </summary>
    /// <remarks>
    /// FCR-N is a reserve that is automatically activated in both directions around a set point when the frequency varies between 50.10 Hz and 49.90 Hz after an imbalance.
    /// </remarks>
    C26 = 223,

    /// <summary>
    /// Frequency Containment Reserve-Disturbance (FCR-D)
    /// </summary>
    /// <remarks>
    /// FCR-D is a reserve that is automatically activated when the frequency falls below 49.90 Hz or rises above 50.1 Hz after an imbalance.
    /// </remarks>
    C27 = 224,

    /// <summary>
    /// Internal trade difference
    /// </summary>
    /// <remarks>
    /// A time series concerning internal trade difference, within an area, such as a Bidding Zone or Scheduling Area. The internal trade difference is the difference between trades reported from an out party (seller) and an in party (buyer). 
    /// </remarks>
    C28 = 225,

    /// <summary>
    /// Small scale production
    /// </summary>
    /// <remarks>
    /// Production from small scale production plants.
    /// </remarks>
    C29 = 226,

    /// <summary>
    /// System price
    /// </summary>
    /// <remarks>
    /// The system price is an unconstrained market clearing reference price. It is calculated without any congestion restrictions by setting capacities to infinity.
    /// </remarks>
    C30 = 227,

    /// <summary>
    /// Wind gust
    /// </summary>
    /// <remarks>
    /// An increase in the speed of the wind lasting for a short period.
    /// </remarks>
    C31 = 228,

    /// <summary>
    /// Area imbalance
    /// </summary>
    /// <remarks>
    /// A time series concerning imbalance between planned consumption, production and exchange in an Area.
    /// </remarks>
    C32 = 229,

    /// <summary>
    /// Unintended energy price
    /// </summary>
    /// <remarks>
    /// A timeseries concerning the price of the unintended cross-border exchange of energy.
    /// </remarks>
    C33 = 230,

    /// <summary>
    /// Frequency containment process energy
    /// </summary>
    /// <remarks>
    /// A timeseries containing the volume of energy resulting from the frequency containment process.
    /// </remarks>
    C34 = 231,

    /// <summary>
    /// Frequency containment process energy price
    /// </summary>
    /// <remarks>
    /// A timeseries containing the energy price from the frequency containment process.
    /// </remarks>
    C35 = 232,

    /// <summary>
    /// Ramping period energy
    /// </summary>
    /// <remarks>
    /// A timeseries containing the volume of energy exchanged as a result of ramping between different ANES values.
    /// </remarks>
    C36 = 233,

    /// <summary>
    /// Ramping period energy price
    /// </summary>
    /// <remarks>
    /// A timeseries containing the price of the energy exchanged as a result of ramping between different ANES values.
    /// </remarks>
    C37 = 234,

    /// <summary>
    /// Frequency deviation
    /// </summary>
    /// <remarks>
    /// A timeseries concerning the difference between the actual and the nominal frequency of a synchronous area.
    /// </remarks>
    C38 = 235,

    /// <summary>
    /// Day-Ahead market price
    /// </summary>
    /// <remarks>
    /// A timeseries concerning Day-Ahead market prices.
    /// </remarks>
    C39 = 236,

    /// <summary>
    /// Conditional bid
    /// </summary>
    /// <remarks>
    /// Standard product bid that is conditional on bids submitted outside of common platform.
    /// </remarks>
    C40 = 237,

    /// <summary>
    /// Thermal limit
    /// </summary>
    /// <remarks>
    /// The current causing a given network element to work outside of the range of safe operating temperatures.
    /// </remarks>
    C41 = 238,

    /// <summary>
    /// Frequency Limit
    /// </summary>
    /// <remarks>
    /// A constraint related to the containment of frequency deviations within a given area.
    /// </remarks>
    C42 = 239,

    /// <summary>
    /// Voltage limit
    /// </summary>
    /// <remarks>
    /// The maximum or minimum permissible voltage within normal operation state of a given network element.
    /// </remarks>
    C43 = 240,

    /// <summary>
    /// Current limit
    /// </summary>
    /// <remarks>
    /// The maximum permissible current within normal operation state of a given network element.
    /// </remarks>
    C44 = 241,

    /// <summary>
    /// Short circuit current limit
    /// </summary>
    /// <remarks>
    /// The maximum permissible short-circuit current within normal operation state of a given network element.
    /// </remarks>
    C45 = 242,

    /// <summary>
    /// Dynamic stability limit
    /// </summary>
    /// <remarks>
    /// A maximum permissible load ensuring the control of oscillations in the grid and avoiding the loss of synchronism.
    /// </remarks>
    C46 = 243,

    /// <summary>
    /// Disconnection
    /// </summary>
    /// <remarks>
    /// A timeseries describing disconnection of a TSO from a common platform.
    /// </remarks>
    C47 = 244,

    /// <summary>
    /// Intended energy with positive price
    /// </summary>
    /// <remarks>
    /// A timeseries concerning the amount of intended energy with prices higher than zero (and including zero).
    /// </remarks>
    C48 = 245,

    /// <summary>
    /// Intended energy with negative price
    /// </summary>
    /// <remarks>
    /// A timeseries concerning the amount of intended energy with prices lower than zero (excluding zero).
    /// </remarks>
    C49 = 246,

    /// <summary>
    /// Decopuling
    /// </summary>
    /// <remarks>
    /// A time series describing decoupling of an area.
    /// </remarks>
    C50 = 247,

    /// <summary>
    /// Resource capacity unit
    /// </summary>
    /// <remarks>
    /// A timeseries containing information about resource capacity units.
    /// </remarks>
    C51 = 248,

    /// <summary>
    /// Resource entry capacity data
    /// </summary>
    /// <remarks>
    /// A timeseries containing the resource capacity that can be allocated to an eligible resource capacity operator from another area.
    /// </remarks>
    C52 = 249,

    /// <summary>
    /// Resource capacity obligation data
    /// </summary>
    /// <remarks>
    /// A timeseries containing the resource capacity operator obligation to guarantee delivery.
    /// </remarks>
    C53 = 250,

    /// <summary>
    /// Available energy
    /// </summary>
    /// <remarks>
    /// A timeseries concerning the available energy.
    /// </remarks>
    C54 = 251,

    /// <summary>
    /// Production curtailment
    /// </summary>
    /// <remarks>
    /// A timeseries concerning the curtailment of production.
    /// </remarks>
    C55 = 252,

    /// <summary>
    /// Rounding error
    /// </summary>
    /// <remarks>
    /// A timeseries describing a rounding error.
    /// </remarks>
    C56 = 253,

    /// <summary>
    /// Metered frequency
    /// </summary>
    /// <remarks>
    /// The timeseries provides information about metered frequency.
    /// </remarks>
    C57 = 254,

    /// <summary>
    /// Adjusted TTC to the nominal criteria
    /// </summary>
    /// <remarks>
    /// The exchange program between two areas which guarantees that the Margin Available for Cross-Zonal Trade (MACZT) fulfils the nominal criteria at least on the most limiting Critical Network Element with Contingency (CNEC) which limits the transfer capacity.
    /// </remarks>
    C58 = 255,

    /// <summary>
    /// Adjusted TTC to the nominal criteria with TSOs limitation
    /// </summary>
    /// <remarks>
    /// The exchange program between two areas which allows the Margin Available for Cross-Zonal Trade (MACZT) on, at least, the most limiting Critical Network Element with Contingency (CNEC) to get closer to the nominal criteria fulfilment with a limited impact on the rest of the network.
    /// </remarks>
    C59 = 256,

    /// <summary>
    /// Frequency deviation larger than standard deviation
    /// </summary>
    /// <remarks>
    /// Total time in which the absolute value of the instantaneous frequency deviation was larger than the standard frequency deviation.
    /// </remarks>
    C60 = 257,

    /// <summary>
    /// Frequency deviation larger than maximum deviation
    /// </summary>
    /// <remarks>
    /// Total time in which the absolute value of the instantaneous frequency deviation was larger than the maximum instantaneous frequency deviation.
    /// </remarks>
    C61 = 258,

    /// <summary>
    /// Frequency deviation not returned to 50%
    /// </summary>
    /// <remarks>
    /// Number of events in which the absolute value of the instantaneous frequency deviation of the synchronous area exceeded 200 % of the standard frequency deviation as stated in SO GL (EU) regulation Art 131.1.a.vi.
    /// </remarks>
    C62 = 259,

    /// <summary>
    /// Frequency deviation not returned to restoration range
    /// </summary>
    /// <remarks>
    /// Number of events in which the absolute value of the instantaneous frequency deviation of the synchronous area exceeded 200 % of the standard frequency deviation.
    /// </remarks>
    C63 = 260,

    /// <summary>
    /// Frequency deviation outside recovery range
    /// </summary>
    /// <remarks>
    /// Number of events for which the absolute value of the instantaneous frequency deviation was outside of the frequency recovery range.
    /// </remarks>
    C64 = 261,

    /// <summary>
    /// Frequency
    /// </summary>
    /// <remarks>
    /// A time series describing measurement frequency.
    /// </remarks>
    C65 = 262,

    /// <summary>
    /// Mean value
    /// </summary>
    /// <remarks>
    /// A time series describing mean values.
    /// </remarks>
    C66 = 263,

    /// <summary>
    /// Standard deviation
    /// </summary>
    /// <remarks>
    /// A time series describing standard deviation.
    /// </remarks>
    C67 = 264,

    /// <summary>
    /// Percentile
    /// </summary>
    /// <remarks>
    /// A time series describing percentiles.
    /// </remarks>
    C68 = 265,

    /// <summary>
    /// Measured frequency resolution
    /// </summary>
    /// <remarks>
    /// A time series describing the resolution of a measured frequency.
    /// </remarks>
    C69 = 266,

    /// <summary>
    /// Accuracy
    /// </summary>
    /// <remarks>
    /// A time series describing measurement accuracy.
    /// </remarks>
    C70 = 267,

    /// <summary>
    /// FRCE outside level 1 range
    /// </summary>
    /// <remarks>
    /// The number of time intervals in which the average value of the FRCE was outside the Level 1 FRCE range as stated in SO GL. (EU) regulation Art 131.1.b.i.
    /// </remarks>
    C71 = 268,

    /// <summary>
    /// FRCE outside level 2 range
    /// </summary>
    /// <remarks>
    /// The number of time intervals in which the average value of the FRCE was outside the Level 2 FRCE range as stated in SO GL (EU) regulation. Art 131.1.b.i.
    /// </remarks>
    C72 = 269,

    /// <summary>
    /// FRCE exceeded 60% of FRR capacity
    /// </summary>
    /// <remarks>
    /// The number of events for which the FRCE exceeded 60 % of the reserve capacity on FRR as stated in SO GL (EU) regulation Art 131.1.b.ii.
    /// </remarks>
    C73 = 270,

    /// <summary>
    /// FRCE exceeded steady state deviation
    /// </summary>
    /// <remarks>
    /// The number of events for which the absolute value of the FRCE exceeded the maximum steady-state frequency deviation.
    /// </remarks>
    C74 = 271,

    /// <summary>
    /// FRCE calculation and accuracy descriptor
    /// </summary>
    /// <remarks>
    /// A time series describing how FRCE is calculated and its accuracy.
    /// </remarks>
    C75 = 272,

    /// <summary>
    /// Forecasted capacity
    /// </summary>
    /// <remarks>
    /// A time series describing forecasted capacity.
    /// </remarks>
    C76 = 273,

    /// <summary>
    /// Minimum available capacity
    /// </summary>
    /// <remarks>
    /// A time series describing minimum available capacity.
    /// </remarks>
    C77 = 274,

    /// <summary>
    /// Average available capacity
    /// </summary>
    /// <remarks>
    /// A time series describing average available capacity.
    /// </remarks>
    C78 = 275,

    /// <summary>
    /// Maximum available capacity
    /// </summary>
    /// <remarks>
    /// A time series describing maximum available capacity.
    /// </remarks>
    C79 = 276,

    /// <summary>
    /// Frequency and accuracy descriptor
    /// </summary>
    /// <remarks>
    /// A time series describing how system frequency and accuracy are determined.
    /// </remarks>
    C80 = 277,

    /// <summary>
    /// Long-Term internal redispatch
    /// </summary>
    /// <remarks>
    /// A time series describing long-term redispatch to relieve Scheduling Area internal congestion.
    /// </remarks>
    C81 = 278,

    /// <summary>
    /// Other unavailability
    /// </summary>
    /// <remarks>
    /// This is an unplanned unavailability. Not considered by market participants as a planned maintenance.
    /// </remarks>
    C82 = 279,

    /// <summary>
    /// Faster than standard FAT
    /// </summary>
    /// <remarks>
    /// Bids that can support a �Full Activation Time� (FAT) that is faster than standard FAT. Fast activation can be done for bids with activation time shorter than the minimum requirement for the standard product. When circumstances call for it, the TSO can order activation of such bids on a shorter notice.
    /// </remarks>
    C83 = 280,

    /// <summary>
    /// Faster than standard deactivation time
    /// </summary>
    /// <remarks>
    /// Fast deactivation can be done for bids with activation time shorter than the minimum requirement for the standard product. When circumstances call for it, the TSO can order activation of such bids on a shorter notice.
    /// </remarks>
    C84 = 281,

    /// <summary>
    /// Slower than standard FAT
    /// </summary>
    /// <remarks>
    /// Bids that can support a Full Activation Time (FAT) that is slower than standard FAT.
    /// </remarks>
    C85 = 282,

    /// <summary>
    /// Remedial action cost summary
    /// </summary>
    /// <remarks>
    /// A timeseries summarizing all incurred costs and/or revenues per party related to the activated remedial actions eligible to Cost Sharing.
    /// </remarks>
    C86 = 283,

    /// <summary>
    /// Settlement result
    /// </summary>
    /// <remarks>
    /// A timeseries representing the cost sharing settlement results between parties (i.e. which party will be paying and/or receiving money for the concerned period).
    /// </remarks>
    C87 = 284,

    /// <summary>
    /// Reserved cross zonal capacity
    /// </summary>
    /// <remarks>
    /// The reserved cross zonal capacity for system operator needs (EBGL art. 38(1)(b) and art. 41.).
    /// </remarks>
    C88 = 285,

    /// <summary>
    /// Energy reserves
    /// </summary>
    /// <remarks>
    /// A timeseries describing energy reserves.
    /// </remarks>
    C89 = 286,

    /// <summary>
    /// Combined dynamic constraint
    /// </summary>
    /// <remarks>
    /// The time series describes a combined dynamic constraint, being defined as a limit on the sum of power flows on a set of network elements or partial flows on a set of network elements for the purpose to respect dynamic stability limits.
    /// </remarks>
    C90 = 287,

    /// <summary>
    /// Anonymised constraint
    /// </summary>
    /// <remarks>
    /// The time series describes an anonymised constraint.
    /// </remarks>
    C91 = 288,

    /// <summary>
    /// Synchronous condenser activation
    /// </summary>
    /// <remarks>
    /// Activates a number of generators or other units in synchronous condenser mode.
    /// </remarks>
    C92 = 289,

    /// <summary>
    /// Permission administration details
    /// </summary>
    /// <remarks>
    /// A timeseries describing permission details such as authorisations, licenses or related regulatory requirements.
    /// </remarks>
    C93 = 290,

    /// <summary>
    /// Maximum capacity value of AC border flow
    /// </summary>
    /// <remarks>
    /// Maximum flow on an AC border between two areas (capacity)
    /// </remarks>
    C94 = 291,

    /// <summary>
    /// Initial forecast value of AC border flow
    /// </summary>
    /// <remarks>
    /// Initial flow on an AC border between two areas (forecast)
    /// </remarks>
    C95 = 292
}

