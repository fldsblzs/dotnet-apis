namespace DotnetAPIs.Domain;

public class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; }= null!;

    public Guid BoardGameId { get; set; }
    public BoardGame BoardGame { get; set; } = null!;
}