using Microsoft.EntityFrameworkCore;
using LearningCSharp.Domains.LogisticsDomain.Persistence.Entities;

namespace LearningCSharp.Domains.LogisticsDomain.Persistence;

public sealed class LogisticsDbContext(
    DbContextOptions<LogisticsDbContext> options)
    : DbContext(options)
{
    public DbSet<CarrierEntity> Carriers { get; set; } = null!;
    
    public DbSet<ShipmentEntity> Shipments { get; set; } = null!;
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("logistics");
        
    }
}
