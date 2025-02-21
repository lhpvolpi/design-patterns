using Designer.Patterns.Strategy;

namespace Designer.Patterns.Tests;

public class StrategyTests
{
    [Fact]
    public void GetShippingCost_WithSedexShipping_ReturnsCorrectCost()
    {
        // Arrange
        var strategy = new SedexShipping();
        var service = new ShippingService(strategy);
        double weight = 2.0;

        // Act
        double cost = service.GetShippingCost(weight);

        // Assert
        Assert.Equal(20.0, cost);
    }

    [Fact]
    public void GetShippingCost_WithPacShipping_ReturnsCorrectCost()
    {
        // Arrange
        var strategy = new PacShipping();
        var service = new ShippingService(strategy);
        double weight = 2.0;

        // Act
        double cost = service.GetShippingCost(weight);

        // Assert
        Assert.Equal(10.0, cost);
    }
}
