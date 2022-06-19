namespace MediatorDesignPattern;

public class Waiter : Colleague
{
    public Waiter(MediatorManager mediator) : base(mediator)
    {
        mediator._waiter = this;
    }

    public override void Notify(string message)
    {
        Console.WriteLine($"Message to waiter : {message}");
    }
}