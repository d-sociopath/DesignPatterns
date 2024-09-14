namespace DesignPatterns.Builder.Example3
{
    public class CarBuilder : IVehicleBuilder
    {
        private Vehicle _vehicle;

        public void BuildEngine()
        {
            _vehicle.Engine = "V8 Engine";
        }

        public void BuildWheels()
        {
            _vehicle.Wheels = "18 inch Alloy Wheels";
        }

        public void BuildBody()
        {
            _vehicle.Body = "Sports Body";
        }

        public Vehicle GetVehicle()
        {
            return _vehicle;
        }
    }
}
