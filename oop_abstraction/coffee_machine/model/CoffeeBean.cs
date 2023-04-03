public class CoffeeBean
{
    private string Name {   get; set;   }
    private double Quantity {   get;    set;    }

    public CoffeeBean(string name, double quantity)
    {
        this.Name = name;
        this.Quantity = quantity;
    }
}