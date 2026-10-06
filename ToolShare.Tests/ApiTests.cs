using Microsoft.AspNetCore.Mvc;
using ToolShare.Api;
using ToolShare.Models;

namespace ToolShare.Tests;

public class ApiTests
{
    [Fact]
    public void Get_ReturnsOk()
    {
        var controller = new ToolsApiController();

        var result = controller.Get();

        Assert.IsType<OkObjectResult>(result);
    }

    [Fact]
    public void Post_ValidTool_ReturnsCreated()
    {
        var controller = new ToolsApiController();

        var result = controller.Post(new Tool
        {
            Name = "Saw",
            Category = "Power Tools",
            DailyRate = 100,
            IsAvailable = true
        });

        Assert.IsType<CreatedResult>(result);
    }
}
