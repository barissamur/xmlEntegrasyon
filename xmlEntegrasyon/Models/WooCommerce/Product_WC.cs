public class BatchProduct_WC
{
    public List<Product_WC> create { get; set; }
}
public class Product_WC
{
    public string name { get; set; }
    public string type { get; set; }
    public string description { get; set; }
    public string sku { get; set; }
    public string sale_price { get; set; }
    public string short_description { get; set; }
    public Category_WC[] categories { get; set; }
    public Image_WC[] images { get; set; }
    public Attribute_WC[] attributes { get; set; }
    public Default_Attributes_WC[] default_attributes { get; set; }
}

public class Category_WC
{
    public int id { get; set; }
    public string name { get; set; }
    public Image_WC image { get; set; }
}

public class Image_WC
{
    public string src { get; set; }
}

public class Attribute_WC
{
    public int id { get; set; }
    public int position { get; set; }
    public bool visible { get; set; }
    public bool variation { get; set; }
    public string[] options { get; set; }
    public string name { get; set; }
}

public class Default_Attributes_WC
{
    public int id { get; set; }
    public string option { get; set; }
    public string name { get; set; }
}
