public class CoffeeMachine
{
    private Dictionary<CoffeeSelection, CoffeeBean> Beans   {   get;    set;    }

    public CoffeeMachine(Dictionary<CoffeeSelection, CoffeeBean> beans)
    {
        this.Beans = beans;
    }

    public Coffee BrewCoffee(CoffeeSelection coffeeSelection)
    {
        return new Coffee(coffeeSelection, 30);
    }
}