namespace BuilderDesignPattern;

public class ChickenPizzaBuilder: IPizzaBuilder
{
    private Pizza _pizza;
    private readonly int _weightByGram;

    private Dictionary<string, short> _mainMaterial = new Dictionary<string, short>
    {
        {"Chicken breast", 50},
        {"Mushrooms", 30},
        {"Pizza cheese", 30},
        {"Pizza dough", 1},
        {"onion", 10},
        {"Pepper", 6},
        {"Ketchup", 3},
        {"Thyme", 1}
    };

    public ChickenPizzaBuilder(int weightByGram)
    {
        this._pizza = new Pizza();
        this._weightByGram = weightByGram;
    }

    public void AddBakingTime()
    {
        this._pizza.BakingTime = new TimeOnly(0, 15);
    }

    public void AddMainMaterial()
    {
        foreach (var material in this._mainMaterial)
        {
            this._mainMaterial[material.Key] = (short)(this._weightByGram * material.Value / 100);
        }
        this._pizza.MainMaterial = this._mainMaterial;
    }

    public void AddTemperatures()
    {
        this._pizza.Temperature = 165;
    }

    public Pizza Build()
    {
        return this._pizza;
    }
}