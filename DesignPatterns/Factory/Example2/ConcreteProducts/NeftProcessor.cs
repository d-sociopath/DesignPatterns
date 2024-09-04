using DesignPatterns.Factory.Example2.ProductInterface;

namespace DesignPatterns.Factory.Example2.ConcreteProducts
{
    public class NeftProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing NEFT payment of {amount}");
        }
    }
}
