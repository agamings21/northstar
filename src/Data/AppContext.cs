using Microsoft.EntityFrameworkCore;

namespace Northstar.Data;

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
}

// Data/AppDbContext.cs

public class AppDbContext : DbContext
{
    public DbSet<Item> Items { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}   