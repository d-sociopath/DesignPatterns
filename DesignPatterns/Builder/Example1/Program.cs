namespace DesignPatterns.Builder.Example1
{
    static class Program
    {
        static void Main()
        {
            IHouseBuilder iglooBuilder = new IglooHouseBuilder();
            CivilEngineer engineer = new CivilEngineer(iglooBuilder);
            engineer.ConstructHouse();
            House iglooHouse = engineer.GetHouse();
            Console.WriteLine($"Builder Constructed - {iglooHouse.ToString()}");

            IHouseBuilder tipiBuilder = new TipiHouseBuilder();
            CivilEngineer engineer2 = new CivilEngineer(tipiBuilder);
            engineer2.ConstructHouse();
            House tipiHouse = engineer2.GetHouse();
            Console.WriteLine($"Builder Constructed - {tipiHouse}");

        }
    }
}
