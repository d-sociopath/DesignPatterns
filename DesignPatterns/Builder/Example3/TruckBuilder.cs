namespace DesignPatterns.Builder.Example3
{
    public class TruckBuilder : IVehicleBuilder
    {
        private Vehicle _vehicle;

        public void BuildEngine()
        {
            _vehicle.Engine = "Diesel Engine";
        }

        public void BuildWheels()
        {
            _vehicle.Wheels = "22 inch Steel Wheels";
        }

        public void BuildBody()
        {
            _vehicle.Body = "Truck Body";
        }

        public Vehicle GetVehicle()
        {
            return _vehicle;
        }
    }
}
