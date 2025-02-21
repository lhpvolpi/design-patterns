using Designer.Patterns.Adapter;

namespace Designer.Patterns.Tests;

public class AdapterTests
{
    [Fact]
    public void Adapter_SendRequest_CallsOldRequest()
    {
        // Arrange
        var oldAdapter = new OldAdapter();
        var adapter = new NewAdapter(oldAdapter);
        using var consoleOutput = new ConsoleOutput();

        // Act
        adapter.SendRequest();

        // Assert
        Assert.Equal("Executing OldRequest\n", consoleOutput.GetOutput());
    }
}