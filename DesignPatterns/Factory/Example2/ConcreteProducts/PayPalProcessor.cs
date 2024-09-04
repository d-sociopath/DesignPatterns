using DesignPatterns.Factory.Example2.ProductInterface;

namespace DesignPatterns.Factory.Example2.ConcreteProducts
{
    public class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount}");
        }
    }
}
