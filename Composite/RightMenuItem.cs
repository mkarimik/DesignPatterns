namespace CompositeDesignPattern;

public class RightMenuItem : MenuComponent
{
    public RightMenuItem(string title, string url)
    {
        Title = title;
        Url = url;
    }

    public override string Title { get; }

    public override string Url { get; }

    public override string ToString()
    {
        var result = $"RightMenuItem : {Title} => {Url}";

        

        return result;
    }
}