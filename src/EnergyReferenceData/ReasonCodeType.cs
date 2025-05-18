// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// The coded motivation of an act.
/// </summary>
/// <remarks>
/// ET0015
/// </remarks>
public enum ReasonCodeType
{
    /// <summary>
    /// Errors not specifically identified 
    /// </summary>
    /// <remarks>
    /// This code is used to identify errors that have not been specifically addressed in the Reason code list. It can be used at any level and refers to the level for which it has been identified.
    /// </remarks>
    _999,

    /// <summary>
    /// Message fully accepted
    /// </summary>
    /// <remarks>
    /// The message has been fully accepted for application processing.
    /// </remarks>
    A01,

    /// <summary>
    /// Message fully rejected 
    /// </summary>
    /// <remarks>
    /// No part of the message has been accepted for application processing, e.g. Global position incomplete.
    /// </remarks>
    A02,

    /// <summary>
    /// Message contains errors at the time series level 
    /// </summary>
    /// <remarks>
    /// Part of the message contents, i.e. certain time series, has been accepted for application processing. It is necessary to look at the time series level to determine the time series that have been rejected. The time series is excluded from the global position.
    /// </remarks>
    A03,

    /// <summary>
    /// Time interval incorrect 
    /// </summary>
    /// <remarks>
    /// The schedule time interval is not within the contractual agreement or the period does not agree with the schedule time interval.
    /// </remarks>
    A04,

    /// <summary>
    /// Sender without valid contract 
    /// </summary>
    /// <remarks>
    /// The sender has no current valid contract with the TSO. The message consequently will be fully rejected.
    /// </remarks>
    A05,

    /// <summary>
    /// Schedule accepted 
    /// </summary>
    /// <remarks>
    /// The schedule of the recipient as presented has been completely accepted.
    /// </remarks>
    A06,

    /// <summary>
    /// Schedule partially accepted 
    /// </summary>
    /// <remarks>
    /// The schedule of the recipient as presented has been partially accepted. It is necessary to look at the time series level to determine the changes (time series rejected, modified, etc.).
    /// </remarks>
    A07,

    /// <summary>
    /// Schedule rejected 
    /// </summary>
    /// <remarks>
    /// The schedule of the recipient as presented has been totally rejected. The cause could be the non presentation of a counter part for the involved trades.
    /// </remarks>
    A08,

    /// <summary>
    /// Time series not matching
    /// </summary>
    /// <remarks>
    /// Time series mismatches. 
    /// </remarks>
    A09,

    /// <summary>
    /// Credit limit exceeded 
    /// </summary>
    /// <remarks>
    /// The contractual credit limit has been exceeded and as such the message has been rejected.
    /// </remarks>
    A10,

    /// <summary>
    /// Time series fully rejected 
    /// </summary>
    /// <remarks>
    /// The time series has been fully rejected. In the case of a confirmation report, this reason code is used in conjunction with either A26 or A30.
    /// </remarks>
    A20,

    /// <summary>
    /// Time series accepted with specific time interval errors 
    /// </summary>
    /// <remarks>
    /// The time series has been accepted but some time interval quantities have been rectified or zeroed out.
    /// </remarks>
    A21,

    /// <summary>
    /// In party/Out party invalid
    /// </summary>
    /// <remarks>
    /// There is no contract for the parties indicated or the rules for cross border nominations are not being respected. The time series has been rejected.
    /// </remarks>
    A22,

    /// <summary>
    /// Area invalid
    /// </summary>
    /// <remarks>
    /// The area is unknown or not allowed. The time series has been rejected.
    /// </remarks>
    A23,

    /// <summary>
    /// A24 not applicable
    /// </summary>
    /// <remarks>
    /// This code is no longer applicable.
    /// </remarks>
    A24,

    /// <summary>
    /// A25 not applicable
    /// </summary>
    /// <remarks>
    /// This code is no longer applicable.
    /// </remarks>
    A25,

    /// <summary>
    /// Default time series applied 
    /// </summary>
    /// <remarks>
    /// The time series has been rejected and replaced with a default time series profile. This reason code may not be used in conjunction with A30.
    /// </remarks>
    A26,

    /// <summary>
    /// Cross border capacity exceeded 
    /// </summary>
    /// <remarks>
    /// The cross border capacity has been exceeded. The time series has been rejected or adjusted.
    /// </remarks>
    A27,

    /// <summary>
    /// Counterpart time series missing 
    /// </summary>
    /// <remarks>
    /// This provides an indication that the time series has not got a counterpart time series. 	/// In the case of an Intermediate Confirmation Report this is advising the recipient that the time series may be rejected at nomination closure if the counterpart time series is not received. 	/// In the case of a Final Confirmation Report this is informing the recipient that the time series has been rejected because the counterpart time series has not been forthcoming. 
    /// </remarks>
    A28,

    /// <summary>
    /// Counterpart time series quantity differences 
    /// </summary>
    /// <remarks>
    /// The time series has been rejected as it does not match that of the counterpart who is considered by market rules to be correct.
    /// </remarks>
    A29,

    /// <summary>
    /// Imposed Time series from nominated party's time series (party identified in reason text)
    /// </summary>
    /// <remarks>
    /// The nominated party's time series has replaced the current time series. This reason code may not be used in conjunction with A26.
    /// </remarks>
    A30,

    /// <summary>
    /// Resolution inconsistency 
    /// </summary>
    /// <remarks>
    /// The resolution is not coherent with the time interval, or resolution not valid.
    /// </remarks>
    A41,

    /// <summary>
    /// Quantity inconsistency 
    /// </summary>
    /// <remarks>
    /// The quantity is not coherent. For example a time period with the same version number but different quantities or an non permitted number of digits after the decimal point, etc.
    /// </remarks>
    A42,

    /// <summary>
    /// Quantity increased 
    /// </summary>
    /// <remarks>
    /// The quantity has been increased in order to satisfy minimum constraints.
    /// </remarks>
    A43,

    /// <summary>
    /// Quantity decreased 
    /// </summary>
    /// <remarks>
    /// The quantity has been decreased in order to satisfy congestion constraints.
    /// </remarks>
    A44,

    /// <summary>
    /// Default quantity applied 
    /// </summary>
    /// <remarks>
    /// The default quantity has been applied as the current quantity does not satisfy contractual obligations.
    /// </remarks>
    A45,

    /// <summary>
    /// Quantities must not be signed values
    /// </summary>
    /// <remarks>
    /// The quantity proposed is illegal since signed values are only permitted in specific circumstances.
    /// </remarks>
    A46,

    /// <summary>
    /// A47 not applicable
    /// </summary>
    /// <remarks>
    /// This code is no longer applicable.
    /// </remarks>
    A47,

    /// <summary>
    /// Modification reason
    /// </summary>
    /// <remarks>
    /// In an intraday transmission, the reason for the modification is as follows (in the reason text).
    /// </remarks>
    A48,

    /// <summary>
    /// Position inconsistency
    /// </summary>
    /// <remarks>
    /// A position is missing or too many.
    /// </remarks>
    A49,

    /// <summary>
    /// Senders time series version conflict
    /// </summary>
    /// <remarks>
    /// There is an error in the sender time series version, i.e. it could be superior to the message version or is inconsistent with the existing data. The time series has been rejected.
    /// </remarks>
    A50,

    /// <summary>
    /// Message identification or version conflict
    /// </summary>
    /// <remarks>
    /// The message identification is already in the receiving system. Or a higher version already exists. Message rejected.
    /// </remarks>
    A51,

    /// <summary>
    /// Time series missing from new version of message
    /// </summary>
    /// <remarks>
    /// A time series is not contained in a new version of the message. Message rejected.
    /// </remarks>
    A52,

    /// <summary>
    /// Receiving party incorrect
    /// </summary>
    /// <remarks>
    /// The receiving party is incorrect. Message rejected.
    /// </remarks>
    A53,

    /// <summary>
    /// Global position not in balance
    /// </summary>
    /// <remarks>
    /// The message does not balance out to zero. Market rules might require that the message is rejected. 
    /// </remarks>
    A54,

    /// <summary>
    /// Time series identification conflict
    /// </summary>
    /// <remarks>
    /// The identification of the time series is duplicated or incorrect. Time series will be rejected.
    /// </remarks>
    A55,

    /// <summary>
    /// Corresponding Time series not netted
    /// </summary>
    /// <remarks>
    /// All corresponding time series must be netted. Time series rejected.
    /// </remarks>
    A56,

    /// <summary>
    /// Deadline limit exceeded/Gate not open
    /// </summary>
    /// <remarks>
    /// The deadline for receiving schedule messages has passed. Message or time series rejected.
    /// </remarks>
    A57,

    /// <summary>
    /// One to one nomination inconsistency
    /// </summary>
    /// <remarks>
    /// There is a one to one nomination inconstancy with the in/out parties or areas. Time series rejected.
    /// </remarks>
    A58,

    /// <summary>
    /// Not compliant to local market rules
    /// </summary>
    /// <remarks>
    /// The level in which this is identified is not in compliance with local market rules. The level in question has been rejected.
    /// </remarks>
    A59,

    /// <summary>
    /// Inter-area transit schedule exceeds nominated schedule
    /// </summary>
    /// <remarks>
    /// The inter-area transit schedule exceeds the nominated schedule for the same time interval. The inter-area transit schedule is rejected.
    /// </remarks>
    A60,

    /// <summary>
    /// Currency invalid
    /// </summary>
    /// <remarks>
    /// The currency is not in compliance with ISO 4217.
    /// </remarks>
    A61,

    /// <summary>
    /// Invalid business type
    /// </summary>
    /// <remarks>
    /// The business type does not belong to the valid set of business types for the process in question.
    /// </remarks>
    A62,

    /// <summary>
    /// Time Series modified
    /// </summary>
    /// <remarks>
    /// The time series has been modified.
    /// </remarks>
    A63,

    /// <summary>
    /// Resource Object Invalid
    /// </summary>
    /// <remarks>
    /// The Resource Object defined in the document is not valid.
    /// </remarks>
    A64,

    /// <summary>
    /// Reserve object Technical  limits exceeded
    /// </summary>
    /// <remarks>
    /// Reserve objects aggregated values are not within technical/prequalified limits
    /// </remarks>
    A65,

    /// <summary>
    /// Planned reserves do not correspond with contractual data
    /// </summary>
    /// <remarks>
    /// Planned reserves do not correspond with contractual data.
    /// </remarks>
    A66,

    /// <summary>
    /// Limit Data is not available
    /// </summary>
    /// <remarks>
    /// Limit Data is not available.
    /// </remarks>
    A67,

    /// <summary>
    /// Reserve Object not qualified for reserve type
    /// </summary>
    /// <remarks>
    /// Reserve Object is not qualified for reserve type.
    /// </remarks>
    A68,

    /// <summary>
    /// Mandatory attributes missing
    /// </summary>
    /// <remarks>
    /// Mandatory attributes missing.
    /// </remarks>
    A69,

    /// <summary>
    /// Curtailment
    /// </summary>
    /// <remarks>
    /// The capacity in question has been curtailed.
    /// </remarks>
    A70,

    /// <summary>
    /// Linked bid rejected due to associated bid unsuccessful
    /// </summary>
    /// <remarks>
    /// The bid in question has been rejected because an associated bid has been unsuccessful.
    /// </remarks>
    A71,

    /// <summary>
    /// Original bid divided to permit acceptance
    /// </summary>
    /// <remarks>
    /// The original bid quantity has been divided to enable it to be accepted.
    /// </remarks>
    A72,

    /// <summary>
    /// Bid accepted
    /// </summary>
    /// <remarks>
    /// The bid in question has been accepted.
    /// </remarks>
    A73,

    /// <summary>
    /// Auction Status
    /// </summary>
    /// <remarks>
    /// The information in the Reason Text provides auction status information.
    /// </remarks>
    A74,

    /// <summary>
    /// Right status information
    /// </summary>
    /// <remarks>
    /// The information in the Reason Text provides status information concerning the transmission rights in question.
    /// </remarks>
    A75,

    /// <summary>
    /// Agreement identification inconsistency
    /// </summary>
    /// <remarks>
    /// There is an inconsistency between the contract type and the agreement identification.
    /// </remarks>
    A76,

    /// <summary>
    /// Dependency matrix not respected
    /// </summary>
    /// <remarks>
    /// There is an inconsistency between the document contents and the dependency matrix.
    /// </remarks>
    A77,

    /// <summary>
    /// Sender identification and/or role invalid
    /// </summary>
    /// <remarks>
    /// The identification of the sender or the sender/role combination is invalid.
    /// </remarks>
    A78,

    /// <summary>
    /// Process type invalid
    /// </summary>
    /// <remarks>
    /// The process type does not figure in the list of valid process types for this document.
    /// </remarks>
    A79,

    /// <summary>
    /// Domain invalid
    /// </summary>
    /// <remarks>
    /// The domain does not figure in the list of valid domains for this document and process.
    /// </remarks>
    A80,

    /// <summary>
    /// Matching period invalid
    /// </summary>
    /// <remarks>
    /// The period is not within the expected limits.
    /// </remarks>
    A81,

    /// <summary>
    /// In/Out area inconsistent with domain
    /// </summary>
    /// <remarks>
    /// The in and out area does not figure within the domain specified.
    /// </remarks>
    A82,

    /// <summary>
    /// Disagree with matching results
    /// </summary>
    /// <remarks>
    /// The matching results provided are not consistent.
    /// </remarks>
    A83,

    /// <summary>
    /// Confirmation ignored due to higher version already received
    /// </summary>
    /// <remarks>
    /// The report has been ignored since a higher version has been received.
    /// </remarks>
    A84,

    /// <summary>
    /// Confirmation without adjustment (time series have been matched without change)
    /// </summary>
    /// <remarks>
    /// The report has been successfully matched without any changes.
    /// </remarks>
    A85,

    /// <summary>
    /// Confirmation with adjustment (time series have been modified)
    /// </summary>
    /// <remarks>
    /// The report has been matched but required adjustment.
    /// </remarks>
    A86,

    /// <summary>
    /// For action (only in intermediate confirmation - time series need mutual agreement and action)
    /// </summary>
    /// <remarks>
    /// The report in question is only for action in an intermediate stage.
    /// </remarks>
    A87,

    /// <summary>
    /// Time series matched
    /// </summary>
    /// <remarks>
    /// The time series has been successfully matched.
    /// </remarks>
    A88,

    /// <summary>
    /// Time series ignored (note: this can only apply to time series that are set to zero - see matching principles)
    /// </summary>
    /// <remarks>
    /// The time series has been ignored and not matched since it does not figure in a counterparty transmission. All are correctly equal to zero.
    /// </remarks>
    A89,

    /// <summary>
    /// Modification proposal (intermediate confirmation)
    /// </summary>
    /// <remarks>
    /// The document is a proposal for change before finalization.
    /// </remarks>
    A90,

    /// <summary>
    /// Expected document not received
    /// </summary>
    /// <remarks>
    /// The document that is expected has not been received within the expected timeframe.
    /// </remarks>
    A91,

    /// <summary>
    /// Not possible to send document on time, but estimated delivery time is provided
    /// </summary>
    /// <remarks>
    /// The document that is due cannot be transmitted within the required timeframe. An estimated time of transmission is provided.
    /// </remarks>
    A92,

    /// <summary>
    /// Not possible to send document on time, and furthermore no expected time of return to normal situation
    /// </summary>
    /// <remarks>
    /// The document that is due cannot be transmitted within the required timeframe. The time of transmission of the document is unknown.
    /// </remarks>
    A93,

    /// <summary>
    /// Document cannot be processed by receiving system
    /// </summary>
    /// <remarks>
    /// The receiving system cannot process that document in question.
    /// </remarks>
    A94,

    /// <summary>
    /// Complementary information
    /// </summary>
    /// <remarks>
    /// Additional text is provided in order to further explain a condition, for example to provide details of an outage.
    /// </remarks>
    A95,

    /// <summary>
    /// Technical constraint
    /// </summary>
    /// <remarks>
    /// A technical constraint has been applied.
    /// </remarks>
    A96,

    /// <summary>
    /// Force majeure curtailment
    /// </summary>
    /// <remarks>
    /// Curtailment due to Force Majeure. A code that enables the identification of the curtailment reason for settlement purposes.
    /// </remarks>
    A97,

    /// <summary>
    /// Network security curtailment
    /// </summary>
    /// <remarks>
    /// Curtailment due to network security reasons A code that enables the identification of the curtailment reason for settlement purposes.
    /// </remarks>
    A98,

    /// <summary>
    /// Auction cancelled
    /// </summary>
    /// <remarks>
    /// The auction has been cancelled.
    /// </remarks>
    A99,

    /// <summary>
    /// Incomplete document
    /// </summary>
    /// <remarks>
    /// The document is incomplete and cannot be processed.
    /// </remarks>
    B01,

    /// <summary>
    /// Accounting Point (tie-line) Time Series missing
    /// </summary>
    /// <remarks>
    /// The document is incomplete as a time series for an accounting point is missing.
    /// </remarks>
    B02,

    /// <summary>
    /// Meter data Time series missing
    /// </summary>
    /// <remarks>
    /// The document is incomplete as a time series for meter data is missing.
    /// </remarks>
    B03,

    /// <summary>
    /// Estimated values not allowed in first transmission
    /// </summary>
    /// <remarks>
    /// The document is in its initial form and estimated values are not allowed.
    /// </remarks>
    B04,

    /// <summary>
    /// No quantity values allowed for a quality that is not available
    /// </summary>
    /// <remarks>
    /// No quantity values are allowed for a quality that is not available.
    /// </remarks>
    B05,

    /// <summary>
    /// Time series accepted
    /// </summary>
    /// <remarks>
    /// Time series accepted.
    /// </remarks>
    B06,

    /// <summary>
    /// Auction without bids being entered
    /// </summary>
    /// <remarks>
    /// The auction has terminated without any bids being submitted. The ReasonText may provide the identification of the auction in question.
    /// </remarks>
    B07,

    /// <summary>
    /// Data not yet available
    /// </summary>
    /// <remarks>
    /// It is not possible to perform the necessary action since the required data for this action is not yet available.
    /// </remarks>
    B08,

    /// <summary>
    /// Bid not accepted
    /// </summary>
    /// <remarks>
    /// The bid in question has not been accepted.
    /// </remarks>
    B09,

    /// <summary>
    /// Initiator area problem
    /// </summary>
    /// <remarks>
    /// The problem concerns the initiator area.
    /// </remarks>
    B10,

    /// <summary>
    /// Cooperating area problem
    /// </summary>
    /// <remarks>
    /// The problem concerns the cooperating area.
    /// </remarks>
    B11,

    /// <summary>
    /// Communication status currently active
    /// </summary>
    /// <remarks>
    /// The status within the system indicates that the communication capability is currently active.
    /// </remarks>
    B12,

    /// <summary>
    /// Communication status currently inactive
    /// </summary>
    /// <remarks>
    /// The status within the system indicates that the communication capability is currently inactive.
    /// </remarks>
    B13,

    /// <summary>
    /// Communication status currently restricted
    /// </summary>
    /// <remarks>
    /// The status within the system indicates that the communication capability is currently restricted.
    /// </remarks>
    B14,

    /// <summary>
    /// Problem associated with both areas
    /// </summary>
    /// <remarks>
    /// The problem concerns both areas.
    /// </remarks>
    B15,

    /// <summary>
    /// Tender unavailable in MOL list
    /// </summary>
    /// <remarks>
    /// A tender that has been requested is no longer available in the MOL.
    /// </remarks>
    B16,

    /// <summary>
    /// Price based on preliminary exchange rate
    /// </summary>
    /// <remarks>
    /// The price is based on a preliminary exchange rate.
    /// </remarks>
    B17,

    /// <summary>
    /// Failure
    /// </summary>
    /// <remarks>
    /// A failure has occurred.
    /// </remarks>
    B18,

    /// <summary>
    /// Foreseen maintenance
    /// </summary>
    /// <remarks>
    /// Maintenance is foreseen.
    /// </remarks>
    B19,

    /// <summary>
    /// Shutdown
    /// </summary>
    /// <remarks>
    /// A shutdown has occurred.
    /// </remarks>
    B20,

    /// <summary>
    /// Official exchange rate approved
    /// </summary>
    /// <remarks>
    /// The official exchange rate has been approved.
    /// </remarks>
    B21,

    /// <summary>
    /// System regulation
    /// </summary>
    /// <remarks>
    /// The information provided regards a regulation for system purposes.
    /// </remarks>
    B22,

    /// <summary>
    /// Frequency regulation
    /// </summary>
    /// <remarks>
    /// The information provided regards a regulation for frequency purposes.
    /// </remarks>
    B23,

    /// <summary>
    /// Load flow overload
    /// </summary>
    /// <remarks>
    /// Situation in the grid, where loading of a certain grid element, e.g. overhead line, is above defined technical limits.
    /// </remarks>
    B24,

    /// <summary>
    /// Voltage level adjustment
    /// </summary>
    /// <remarks>
    /// A TSO activity to maintain an acceptable voltage profile throughout the network. This is achieved by balancing of the respective reactive power requirements of the network and the customers.
    /// </remarks>
    B25,

    /// <summary>
    /// Emergency situation curtailment
    /// </summary>
    /// <remarks>
    /// Curtailment due to emergency situation. A code that enables the identification of the curtailment reason for settlement purposes.
    /// </remarks>
    B26,

    /// <summary>
    /// Calculation process failed
    /// </summary>
    /// <remarks>
    /// The calculation has not been performed.
    /// </remarks>
    B27,

    /// <summary>
    /// No capacity constraint impact on the market
    /// </summary>
    /// <remarks>
    /// The market position is such as no capacity constraint is applied to limit the cross border exchanges.
    /// </remarks>
    B28,

    /// <summary>
    /// Special Condition
    /// </summary>
    /// <remarks>
    /// Special condition need to be fulfilled.
    /// </remarks>
    B29,

    /// <summary>
    /// Unverified
    /// </summary>
    /// <remarks>
    /// Missing or not validated data.
    /// </remarks>
    B30,

    /// <summary>
    /// Verified
    /// </summary>
    /// <remarks>
    /// Data has successfully passed the verification process.
    /// </remarks>
    B31,

    /// <summary>
    /// CGM inconsistency
    /// </summary>
    /// <remarks>
    /// Describes an element which was not found in the CGM.
    /// </remarks>
    B32,

    /// <summary>
    /// Network dictionary inconsistency
    /// </summary>
    /// <remarks>
    /// Describes an element which was not found in the network dictionary.
    /// </remarks>
    B33,

    /// <summary>
    /// Capacity reduced by TSO
    /// </summary>
    /// <remarks>
    /// Describes a capacity that was reduced by a TSO.
    /// </remarks>
    B34,

    /// <summary>
    /// Overload
    /// </summary>
    /// <remarks>
    /// Describes an N-k or N state overload.
    /// </remarks>
    B35,

    /// <summary>
    /// GLSK limitation
    /// </summary>
    /// <remarks>
    /// Describes a situation in which there is not enough power adjustment in the GLSK file to cover the capacity.
    /// </remarks>
    B36,

    /// <summary>
    /// Voltage constraint
    /// </summary>
    /// <remarks>
    /// Describes an N-k or N state voltage violation.
    /// </remarks>
    B37,

    /// <summary>
    /// Angle constraint
    /// </summary>
    /// <remarks>
    /// Describes an N-k or N state angle violation.
    /// </remarks>
    B38,

    /// <summary>
    /// Stability
    /// </summary>
    /// <remarks>
    /// Describes a situation in which the dynamic behaviour of the network violated.
    /// </remarks>
    B39,

    /// <summary>
    /// Loadflow divergence
    /// </summary>
    /// <remarks>
    /// Describes a network situation in which the provided capacity values are part of a load flow divergence situation.
    /// </remarks>
    B40,

    /// <summary>
    /// Exclusion for SoS reasons
    /// </summary>
    /// <remarks>
    /// This is the adjustment applied to the capacity of a branch to have a minimum RAM (Remaining Available Margin) available for commercial exchanges.
    /// </remarks>
    B41,

    /// <summary>
    /// Constraint by the market
    /// </summary>
    /// <remarks>
    /// A constraint due to market restrictions.
    /// </remarks>
    B42,

    /// <summary>
    /// Ordinary
    /// </summary>
    /// <remarks>
    /// The contingency is ordinary (methodology for coordinating operational security analysis, article 6).
    /// </remarks>
    B43,

    /// <summary>
    /// Exceptional
    /// </summary>
    /// <remarks>
    /// The contingency is exceptional (methodology for coordinating operational security analysis, article 6).
    /// </remarks>
    B44,

    /// <summary>
    /// Out of range
    /// </summary>
    /// <remarks>
    /// The contingency is out of range (methodology for coordinating operational security analysis, article 6).
    /// </remarks>
    B45,

    /// <summary>
    /// Internal congestion
    /// </summary>
    /// <remarks>
    /// A temporary congestion within a bidding zone or scheduling area.
    /// </remarks>
    B46,

    /// <summary>
    /// Operational security constraints
    /// </summary>
    /// <remarks>
    /// Operational security constraints identified by TSOs.
    /// </remarks>
    B47,

    /// <summary>
    /// Estimated value
    /// </summary>
    /// <remarks>
    /// Describes a situation where a calculation process has failed and extrapolated or interpolated values will be applied.
    /// </remarks>
    B48,

    /// <summary>
    /// Balancing
    /// </summary>
    /// <remarks>
    /// Activated for balancing purposes.
    /// </remarks>
    B49,

    /// <summary>
    /// Values shared
    /// </summary>
    /// <remarks>
    /// Values of this time series are also valid for counter-party.
    /// </remarks>
    B50,

    /// <summary>
    /// Outside price limits
    /// </summary>
    /// <remarks>
    /// The offered price is not within the valid limits.
    /// </remarks>
    B51,

    /// <summary>
    /// Previous timeframe data
    /// </summary>
    /// <remarks>
    /// In case of processing issue, sent data are based on the previous timeframe.
    /// </remarks>
    B52,

    /// <summary>
    /// MOL merging succesful
    /// </summary>
    /// <remarks>
    /// The merging of the Merit Order List has been successfully processed.
    /// </remarks>
    B53,

    /// <summary>
    /// MOL merging failed
    /// </summary>
    /// <remarks>
    /// The merging of the Merit Order List has failed.
    /// </remarks>
    B54,

    /// <summary>
    /// Because of redispatching
    /// </summary>
    /// <remarks>
    /// Because of redispatching according to Article 2(26) of Commission Regulation (EU) 543/2013
    /// </remarks>
    B55,

    /// <summary>
    /// Because of countertrading
    /// </summary>
    /// <remarks>
    /// Because of countertrading according to Article 2(13) of Commission Regulation (EU) 543/2013
    /// </remarks>
    B56,

    /// <summary>
    /// Because of other remedial action
    /// </summary>
    /// <remarks>
    /// Not available because of any remedial action.
    /// </remarks>
    B57,

    /// <summary>
    /// Insufficiency of reserves
    /// </summary>
    /// <remarks>
    /// The reserve capacity is not sufficient.
    /// </remarks>
    B58,

    /// <summary>
    /// Unavailability of reserve providing unit
    /// </summary>
    /// <remarks>
    /// The unit providing the reserve is subject to technical unavailability.
    /// </remarks>
    B59,

    /// <summary>
    /// Unavailability of automatic protection systems
    /// </summary>
    /// <remarks>
    /// Unavailability of tools to detect predetermined system conditions that have a high probability of causing unusual stress on the power system, for which pre-planned remedial action is considered necessary or for which automatic protective actions may be triggered such as special protection schemes or automatic load shedding.
    /// </remarks>
    B60,

    /// <summary>
    /// Physical cable or converter restrictions
    /// </summary>
    /// <remarks>
    /// Limitation due to physical cable or converter restrictions.
    /// </remarks>
    B61,

    /// <summary>
    /// Constraints in controller systems
    /// </summary>
    /// <remarks>
    /// Limitation due to constraints in controller systems.
    /// </remarks>
    B62,

    /// <summary>
    /// Adjusted because of expected violation of operational security
    /// </summary>
    /// <remarks>
    /// The capacity is adjusted because of an expected violation of operational security limits of physical transmission assets.
    /// </remarks>
    B63,

    /// <summary>
    /// Adjusted because already considered remedial actions are assessed as not sufficient
    /// </summary>
    /// <remarks>
    /// The capacity is adjusted because the remedial actions were assessed as not sufficient or ineffective to avoid the expected violation of operational security limit(s).
    /// </remarks>
    B64,

    /// <summary>
    /// Time series partially accepted
    /// </summary>
    /// <remarks>
    /// The time series is partially accepted.
    /// </remarks>
    B65,

    /// <summary>
    /// Demand fully netted
    /// </summary>
    /// <remarks>
    /// Demand was fully netted against other demand(s).
    /// </remarks>
    B66,

    /// <summary>
    /// Bid activated in same direction
    /// </summary>
    /// <remarks>
    /// One or several bids were activated in the same direction within the same uncongested area as the demand.
    /// </remarks>
    B67,

    /// <summary>
    /// Optimization in progress
    /// </summary>
    /// <remarks>
    /// The activation optimisation framework is being executed.
    /// </remarks>
    B68,

    /// <summary>
    /// Wrong energy market timeframe
    /// </summary>
    /// <remarks>
    /// The given energy market timeframe is invalid or wrong.
    /// </remarks>
    B69,

    /// <summary>
    /// Message partially accepted
    /// </summary>
    /// <remarks>
    /// The detailed transactions of the received document are partially accepted. It is necessary to look at the detailed (transaction) level to determine if the transaction is accepted, rejected etc.
    /// </remarks>
    B70,

    /// <summary>
    /// (Explicit) Permission from the customer
    /// </summary>
    /// <remarks>
    /// Based on the regulation (EU) 2016/679 (GDPR) Article 6, Lawfulness of processing: The data subject has given consent to the processing of his or her personal data for one or more specific purposes.
    /// </remarks>
    B71,

    /// <summary>
    /// In execution of a contract with the customer (Execution of contract)
    /// </summary>
    /// <remarks>
    /// Based on the regulation (EU) 2016/679 (GDPR) Article 6, Lawfulness of processing: Processing is necessary for the performance of a contract to which the data subject is party or in order to take steps at the request of the data subject prior to entering into a contract.
    /// </remarks>
    B72,

    /// <summary>
    /// Legal obligations
    /// </summary>
    /// <remarks>
    /// Based on the regulation (EU) 2016/679 (GDPR) Article 6, Lawfulness of processing: Processing is necessary for compliance with a legal obligation to which the controller is subject.
    /// </remarks>
    B73,

    /// <summary>
    /// In protection of vital interests of the customer
    /// </summary>
    /// <remarks>
    /// Based on the regulation (EU) 2016/679 (GDPR) Article 6, Lawfulness of processing: Processing is necessary in order to protect the vital interests of the data subject or of another natural person.	/// 
    /// </remarks>
    B74,

    /// <summary>
    /// In order to perform a duty of common (national) interest
    /// </summary>
    /// <remarks>
    /// Based on the regulation (EU) 2016/679 (GDPR) Article 6, Lawfulness of processing: Processing is necessary for the performance of a task carried out in the public interest or in the exercise of official authority vested in the controller.	/// 
    /// </remarks>
    B75,

    /// <summary>
    /// Justified interest of the dataprocessee
    /// </summary>
    /// <remarks>
    /// Based on the regulation (EU) 2016/679 (GDPR) Article 6, Lawfulness of processing: Processing is necessary for the purposes of the legitimate interests pursued by the controller or by a third party, except where such interests are overridden by the interests or fundamental rights and freedoms of the data subject which require protection of personal data, in particular where the data subject is a child	/// 
    /// </remarks>
    B76,

    /// <summary>
    /// Fulfilment of purpose
    /// </summary>
    /// <remarks>
    /// The purpose of the object or action has been fulfilled.
    /// </remarks>
    B77,

    /// <summary>
    /// Reach of end timestamp
    /// </summary>
    /// <remarks>
    /// The object or action has reached its end timestamp.
    /// </remarks>
    B78,

    /// <summary>
    /// Revocation
    /// </summary>
    /// <remarks>
    /// Revocation of the action or object.
    /// </remarks>
    B79,

    /// <summary>
    /// Termination
    /// </summary>
    /// <remarks>
    /// Termination of the action or object.
    /// </remarks>
    B80
}

