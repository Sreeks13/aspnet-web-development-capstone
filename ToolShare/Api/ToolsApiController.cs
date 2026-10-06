using Microsoft.AspNetCore.Mvc;
using ToolShare.Models;

namespace ToolShare.Api;

[ApiController]
[Route("api/tools")]
public class ToolsApiController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(ToolRepository.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var tool = ToolRepository.Get(id);
        if (tool == null) return NotFound();

        return Ok(tool);
    }

    [HttpPost]
    public IActionResult Post(Tool tool)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        ToolRepository.Add(tool);

        return Created($"/api/tools/{tool.Id}", tool);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, Tool tool)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        tool.Id = id;

        if (!ToolRepository.Update(tool))
            return NotFound();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        if (!ToolRepository.Delete(id))
            return NotFound();

        return NoContent();
    }
}
