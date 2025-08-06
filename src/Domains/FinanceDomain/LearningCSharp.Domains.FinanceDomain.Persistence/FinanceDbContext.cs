using Microsoft.EntityFrameworkCore;
using LearningCSharp.Domains.FinanceDomain.Persistence.Entities;

namespace LearningCSharp.Domains.FinanceDomain.Persistence;

/// <summary>
/// Database context for Finance domain
/// </summary>
public sealed class FinanceDbContext(
    DbContextOptions<FinanceDbContext> options)
    : DbContext(options)
{
    /// <summary>
    /// Bank accounts in the system
    /// </summary>
    public DbSet<BankAccountEntity> BankAccounts { get; set; } = null!;
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("finance");
        
    }
}
