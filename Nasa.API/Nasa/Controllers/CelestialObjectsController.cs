using Microsoft.AspNetCore.Mvc;
using Nasa.Models;

namespace Nasa.Controllers;

[ApiController]
[Route("[controller]")]
public class CelestialObjectsController : ControllerBase
{
    private readonly ILogger<CelestialObjectsController> logger;

    public CelestialObjectsController(ILogger<CelestialObjectsController> logger)
    {
        this.logger = logger;
    }

    [HttpGet]
    public IActionResult ReadAllCelestialObjects()
    {
        return Ok(Storage.CelestialObjects.Select(CelestialObjectResponseModel.FromCelestialObject));
    }

    [HttpPost]
    public IActionResult CreateCelestialObject(CelestialObjectModel celestialObjectModel)
    {
        var celestialObject = celestialObjectModel.ToCelestialObject();
        
        Storage.CelestialObjects.Add(celestialObject);

        return Ok(CelestialObjectResponseModel.FromCelestialObject(celestialObject));
    }
}