using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.SqlServer;

public class CarDbContext : DbContext
{
    public DbSet<Manufacturer> Manufacturers { get; set; }

    public CarDbContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(typeof(CarDbContext).Assembly);
        base.OnModelCreating(builder);
    }
}
