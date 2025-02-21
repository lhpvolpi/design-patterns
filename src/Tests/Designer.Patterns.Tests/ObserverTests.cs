using Designer.Patterns.Observer;

namespace Designer.Patterns.Tests;

public class ObserverTests
{
    [Fact]
    public void RegisterObserver_ShouldAddObserverToList()
    {
        // Arrange
        using var consoleOutput = new ConsoleOutput();

        var notifier = new OrderNotifier();
        var cliente1 = new Customer("Leonardo");
        var cliente2 = new Customer("Carlos");

        notifier.RegisterObserver(cliente1);
        notifier.RegisterObserver(cliente2);

        // Act
        notifier.NotifyObservers("Novo pedido disponível!");

        // Assert
        Assert.Contains("Leonardo recebeu a notificação: Novo pedido disponível!", consoleOutput.GetOutput());
        Assert.Contains("Carlos recebeu a notificação: Novo pedido disponível!", consoleOutput.GetOutput());
    }

    [Fact]
    public void RemoveObserver_ShouldRemoveObserverFromList()
    {
        // Arrange
        using var consoleOutput = new ConsoleOutput();

        var notifier = new OrderNotifier();
        var cliente1 = new Customer("Leonardo");
        var cliente2 = new Customer("Carlos");

        notifier.RegisterObserver(cliente1);
        notifier.RemoveObserver(cliente2);

        // Act
        notifier.NotifyObservers("Novo pedido disponível!");

        // Assert
        Assert.Contains("Leonardo recebeu a notificação: Novo pedido disponível!", consoleOutput.GetOutput());
    }
}
