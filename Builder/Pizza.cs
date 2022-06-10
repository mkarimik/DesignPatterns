namespace BuilderDesignPattern;

public class Pizza
{
    public Dictionary<string, short> MainMaterial { get; set; }

    public TimeOnly BakingTime { get; set; }

    public int Temperature { get; set; }

    public override string ToString()
    {
        var mainMaterial = "=================================================";

        mainMaterial += "\r\nMain material : ";
        foreach (var item in MainMaterial)
        {
            mainMaterial += $"\r\n\t{item.Key} = {item.Value}";
        }

        mainMaterial += $"\r\n\r\nTemperature : {Temperature}C";
        mainMaterial += $"\r\n\r\nBakingTime : {BakingTime.Minute}m";

        mainMaterial += "\r\n-------------------------------------------------\r\n";

        return mainMaterial;
    }
}