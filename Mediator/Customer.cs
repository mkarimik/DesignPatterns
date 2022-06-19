namespace MediatorDesignPattern;

public class Customer : Colleague
{
    public Customer(MediatorManager mediator) : base(mediator)
    {
        mediator._customer = this;
    }

    public override void Notify(string message)
    {
        Console.WriteLine($"Message to customer : {message}");
    }
}