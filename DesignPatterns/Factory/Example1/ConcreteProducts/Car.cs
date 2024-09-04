using DesignPatterns.Factory.Example1.ProductInterface;

namespace DesignPatterns.Factory.Example1.ConcreteProducts
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car");
        }
    }
}
