namespace Designer.Patterns.Strategy;

public class Strategy
{
    public Strategy()
    {
        var service = new ShippingService(new SedexShipping());
        Console.WriteLine(service.GetShippingCost(2));
    }
}
