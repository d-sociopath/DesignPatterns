namespace DesignPatterns.Builder.Example3
{
    public class VehicleDirector
    {
        private readonly IVehicleBuilder _vehicleBuilder;

        public VehicleDirector(IVehicleBuilder vehicleBuilder)
        {
            _vehicleBuilder = vehicleBuilder;
        }
        
        public void BuildVehicle()
        {
            _vehicleBuilder.BuildEngine();
            _vehicleBuilder.BuildWheels();
            _vehicleBuilder.BuildBody();
        }

        public Vehicle GetVehicle()
        {
            return _vehicleBuilder.GetVehicle();
        }
    }
}
