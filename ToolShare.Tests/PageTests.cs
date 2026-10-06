using Microsoft.AspNetCore.Mvc;
using ToolShare.Controllers;

namespace ToolShare.Tests;

public class PageTests
{
    [Fact]
    public void Index_ReturnsView()
    {
        var controller = new ToolsController();

        var result = controller.Index();

        Assert.IsType<ViewResult>(result);
    }
}
