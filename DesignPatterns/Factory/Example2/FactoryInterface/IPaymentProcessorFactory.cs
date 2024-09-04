using DesignPatterns.Factory.Example2.ProductInterface;

namespace DesignPatterns.Factory.Example2.FactoryInterface
{
    public interface IPaymentProcessorFactory
    {
        IPaymentProcessor CreatePaymentProcessor(PaymentType paymentType);
    }
}
