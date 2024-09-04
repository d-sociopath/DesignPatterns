using DesignPatterns.Factory.Example2.ConcreteFactory;
using DesignPatterns.Factory.Example2.ProductInterface;

namespace DesignPatterns.Factory.Example2
{
    static class program
    {
        static void Main()
        {
            ProcessPayment(PaymentType.CreditCard, 100.00m);
            //Processing Credit Card payment of 100.00

            ProcessPayment(PaymentType.Upi, 200.00m);
            //Processing UPI payment of 200.00

            ProcessPayment(PaymentType.PayPal, 300.00m);
            //Processing PayPal payment of 300.00

            ProcessPayment(PaymentType.Neft, 400.00m);
            //Processing NEFT payment of 400.00
        }

        static void ProcessPayment(PaymentType paymentType, decimal amount)
        {
            var paymentProcessoryFactory = new PaymentProcessorFactory();
            var paymentProcessor = paymentProcessoryFactory.CreatePaymentProcessor(paymentType);
            paymentProcessor.ProcessPayment(amount);
        }
    }
}
