using Microsoft.EntityFrameworkCore;
using Product.Domain.Entity;
using Product.Infrastructure.Configs;

namespace Product.Infrastructure.dbContext;

public class ProductDbContext : DbContext
{
    public DbSet<Domain.Entity.Product> Products { get; set; }
    
    public DbSet<Domain.Entity.ProductType> ProductTypes { get; set; }
    
    public DbSet<Domain.Entity.Category> Categories { get; set; }
    
    public DbSet<ProductVariant> ProductVariants { get; set; }
    
    public ProductDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
    }
}