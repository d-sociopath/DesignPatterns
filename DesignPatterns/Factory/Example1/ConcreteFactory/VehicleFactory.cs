using DesignPatterns.Factory.Example1.ConcreteProducts;
using DesignPatterns.Factory.Example1.FactoryInterface;
using DesignPatterns.Factory.Example1.ProductInterface;

namespace DesignPatterns.Factory.Example1.ConcreteFactories
{
    public class VehicleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(VehicleType vehicleType)
        {
            return vehicleType switch
            {
                VehicleType.Bike => new Bike(),
                VehicleType.Car => new Car(),
                VehicleType.Truck => new Truck()
            };
        }
    }
}
