public class Coffee
{
    public CoffeeSelection Selection {   get; private set;   }
    public double Quantity {   get;    private set;    }

    public Coffee(CoffeeSelection coffeeSelection, double quantity)
    {
        this.Selection = coffeeSelection;
        this.Quantity = quantity;
    }
}