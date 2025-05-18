// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// The condition or position of an object with regard to its standing.
/// </summary>
/// <remarks>
/// ET0025
/// </remarks>
public enum StatusType
{
    /// <summary>
    /// Intermediate
    /// </summary>
    /// <remarks>
    /// The document is in a non finalized state.
    /// </remarks>
    A01 = 1,

    /// <summary>
    /// Final
    /// </summary>
    /// <remarks>
    /// The document is in a definitive state.
    /// </remarks>
    A02 = 2,

    /// <summary>
    /// Deactivated
    /// </summary>
    /// <remarks>
    /// The object being reported has been deactivated.
    /// </remarks>
    A03 = 3,

    /// <summary>
    /// Reactivated
    /// </summary>
    /// <remarks>
    /// The object being reported has been reactivated.
    /// </remarks>
    A04 = 4,

    /// <summary>
    /// Active
    /// </summary>
    /// <remarks>
    /// The object being reported is currently active.
    /// </remarks>
    A05 = 5,

    /// <summary>
    /// Available
    /// </summary>
    /// <remarks>
    /// The volumes (one or more) are available.
    /// </remarks>
    A06 = 6,

    /// <summary>
    /// Activated
    /// </summary>
    /// <remarks>
    /// The quantities in the time series have been activated.
    /// </remarks>
    A07 = 7,

    /// <summary>
    /// In process
    /// </summary>
    /// <remarks>
    /// The quantities in the time series are in the process of activation (an activation request has been made).
    /// </remarks>
    A08 = 8,

    /// <summary>
    /// Cancelled
    /// </summary>
    /// <remarks>
    /// The tender indicated in the time series has been completely cancelled.	/// In this case the resources are no longer available to all Acquiring System Operators
    /// </remarks>
    A09 = 9,

    /// <summary>
    /// Ordered
    /// </summary>
    /// <remarks>
    /// The quantities in the time series are to be activated.
    /// </remarks>
    A10 = 10,

    /// <summary>
    /// Unavailable
    /// </summary>
    /// <remarks>
    /// The volumes (one or more) are unavailable.
    /// </remarks>
    A11 = 11,

    /// <summary>
    /// RGCE agreed
    /// </summary>
    /// <remarks>
    /// The information has been agreed within the ENTSO-E Regional Group Continental Europe process.
    /// </remarks>
    A12 = 12,

    /// <summary>
    /// Withdrawn
    /// </summary>
    /// <remarks>
    /// The information or action has been withdrawn by the submitter.
    /// </remarks>
    A13 = 13,

    /// <summary>
    /// Creation
    /// </summary>
    /// <remarks>
    /// The action requested to be carried out is the creation of a new object.
    /// </remarks>
    A14 = 14,

    /// <summary>
    /// Update
    /// </summary>
    /// <remarks>
    /// The action requested to be carried out is the update an existing object.
    /// </remarks>
    A15 = 15,

    /// <summary>
    /// Deactivation
    /// </summary>
    /// <remarks>
    /// The action requested to be carried out is to deactivate an existing object.
    /// </remarks>
    A16 = 16,

    /// <summary>
    /// Reactivation
    /// </summary>
    /// <remarks>
    /// The action requested to be carried out is to reactivate a previously deactivated object.
    /// </remarks>
    A17 = 17,

    /// <summary>
    /// Preventive
    /// </summary>
    /// <remarks>
    /// The remedial action is applied to prevent an outage.
    /// </remarks>
    A18 = 18,

    /// <summary>
    /// Curative
    /// </summary>
    /// <remarks>
    /// The remedial action is applied after an outage has occurred, in order to maintain the operational security.
    /// </remarks>
    A19 = 19,

    /// <summary>
    /// Automatic
    /// </summary>
    /// <remarks>
    /// The remedial action being described is applied by an automation when an outage occurs.
    /// </remarks>
    A20 = 20,

    /// <summary>
    /// Open
    /// </summary>
    /// <remarks>
    /// The action being described consists of disconnecting the network element  to the transmission network.
    /// </remarks>
    A21 = 21,

    /// <summary>
    /// Close
    /// </summary>
    /// <remarks>
    /// The action being described consists of connecting the network element  to the transmission network.
    /// </remarks>
    A22 = 22,

    /// <summary>
    /// Stop
    /// </summary>
    /// <remarks>
    /// The action being described consists of stopping the production or consumption connected to a network element.
    /// </remarks>
    A23 = 23,

    /// <summary>
    /// Start
    /// </summary>
    /// <remarks>
    /// The action being described consists of starting the production or consumption connected to a network element.
    /// </remarks>
    A24 = 24,

    /// <summary>
    /// Relative
    /// </summary>
    /// <remarks>
    /// The quantity being described is a relative value to an initial state.
    /// </remarks>
    A25 = 25,

    /// <summary>
    /// Absolute
    /// </summary>
    /// <remarks>
    /// The quantity being described is an absolute value.
    /// </remarks>
    A26 = 26,

    /// <summary>
    /// Curative or preventive
    /// </summary>
    /// <remarks>
    /// The remedial action can be applied to prevent an outage or after an outage has occurred in order to maintain the operational security.
    /// </remarks>
    A27 = 27,

    /// <summary>
    /// Unshared bid
    /// </summary>
    /// <remarks>
    /// Used to indicate that the bid cannot be shared.
    /// </remarks>
    A28 = 28,

    /// <summary>
    /// Pre Processed
    /// </summary>
    /// <remarks>
    /// to be process
    /// </remarks>
    A29 = 29,

    /// <summary>
    /// Substituted
    /// </summary>
    /// <remarks>
    /// Substituted pre-processing data.
    /// </remarks>
    A30 = 30,

    /// <summary>
    /// Modified
    /// </summary>
    /// <remarks>
    /// Modified pre-processing data by RSC or CGMA platform.
    /// </remarks>
    A31 = 31,

    /// <summary>
    /// Result
    /// </summary>
    /// <remarks>
    /// Result
    /// </remarks>
    A32 = 32,

    /// <summary>
    /// Not satisfied
    /// </summary>
    /// <remarks>
    /// The need described in the time series cannot be satisfied.
    /// </remarks>
    A33 = 33,

    /// <summary>
    /// Rejected
    /// </summary>
    /// <remarks>
    /// The document rejected by one or more parties.
    /// </remarks>
    A34 = 34,

    /// <summary>
    /// Preliminary
    /// </summary>
    /// <remarks>
    /// Indicative information only for initial planning purposes.
    /// </remarks>
    A35 = 35,

    /// <summary>
    /// Planned
    /// </summary>
    /// <remarks>
    /// Is planned.
    /// </remarks>
    A36 = 36,

    /// <summary>
    /// Confirmed
    /// </summary>
    /// <remarks>
    /// The status is  confirmed.
    /// </remarks>
    A37 = 37,

    /// <summary>
    /// Shall Be Used
    /// </summary>
    /// <remarks>
    /// The object defined in the series shall be used.
    /// </remarks>
    A38 = 38,

    /// <summary>
    /// Could Be Used
    /// </summary>
    /// <remarks>
    /// The object defined in the series could be used.
    /// </remarks>
    A39 = 39,

    /// <summary>
    /// Proposed
    /// </summary>
    /// <remarks>
    /// The status of the information is proposed.
    /// </remarks>
    A40 = 40,

    /// <summary>
    /// Individual Network Data
    /// </summary>
    /// <remarks>
    /// The network data provided in the document or series concerns the the unique TSO area describes by the document or series.
    /// </remarks>
    A41 = 41,

    /// <summary>
    /// Common Network Data
    /// </summary>
    /// <remarks>
    /// The network data provided in the document or series concerns the whole area describes by the document or series.
    /// </remarks>
    A42 = 42,

    /// <summary>
    /// Setpoint schedule
    /// </summary>
    /// <remarks>
    /// The code for the power setpoint mode of operation of the HVDC link.
    /// </remarks>
    A43 = 43,

    /// <summary>
    /// Proportional external signal
    /// </summary>
    /// <remarks>
    /// The code for the proportional external signal mode of operation of the HVDC link.
    /// </remarks>
    A44 = 44,

    /// <summary>
    /// AC emulation
    /// </summary>
    /// <remarks>
    /// The code for the AC emulation mode of operation of the HVDC link.
    /// </remarks>
    A45 = 45,

    /// <summary>
    /// Importing element
    /// </summary>
    /// <remarks>
    /// An importing network element in which the flow measurement enters.
    /// </remarks>
    A46 = 46,

    /// <summary>
    /// Exporting element
    /// </summary>
    /// <remarks>
    /// An exporting network element from which the flow measurement comes out.
    /// </remarks>
    A47 = 47,

    /// <summary>
    /// To be optimized
    /// </summary>
    /// <remarks>
    /// Describes an element which needs to be optimized by an optimization process.
    /// </remarks>
    A48 = 48,

    /// <summary>
    /// To be monitored
    /// </summary>
    /// <remarks>
    /// Describes an element which needs to be monitored by an optimization process.
    /// </remarks>
    A49 = 49,

    /// <summary>
    /// To be included in capacity calculation
    /// </summary>
    /// <remarks>
    /// Describes an element which needs to be taken into account in a capacity calculation process.
    /// </remarks>
    A50 = 50,

    /// <summary>
    /// Relative to previous point in time
    /// </summary>
    /// <remarks>
    /// The quantity being described is a relative value to a previous point in time.
    /// </remarks>
    A51 = 51,

    /// <summary>
    /// For flow optimization
    /// </summary>
    /// <remarks>
    /// Describes an element which needs to be optimized by a flow optimization process.
    /// </remarks>
    A52 = 52,

    /// <summary>
    /// For voltage optimization
    /// </summary>
    /// <remarks>
    /// Describes an element which needs to be optimized by a voltage optimization process.
    /// </remarks>
    A53 = 53,

    /// <summary>
    /// Presolved
    /// </summary>
    /// <remarks>
    /// Describes an active constraint that limits the exchanges. It is part of the presolved domain.
    /// </remarks>
    A54 = 54,

    /// <summary>
    /// Not available if linked bid activated
    /// </summary>
    /// <remarks>
    /// Bid not available if linked bid activated.
    /// </remarks>
    A55 = 55,

    /// <summary>
    /// Not available if linked bid rejected
    /// </summary>
    /// <remarks>
    /// Bid not available if linked bid rejected.
    /// </remarks>
    A56 = 56,

    /// <summary>
    /// Not available for DA if linked bid subject to DA
    /// </summary>
    /// <remarks>
    /// Bid not available for direct activation if linked bid subject to direct activation.
    /// </remarks>
    A57 = 57,

    /// <summary>
    /// Not available for DA if linked bid subject to SA
    /// </summary>
    /// <remarks>
    /// Bid not available for direct activation if linked bid subject to scheduled activation.
    /// </remarks>
    A58 = 58,

    /// <summary>
    /// Not available if linked bid subject to SA
    /// </summary>
    /// <remarks>
    /// Bid not available if linked bid subject to scheduled activation.
    /// </remarks>
    A59 = 59,

    /// <summary>
    /// Not available if linked bid subject to DA
    /// </summary>
    /// <remarks>
    /// Bid not available if linked bid subject to direct activation.
    /// </remarks>
    A60 = 60,

    /// <summary>
    /// Primary market
    /// </summary>
    /// <remarks>
    /// A value is traded for the first time.
    /// </remarks>
    A61 = 61,

    /// <summary>
    /// Secondary market
    /// </summary>
    /// <remarks>
    /// A value is traded for the second or next times between two parties.
    /// </remarks>
    A62 = 62,

    /// <summary>
    /// Interesting
    /// </summary>
    /// <remarks>
    /// Describes an asset which is considered as interesting.
    /// </remarks>
    A63 = 63,

    /// <summary>
    /// Relevant
    /// </summary>
    /// <remarks>
    /// Describes an asset which is considered as relevant.
    /// </remarks>
    A64 = 64,

    /// <summary>
    /// Conditionally available
    /// </summary>
    /// <remarks>
    /// Bid available as long as none of the conditions associated with the linked bids materialise.
    /// </remarks>
    A65 = 65,

    /// <summary>
    /// Conditionally unavailable
    /// </summary>
    /// <remarks>
    /// Bid unavailable as long as none of the conditions associated with the linked bids materialise.
    /// </remarks>
    A66 = 66,

    /// <summary>
    /// Available if linked bid activated
    /// </summary>
    /// <remarks>
    /// Bid available if linked bid activated.
    /// </remarks>
    A67 = 67,

    /// <summary>
    /// Available if linked bid rejected
    /// </summary>
    /// <remarks>
    /// Bid available if linked bid rejected.
    /// </remarks>
    A68 = 68,

    /// <summary>
    /// Available if linked bid subject to SA
    /// </summary>
    /// <remarks>
    /// Bid available if linked bid subject to scheduled activation.
    /// </remarks>
    A69 = 69,

    /// <summary>
    /// Available if linked bid subject to DA
    /// </summary>
    /// <remarks>
    /// Bid available if linked bid subject to direct activation.
    /// </remarks>
    A70 = 70,

    /// <summary>
    /// Available for DA if linked bid subject to DA
    /// </summary>
    /// <remarks>
    /// Bid available for direct activation if linked bid subject to direct activation.
    /// </remarks>
    A71 = 71,

    /// <summary>
    /// Available for DA if linked bid subject to SA
    /// </summary>
    /// <remarks>
    /// Bid available for direct activation if linked bid subject to scheduled activation.
    /// </remarks>
    A72 = 72,

    /// <summary>
    /// Delta
    /// </summary>
    /// <remarks>
    /// Describes a status representing a difference between two values.
    /// </remarks>
    A73 = 73,

    /// <summary>
    /// Validated
    /// </summary>
    /// <remarks>
    /// The object or action was validated.
    /// </remarks>
    A74 = 74,

    /// <summary>
    /// Invalid
    /// </summary>
    /// <remarks>
    /// The object or action was invalid.
    /// </remarks>
    A75 = 75,

    /// <summary>
    /// Timed out
    /// </summary>
    /// <remarks>
    /// The object or action was timed out.
    /// </remarks>
    A76 = 76
}

