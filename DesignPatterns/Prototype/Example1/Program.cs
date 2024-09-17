using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype.Example1
{
    static class Program
    {
        static void Main()
        {
            //Create an original circle
            Circle originalCircle = new Circle(10, "red");

            //Clone the original circle
            Circle clonedCircle =  (Circle)originalCircle.Clone();

            //Modify the cloned circle's color
            clonedCircle.Color = "Green";

            // Create an original rectangle
            Rectangle originalRectangle = new Rectangle(20, 30, "Green");

            // Clone the original rectangle
            Rectangle clonedRectangle = (Rectangle)originalRectangle.Clone();

            // Modify the cloned rectangle
            clonedRectangle.Width = 25;

            // Display the original and cloned shapes
            Console.WriteLine("Original Circle:");
            Console.WriteLine(originalCircle);

            Console.WriteLine("\nCloned Circle:");
            Console.WriteLine(clonedCircle);

            Console.WriteLine("\nOriginal Rectangle:");
            Console.WriteLine(originalRectangle);

            Console.WriteLine("\nCloned Rectangle:");
            Console.WriteLine(clonedRectangle);
        }
    }
}
