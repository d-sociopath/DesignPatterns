namespace DesignPatterns.Builder.Example2
{
    static class Program
    {
        static void Main()
        {
            var toyACreator = new ToyCreator(new ToyABuilder());
            toyACreator.CreateToy();
            toyACreator.GetToy();

            var toyBCreator = new ToyCreator(new ToyBBuilder());
            toyBCreator.CreateToy();
            toyBCreator.GetToy();

        }
    }
}
