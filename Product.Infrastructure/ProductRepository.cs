using Microsoft.EntityFrameworkCore;
using Product.Domain;
using Product.Infrastructure.dbContext;

namespace Product.Infrastructure;

public class ProductRepository : IProductRepository
{
    private readonly ProductDbContext _dbContext;
    
    public ProductRepository(ProductDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<List<Domain.Entity.Product>> FindAllProductAsync()
    {
        return await _dbContext.Products.Include(p => p.Variants.Where(x => x.Deleted == false && x.Visible == true))
                                        .Where(x => x.Deleted == false && x.Visible == true)
                                        .ToListAsync();
    }

    public async Task<Domain.Entity.Product> FindProductByIdAsync(Guid productId)
    {
        var result = await _dbContext.Products.Include(x => x.Variants.Where(x => x.Deleted == false && x.Visible == true))
            .ThenInclude(x => x.ProductType)
            .SingleOrDefaultAsync(x => x.Id == productId && x.Deleted == false && x.Visible == true);

        return result;
    }

    public async Task<List<Domain.Entity.Product>> FindProductByCategoryAsync(string categoryUrl)
    {
        return await _dbContext.Products.Where(x =>
                x.Deleted == false && x.Visible == true && x.Category.Url.ToLower().Equals(categoryUrl.ToLower()))
            .Include(p => p.Variants.Where(v => v.Deleted == false && v.Visible == true))
            .ToListAsync();
    }

    public async Task<List<Domain.Entity.Product>> FindProductBySearchAsync(string searchText)
    {
        var result = await FindProductBySearchOnLinq(searchText);
        
        return result;
    }

    public async Task<List<string>> GetProductSearchSuggestionsAsync(string searchText)
    {
        var products = await FindProductBySearchOnLinq(searchText);
        List<string> result = new List<string>();

        foreach (var product in products)
        {
            if (product.Name.ToLower().Contains(searchText, StringComparison.OrdinalIgnoreCase))
            {
                result.Add(product.Name);
            }

            if (product.Description != null)
            {
                var punctuation = product.Description.Where(char.IsPunctuation).Distinct().ToArray();
                
                var words = product.Description.Split().Select(s => s.Trim(punctuation));

                foreach (var word in words)
                {
                    if (word.Contains(searchText, StringComparison.OrdinalIgnoreCase) && !result.Contains(word))
                    {
                        result.Add(word);
                    }
                }
                
            }
        }
        
        return result;
    }
    
    private async Task<List<Domain.Entity.Product>> FindProductBySearchOnLinq(string searchText)
    {
        return await _dbContext.Products.Where(x => x.Deleted == false && x.Visible == true &&
                (x.Name.ToLower().Contains(searchText.ToLower()) || x.Description.ToLower().Contains(searchText.ToLower())))
            .Include(p => p.Variants.Where(v => v.Deleted == false && v.Visible == true))
            .ToListAsync();
    }

    public Task<List<Domain.Entity.Product>> GetProductsByFeatureAsync()
    {
        var result = _dbContext.Products.Where(x => x.Deleted == false && x.Visible == true && x.Featured == true)
            .Include(p => p.Variants.Where(v => v.Deleted == false && v.Visible == true))
            .ToListAsync();

        return result;
    }
}