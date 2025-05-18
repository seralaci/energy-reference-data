// Based on ENTSO-E codelist 92 Release Date: 2025-01-13
// https://www.entsoe.eu/publications/electronic-data-interchange-edi-library/

namespace EnergyReferenceData;

/// <summary>
/// The identification of the coordinate system used for the location position.
/// </summary>
/// <remarks>
/// ET0108
/// </remarks>
public enum CoordinateSystemType
{
    /// <summary>
    /// ED50
    /// </summary>
    /// <remarks>
    /// ED 50 (European Datum 1950) is a geodetic datum which was defined after World War II for the international connection of geodetic networks.
    /// </remarks>
    A01,

    /// <summary>
    /// OSGB36
    /// </summary>
    /// <remarks>
    /// Ordinance Survey Great Britain 1936. The Ordinance Survey (OS) devised the national grid reference system, and it is heavily used in their survey data, and in maps (whether published by the Ordinance Survey or commercial map producers) based on those surveys.
    /// </remarks>
    A02,

    /// <summary>
    /// WGS84
    /// </summary>
    /// <remarks>
    /// The World Geodetic System version 1984. for use in cartography, geodesy, and navigation including by GPS. It comprises a standard coordinate system for the earth, a standard spheroidal reference surface (the datum or reference ellipsoid) for raw altitude data, and a gravitational equipotential surface (the geoid) that defines the nominal sea level.
    /// </remarks>
    A03,

    /// <summary>
    /// GTRF
    /// </summary>
    /// <remarks>
    /// Galileo Terrestrial Reference Frame
    /// </remarks>
    A04
}

