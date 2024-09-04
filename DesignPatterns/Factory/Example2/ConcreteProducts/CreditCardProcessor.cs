using DesignPatterns.Factory.Example2.ProductInterface;

namespace DesignPatterns.Factory.Example2.ConcreteProducts
{
    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Credit Card payment of {amount}");
        }
    }
}
