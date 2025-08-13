using Microsoft.EntityFrameworkCore;

namespace Product.Infrastructure.Configs;

public class ProductVariantConfig : IEntityTypeConfiguration<Product.Domain.Entity.ProductVariant>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product.Domain.Entity.ProductVariant> builder)
    {
        builder.ToTable($"T_{nameof(Product.Domain.Entity.ProductVariant)}");
        
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Price).HasColumnType("decimal(18,2)");
            
        builder.Property(x => x.OriginalPrice).HasColumnType("decimal(18,2)");
    }
}