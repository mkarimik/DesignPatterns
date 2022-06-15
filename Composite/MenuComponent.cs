namespace CompositeDesignPattern;

public abstract class MenuComponent
{
    public abstract string Title { get; }
    public virtual string Url { get; }

    public virtual void Add(MenuComponent menuComponent)
    {

    }

    public virtual void Remove(MenuComponent menuComponent)
    {

    }
}
