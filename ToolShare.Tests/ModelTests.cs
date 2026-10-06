using ToolShare.Models;

namespace ToolShare.Tests;

public class ModelTests
{
    [Fact]
    public void Tool_HasExpectedProperties()
    {
        var tool = new Tool
        {
            Id = 1,
            Name = "Drill",
            Category = "Power Tools",
            DailyRate = 100,
            IsAvailable = true
        };

        Assert.Equal("Drill", tool.Name);
        Assert.Equal("Power Tools", tool.Category);
        Assert.Equal(100, tool.DailyRate);
        Assert.True(tool.IsAvailable);
    }
}
