namespace MediatorDesignPattern;

public abstract class Colleague
{
    private readonly MediatorManager _mediator;

    public Colleague(MediatorManager mediator)
    {
        this._mediator = mediator;
    }

    public void SendMessage(string message)
    {
        this._mediator.SendToColleague(message, this);
    }

    public abstract void Notify(string message);
}