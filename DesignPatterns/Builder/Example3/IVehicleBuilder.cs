namespace DesignPatterns.Builder.Example3
{
    public interface IVehicleBuilder
    {
        void BuildEngine();
        void BuildWheels();
        void BuildBody();
        Vehicle GetVehicle();
    }
}
