namespace Designer.Patterns.Observer;

public interface IObserver
{
    void Update(string message);
}

public class Customer : IObserver
{
    private readonly string _name;

    public Customer(string name)
        => this._name = name;

    public void Update(string message)
        => Console.WriteLine($"{this._name} recebeu a notificação: {message}");
}

public class OrderNotifier
{
    private readonly List<IObserver> _observers = new();

    public OrderNotifier() { }

    public void RegisterObserver(IObserver observer)
        => this._observers.Add(observer);

    public void RemoveObserver(IObserver observer)
        => this._observers.Remove(observer);

    public void NotifyObservers(string message)
    {
        foreach (var observer in this._observers)
            observer.Update(message);
    }
}