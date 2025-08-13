using Microsoft.EntityFrameworkCore;

namespace Product.Infrastructure.Configs;

public class ProductTypeConfig : IEntityTypeConfiguration<Product.Domain.Entity.ProductType>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product.Domain.Entity.ProductType> builder)
    {
        builder.ToTable($"T_{nameof(Product.Domain.Entity.ProductType)}");
    }
    
}