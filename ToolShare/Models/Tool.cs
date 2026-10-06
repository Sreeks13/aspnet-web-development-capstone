using System.ComponentModel.DataAnnotations;

namespace ToolShare.Models;

public class Tool
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = "";

    [Required]
    [StringLength(100)]
    public string Category { get; set; } = "";

    [Range(0, 100000)]
    public decimal DailyRate { get; set; }

    public bool IsAvailable { get; set; }
}
