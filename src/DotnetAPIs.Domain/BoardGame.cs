namespace DotnetAPIs.Domain;

public class BoardGame
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public string? BggLink { get; set; }
    public int Players { get; set; }
    public float Weight { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }

    public List<Category> Categories { get; set; } = [];
}