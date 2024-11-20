using Microsoft.AspNetCore.Mvc;
using FightMemory.Domain.Entities;

[ApiController]
[Route("api/[controller]")]
public class TechniqueController : ControllerBase
{
    [HttpGet]
    public IActionResult GetTechniques()
    {
        var techniques = new List<Technique>
        {
            new Technique { Id = 1, Name = "Single-Leg Takedown", Steps = new List<string> { "Step 1", "Step 2" } }
        };
        return Ok(techniques);
    }
}
