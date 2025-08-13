namespace Product.Domain.Entity;

public interface ICategoryRepository
{
    Task<List<Category>> FindAllCategoriesAsync();
}