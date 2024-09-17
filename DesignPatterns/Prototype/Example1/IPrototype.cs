namespace DesignPatterns.Prototype.Example1
{
    public interface IPrototype<T>
    {
        T Clone();
    }
}
