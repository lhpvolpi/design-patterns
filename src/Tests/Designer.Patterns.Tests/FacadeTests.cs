using Designer.Patterns.Facade;

namespace Designer.Patterns.Tests;

public class FacadeTests
{
    [Fact]
    public void WatchMovie_ShouldPrintStartWatchingMovie()
    {
        // Arrange
        var homeTheater = new HomeTheaterFacade();
        using var consoleOutput = new ConsoleOutput();

        // Act
        homeTheater.WatchMovie();

        // Assert
        Assert.Contains("Start watching movie.\n", consoleOutput.GetOutput());
    }
}