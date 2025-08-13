namespace Product.Domain;

public interface IProductRepository
{
    Task<List<Entity.Product>> FindAllProductAsync();
    Task<Entity.Product> FindProductByIdAsync(Guid id);
    Task<List<Entity.Product>> FindProductByCategoryAsync(string categoryUrl);
     
    Task<List<Entity.Product>> FindProductBySearchAsync(string searchText);
    
    Task<List<string>> GetProductSearchSuggestionsAsync(string searchText);
    
    Task<List<Entity.Product>> GetProductsByFeatureAsync();
}