using DesignPatterns.Factory.Example2.ConcreteProducts;
using DesignPatterns.Factory.Example2.FactoryInterface;
using DesignPatterns.Factory.Example2.ProductInterface;

namespace DesignPatterns.Factory.Example2.ConcreteFactory
{
    public class PaymentProcessorFactory : IPaymentProcessorFactory
    {
        public IPaymentProcessor CreatePaymentProcessor(PaymentType paymentType)
        {
            #region Approach1
            return paymentType switch
            {
                PaymentType.CreditCard => new CreditCardProcessor(),
                PaymentType.Upi => new UpiProcessor(),
                PaymentType.PayPal => new PayPalProcessor(),
                PaymentType.Neft => new NeftProcessor(),
                _ => throw new ArgumentException("Invalid Payment Type", nameof(paymentType))
            };

            #endregion


            ///This below approach creates new instance of product using reflection
            ///basically it creates the class name dynamically based on The Enum Value of Product 
            ///e.g.- here we have created the concrete product classes as CreditCardProcessor, UpiProcessor & which has Enum Value & 'Processor'
            ///This is not a concrete way to generate new instance of a class
            ///But in case when we have n number of products which are going to be added in future
            ///This approach helps as we dont have to add enum and instance generation manually everytime.
            #region Approach2
            var assembly = typeof(IPaymentProcessor).Assembly;
            var className = $"{paymentType}Processor";

            var type = assembly.GetTypes().FirstOrDefault(t => t.Name.Equals(className, StringComparison.Ordinal));

            if (type != null)
            {
                return Activator.CreateInstance(type) as IPaymentProcessor;
            }

            throw new ArgumentException("Invalid Payment Type", nameof(paymentType));
            #endregion
        }
    }
}
