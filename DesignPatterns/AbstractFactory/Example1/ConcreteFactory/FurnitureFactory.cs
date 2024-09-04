using DesignPatterns.AbstractFactory.ConcreteProducts;
using DesignPatterns.AbstractFactory.FactoryInterface;
using DesignPatterns.AbstractFactory.ProductInterfaceOrAbstractProducts;

namespace DesignPatterns.AbstractFactory.Example1.ConcreteFactory
{
    public class FurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair(FurnitureType furnitureType)
        {
            return furnitureType switch
            {
                FurnitureType.Modern => new ModernChair(),
                FurnitureType.Victorian => new VictorianChair(),
                _ => throw new ArgumentException("Invalid Furniture Type", nameof(furnitureType)),
            };
        }

        public ISofa CreateSofa(FurnitureType furnitureType)
        {
            return furnitureType switch
            {
                FurnitureType.Modern => new ModernSofa(),
                FurnitureType.Victorian => new VictorianSofa(),
                _ => throw new ArgumentException("Invalid Furniture Type", nameof(furnitureType)),
            };
        }
    }

    #region OwnReference
    public class FurnitureFactoryUsingAbstractClass : FurnitureFactoryBase
    {
        protected override IChair CreateChair(FurnitureType furnitureType)
        {
            return furnitureType switch
            {
                FurnitureType.Modern => new ModernChair(),
                FurnitureType.Victorian => new VictorianChair(),
                _ => throw new ArgumentException("Invalid Furniture Type", nameof(furnitureType)),
            };
        }

        protected override ISofa CreateSofa(FurnitureType furnitureType)
        {
            return furnitureType switch
            {
                FurnitureType.Modern => new ModernSofa(),
                FurnitureType.Victorian => new VictorianSofa(),
                _ => throw new ArgumentException("Invalid Furniture Type", nameof(furnitureType)),
            };
        }
    }

    public abstract class FurnitureFactoryBase
    {
        protected abstract IChair CreateChair(FurnitureType furnitureType);
        protected abstract ISofa CreateSofa(FurnitureType furnitureType);
    }
    #endregion
}