using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Product.Infrastructure.dbContext
{
    public class ProductDbContextFactory : IDesignTimeDbContextFactory<ProductDbContext>
    {
        public ProductDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProductDbContext>();
            optionsBuilder.UseNpgsql("Host=127.0.0.1;Database=myShop;Username=postgres;Password=saPWD%");

            return new ProductDbContext(optionsBuilder.Options);
        }
    }
}