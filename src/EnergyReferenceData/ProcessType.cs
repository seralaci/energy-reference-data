// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// Indicates the nature of process that the document addresses.
/// </summary>
/// <remarks>
/// ET0020
/// </remarks>
public enum ProcessType
{
    /// <summary>
    /// Day ahead
    /// </summary>
    /// <remarks>
    /// The information provided concerns a day ahead process.
    /// </remarks>
    A01 = 1,

    /// <summary>
    /// Intra day incremental
    /// </summary>
    /// <remarks>
    /// The information provided concerns an intra day schedule.
    /// </remarks>
    A02 = 2,

    /// <summary>
    /// Inter-area transit
    /// </summary>
    /// <remarks>
    /// The information provided concerns an inter area transit schedule. The rules governing this process are market dependent
    /// </remarks>
    A03 = 3,

    /// <summary>
    /// System operation closure
    /// </summary>
    /// <remarks>
    /// The information provided concerns the closure of a given period of both scheduled and regulation information.
    /// </remarks>
    A04 = 4,

    /// <summary>
    /// Metered data aggregation
    /// </summary>
    /// <remarks>
    /// The information provided concerns the aggregation process of metered information.
    /// </remarks>
    A05 = 5,

    /// <summary>
    /// Imbalance settlement
    /// </summary>
    /// <remarks>
    /// The information provided concerns the imbalance settlement for a given period for a balance responsible party or parties.
    /// </remarks>
    A06 = 6,

    /// <summary>
    /// Capacity allocation
    /// </summary>
    /// <remarks>
    /// The information provided concerns the capacity allocation process.
    /// </remarks>
    A07 = 7,

    /// <summary>
    /// Central reconciliation
    /// </summary>
    /// <remarks>
    /// The process carried out to finalise the imbalance settlement based on actual metered values against provisional values from profiled metering points. 
    /// </remarks>
    A08 = 8,

    /// <summary>
    /// Released capacity allocation
    /// </summary>
    /// <remarks>
    /// The process concerns the notification of capacity rights that are being released.
    /// </remarks>
    A09 = 9,

    /// <summary>
    /// Proposed capacity allocation
    /// </summary>
    /// <remarks>
    /// The process concerns the proposed capacity to be allocated for a given border.
    /// </remarks>
    A10 = 10,

    /// <summary>
    /// Agreed capacity allocation
    /// </summary>
    /// <remarks>
    /// The process concerns the capacity that has been agreed for allocation for a border.
    /// </remarks>
    A11 = 11,

    /// <summary>
    /// Long term
    /// </summary>
    /// <remarks>
    /// The process concerns scheduling all schedules except daily and intraday contracts.
    /// </remarks>
    A12 = 12,

    /// <summary>
    /// Post scheduling adjustment
    /// </summary>
    /// <remarks>
    /// The process concerns the adjustments made to previous schedules after the period of execution.
    /// </remarks>
    A13 = 13,

    /// <summary>
    /// Forecast
    /// </summary>
    /// <remarks>
    /// The data contained in the document are to be handled in short, medium, long term forecasting process.
    /// </remarks>
    A14 = 14,

    /// <summary>
    /// Capacity determination
    /// </summary>
    /// <remarks>
    /// The process of determining the capacity for use.
    /// </remarks>
    A15 = 15,

    /// <summary>
    /// Realised
    /// </summary>
    /// <remarks>
    /// The process for the treatment of realised data as opposed to forecast data.
    /// </remarks>
    A16 = 16,

    /// <summary>
    /// Schedule day
    /// </summary>
    /// <remarks>
    /// The process concerns the day ahead, intraday and eventually ex-post scheduling in a single document. The schedule will be transferred within the total  position including historic information.
    /// </remarks>
    A17 = 17,

    /// <summary>
    /// Intraday total
    /// </summary>
    /// <remarks>
    /// This process concerns an intraday schedule which contains the accumulated day ahead and intraday current position.
    /// </remarks>
    A18 = 18,

    /// <summary>
    /// Intraday accumulated
    /// </summary>
    /// <remarks>
    /// This process concerns a single intraday schedule process where only intraday evolutions occur through version changes.
    /// </remarks>
    A19 = 19,

    /// <summary>
    /// SOMA process
    /// </summary>
    /// <remarks>
    ///  System Operator meter alignment process.
    /// </remarks>
    A20 = 20,

    /// <summary>
    /// SOVM process
    /// </summary>
    /// <remarks>
    ///  System Operator validated measurement process.
    /// </remarks>
    A21 = 21,

    /// <summary>
    /// RGCE accounting process
    /// </summary>
    /// <remarks>
    /// The document provides ENTSO-E Regional Group Continental Europe accounting process information.
    /// </remarks>
    A22 = 22,

    /// <summary>
    /// CCSR RGCE Settlement 
    /// </summary>
    /// <remarks>
    /// The process concerns the control center settlement report for the whole of the ENTSO-E Regional Group Continental Europe.
    /// </remarks>
    A23 = 23,

    /// <summary>
    /// CBSR Settlement 
    /// </summary>
    /// <remarks>
    /// The process concerns the control block settlement report.
    /// </remarks>
    A24 = 24,

    /// <summary>
    /// CASR Settlement 
    /// </summary>
    /// <remarks>
    /// The process concerns the control area settlement report.
    /// </remarks>
    A25 = 25,

    /// <summary>
    /// Outage information
    /// </summary>
    /// <remarks>
    /// The process concerns TSO publication of outages on its power system.
    /// </remarks>
    A26 = 26,

    /// <summary>
    /// Reserve resource process
    /// </summary>
    /// <remarks>
    /// The process being described is for general reserve resources.
    /// </remarks>
    A27 = 27,

    /// <summary>
    /// Primary reserve process
    /// </summary>
    /// <remarks>
    /// The process being described is for primary reserves.
    /// </remarks>
    A28 = 28,

    /// <summary>
    /// Secondary reserve process
    /// </summary>
    /// <remarks>
    /// The process being described is for secondary reserves.
    /// </remarks>
    A29 = 29,

    /// <summary>
    /// Tertiary reserve process
    /// </summary>
    /// <remarks>
    /// The process being described is for tertiary reserves.
    /// </remarks>
    A30 = 30,

    /// <summary>
    /// Week ahead
    /// </summary>
    /// <remarks>
    /// The process being described is for the week ahead.
    /// </remarks>
    A31 = 31,

    /// <summary>
    /// Month ahead
    /// </summary>
    /// <remarks>
    /// The process being described is for the month ahead.
    /// </remarks>
    A32 = 32,

    /// <summary>
    /// Year ahead
    /// </summary>
    /// <remarks>
    /// The process being described is for the year ahead.
    /// </remarks>
    A33 = 33,

    /// <summary>
    /// Contracted
    /// </summary>
    /// <remarks>
    /// The process being described is for contracted information.
    /// </remarks>
    A34 = 34,

    /// <summary>
    /// Network information
    /// </summary>
    /// <remarks>
    /// The process being described is for network information.
    /// </remarks>
    A35 = 35,

    /// <summary>
    /// Creation
    /// </summary>
    /// <remarks>
    /// The process being described is for the creation of information.
    /// </remarks>
    A36 = 36,

    /// <summary>
    /// Modification
    /// </summary>
    /// <remarks>
    /// The process being described is for the modification of information.
    /// </remarks>
    A37 = 37,

    /// <summary>
    /// Deactivation process
    /// </summary>
    /// <remarks>
    /// The process being described is for deactivation of information.
    /// </remarks>
    A38 = 38,

    /// <summary>
    /// Synchronisation process
    /// </summary>
    /// <remarks>
    /// The process being described is for the synchronisation of information.
    /// </remarks>
    A39 = 39,

    /// <summary>
    /// Intraday process
    /// </summary>
    /// <remarks>
    /// The process being described is for intraday process.
    /// </remarks>
    A40 = 40,

    /// <summary>
    /// Redispatch process
    /// </summary>
    /// <remarks>
    /// The process being described is for redispatch activation.
    /// </remarks>
    A41 = 41,

    /// <summary>
    /// Activation history process
    /// </summary>
    /// <remarks>
    /// The process being described is for the provision of an activation history.
    /// </remarks>
    A42 = 42,

    /// <summary>
    /// Flow based domain constraint day-ahead
    /// </summary>
    /// <remarks>
    /// The information provided concerns the flow-based process in day ahead.
    /// </remarks>
    A43 = 43,

    /// <summary>
    /// Flow based domain constraint intraday
    /// </summary>
    /// <remarks>
    /// The information provided concerns the flow-based process in intraday.
    /// </remarks>
    A44 = 44,

    /// <summary>
    /// Two days ahead
    /// </summary>
    /// <remarks>
    /// Two days ahead.
    /// </remarks>
    A45 = 45,

    /// <summary>
    /// Replacement reserve
    /// </summary>
    /// <remarks>
    /// A process being described is for replacement reserves (RR) to restore or support the required level of frequency restoration reserves.
    /// </remarks>
    A46 = 46,

    /// <summary>
    /// Manual frequency restoration reserve
    /// </summary>
    /// <remarks>
    /// A process being described is for manual frequency restoration reserves (mFRR).
    /// </remarks>
    A47 = 47,

    /// <summary>
    /// Day-ahead capacity determination
    /// </summary>
    /// <remarks>
    /// The process run at the day-ahead timeframe to determine the capacity for use.
    /// </remarks>
    A48 = 48,

    /// <summary>
    /// Intraday capacity determination
    /// </summary>
    /// <remarks>
    /// The process run at the intraday timeframe to determine the capacity for use.
    /// </remarks>
    A49 = 49,

    /// <summary>
    /// Long term capacity determination
    /// </summary>
    /// <remarks>
    /// The process run at the long term timeframe to determine the capacity for use.
    /// </remarks>
    A50 = 50,

    /// <summary>
    /// Automatic frequency restoration reserve
    /// </summary>
    /// <remarks>
    /// A process being described is for automatic frequency restoration reserves (aFRR).
    /// </remarks>
    A51 = 51,

    /// <summary>
    /// Frequency containment reserve
    /// </summary>
    /// <remarks>
    /// A process being described is for frequency containment reserves (FCR).
    /// </remarks>
    A52 = 52,

    /// <summary>
    /// Common Grid Model (CGM) merging process
    /// </summary>
    /// <remarks>
    /// The process for merging individual grid models to form the common grid model.
    /// </remarks>
    A53 = 53,

    /// <summary>
    /// Coordinated security analysis
    /// </summary>
    /// <remarks>
    /// The process being described is used for coordinated security analysis.
    /// </remarks>
    A54 = 54,

    /// <summary>
    /// Exchange of master data
    /// </summary>
    /// <remarks>
    /// A process for exchanging master data.
    /// </remarks>
    A55 = 55,

    /// <summary>
    /// Frequency restoration reserve
    /// </summary>
    /// <remarks>
    /// The process being described is for general frequency restoration reserve.
    /// </remarks>
    A56 = 56,

    /// <summary>
    /// FSKAR settlement
    /// </summary>
    /// <remarks>
    /// The information provided concerns the Financial Settlement of K?f, ACE and ramping period settlement for a given period.
    /// </remarks>
    A57 = 57,

    /// <summary>
    /// mFRR capacity market
    /// </summary>
    /// <remarks>
    /// Processes related to the Reserve option market to assure that there are enough available reserves for the manual FRR market.
    /// </remarks>
    A58 = 58,

    /// <summary>
    /// Internal trade reporting
    /// </summary>
    /// <remarks>
    /// The process related to internal trade reporting.
    /// </remarks>
    A59 = 59,

    /// <summary>
    /// Scheduled activation mFRR
    /// </summary>
    /// <remarks>
    /// mFRR being subject to scheduled activation.
    /// </remarks>
    A60 = 60,

    /// <summary>
    /// Direct activation mFRR
    /// </summary>
    /// <remarks>
    /// mFRR being subject to direct activation.
    /// </remarks>
    A61 = 61,

    /// <summary>
    /// Registration
    /// </summary>
    /// <remarks>
    /// A process related to the registration and management of object information.
    /// </remarks>
    A62 = 62,

    /// <summary>
    /// Imbalance Netting
    /// </summary>
    /// <remarks>
    /// The process described is for imbalance netting.
    /// </remarks>
    A63 = 63,

    /// <summary>
    /// Criteria application for instantaneous frequency
    /// </summary>
    /// <remarks>
    /// The  process describes criteria application for instantaneous frequency.
    /// </remarks>
    A64 = 64,

    /// <summary>
    /// Criteria application for frequency restoration
    /// </summary>
    /// <remarks>
    /// The process describes criteria application for frequency restoration.
    /// </remarks>
    A65 = 65,

    /// <summary>
    /// Cost sharing
    /// </summary>
    /// <remarks>
    /// The process describes the cost sharing process for costly remedial actions.
    /// </remarks>
    A66 = 66,

    /// <summary>
    /// Central selection aFRR
    /// </summary>
    /// <remarks>
    /// aFRR subject to central selection of bids for activation.
    /// </remarks>
    A67 = 67,

    /// <summary>
    /// Local selection aFRR
    /// </summary>
    /// <remarks>
    /// aFRR subject to local selection of bids for activation.
    /// </remarks>
    A68 = 68,

    /// <summary>
    /// Common grid model alignment
    /// </summary>
    /// <remarks>
    /// The process for aligning bidding zone net positions.
    /// </remarks>
    A69 = 69,

    /// <summary>
    /// Pan-European verification function
    /// </summary>
    /// <remarks>
    /// The process for verifying bidding zone net positions.
    /// </remarks>
    A70 = 70,

    /// <summary>
    /// Outage planning coordination
    /// </summary>
    /// <remarks>
    /// The process being described is used for outage planning coordination.
    /// </remarks>
    A71 = 71,

    /// <summary>
    /// Short term adequacy
    /// </summary>
    /// <remarks>
    /// The process being described is used for short term adequacy calculations.
    /// </remarks>
    A72 = 72,

    /// <summary>
    /// Coordinated capacity calculation
    /// </summary>
    /// <remarks>
    /// The process being described is used for coordinated capacity calculation.
    /// </remarks>
    A73 = 73,

    /// <summary>
    /// Access to metered data
    /// </summary>
    /// <remarks>
    /// Access to meter readings of electricity consumption from or electricity feed into the grid.
    /// </remarks>
    A74 = 74,

    /// <summary>
    /// Permission administration
    /// </summary>
    /// <remarks>
    /// Administration of permissions to access and/or use data.
    /// </remarks>
    A75 = 75
}

