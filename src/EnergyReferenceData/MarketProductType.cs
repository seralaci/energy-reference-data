// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// The identification of the type of a product on a market view
/// </summary>
/// <remarks>
/// ET0008
/// </remarks>
public enum MarketProductType
{
    /// <summary>
    /// Standard balancing product
    /// </summary>
    /// <remarks>
    /// A harmonised balancing product defined by all TSOs for the exchange of balancing services.
    /// </remarks>
    A01 = 1,

    /// <summary>
    /// Specific balancing product
    /// </summary>
    /// <remarks>
    /// A product different from a standard product.
    /// </remarks>
    A02 = 2,

    /// <summary>
    /// Product from integrated scheduling process
    /// </summary>
    /// <remarks>
    /// From the EBGL Article 2 (19), means an iterative process that uses at least integrated scheduling process bids that contain commercial data, complex technical data of individual power generating facilities or demand facilities and explicitly includes the start-up characteristics, the latest control area adequacy analysis and the operational security limits as an input to the process.
    /// </remarks>
    A03 = 3,

    /// <summary>
    /// Local balancing product
    /// </summary>
    /// <remarks>
    /// A balancing product that is neither standard nor specific. This type may be applicable only in the interim period until standard and specific products have been defined within the given scheduling area.
    /// </remarks>
    A04 = 4,

    /// <summary>
    /// Standard mFRR product eligible for scheduled activation
    /// </summary>
    /// <remarks>
    /// Standard mFRR product eligible for scheduled activation.
    /// </remarks>
    A05 = 5,

    /// <summary>
    /// Standard mFRR product eligible for direct activation
    /// </summary>
    /// <remarks>
    /// Standard mFRR product eligible for direct activation.
    /// </remarks>
    A06 = 6,

    /// <summary>
    /// Standard mFRR product eligible for direct and scheduled activation
    /// </summary>
    /// <remarks>
    /// Standard mFRR product eligible for direct as well as scheduled activation.
    /// </remarks>
    A07 = 7,

    /// <summary>
    /// Market wide resource capacity mechanism
    /// </summary>
    /// <remarks>
    /// This is a market-wide resource capacity mechanism where all resource capacity required to ensure security of supply receives payment. These mechanisms are open for participation to all capacity resources contributing to adequacy.
    /// </remarks>
    A08 = 8,

    /// <summary>
    /// Strategic reserve resource capacity mechanism
    /// </summary>
    /// <remarks>
    /// This is a market resource capacity mechanism that is kept outside of the electricity market and only used if the market participants do not offer enough generation to meet short-term demand.
    /// </remarks>
    A09 = 9,

    /// <summary>
    /// Other resource capacity mechanism
    /// </summary>
    /// <remarks>
    /// This is any other kind of market resource capacity mechanism.
    /// </remarks>
    A10 = 10,

    /// <summary>
    /// Fast activation product
    /// </summary>
    /// <remarks>
    /// The fast activation product shall be considered as a fall-back solution for situations where coordination with all parties is no longer possible due to insufficient time and the regular product could not be properly applied.
    /// </remarks>
    A11 = 11,

    /// <summary>
    /// Remedial Action Cost Sharing Polluter Pays
    /// </summary>
    /// <remarks>
    /// Cost sharing of coordinated remedial action measures (redispatch and countertrading) under the polluter pays principle.
    /// </remarks>
    A12 = 12
}

