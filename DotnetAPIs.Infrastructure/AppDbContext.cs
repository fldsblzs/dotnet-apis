using DotnetAPIs.Domain;
using Microsoft.EntityFrameworkCore;

namespace DotnetAPIs.Infrastructure;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<BoardGame> BoardGames { get; set; }
    public DbSet<Category> Categories { get; set; }
}