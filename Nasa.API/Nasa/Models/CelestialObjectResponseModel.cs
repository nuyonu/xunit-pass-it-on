using Nasa.Entities;

namespace Nasa.Models;

public class CelestialObjectResponseModel
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }

    public double Mass { get; set; }

    public double EquatorialDiameter { get; set; }

    public double SurfaceTemperature { get; set; }

    public DateTime DiscoveryDate { get; set; }

    public string Type { get; set; }
    
    public static CelestialObjectResponseModel FromCelestialObject(CelestialObject celestialObject)
    {
        return new CelestialObjectResponseModel
        {
            Id = celestialObject.Id,
            Name = celestialObject.Name,
            Mass = celestialObject.Mass,
            Type = celestialObject.Type.Name,
            DiscoveryDate = celestialObject.DiscoveryDate,
            EquatorialDiameter = celestialObject.EquatorialDiameter,
            SurfaceTemperature = celestialObject.SurfaceTemperature
        };
    }
}