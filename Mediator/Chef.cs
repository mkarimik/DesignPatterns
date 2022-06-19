namespace MediatorDesignPattern;

public class Chef : Colleague
{
    public Chef(MediatorManager mediator) : base(mediator)
    {
        mediator._chef = this;
    }

    public override void Notify(string message)
    {
        Console.WriteLine($"Message to chef : {message}");
    }
}