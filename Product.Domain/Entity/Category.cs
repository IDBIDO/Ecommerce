namespace Product.Domain.Entity;

public class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public bool Visible { get; set; }
    public bool Deleted { get; set; }
    
    private Category()
    {
    }
    
    public Category(string name, string url, bool visible = true, bool deleted = false)
    {
        Id = Guid.NewGuid();
        Name = name;
        Url = url;
        Visible = visible;
        Deleted = deleted;
    }
    
    public void CategoryVisible()
    {
        if (Visible)
        {
            Console.WriteLine("Category is visible");
            return;
        }
        
        Visible = true;
    }
    
    public void CategoryHidden()
    {
        if (!Visible)
        {
            Console.WriteLine("Category is hidden");
            return;
        }
        
        Visible = false;
    }
    
    public void CategoryDeleted()
    {
        if (Deleted)
        {
            Console.WriteLine("Category is deleted");
            return;
        }
        
        this.Visible = false;
        this.Deleted = true;
    }
}