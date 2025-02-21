namespace Designer.Patterns.Strategy;

public interface IShippingStrategy
{
    double CalculateShipping(double weight);
}

public class SedexShipping : IShippingStrategy
{
    public double CalculateShipping(double weight)
        => weight * 10.0;
}

public class PacShipping : IShippingStrategy
{
    public double CalculateShipping(double weight)
        => weight * 5.0;
}

public class ShippingService
{
    private readonly IShippingStrategy _strategy;

    public ShippingService(IShippingStrategy strategy)
        => this._strategy = strategy;

    public double GetShippingCost(double weight)
        => this._strategy.CalculateShipping(weight);
}
