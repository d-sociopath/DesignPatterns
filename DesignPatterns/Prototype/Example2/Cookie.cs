namespace DesignPatterns.Prototype.Example2
{
    public abstract class Cookie : IPrototype<Cookie>
    {
        public string Flavor { get; set; }
        public bool HasNuts { get; set; }

        public abstract Cookie Clone();

        public override string ToString()
        {
            return $"Cookie Flavor : {Flavor}, HasNuts : {HasNuts}";
        }
    }
}
