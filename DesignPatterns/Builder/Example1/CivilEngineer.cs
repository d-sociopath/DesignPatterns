namespace DesignPatterns.Builder.Example1
{
    public class CivilEngineer
    {
        private IHouseBuilder _houseBuilder;

        public CivilEngineer(IHouseBuilder houseBuilder)
        {
            _houseBuilder = houseBuilder;
        }

        public House GetHouse()
        {
            return _houseBuilder.GetHouse();
        }

        public void ConstructHouse()
        {
            _houseBuilder.BuildBasement();
            _houseBuilder.BuildStructure();
            _houseBuilder.BuildRoof();
            _houseBuilder.BuildInterior();
        }
    }
}
