namespace DesignPatterns.Prototype.Example1
{
    public abstract class Shape : IPrototype<Shape>
    {
        public string Color { get; set; }
        public abstract Shape Clone();

        public override string ToString()
        {
            return $"Shape with color : {Color}";
        }
    }
}
