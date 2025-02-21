using Designer.Patterns.Factory;

namespace Designer.Patterns.Tests;

public class FactoryTest
{
    [Fact]
    public void BoletoPayment_ProcessPayment_ShouldWriteCorrectMessage()
    {
        // Arrange
        var boletoFactory = new BoletoPaymentFactory();
        var boletoPayment = boletoFactory.CreatePayment();
        using var consoleOutput = new ConsoleOutput();

        // Act
        boletoPayment.ProcessPayment();

        // Assert
        Assert.Equal("Boleto payment processed\n", consoleOutput.GetOutput());
    }

    [Fact]
    public void CreditCardPayment_ProcessPayment_ShouldWriteCorrectMessage()
    {
        // Arrange
        var creditCardFactory = new CreditCardPaymentFactory();
        var creditCardPayment = creditCardFactory.CreatePayment();
        using var consoleOutput = new ConsoleOutput();

        // Act
        creditCardPayment.ProcessPayment();

        // Assert
        Assert.Equal("Credit card payment processed\n", consoleOutput.GetOutput());
    }
}