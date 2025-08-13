using Product.Domain.Entity;

namespace Product.Domain;

public interface IProductTypeRepository
{
    Task<List<ProductType>> FindAllProductTypesAsync();
    Task<List<ProductType>> GetProductTypeByProductId(Guid productId);
}