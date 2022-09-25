using Nasa.Entities;

namespace Nasa.Models;

public class CelestialObjectModel
{
    public string Name { get; set; }

    public double Mass { get; set; }

    public double EquatorialDiameter { get; set; }

    public double SurfaceTemperature { get; set; }

    public DateTime DiscoveryDate { get; set; }

    public CelestialObject ToCelestialObject()
    {
        return new CelestialObject(this.Name, this.Mass, this.EquatorialDiameter, this.SurfaceTemperature, this.DiscoveryDate);
    }
}