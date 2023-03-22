namespace IWantApp.Domain.Products;

public class Product : Enty
{
    public string Name { get; set; }

    public Category Category { get; set; }

    public string Description { get; set; }

    public bool HaasStock { get; set; }


}
