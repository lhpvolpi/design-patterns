namespace Designer.Patterns.Observer;

public class Observer
{
    public Observer()
    {
        var notifier = new OrderNotifier();
        var cliente1 = new Customer("Leonardo");
        var cliente2 = new Customer("Carlos");

        notifier.RegisterObserver(cliente1);
        notifier.RegisterObserver(cliente2);

        notifier.NotifyObservers("Novo pedido disponível!");
    }
}
