namespace BuilderDesignPattern;

public class Bake
{
    private readonly IPizzaBuilder _pizzaBuilder;

    public Bake(IPizzaBuilder pizzaBuilder)
    {
        this._pizzaBuilder = pizzaBuilder;
    }

    public Pizza Build()
    {
        this._pizzaBuilder.AddMainMaterial();
        this._pizzaBuilder.AddBakingTime();
        this._pizzaBuilder.AddTemperatures();

        return this._pizzaBuilder.Build();
    }
}