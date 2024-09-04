using DesignPatterns.AbstractFactory.ProductInterfaceOrAbstractProducts;

namespace DesignPatterns.AbstractFactory.ConcreteProducts
{
    public class ModernSofa : ISofa
    {
        public void LieOn()
        {
            Console.WriteLine("Lying on a Modern Sofa");
        }
    }
}
