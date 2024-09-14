namespace DesignPatterns.Builder.Example3
{
    static class Program
    {
        static void Main()
        {
            //Building a Car
            IVehicleBuilder carBuilder = new CarBuilder();
            VehicleDirector carDirector = new VehicleDirector(carBuilder);

            carDirector.BuildVehicle();
            var car = carDirector.GetVehicle();
            Console.WriteLine(car);

            // Building a Truck
            IVehicleBuilder truckBuilder = new TruckBuilder();
            VehicleDirector truckDirector = new VehicleDirector(truckBuilder);

            truckDirector.BuildVehicle();
            var truck = truckDirector.GetVehicle();
            Console.WriteLine(truck);
        }

    }
}
