using DesignPatterns.AbstractFactory.Example1.ConcreteFactory;
using DesignPatterns.AbstractFactory.FactoryInterface;

namespace DesignPatterns.AbstractFactory.Example1
{
    static class Program
    {
        static void Main() 
        {
            CreateChair(FurnitureType.Modern);
            //Sitting on a Modern Chair

            CreateChair(FurnitureType.Victorian);
            //Sitting on a Victorian Chair

            CreateSofa(FurnitureType.Modern);
            //Lying on a Modern Sofa

            CreateSofa(FurnitureType.Victorian);
            //Lying on a Victorian Sofa
        }

        static void CreateChair(FurnitureType furnitureType)
        {
            var furnitureFactory = new FurnitureFactory();

            var chair = furnitureFactory.CreateChair(furnitureType);
            chair.SitOn();
        }

        static void CreateSofa(FurnitureType furnitureType)
        {
            var furnitureFactory = new FurnitureFactory();
            
            var sofa = furnitureFactory.CreateSofa(furnitureType);
            sofa.LieOn();
        }
    }
}
