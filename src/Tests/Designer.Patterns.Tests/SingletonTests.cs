using Designer.Patterns.Singleton;

namespace Designer.Patterns.Tests;

public class SingletonTests
{
    [Fact]
    public void Logger_Instance_ShouldReturnSameInstance()
    {
        // Arrange & Act
        var instance1 = Logger.Instance;
        var instance2 = Logger.Instance;

        // Assert
        Assert.Same(instance1, instance2);
    }

    [Fact]
    public void Logger_Log_ShouldWriteMessageToConsole()
    {
        // Arrange
        var logger = Logger.Instance;
        var message = "Test message";
        using var consoleOutput = new ConsoleOutput();

        // Act
        logger.Log(message);

        // Assert
        Assert.Contains(message, consoleOutput.GetOutput());
    }
}