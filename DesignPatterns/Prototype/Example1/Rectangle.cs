using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype.Example1
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height, string color) 
        {
            Width = width;
            Height = height;
            Color = color;
        }

        public override Shape Clone()
        {
            return (Rectangle)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Rectangle with Width : {Width}, Height : {Height}, Color : {Color}";
        }
    }
}
