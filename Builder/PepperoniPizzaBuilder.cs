namespace BuilderDesignPattern;

public class PepperoniPizzaBuilder : IPizzaBuilder
{
    private Pizza _pizza;
    private readonly int _weightByGram;

    private Dictionary<string, short> _mainMaterial = new Dictionary<string, short>
    {
        {"Pepperoni sausage", 50},
        {"Pizza cheese", 30},
        {"tomato", 10},
        {"Pepper", 6},
        {"Ketchup", 3},
        {"Thyme", 1}
    };

    public PepperoniPizzaBuilder(int weightByGram)
    {
        this._pizza = new Pizza();
        this._weightByGram = weightByGram;
    }

    public void AddBakingTime()
    {
        this._pizza.BakingTime = new TimeOnly(0, 20);
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
        this._pizza.Temperature = 150;
    }

    public Pizza Build()
    {
        return this._pizza;
    }
}