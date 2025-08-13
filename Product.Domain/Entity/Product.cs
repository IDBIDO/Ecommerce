namespace Product.Domain.Entity;

public class Product : IAggregateRoot
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    
    public Category? Category { get; set; }
    public Guid CategoryId { get; set; }
    
    public List<ProductVariant> Variants { get; set; }
    
    public bool Featured { get; set; }
    
    public bool Visible { get; set; }
    public bool Deleted { get; set; }

    private Product()
    {
        
    }
    
    public Product(
        string title,
        string description,
        string imageUrl,
        Guid categoryId,
        List<ProductVariant> variants,
        bool featured = false,
        bool visible = true,
        bool deleted = false)
    {
        Id = Guid.NewGuid();
        Name = title;
        Description = description;
        ImageUrl = imageUrl;
        CategoryId = categoryId;
        Variants = variants;
        Featured = featured;
        Visible = visible;
        Deleted = false;
    }

    public void ActiveFeatured()
    {
        if (Featured)
        {
            Console.WriteLine("Featured Product");
            return;
        }
        
        this.Featured = true;
    }

    public void DrawbackFeatured()
    {
        if (!Featured)
        {
            Console.WriteLine("Not Featured Product");
            return;
        }
        
        this.Featured = false;
    }

    public void AddVariant(ProductVariant variant)
    {
        if (this.Variants.Contains(variant))
        {
            Console.WriteLine("Variant already added");
            return;
        }
        this.Variants.Add(variant);
    }
    
    public void RemoveVariant(ProductVariant variant)
    {
        if (!this.Variants.Contains(variant))
        {
            Console.WriteLine("Variant not found");
            return;
        }
        this.Variants.Remove(variant);
    }
    
    public void ProductVisible()
    {
        if (Visible)
        {
            Console.WriteLine("Product is visible");
            return;
        }
        
        this.Visible = true;
    }
    
    public void ProductInvisible()
    {
        if (!Visible)
        {
            Console.WriteLine("Product is not visible");
            return;
        }
        
        this.Visible = false;
    }
    
    public void ProductDeleted()
    {
        if (Deleted)
        {
            Console.WriteLine("Product is deleted");
            return;
        }
        this.Visible = false;
        this.Deleted = true;
    }
    
    
    
}