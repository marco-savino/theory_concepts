
Dictionary<CoffeeSelection, CoffeeBean> beans = new Dictionary<CoffeeSelection, CoffeeBean>();

// per ogni categoria di caffè aggiungi ai chicchi disponibili le varianti "toasted" e "raw", quantità 50 ml
foreach(CoffeeSelection coffeeSelection in (CoffeeSelection[]) Enum.GetValues(typeof(CoffeeSelection)))
{
    beans.Add(coffeeSelection, new CoffeeBean("Toasted", 50));
    //beans.Add(coffeeSelection, new CoffeeBean("Raw", 50)); // the dictionary was not the better data structure choice...
}

CoffeeMachine coffeeMachine = new CoffeeMachine(beans);

Coffee coffee = coffeeMachine.BrewCoffee(CoffeeSelection.ESPRESSO);

Console.WriteLine("Coffee is ready! Here's your cup: selection {0}, quantity {1}", coffee.Selection, coffee.Quantity);
