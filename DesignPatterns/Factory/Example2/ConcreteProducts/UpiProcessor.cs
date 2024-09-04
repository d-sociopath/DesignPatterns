using DesignPatterns.Factory.Example2.ProductInterface;

namespace DesignPatterns.Factory.Example2.ConcreteProducts
{
    public class UpiProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing UPI payment of {amount}");
        }
    }
}
