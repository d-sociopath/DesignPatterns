using DesignPatterns.Factory.Example1.ConcreteFactories;

namespace DesignPatterns.Factory.Example1
{
    static class program
    {
        static void Main()
        {
            var vehicleFactory = new VehicleFactory();

            var bike = vehicleFactory.CreateVehicle(VehicleType.Bike);
            bike.Drive();
            //Riding a bike

            var car = vehicleFactory.CreateVehicle(VehicleType.Car);
            car.Drive();
            //Driving a car

            var truck = vehicleFactory.CreateVehicle(VehicleType.Truck);
            truck.Drive();
            //Driving a truck

        }

    }
}