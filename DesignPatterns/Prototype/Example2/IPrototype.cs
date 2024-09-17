namespace DesignPatterns.Prototype.Example2
{
    public interface IPrototype<T>
    {
        T Clone();
    }
}
