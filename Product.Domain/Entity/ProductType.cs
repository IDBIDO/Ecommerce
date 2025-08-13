namespace Product.Domain.Entity;

public class ProductType
{
    public Guid Id {get; set; }
    public string Name { get; set; }    // Basic, Premium, etc.

    public ProductType()
    {
    }

    public ProductType(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
    }
}