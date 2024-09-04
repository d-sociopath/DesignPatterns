using DesignPatterns.AbstractFactory.ProductInterfaceOrAbstractProducts;

namespace DesignPatterns.AbstractFactory.ConcreteProducts
{
    public class ModernChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Sitting on a Modern Chair");
        }
    }
}
