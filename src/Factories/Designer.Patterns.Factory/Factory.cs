namespace Designer.Patterns.Factory;

public class Factory
{
    public Factory()
    {
        // Boleto Payment
        var boletoFactory = new BoletoPaymentFactory();
        var boletoPayment = boletoFactory.CreatePayment();
        boletoPayment.ProcessPayment();

        // Credit Card Payment
        var creditCardFactory = new CreditCardPaymentFactory();
        var creditCardPayment = creditCardFactory.CreatePayment();
        creditCardPayment.ProcessPayment();
    }
}
