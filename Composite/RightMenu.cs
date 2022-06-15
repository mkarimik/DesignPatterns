namespace CompositeDesignPattern;

public class RightMenu : MenuComponent
{
    List<MenuComponent> _childList = new List<MenuComponent>();

    public RightMenu(string title)
    {
        Title = title;
    }

    public override string Title { get; }

    public override void Add(MenuComponent menuComponent)
    {
        _childList.Add(menuComponent);
    }

    public override void Remove(MenuComponent menuComponent)
    {
        _childList.Remove(menuComponent);
    }

    public override string ToString()
    {
        var result = $"\r\nRightMenu : {Title}";
        result += $"\r\n--------------------------------------------";

        foreach (var item in _childList)
        {
            result+=$"\r\n{item}";
        }

        return result;
    }
}