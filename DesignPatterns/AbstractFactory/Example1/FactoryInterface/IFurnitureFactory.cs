using DesignPatterns.AbstractFactory.Example1;
using DesignPatterns.AbstractFactory.ProductInterfaceOrAbstractProducts;

namespace DesignPatterns.AbstractFactory.FactoryInterface
{
    public interface IFurnitureFactory
    {
        IChair CreateChair(FurnitureType furnitureType);
        ISofa CreateSofa(FurnitureType furnitureType);
    }
}
