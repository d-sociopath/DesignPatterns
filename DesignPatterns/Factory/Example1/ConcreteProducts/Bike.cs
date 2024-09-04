using DesignPatterns.Factory.Example1.ProductInterface;

namespace DesignPatterns.Factory.Example1.ConcreteProducts
{
    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding a bike");
        }
    }
}
