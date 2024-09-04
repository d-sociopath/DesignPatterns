using DesignPatterns.Factory.Example1.ProductInterface;

namespace DesignPatterns.Factory.Example1.FactoryInterface
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle(VehicleType vehicleType);
    }
}
