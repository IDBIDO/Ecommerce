using Microsoft.EntityFrameworkCore;

namespace Product.Infrastructure.Configs;

public class CategoryConfig : IEntityTypeConfiguration<Product.Domain.Entity.Category>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product.Domain.Entity.Category> builder)
    {
        builder.ToTable($"T_{nameof(Product.Domain.Entity.Category)}");
    }
}
