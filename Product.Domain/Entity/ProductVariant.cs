namespace Product.Domain.Entity;

public class ProductVariant
{
    public Guid Id { get; set; }
    
    public Product? Product { get; set; }
    
    public Guid ProductId { get; set; }
    
    public ProductType? ProductType { get; set; }
    
    public Guid ProductTypeId { get; set; }
    
    public decimal Price { get; set; }
    
    public decimal OriginalPrice { get; set; }
    
    public bool Visible { get; set; }
    
    public bool Deleted { get; set; }
    
    private ProductVariant() { }
    
    public ProductVariant(
        Guid productId,
        Guid productTypeId,
        decimal price,
        decimal originalPrice,
        bool visible = true,
        bool deleted = false)
    {
        Id = Guid.NewGuid();
        ProductId = productId;
        ProductTypeId = productTypeId;
        Price = price;
        OriginalPrice = originalPrice;
        Visible = visible;
        Deleted = deleted;
    }
    
    public void UpdateType(ProductType productType)
    {
        if (productType == null)
        {
            throw new ArgumentNullException(nameof(productType), "Product type cannot be null");
        }
        
        ProductType = productType;
    }
    
    public void ProductVisible()
    {
        if (Visible)
        {
            Console.WriteLine("Product variant is visible");
            return;
        }
        
        Visible = true;
    }
    
    public void ProductHidden()
    {
        if (!Visible)
        {
            Console.WriteLine("Product variant is hidden");
            return;
        }
        
        Visible = false;
    }
    
    public void ProductDeleted()
    {
        if (Deleted)
        {
            Console.WriteLine("Product variant is deleted");
            return;
        }
        
        Visible = false;
        Deleted = true;
    }
}