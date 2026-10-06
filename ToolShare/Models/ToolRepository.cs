namespace ToolShare.Models;

public static class ToolRepository
{
    private static readonly List<Tool> tools =
    [
        new Tool { Id = 1, Name = "Drill", Category = "Power Tools", DailyRate = 250, IsAvailable = true },
        new Tool { Id = 2, Name = "Ladder", Category = "Equipment", DailyRate = 150, IsAvailable = true },
        new Tool { Id = 3, Name = "Hammer", Category = "Hand Tools", DailyRate = 75, IsAvailable = false }
    ];

    public static List<Tool> GetAll() => tools;

    public static Tool? Get(int id) =>
        tools.FirstOrDefault(t => t.Id == id);

    public static void Add(Tool tool)
    {
        tool.Id = tools.Count == 0 ? 1 : tools.Max(t => t.Id) + 1;
        tools.Add(tool);
    }

    public static bool Update(Tool tool)
    {
        var existing = Get(tool.Id);
        if (existing == null) return false;

        existing.Name = tool.Name;
        existing.Category = tool.Category;
        existing.DailyRate = tool.DailyRate;
        existing.IsAvailable = tool.IsAvailable;

        return true;
    }

    public static bool Delete(int id)
    {
        var tool = Get(id);
        if (tool == null) return false;

        tools.Remove(tool);
        return true;
    }
}
