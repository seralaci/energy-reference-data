// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// The identification of the type of asset.
/// </summary>
/// <remarks>
/// ET0031
/// </remarks>
public enum AssetType
{
    /// <summary>
    /// Tie line
    /// </summary>
    /// <remarks>
    /// A high voltage line used for cross border energy interconnections.
    /// </remarks>
    A01,

    /// <summary>
    /// Line
    /// </summary>
    /// <remarks>
    /// A specific electric line within a country.
    /// </remarks>
    A02,

    /// <summary>
    /// Resource Object
    /// </summary>
    /// <remarks>
    /// A resource that can either produce or consume energy.
    /// </remarks>
    A03,

    /// <summary>
    /// Generation
    /// </summary>
    /// <remarks>
    /// A resource that can produce energy.
    /// </remarks>
    A04,

    /// <summary>
    /// Load
    /// </summary>
    /// <remarks>
    /// A resource that can consume energy.
    /// </remarks>
    A05,

    /// <summary>
    /// Phase Shift Transformer
    /// </summary>
    /// <remarks>
    /// An electrical device for controlling the power flow through specific lines in a power transmission network.
    /// </remarks>
    A06,

    /// <summary>
    /// Circuit Breaker
    /// </summary>
    /// <remarks>
    /// An electrical switch designed to protect an electrical circuit from damage caused by overcurrent/overload or short circuit.
    /// </remarks>
    A07,

    /// <summary>
    /// Busbar
    /// </summary>
    /// <remarks>
    /// A specific element within a substation to connect grid elements for energy distribution purposes.
    /// </remarks>
    A08,

    /// <summary>
    /// Capacitor
    /// </summary>
    /// <remarks>
    /// A transmission element designed to inject reactive power into the transmission network. 
    /// </remarks>
    A09,

    /// <summary>
    /// Inductor
    /// </summary>
    /// <remarks>
    /// A transmission element designed to compensate reactive power in the transmission network.
    /// </remarks>
    A10,

    /// <summary>
    /// Power plant connection
    /// </summary>
    /// <remarks>
    /// All the network equipment that link the generating unit to the grid.
    /// </remarks>
    A11,

    /// <summary>
    /// FACTS
    /// </summary>
    /// <remarks>
    /// Flexible Alternating Current Transmission System
    /// </remarks>
    A12,

    /// <summary>
    /// Production unit
    /// </summary>
    /// <remarks>
    /// A production unit is a composition of one or several generation units.
    /// </remarks>
    A13,

    /// <summary>
    /// Internal tie line
    /// </summary>
    /// <remarks>
    /// An internal tie line is a line between two scheduling areas within the same bidding zone.
    /// </remarks>
    A14,

    /// <summary>
    /// Biomass
    /// </summary>
    /// <remarks>
    /// A resource using biomass for energy.
    /// </remarks>
    B01,

    /// <summary>
    /// Fossil Brown coal/Lignite
    /// </summary>
    /// <remarks>
    /// A resource using Fossil Brown coal/Lignite for energy.
    /// </remarks>
    B02,

    /// <summary>
    /// Fossil Coal-derived gas
    /// </summary>
    /// <remarks>
    /// A resource using Fossil Coal-derived gas for energy.
    /// </remarks>
    B03,

    /// <summary>
    /// Fossil Gas
    /// </summary>
    /// <remarks>
    /// A resource using Fossil Gas for energy.
    /// </remarks>
    B04,

    /// <summary>
    /// Fossil Hard coal
    /// </summary>
    /// <remarks>
    /// A resource using Fossil Hard coal for energy.
    /// </remarks>
    B05,

    /// <summary>
    /// Fossil Oil
    /// </summary>
    /// <remarks>
    /// A resource using Fossil Oil for energy.
    /// </remarks>
    B06,

    /// <summary>
    /// Fossil Oil shale
    /// </summary>
    /// <remarks>
    /// A resource using Fossil Oil shale for energy.
    /// </remarks>
    B07,

    /// <summary>
    /// Fossil Peat
    /// </summary>
    /// <remarks>
    /// A resource using Fossil Peat for energy.
    /// </remarks>
    B08,

    /// <summary>
    /// Geothermal
    /// </summary>
    /// <remarks>
    /// A resource using Geothermal for energy.
    /// </remarks>
    B09,

    /// <summary>
    /// Hydro-electric pure pumped storage head installation
    /// </summary>
    /// <remarks>
    /// Unit in which moving water energy is converted to electricity using flowing water to generate electricity with a large dam and reservoirs. Pure pumped storage plants store water in an upper reservoir with no natural inflows.
    /// </remarks>
    B10,

    /// <summary>
    /// Hydro Run-of-river head installation
    /// </summary>
    /// <remarks>
    /// Unit in which moving water energy is converted to electricity using flowing water to generate electricity in the absence of a large dam and reservoirs.
    /// </remarks>
    B11,

    /// <summary>
    /// Hydro-electric storage head installation
    /// </summary>
    /// <remarks>
    /// Unit in which moving water energy is converted to electricity using flowing water to generate electricity with a large dam and reservoirs.
    /// </remarks>
    B12,

    /// <summary>
    /// Marine unspecified
    /// </summary>
    /// <remarks>
    /// Unit in which marine energy is converted to electricity with equipment/devices not specified.
    /// </remarks>
    B13,

    /// <summary>
    /// Nuclear unspecified
    /// </summary>
    /// <remarks>
    /// A unit in which the heat source is a nuclear reactor of type that is not specified in other nuclear types. 
    /// </remarks>
    B14,

    /// <summary>
    /// Other renewable
    /// </summary>
    /// <remarks>
    /// A resource using Other renewable for energy.
    /// </remarks>
    B15,

    /// <summary>
    /// Solar unspecified
    /// </summary>
    /// <remarks>
    /// Unit in which solar energy is converted to electricity with equipment/devices not specified.
    /// </remarks>
    B16,

    /// <summary>
    /// Waste
    /// </summary>
    /// <remarks>
    /// A resource using Waste for energy.
    /// </remarks>
    B17,

    /// <summary>
    /// Wind Offshore
    /// </summary>
    /// <remarks>
    /// Unit in which wind energy is converted to electricity using wind farms constructed in bodies of water, usually in the ocean.
    /// </remarks>
    B18,

    /// <summary>
    /// Wind Onshore
    /// </summary>
    /// <remarks>
    /// Unit in which wind energy is converted to electricity using wind farms constructed on land.
    /// </remarks>
    B19,

    /// <summary>
    /// Other unspecified
    /// </summary>
    /// <remarks>
    /// Other unspecified technology.
    /// </remarks>
    B20,

    /// <summary>
    /// AC Link
    /// </summary>
    /// <remarks>
    /// Overhead line or cable which is used to transmit electrical power via Alternative Current.
    /// </remarks>
    B21,

    /// <summary>
    /// DC Link
    /// </summary>
    /// <remarks>
    /// Overhead line or cable which is used to transmit electrical power via Direct Current.
    /// </remarks>
    B22,

    /// <summary>
    /// Substation
    /// </summary>
    /// <remarks>
    /// An assembly of equipment in an electric power system through which electric energy is passed for transmission, transformation, distribution or switching.
    /// </remarks>
    B23,

    /// <summary>
    /// Transformer
    /// </summary>
    /// <remarks>
    /// Electrical device that transfers energy from one voltage level to another voltage level.
    /// </remarks>
    B24,

    /// <summary>
    /// Energy storage
    /// </summary>
    /// <remarks>
    /// A resource that stores energy. It could be gas, electricity, etc.
    /// </remarks>
    B25,

    /// <summary>
    /// Demand Side Response
    /// </summary>
    /// <remarks>
    /// A resource that change its electricity consumption patterns in response to a signal or incentive.
    /// </remarks>
    B26,

    /// <summary>
    /// Dispatchable hydro resource
    /// </summary>
    /// <remarks>
    /// A resource referring to dispatchable hydro generation.
    /// </remarks>
    B27,

    /// <summary>
    /// Solar photovoltaic
    /// </summary>
    /// <remarks>
    /// Unit in which solar energy is converted to electricity using a technology based on the photoelectric effect.
    /// </remarks>
    B28,

    /// <summary>
    /// Solar concentration
    /// </summary>
    /// <remarks>
    /// Unit in which solar energy is converted to electricity using mirrors to concentrate the sun's energy to drive traditional steam turbines or engines.
    /// </remarks>
    B29,

    /// <summary>
    /// Wind unspecified
    /// </summary>
    /// <remarks>
    /// Unit in which wind energy is converted to electricity with equipment/devices not specified.
    /// </remarks>
    B30,

    /// <summary>
    /// Hydro-electric unspecified
    /// </summary>
    /// <remarks>
    /// Unit in which moving water energy is converted to electricity with equipment/devices not specified. 
    /// </remarks>
    B31,

    /// <summary>
    /// Hydro-electric mixed pumped storage head installation
    /// </summary>
    /// <remarks>
    /// Unit in which moving water energy is converted to electricity using flowing water to generate electricity with a large dam and reservoirs. Mixed pumped storage plants use a combination of pumped storage and conventional hydroelectric plants with an upper reservoir that is replenished in part by natural inflows from a stream or river.
    /// </remarks>
    B32,

    /// <summary>
    /// Marine tidal
    /// </summary>
    /// <remarks>
    /// Unit in which marine energy from tides is converted to electricity.
    /// </remarks>
    B33,

    /// <summary>
    /// Marine wave
    /// </summary>
    /// <remarks>
    /// Unit in which marine energy from waves is converted to electricity.
    /// </remarks>
    B34,

    /// <summary>
    /// Marine currents
    /// </summary>
    /// <remarks>
    /// Unit in which marine energy from currents is converted to electricity.
    /// </remarks>
    B35,

    /// <summary>
    /// Marine pressure
    /// </summary>
    /// <remarks>
    /// Unit in which marine energy from pressure is converted to electricity.
    /// </remarks>
    B36,

    /// <summary>
    /// Thermal unspecified
    /// </summary>
    /// <remarks>
    /// Unit in which heat energy is converted to electricity with equipment/devices not specified in other thermal types.
    /// </remarks>
    B37,

    /// <summary>
    /// Thermal combined cycle gas turbine with heat recovery
    /// </summary>
    /// <remarks>
    /// Unit in which heat energy is converted to electricity called Combined Cycle Gas Turbine. The power is generated by the single or multiple gas turbine(s) in combination with the steam turbine(s). The unit might be equipped with waste heat recovery (e.g. to district heating network).
    /// </remarks>
    B38,

    /// <summary>
    /// Thermal steam turbine with back-pressure turbine (open cycle)
    /// </summary>
    /// <remarks>
    /// Unit in which heat energy is converted to electricity. The power is generated with the steam that is expanded in the back-pressure steam turbine with or without heat output (e.g. to district heating network).
    /// </remarks>
    B39,

    /// <summary>
    /// Thermal steam turbine with condensation turbine (closed cycle)
    /// </summary>
    /// <remarks>
    /// Unit in which heat energy is converted to electricity. The power is generated with the steam that is expanded in the condensation steam turbine with or without heat output (e.g. to district heating network).
    /// </remarks>
    B40,

    /// <summary>
    /// Thermal gas turbine with heat recovery
    /// </summary>
    /// <remarks>
    /// Unit in which heat energy is converted to electricity called Simple Cycle Gas Turbine. The power is generated by the gas turbine and the flue gas waste heat is recovered (e.g. to district heating network).
    /// </remarks>
    B41,

    /// <summary>
    /// Thermal internal combustion engine
    /// </summary>
    /// <remarks>
    /// An internal combustion engine is a heat engine in which the combustion of a fuel occurs with an oxidizer (usually air) in a combustion chamber that is an integral part of the working fluid flow circuit (e.g. reciprocating engine). The unit might be equipped with waste heat recovery (e.g. to district heating network).
    /// </remarks>
    B42,

    /// <summary>
    /// Thermal micro-turbine
    /// </summary>
    /// <remarks>
    /// Unit in which heat energy is converted to electricity called Simple Cycle Gas Turbine. The power is generated by the gas turbine (capacity less than 500kWe). The unit might be equipped with waste heat recovery (e.g. to district heating network).
    /// </remarks>
    B43,

    /// <summary>
    /// Thermal Stirling engine
    /// </summary>
    /// <remarks>
    /// A Stirling engine is a heat engine that is operated by the cyclic compression and expansion of air or other gas (the working fluid) at different temperatures, resulting in a net conversion of heat energy to mechanical work.
    /// </remarks>
    B44,

    /// <summary>
    /// Thermal fuel cell
    /// </summary>
    /// <remarks>
    /// A fuel cell is an electrochemical cell that converts the chemical energy of a fuel (e.g. hydrogen) and an oxidizing agent (e.g. oxygen) into electricity through a pair of redox reactions.
    /// </remarks>
    B45,

    /// <summary>
    /// Thermal steam engine
    /// </summary>
    /// <remarks>
    /// A steam engine is a heat engine that performs mechanical work using steam as its working fluid. The steam engine uses the force produced by steam pressure to push a piston back and forth inside a cylinder.
    /// </remarks>
    B46,

    /// <summary>
    /// Thermal organic Rankine cycle
    /// </summary>
    /// <remarks>
    /// The Organic Rankine Cycle (ORC) is named for its use of an organic, high molecular mass fluid with a liquid-vapor phase change, or boiling point, occurring at a lower temperature than the water-steam phase change. The fluid allows Rankine cycle heat recovery from lower temperature sources such as biomass combustion, industrial waste heat, geothermal heat, solar ponds etc. The low-temperature heat is converted into useful work, that can itself be converted into electricity.
    /// </remarks>
    B47,

    /// <summary>
    /// Thermal gas turbine without heat recovery
    /// </summary>
    /// <remarks>
    /// Unit in which heat energy is converted to electricity called Simple Cycle Gas Turbine. The power is generated by the gas turbine and there is no flue gas waste heat recovery.
    /// </remarks>
    B48,

    /// <summary>
    /// Nuclear heavy water reactor
    /// </summary>
    /// <remarks>
    /// A unit in which the heat source is a pressurized heavy-water reactor (PHWR) that is a nuclear reactor that uses heavy water (deuterium oxide D2O) as its coolant and neutron moderator.
    /// </remarks>
    B49,

    /// <summary>
    /// Nuclear light water reactor
    /// </summary>
    /// <remarks>
    /// A unit in which the heat source is a light-water reactor (LWR) that is a type of thermal-neutron reactor that uses normal water, as both its coolant and neutron moderator � furthermore a solid form of fissile elements is used as fuel. 
    /// </remarks>
    B50,

    /// <summary>
    /// Nuclear breeder
    /// </summary>
    /// <remarks>
    /// A unit in which the heat source is a nuclear reactor that generates more fissile material than it consumes.
    /// </remarks>
    B51,

    /// <summary>
    /// Nuclear graphite reactor
    /// </summary>
    /// <remarks>
    /// A unit in which the heat source is a graphite-moderated reactor that is a nuclear reactor that uses carbon as a neutron moderator, which allows natural uranium to be used as nuclear fuel.
    /// </remarks>
    B52,

    /// <summary>
    /// Temporary energy storage
    /// </summary>
    /// <remarks>
    /// A resource that is temporarily connected to the grid and that may store energy when connected, such as an electric vehicle.
    /// </remarks>
    B53,

    /// <summary>
    /// Permanent energy storage
    /// </summary>
    /// <remarks>
    /// A resource that is permanently connected to the grid and that may store energy when connected, such as a pumped hydro.
    /// </remarks>
    B54,

    /// <summary>
    /// Electric vehicle battery
    /// </summary>
    /// <remarks>
    /// A resource using electric vehicle batteries, commercial and private. The reason for separating vehicle batteries and non-vehicle batteries is that the vehicle batteries not necessarily is connected to the charger.
    /// </remarks>
    B55,

    /// <summary>
    /// Heat pump specified
    /// </summary>
    /// <remarks>
    /// A heat pump is a device that uses work to transfer heat from a cool space to a warm space by transferring thermal energy using a refrigeration cycle
    /// </remarks>
    B56,

    /// <summary>
    /// Heat pump electrical
    /// </summary>
    /// <remarks>
    /// A heat pump is a device that uses electricity to transfer heat from a cool space to a warm space by transferring thermal energy using a refrigeration cycle.
    /// </remarks>
    B57,

    /// <summary>
    /// Heat pump absorption
    /// </summary>
    /// <remarks>
    /// A heat pump is a device that uses absorption technology to transfer heat from a cool space to a warm space by transferring thermal energy using a refrigeration cycle.
    /// </remarks>
    B58,

    /// <summary>
    /// Auxiliary power unit
    /// </summary>
    /// <remarks>
    /// A technology that provides energy as a backup.
    /// </remarks>
    B59,

    /// <summary>
    /// Water electrolysis unspecified
    /// </summary>
    /// <remarks>
    /// Unspecified water electrolysis. 
    /// </remarks>
    B60,

    /// <summary>
    /// Water electrolysis low temperature unspecified
    /// </summary>
    /// <remarks>
    /// Unspecified water electrolysis at low temperature as in an Alkaline or Proto-Exchange Membrane (PEM) fuel cell.
    /// </remarks>
    B61,

    /// <summary>
    /// Water electrolysis low temperature main product
    /// </summary>
    /// <remarks>
    /// Main product water electrolysis at low temperature as in an Alkaline or Proto-Exchange Membrane (PEM) fuel cell.
    /// </remarks>
    B62,

    /// <summary>
    /// Water electrolysis high temperature unspecified
    /// </summary>
    /// <remarks>
    /// Unspecified water electrolysis at high temperature as in a Solid Oxide Electrolysis Cell (SOEC) fuel cell.
    /// </remarks>
    B63,

    /// <summary>
    /// Steam methane reforming unspecified
    /// </summary>
    /// <remarks>
    /// Unspecified methane reforming.
    /// </remarks>
    B64,

    /// <summary>
    /// Steam methane reforming without CCS/CCU  unspecified
    /// </summary>
    /// <remarks>
    /// Main product methane reforming without Carbon Capture and Sequestration (CCS)/Carbon Capture and Use (CCU).  
    /// </remarks>
    B65,

    /// <summary>
    /// Steam methane reforming with CCS/CCU  unspecified
    /// </summary>
    /// <remarks>
    /// Unspecified methane reforming with Carbon Capture and Sequestration (CCS)/Carbon Capture and Use (CCU).    
    /// </remarks>
    B66,

    /// <summary>
    /// Steam methane reforming with CCS/CCU  main product
    /// </summary>
    /// <remarks>
    /// Main product methane reforming with Carbon Capture and Sequestration (CCS)/Carbon Capture and Use (CCU).    
    /// </remarks>
    B67,

    /// <summary>
    /// Partial oxidation unspecified
    /// </summary>
    /// <remarks>
    /// Unspecified partial oxidation.
    /// </remarks>
    B68,

    /// <summary>
    /// Autothermal reforming unspecified
    /// </summary>
    /// <remarks>
    /// Unspecified autothermal reforming.
    /// </remarks>
    B69,

    /// <summary>
    /// Methanol reforming unspecified
    /// </summary>
    /// <remarks>
    /// Unspecified methanol reforming.
    /// </remarks>
    B70,

    /// <summary>
    /// Ammonia reforming unspecified
    /// </summary>
    /// <remarks>
    /// Unspecified ammonia reforming.
    /// </remarks>
    B71,

    /// <summary>
    /// Ammonia gasification
    /// </summary>
    /// <remarks>
    /// Unspecified gasification.
    /// </remarks>
    B72,

    /// <summary>
    /// Chlor-alkali electrolysis unspecified
    /// </summary>
    /// <remarks>
    /// Unspecified alkali electrolysis.
    /// </remarks>
    B73,

    /// <summary>
    /// Chlor-alkali electrolysis by-product
    /// </summary>
    /// <remarks>
    /// Alkali electrolysis product.
    /// </remarks>
    B74,

    /// <summary>
    /// ACDC converter
    /// </summary>
    /// <remarks>
    /// ACDC converters are electrical circuits that transform alternating current (AC) into direct current (DC) and vice versa.
    /// </remarks>
    B75,

    /// <summary>
    /// Converter
    /// </summary>
    /// <remarks>
    /// Electrical device that converts current between AC and DC.
    /// </remarks>
    B76
}

