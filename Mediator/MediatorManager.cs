namespace MediatorDesignPattern;

public class MediatorManager
{
    public Customer _customer { get; set; }
    public Waiter _waiter { get; set; }
    public Chef _chef { get; set; }

    public void SendToColleague(string message, Colleague colleague)
    {
        if (colleague == _customer)
            _waiter.Notify(message);
        else if (colleague == _waiter)
            _chef.Notify(message);
        else if (colleague == _chef)
            _customer.Notify(message);
    }
}