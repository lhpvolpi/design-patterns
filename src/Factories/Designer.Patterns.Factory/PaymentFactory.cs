namespace Designer.Patterns.Factory;

public interface IPayment
{
    void ProcessPayment();
}

public class BoletoPayment : IPayment
{
    public void ProcessPayment()
        => Console.WriteLine("Boleto payment processed");
}

public class CreditCardPayment : IPayment
{
    public void ProcessPayment()
        => Console.WriteLine("Credit card payment processed");
}

public abstract class PaymentFactory
{
    public abstract IPayment CreatePayment();
}

public class BoletoPaymentFactory : PaymentFactory
{
    public override IPayment CreatePayment()
        => new BoletoPayment();
}

public class CreditCardPaymentFactory : PaymentFactory
{
    public override IPayment CreatePayment()
        => new CreditCardPayment();
}