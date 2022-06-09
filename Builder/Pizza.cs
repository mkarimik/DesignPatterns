namespace BuilderDesignPattern;

public class Pizza
{
    public Dictionary<string, short> MainMaterial { get; set; }

    public TimeOnly BakingTime { get; set; }

    public int Temperature { get; set; }

    public override string ToString()
    {
        return base.ToString();
    }
}