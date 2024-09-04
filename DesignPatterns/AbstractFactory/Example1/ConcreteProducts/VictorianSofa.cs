using DesignPatterns.AbstractFactory.ProductInterfaceOrAbstractProducts;

namespace DesignPatterns.AbstractFactory.ConcreteProducts
{
    public class VictorianSofa : ISofa
    {
        public void LieOn()
        {
            Console.WriteLine("Lying on a Victorian Sofa");
        }
    }
}
