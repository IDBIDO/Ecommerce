using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Product.Domain.Entity;

namespace Product.Infrastructure.Configs;

public class ProductConfig : IEntityTypeConfiguration<Product.Domain.Entity.Product>
{
    public void Configure(EntityTypeBuilder<Product.Domain.Entity.Product> builder)
    {
        builder.ToTable($"T_{nameof(Product.Domain.Entity.Product)}");
        
        /*
            EF Core: “Okay, starting with Product… what do you have many of?”
            You: “Variants.” (x => x.Variants)
            EF Core: “Cool, now let’s look from Variant’s perspective… who do you belong to?”
            You: “A single Product.” (x => x.Product)
            EF Core: “Got it. Which property holds that link?”
            You: “ProductId.” (x => x.ProductId)
         */
        builder.HasMany(x => x.Variants)
            .WithOne(x => x.Product)
            .HasForeignKey(x => x.ProductId);
    }
}