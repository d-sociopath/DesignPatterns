using DesignPatterns.AbstractFactory.ProductInterfaceOrAbstractProducts;

namespace DesignPatterns.AbstractFactory.ConcreteProducts
{
    public class VictorianChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Sitting on a Victorian Chair");
        }
    }
}
