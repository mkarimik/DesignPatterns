namespace BuilderDesignPattern;

public interface IPizzaBuilder
{
    void AddMainMaterial();
    void AddBakingTime();
    void AddTemperatures();
    Pizza Build();
}