namespace DesignPatterns.Prototype.Example1
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(int radius, string color) 
        {
            Radius = radius;
            Color = color;
        }

        public override Shape Clone()
        {
            return (Shape)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Circle with Radius : {Radius}, Color : {Color}";

        }
    }
}
